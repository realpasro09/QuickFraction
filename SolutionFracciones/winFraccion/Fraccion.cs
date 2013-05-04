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
    }
}
