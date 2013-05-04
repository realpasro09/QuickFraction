using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFraccion;

namespace TestFracciones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f = new Fraccion();
            int numerador = f.Numerador;
            int denominador = f.Denominador;
            var b = (numerador == 1) && (denominador == 1);
            Assert.AreEqual(true,b);
        }

        [TestMethod]
        public void TestSummarFracciones()
        {
            var f1 = new Fraccion(2,3);
            var f2 = new Fraccion(1,0);

            var fraccionExpected = new Fraccion(3,3);
            var resultado = new Fraccion();
            resultado.Sumar(f1, f2);
            Assert.AreEqual(fraccionExpected,resultado);
        }

        [TestMethod]
        public void TestSummarMiCalc()
        {
            var c = new Calc {Valor1 = 10, Valor2 = 10};
            var suma = c.Suma();
            Assert.AreEqual(10,suma);
        }
        
        [TestMethod]
        public void TestDenominadorCero()
        {
            try
            {
                var f = new Fraccion { Denominador = 0 };
            }
            catch (DivideByZeroException)
            {
                return;
            }
            Assert.Fail();
        }
    }
}
