﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winFraccion
{
    public class Calc
    {
        public int sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int mult(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int porcentaje(int valor1, int valor2)
        {
            return valor1 / valor2;
        }

    }
}
