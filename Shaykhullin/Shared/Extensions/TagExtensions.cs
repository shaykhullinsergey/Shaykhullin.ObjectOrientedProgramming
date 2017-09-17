using System.Windows.Forms;

namespace Shaykhullin.Extensions
{
  public static class TagExtensions
  {
    public static int ParseTag(this object sender)
    {
      return int.Parse((sender as Control)?.Tag.ToString());
    }

    public static string Tag(this object sender)
    {
      return (sender as Control)?.Tag.ToString();
    }
  }
}
