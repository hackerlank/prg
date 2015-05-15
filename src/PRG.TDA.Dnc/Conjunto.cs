using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Dnc
{
    public class Conjunto : IConjunto
    {
        internal class Nodo
        {
            public int Valor { get; set; }
            public Nodo Sig { get; set; }
        }

        internal Nodo primero;

        public void Inicializar()
        {
            primero = null;
        }

        public void Agregar(int x)
        {
            if (Pertenece(x))
                return;

            Nodo nuevo = new Nodo();
            nuevo.Valor = x;
            nuevo.Sig = null;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                var aux = primero;
                while (aux != null && aux.Sig != null)
                    aux = aux.Sig;

                aux.Sig = nuevo;
            }
        }

        public void Sacar(int x)
        {
            if (primero == null)
                return;

            if (primero.Valor == x)
                primero = primero.Sig;
            else
            {
                Nodo aux = primero;
                while (aux != null && aux.Sig != null && aux.Sig.Valor != x)
                    aux = aux.Sig;

                if (aux.Sig != null)
                    aux.Sig = aux.Sig.Sig;
            }
        }

        public int Elegir()
        {
            var aux = primero;
            while (aux != null && aux.Sig != null)
                aux = aux.Sig;

            return aux.Valor;
        }

        public bool Pertenece(int x)
        {
            var aux = primero;
            while (aux != null && aux.Valor != x)
                aux = aux.Sig;

            return aux != null;
        }

        public bool ConjuntoVacio()
        {
            return primero == null;
        }
    }
}
