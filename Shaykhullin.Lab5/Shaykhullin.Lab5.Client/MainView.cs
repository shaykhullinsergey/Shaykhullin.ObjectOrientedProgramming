using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab5.Client
{
  public partial class MainView : Form
  {
    private object lockObject = new object();

    private byte[] data;
    private int position;
    private long sumResult;
    private int count;
    private Task task;

    public MainView()
    {
      InitializeComponent();
    }

    bool ProgressFinished
    {
      get
      {
        lock (lockObject)
        {
          return position >= data.Length;
        }
      }
    }

    bool HasMoreData(out int dataSize)
    {
      lock (lockObject)
      {
        if (count < data.Length)
          dataSize = (count - position) & -4;
        else
          dataSize = count - position;
        return dataSize > 0;
      }
    }

    private void ProcessData()
    {
      while (!ProgressFinished)
      {
        if (HasMoreData(out int dataToProgress))
        {
          for (int i = position; i < position + (dataToProgress & -4); i += 4)
          {
            sumResult += data[i] + (data[i + 1] << 8) + (data[i + 2] << 16) + (data[i + 3] << 24);
          }

          switch (dataToProgress & 3)
          {
            case 1:
              sumResult += data[position + (dataToProgress & -4)];
              break;
            case 2:
              sumResult += data[position + (dataToProgress & -4)] + (data[position + (dataToProgress & -4) + 1] << 8);
              break;
            case 3:
              sumResult += data[position + (dataToProgress & -4)] + (data[position + (dataToProgress & -4) + 1] << 8) + (data[position + (dataToProgress & -4) + 2] << 16);
              break;
          }

          Thread.MemoryBarrier();

          position += dataToProgress;
          progressBar.BeginInvoke(new Action(() => progressBar.Value = (int)Math.Round(100.0 * position / data.Length)));
        }
        else
        {
          Thread.Yield();
        }
      }
    }

    private async Task MakeAsyncRequest(string url)
    {
      var responce = await WebRequest.CreateHttp(url)
        .GetResponseAsync();

      using (var netStream = responce.GetResponseStream())
      {
        data = new byte[responce.ContentLength];

        task = Task.Run(new Action(ProcessData));

        while (count < responce.ContentLength)
        {
          int read = await netStream.ReadAsync(data, count, (int)responce.ContentLength - count);

          Thread.MemoryBarrier();

          lock (lockObject)
          {
            count += read;
          }
        }
      }
    }

    private async void OnDownloadClick(object sender, EventArgs e)
    {
      data = null;
      sumResult = position = count = 0;
      progressBar.Value = 0;
      task?.Dispose();

      await MakeAsyncRequest(url.Text);
      await task;

      result.Text = sumResult.ToString();
      hexResult.Text = $"0x{sumResult:X}";
      MessageBox.Show("Done");
    }
  }
}
