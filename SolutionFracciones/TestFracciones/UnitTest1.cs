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
    }
}
