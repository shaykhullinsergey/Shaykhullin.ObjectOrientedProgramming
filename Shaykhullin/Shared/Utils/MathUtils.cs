using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin.Utils
{
  public static class MathUtils
  {
    public static (int numerator, int denominator) MinimizeFraction(int numerator, int denominator)
    {
      if (numerator == 0)
      {
        return (numerator: 0, denominator: 0);
      }

      var commonDivisor = GreatestCommonDivisor(numerator, denominator);

      return (numerator / commonDivisor, denominator / commonDivisor);

      int GreatestCommonDivisor(int a, int b)
      {
        int temp;

        while (b != 0)
        {
          temp = b;
          b = a % b;
          a = temp;
        }

        return a;
      }
    }

    public static (long numerator, long denominator) MinimizeFraction(long numerator, long denominator)
    {
      if (numerator == 0)
      {
        return (numerator: 0, denominator: 0);
      }

      var commonDivisor = GreatestCommonDivisor(numerator, denominator);

      return (numerator / commonDivisor, denominator / commonDivisor);

      long GreatestCommonDivisor(long a, long b)
      {
        long temp;

        while (b != 0)
        {
          temp = b;
          b = a % b;
          a = temp;
        }

        return a;
      }
    }
  }
}
