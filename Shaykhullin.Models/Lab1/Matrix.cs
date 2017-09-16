using Shaykhullin.Extensions;

namespace Shaykhullin.Models.Lab1
{
  public class Matrix
  {
    public const int Size = 3;

    private double[,] matrix = new double[Size, Size];

    public double this[int x, int y]
    {
      get
      {
        if(x.IsInRange(0, 3).WithRange(y, 0, 3s))
        {
          return matrix[x, y];
        }
        else
        {
          return 0.0;
        }
      }
      set
      {
        if(x.IsInRange(0, 3).WithRange(y, 0, 3))
        {
          matrix[x, y] = value;
        }
      }
    }



  }
}
