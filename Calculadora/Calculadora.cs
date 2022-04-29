using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public int sumar(int nro1, int nro2)
        {
            return nro1 + nro2;
        }

        public int restar(int nro1, int nro2)
        {
            if (nro1 >= nro2)
            {
                return nro1 - nro2;
            }
            return nro2 + nro1;
        }

        public int multiplicar(int nro1, int nro2)
        {
            return nro1 * nro2;
        }

        public int dividir(int nro1, int nro2)
        {
            if (nro2 != 0)
            {
                return nro1 / nro2;
            }
            Console.WriteLine("No es posibile dividir por 0");
            return -1;
        }
    }
}
