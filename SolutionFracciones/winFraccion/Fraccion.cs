using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFraccion
{
    public class Fraccion
    {
        private int _Numerador;
        private int _Denominador;
        public int Numerador {
            get { return _Numerador; }
            set { _Numerador = value ;}
        }

        public int Denominador
        {
            get 
            { 
                return _Denominador;  
            }
            set
            {
                if (value == 0) throw new DivideByZeroException();
                _Denominador = value; 
            } 
        
        }

        public Fraccion()
        {
            this.Numerador = 1;
            this.Denominador = 1;
        }
        public Fraccion(int num, int den)
        {
            this.Numerador = num;
            this.Denominador = den;
        }

        public void Sumar(Fraccion f1, Fraccion f2)
        {
            throw new NotImplementedException();
        }
    }
}
