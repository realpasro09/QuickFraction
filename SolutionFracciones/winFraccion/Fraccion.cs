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
            //Constructor default


            Numerador = 1;// Definidos por omision
            Denominador = 1;

        }
        public Fraccion(int num, int den)
        {
            //Constructor con parametros 
            this.Numerador = num;
            this.Denominador = den;
        }

        public void Sumar(Fraccion f1, Fraccion f2)
        {
            this.Denominador = f1.Denominador*f2.Denominador;
            this.Numerador = (f1.Numerador*f2.Denominador) + (f2.Numerador*f1.Denominador);
        }
    }
}
