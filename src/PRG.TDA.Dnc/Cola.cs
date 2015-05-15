using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Dnc
{
    public class Cola : ICola
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

        public void Acolar(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.Valor = x;
            nuevo.Sig = null;

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo aux2 = primero;
                while (aux2 != null && aux2.Sig != null)
                    aux2 = aux2.Sig;
                
                aux2.Sig = nuevo; 
            }
        }

        public void Desacolar()
        {
            if (primero != null)
                primero = primero.Sig;
        }

        public int Primero()
        {
            return primero.Valor;
        }

        public bool ColaVacia()
        {
            return primero == null;
        }
    }
}
