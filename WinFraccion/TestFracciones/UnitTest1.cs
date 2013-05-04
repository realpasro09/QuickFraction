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
    }
}
