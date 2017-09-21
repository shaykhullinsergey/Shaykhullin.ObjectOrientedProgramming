using System;
using System.Linq;
using System.Text.RegularExpressions;

using Shaykhullin.Utils;

namespace Shaykhullin.Shared.Practice1
{
  public class Fraction
  {
    private int numerator, denominator;

    public Fraction(int numerator, int denominator)
    {
      (this.numerator, this.denominator) = 
        MathUtils.MinimizeFraction(numerator, denominator);
    }

    public override string ToString() => $"{numerator}/{denominator}";

    public static Fraction Add(Fraction a, Fraction b) => 
      new Fraction
      (
        numerator: a.numerator * b.denominator + a.denominator * b.numerator, 
        denominator: a.denominator * b.denominator
      );

    public static Fraction Substract(Fraction a, Fraction b) =>
      new Fraction
      (
        numerator: a.numerator * b.denominator - a.denominator * b.numerator,
        denominator: a.denominator * b.denominator
      );

    public static Fraction Product(Fraction a, Fraction b) =>
      new Fraction
      (
        numerator: a.numerator * b.denominator,
        denominator: b.numerator * a.denominator
      );

    public static Fraction Divide(Fraction a, Fraction b) =>
      new Fraction
      (
        numerator: a.numerator * b.numerator,
        denominator: b.denominator * a.denominator
      );

    public static (long Integer, long Numerator, long Denominator)? ParseToProperFraction(string number)
    {
      if(double.TryParse(number, out var result))
      {
        return ToProperFraction();
      }
      return FromPeriodicFraction();

      (long, long, long) ToProperFraction()
      {
        var integer = GetInteger();
        var denominator = GetDenominator(result);
        var numerator = GetNumerator();
        (numerator, denominator) = MathUtils.MinimizeFraction(numerator, denominator);

        return (integer, numerator, denominator);

        long GetInteger() => (long)Math.Truncate(result);
        long GetDenominator(double numberValue)
        {
          var calculatedDenominator = 1L;

          while (HasNoMoreDigitsAfterDot())
          {
            numberValue *= 10;
            calculatedDenominator *= 10;
          }

          return calculatedDenominator;

          bool HasNoMoreDigitsAfterDot() => Math.Abs(numberValue % 1) > double.Epsilon;
        }
        long GetNumerator() => (long)Math.Round((result % 1) * denominator);
      }
      (long, long, long)? FromPeriodicFraction()
      {
        if (new Regex(@"^\d+\.\(\d+\)").IsMatch(number))
        {
          var (integer, numerator, denominator) = ParsePeriodicFraction();
          (numerator, denominator) = MathUtils.MinimizeFraction(numerator, denominator);
          return (integer, numerator, denominator);

          (long, long, long) ParsePeriodicFraction()
          {
            var split = number.Split('.')
              .Select(s => new string(s.Trim('(', ')').Take(17).ToArray()))
              .ToArray();

            return (long.Parse(split[0]), long.Parse(split[1]), long.Parse(new string('9', split[1].Length));
          }
        }
        return null;
      }
    }
  }
}
