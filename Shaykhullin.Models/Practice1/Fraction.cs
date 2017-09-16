using Shaykhullin.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin.Models.Practice1
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

    public static (long Integer, long Numerator, long Denominator) ToProperFraction(double number)
    {
      var integer = GetInteger();
      var denominator = GetDenominator(number);
      var numerator = GetNumerator();
      (numerator, denominator) = MathUtils.MinimizeFraction(numerator, denominator);

      return (integer, numerator, denominator);


      long GetInteger() => (long)Math.Floor(number);
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
      long GetNumerator() => (long)Math.Round((number % 1) * denominator);
    }
  }
}
