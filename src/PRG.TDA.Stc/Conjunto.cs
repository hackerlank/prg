using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Stc
{
    public class Conjunto : IConjunto
    {
        internal int[] elems;
        internal int pos;

        public void Inicializar()
        {
            elems = new int[100];
            pos = 0;
        }

        public void Agregar(int x)
        {
            if (Pertenece(x))
                return;

            elems[pos] = x;
            pos++;
        }

        public void Sacar(int x)
        {
            int i = 0;
            while (i < pos && elems[i] != x)
                i++;

            if (i >= pos)
                return;

            elems[i] = elems[pos-1];

            pos--;
        }

        public int Elegir()
        {
            return elems[pos - 1];
        }

        public bool Pertenece(int x)
        {
            int i=0;
            while (i < pos && elems[i] != x)
                i++;
            return i < pos;
        }

        public bool ConjuntoVacio()
        {
            return pos == 0;
        }
    }
}
