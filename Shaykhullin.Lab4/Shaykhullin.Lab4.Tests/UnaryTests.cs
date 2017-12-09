using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Math;

namespace Shaykhullin.Tests
{
  [TestClass]
  public class UnaryTests : InterpreterTester
  {
    [TestMethod]
    public void КоинусВычисляетсяВВыражении()
    {
      var result = Interpret<double>("sin(cos(12.2))");

      Assert.AreEqual(Sin(Cos(12.2)), result);
    }

    [TestMethod]
    public void КоинусВычисляется()
    {
      var result = Interpret<double>("cos(12.2)");

      Assert.AreEqual(Cos(12.2), result);
    }

    [TestMethod]
    public void СинусВычисляетсяВВыражении()
    {
      var result = Interpret<double>("cos(sin(10))");

      Assert.AreEqual(Cos(Sin(10)), result);
    }

    [TestMethod]
    public void СинусВычисляется()
    {
      var result = Interpret<double>("sin(10)");

      Assert.AreEqual(Sin(10), result);
    }

    [TestMethod]
    public void ДвойноеВозведениеВСтепеньПрименяетя()
    {
      var result = Interpret<double>("2****");

      Assert.AreEqual(16, result);
    }

    [TestMethod]
    public void ОстатокОтДеленияПрименяется()
    {
      var result = Interpret<double>("min((12 % 5), (1))");

      Assert.AreEqual(1d, result);
    }

    [TestMethod]
    public void ОкруглениеДоЦелогоПрименяется()
    {
      var result = Interpret<double>("trunc(1.19123123)");

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ОкруглениеКПлюсБесконечностиПрименяется()
    {
      var result = Interpret<double>("ceil(1.1)");

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ОкруглениеКМинусБесконечностиПрименяется()
    {
      var result = Interpret<double>("floor(1.99)");

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void ОкруглениеКЧетномуПрименяется()
    {
      var result = Interpret<double>("round(1.5)");

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ВозведениеВСтепеньПрименяется()
    {
      var result = Interpret<double>("10**");

      Assert.AreEqual(100d, result);
    }

    [TestMethod]
    public void УнарноеОтрицаниеПрименяетсяТрижды()
    {
      var result = Interpret<bool>("!!!true");

      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void УнарноеОтрицаниеПрименяетсяДважды()
    {
      var result = Interpret<bool>("!!true");

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void УнарноеОтрицаниеПрименяется()
    {
      var result = Interpret<bool>("!true");

      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void УнарнаяФункцияПрименяетсяВнутриБинарной()
    {
      var result = Interpret<double>("max(sign(-10), sign(10))");

      Assert.AreEqual(1d, result);
    }

    [TestMethod]
    public void УнарныйМинусПримеряется()
    {
      var result = Interpret<double>("-1");

      Assert.AreEqual(-1d, result);
    }

    [TestMethod]
    public void УнарнаяФункцияПрименяется()
    {
      var result = Interpret<double>("sign(-100) + 1");

      Assert.AreEqual(0d, result);
    }

    [TestMethod]
    public void УнарныйМинусПримеряетсяНесколькоРаз()
    {
      var result = Interpret<double>("-----1");

      Assert.AreEqual(-1d, result);
    }

    [TestMethod]
    public void УнарныйМинусВместеСУнарнымПлюсом()
    {
      var result = Interpret<double>("+-+1");

      Assert.AreEqual(-1d, result);
    }

    [TestMethod]
    public void УнарныйМинусВместеСБинарнымПлюсом()
    {
      var result = Interpret<double>("-1+1");

      Assert.AreEqual(0d, result);
    }

    [TestMethod]
    public void УнарныйМинусПрименяетсяКПравильномуОперанду()
    {
      var result = Interpret<double>("min((-1), 2)");

      Assert.AreEqual(-1d, result);
    }
  }
}
