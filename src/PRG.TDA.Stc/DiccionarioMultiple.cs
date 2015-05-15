using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Stc
{
    public class DiccionarioMultiple : IDiccionarioMultiple
    {
        internal class ClaveValor
        {
            public int Clave { get; set; }
            public int[] Valores { get; set; }
            public int pos { get; set; }

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
            
            if (i < pos)
            {
                ClaveValor cv = elems[i];

                int x = 0;
                while (x < cv.pos && cv.Valores[x] != v)
                    x++;

                if (x >= cv.pos)
                {
                    cv.Valores[x] = v;
                    cv.pos++;
                }
            }
            else
            {
                ClaveValor cv = new ClaveValor();
                cv.Clave = c;
                cv.Valores = new int[100];
                cv.Valores[0] = v;
                cv.pos = 1;
            }
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

        public void EliminarValor(int c, int v)
        {
            int i = 0;
            while (i < pos && elems[i].Clave != c)
                i++;

            if (i >= pos)
                return;

            if (elems[i].pos == 1 && elems[i].Valores[0] == v)
            {
                Eliminar(c);
                return;
            }

            int x = 0;
            while (x < elems[i].pos && elems[i].Valores[x] != v)
                x++;

            if (x >= elems[i].pos)
                return;

            elems[i].Valores[x] = elems[i].Valores[elems[i].pos - 1];
            elems[i].pos--;
        }

        public IConjunto Recuperar(int c)
        {
            int i = 0;
            while (i < pos && elems[i].Clave != c)
                i++;

            IConjunto conj = new Conjunto();
            conj.Inicializar();

            if (i < pos)
            {
                int x;
                for (x = 0; x < elems[i].pos; x++)
                {
                    conj.Agregar(elems[i].Valores[x]);
                }
            }

            return conj;
        }

        public IConjunto Claves()
        {
            IConjunto conj = new Conjunto();
            conj.Inicializar();
            int i = 0;
            for (i = 0; i < pos; i++)
            {
                conj.Agregar(elems[i].Clave);
            }

            return conj;
        }
    }
}
