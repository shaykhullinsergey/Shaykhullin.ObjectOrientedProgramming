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
  }
}
