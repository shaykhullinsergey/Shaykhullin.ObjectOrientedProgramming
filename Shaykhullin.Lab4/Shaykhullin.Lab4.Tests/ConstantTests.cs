using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Math;

namespace Shaykhullin.Tests
{
  [TestClass]
  public class ConstantTests : InterpreterTester
  {
    [TestMethod]
    public void ТангенсВычисляетсяВВыражении()
    {
      var result = Interpret<double>("min(tan(1.12e-10), 10)");

      Assert.AreEqual(Tan(1.12e-10), result);
    }

    [TestMethod]
    public void ТангенсВычисляется()
    {
      var result = Interpret<double>("tan(1.2e-10)");

      Assert.AreEqual(Tan(1.2e-10), result);
    }

    [TestMethod]
    public void ЭкспоненциальнаяФормаЗаписиВычисляетсяВВыражении()
    {
      var result = Interpret<bool>("min(max(1.5e-10, 10.10e2), 1.4e-11) == 1.4e-11");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void НормализованнаяЭкспоненциальнаяФормаЗаписиВещественныхЧиселПоСтандартуIEEE754()
    {
      var result = Interpret<double>("1.2e-1");

      Assert.AreEqual(0.12, result);
    }

    [TestMethod]
    public void ВыражениеСКонстантамиВычисляется()
    {
      var result = Interpret<bool>("max(min(e, pi), min((e-pi), (pi**))) == e");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void КонстантаEВычисляетсяВВыражении()
    {
      var result = Interpret<double>("e-1.111");

      Assert.AreEqual(E-1.111, result, 0.00000001);
    }

    [TestMethod]
    public void КонстантаEВычисляется()
    {
      var result = Interpret<double>("e");

      Assert.AreEqual(E, result, 0.00000001);
    }

    [TestMethod]
    public void КонстантаПиВычисляетсяВВыражении()
    {
      var result = Interpret<double>("pi+1.2");

      Assert.AreEqual(PI + 1.2, result, 0.00000001);
    }

    [TestMethod]
    public void КонстантаПиВычисляется()
    {
      var result = Interpret<double>("pi");

      Assert.AreEqual(PI, result, 0.00000001);
    }
  }
}
