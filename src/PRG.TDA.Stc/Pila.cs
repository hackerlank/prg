using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Stc
{
    public class Pila : IPila
    {
        internal int[] elems;
        internal int pos;

        public void Inicializar()
        {
            elems = new int[100];
            pos = 0;
        }

        public void Apilar(int x)
        {
            elems[pos] = x;
            pos++;
        }

        public void Desapilar()
        {
            if (pos <= 0)
                return;

            pos--;
        }

        public bool PilaVacia()
        {
            return pos == 0;
        }

        public int Tope()
        {
            return elems[pos - 1];
        }
    }
}
