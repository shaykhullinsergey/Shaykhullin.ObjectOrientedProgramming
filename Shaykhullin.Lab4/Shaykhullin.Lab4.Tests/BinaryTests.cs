using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Math;

namespace Shaykhullin.Tests
{
  [TestClass]
  public class BinaryTests : InterpreterTester
  {
    [TestMethod]
    public void ПоследовательностьОперацийВыполняется()
    {
      var result = Interpret<bool>("true & false | true ^ false");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ЛогическиеОператорыИиИлиПрименяютсяВПравильнойПоследовательности()
    {
      var result1 = Interpret<bool>("true & false | true");
      var result2 = Interpret<bool>("false | true & false");

      Assert.IsTrue(result1);
      Assert.IsFalse(result2);
    }

    [TestMethod]
    public void ИсключающееИлиПрименяетсяСОтрицанием()
    {
      var result = Interpret<bool>("!(true ^ true)");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ИсключающееИлиПрименяется()
    {
      var result = Interpret<bool>("true ^ true");

      Assert.IsFalse(result);
    }

    [TestMethod]
    public void ЛожьИлиИстинаРавнаИстине()
    {
      var result = Interpret<bool>("false | true");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ЛожьИИстинаРавнаЛжи()
    {
      var result = Interpret<bool>("false & true");

      Assert.IsFalse(result);
    }

    [TestMethod]
    public void ЛожьРавнаЛжиСПодстановкой()
    {
      var result = Interpret<bool>("(1 == 0) == false");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ЛожьРавнаЛжи()
    {
      var result = Interpret<bool>("false == false");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ПравдаРавнаПравде()
    {
      var result = Interpret<bool>("true == true");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ПравдаНеРавнаЛжи()
    {
      var result = Interpret<bool>("true != false");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорБольшеИлиРавноПрименяетсяКРавным()
    {
      var result = Interpret<bool>("2.23 >= 2.23");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорБольшеИлиРавноПрименяется()
    {
      var result = Interpret<bool>("1.11 >= 2.22");

      Assert.IsFalse(result);
    }

    [TestMethod]
    public void ОператорМеньшеИлиРавноПрименяетсяКРавным()
    {
      var result = Interpret<bool>("2.22 <= 2.22");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорМеньшеИлиРавноПрименяется()
    {
      var result = Interpret<bool>("1.11 <= 2.22");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорМеньшеПрименяетсяКВыражению()
    {
      var result = Interpret<bool>("1 + 2 < 2 - 100.12");

      Assert.IsFalse(result);
    }

    [TestMethod]
    public void ОператорБольшеПрименяетсяКВыраженям()
    {
      var result = Interpret<bool>("1 + 2 > 2 - 1");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорБольшеПрименяетсяКВыражению()
    {
      var result = Interpret<bool>("1 + 2 > 2");

      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ОператорБольшеПрименяется()
    {
      var result = Interpret<bool>("1 > 2");

      Assert.IsFalse(result);
    }

    [TestMethod]
    public void ЛогическоеРавенствоПрименяетсяКЛогическому()
    {
      var result1 = Interpret<bool>("true == true");

      Assert.IsTrue(result1);
    }

    [TestMethod]
    public void ЛогическоеРавенствоПрименяется()
    {
      var result1 = Interpret<bool>("true == (1.2 == 1.2)");

      Assert.IsTrue(result1);
    }

    [TestMethod]
    public void ВещественноеРавенствоПрименяетсяСУмножением()
    {
      var result1 = Interpret<bool>("100 == 10*10");

      Assert.IsTrue(result1);
    }

    [TestMethod]
    public void ВещественноеРавенствоПрименяется()
    {
      var result1 = Interpret<bool>("100 == 100");

      Assert.IsTrue(result1);
    }

    [TestMethod]
    public void БинарноеСложениеПрименяется()
    {
      var result = Interpret<double>("2+2");

      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void БинарноеВычитаниеПрименяется()
    {
      var result = Interpret<double>("2-2+2");

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void БинарноеУмножениеПрименяется()
    {
      var result1 = Interpret<double>("2*2+2");
      var result2 = Interpret<double>("2+2*2");

      Assert.AreEqual(6, result1);
      Assert.AreEqual(6, result2);
    }

    [TestMethod]
    public void БинарноеДелениеПрименяется()
    {
      var result1 = Interpret<double>("2/2+2");
      var result2 = Interpret<double>("2+2/2");

      Assert.AreEqual(3, result1);
      Assert.AreEqual(3, result2);
    }
  }
}
