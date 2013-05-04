using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFraccion
{
    public class Fraccion
    {
        private int _denominador;

        public Fraccion(int num, int den)
        {
            Numerador = num;
            Denominador = den;
        }

        public Fraccion()
        {
            Numerador = 1;
            _denominador = 1;
        }

        public int Numerador { get; set; }

        public int Denominador
        {
            get { return _denominador; }
            set
            {
                if (value == 0)
                    throw new DivideByZeroException();
                _denominador = value;
            }
        }

        public void Sumar(Fraccion f1, Fraccion f2)
        {
            Numerador = f1.Numerador + f2.Numerador;
            Denominador = f2.Denominador + f2.Denominador;
        }
    }
}
