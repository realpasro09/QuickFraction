using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFraccion
{
    public class Fraccion
    {
        
        public int Numerador { get; set; }

        public int Denominador { get; set; }

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
