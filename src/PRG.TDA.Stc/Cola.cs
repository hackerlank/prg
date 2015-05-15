using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Stc
{
    public class Cola : ICola
    {
        internal int[] elems;
        internal int pos;

        public void Inicializar()
        {
            elems = new int[100];
            pos = 0;
        }

        public void Acolar(int x)
        {
            elems[pos] = x;
            pos++;
        }

        public void Desacolar()
        {
            int i, aux = elems[pos - 1], aux2;
            for (i = pos-1; i > 0; i--)
            {
                aux2 = elems[i - 1];
                elems[i - 1] = aux;
                aux = aux2;
            }
            pos--;
        }

        public int Primero()
        {
            return elems[0];
        }

        public bool ColaVacia()
        {
            return pos == 0;
        }
    }
}
