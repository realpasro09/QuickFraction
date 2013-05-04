using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using winFraccion;


namespace TestFracciones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructorDefault()
        {
            Fraccion F = new Fraccion();
            int numerador = F.Numerador;
            int denominador = F.Denominador;
            bool b = (numerador == 1) && (denominador == 1);
            Assert.AreEqual(true, b);



        }
        [TestMethod]
        public void testSumarFracciones()
        {
            Fraccion f1 = new Fraccion(2,3);
            Fraccion f2 = new Fraccion(1, 3);

            Fraccion FraccionExpected = new Fraccion(3, 3);

            Fraccion resultado = new Fraccion();
            resultado.Sumar(f1, f2);

            bool b = (resultado.Numerador == 3) && (resultado.Denominador == 3);
            Assert.AreEqual(true, b);


        }

        [TestMethod]
        public void testMultiplicarFracciones()
        {
            Fraccion f1 = new Fraccion(2, 3);
            Fraccion f2 = new Fraccion(1, 3);

            Fraccion FraccionExpected = new Fraccion(2, 9);

            Fraccion resultado = new Fraccion();
            resultado.Multiplicar(f1, f2);

            bool b = (resultado.Numerador == FraccionExpected.Numerador) && (resultado.Denominador == FraccionExpected.Denominador);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void testDenominadorNoCERO()
        {
            Fraccion F = new Fraccion();
            try
            {
                F.Denominador = 0;

            }
            catch (DivideByZeroException D)
            {
                return;
            }

            Assert.Fail();

        }

        [TestMethod]
        public void testSumarMiCalc()
        {
            Calc c = new Calc();
            int valor1 = 10;
            int valor2 = 10;
            int resultado = c.sumar(valor1, valor2);
            Assert.AreEqual(20, resultado);

        }


    }
}
