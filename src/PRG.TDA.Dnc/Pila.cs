using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Dnc
{
    public class Pila : IPila
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

        public void Apilar(int x)
        {
            Nodo aux = new Nodo();
            aux.Valor = x;
            aux.Sig = primero;
            primero = aux;
        }

        public void Desapilar()
        {
            primero = primero.Sig;
        }

        public bool PilaVacia()
        {
            return primero == null;
        }

        public int Tope()
        {
            return primero.Valor;
        }
    }
}
