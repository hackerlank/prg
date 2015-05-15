using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Dnc
{
    public class DiccionarioSimple : IDiccionarioSimple
    {
        internal class Nodo
        {
            public int Clave { get; set; }
            public int Valor { get; set; }
            public Nodo Sig { get; set; }
        }

        internal Nodo primero;

        public void Inicializar()
        {
            primero = null;
        }

        public void Agregar(int c, int v)
        {
            Nodo aux = primero;
            while(aux != null && aux.Clave != c)
                aux = aux.Sig;

            if (aux == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.Clave = c;
                nuevo.Valor = v;

                primero = nuevo;
            }
            else
            {
                aux.Valor = v;
            }
        }

        public void Eliminar(int c)
        {
            if (primero == null)
                return;

            if (primero.Clave == c)
                primero = primero.Sig;
            else
            {
                Nodo aux = primero;
                while (aux.Sig != null && aux.Sig.Clave != c)
                    aux = aux.Sig;

                if (aux.Sig != null)
                    aux.Sig = aux.Sig.Sig;
            }



        }

        public int Recuperar(int c)
        {
            Nodo aux = primero;
            while (aux != null && aux.Clave != c)
                aux = aux.Sig;

            return aux.Clave;
        }

        public IConjunto Claves()
        {
            IConjunto conj = new Conjunto();
            conj.Inicializar();
            Nodo aux = primero;
            while (aux != null)
            {
                conj.Agregar(aux.Clave);
                aux = aux.Sig;
            }

            return conj;
        }
    }
}
