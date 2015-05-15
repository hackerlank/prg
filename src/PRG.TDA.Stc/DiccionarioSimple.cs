using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Stc
{
    public class DiccionarioSimple : IDiccionarioSimple
    {
        internal class ClaveValor
        {
            public int Clave { get; set; }
            public int Valor { get; set; }
        }

        internal ClaveValor[] elems;
        internal int pos;

        public void Inicializar()
        {
            elems = new ClaveValor[100];
            pos = 0;
        }

        public void Agregar(int c, int v)
        {
            int i = 0;
            while (i < pos && elems[i].Clave != c)
                i++;

            elems[i] = new ClaveValor();
            elems[i].Clave = c;
            elems[i].Valor = v;

            if (i == pos)
                pos++;
        }

        public void Eliminar(int c)
        {
            int i = 0;
            while (i < pos && elems[i].Clave != c)
                i++;

            if (i >= pos)
                return;

            elems[i] = elems[pos - 1];
            pos--;
        }

        public int Recuperar(int c)
        {
            int i = 0;
            while (i < pos && elems[i].Clave != c)
                i++;

            return elems[i].Valor;
        }

        public IConjunto Claves()
        {
            IConjunto claves = new Conjunto();
            claves.Inicializar();
            int i;
            for (i = 0; i < pos; i++)
            {
                claves.Agregar(elems[i].Clave);
            }
            return claves;
        }
    }
}
