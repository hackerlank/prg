using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA.Dnc
{
    public class DiccionarioMultiple : IDiccionarioMultiple
    {
        internal class NodoValor
        {
            public int Valor { get; set; }
            public NodoValor Sig { get; set; }
        }

        internal class Nodo
        {
            public int Clave { get; set; }
            public NodoValor Primero { get; set; }
            public Nodo Sig { get; set; }
        }

        internal Nodo primero;

        public void Inicializar()
        {
            primero = null;
        }

        public void Agregar(int c, int x)
        {
            Nodo aux = primero;
            while (aux != null && aux.Clave != c)
                aux = aux.Sig;

            if (aux != null)
            {
                NodoValor aux2 = aux.Primero;
                while (aux2 != null && aux2.Valor != x)
                    aux2 = aux2.Sig;

                if (aux2 == null)
                {
                    NodoValor nuevo = new NodoValor();
                    nuevo.Valor = x;
                    nuevo.Sig = aux.Primero;
                    aux.Primero = nuevo;
                }
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.Clave = c;
                nuevo.Sig = primero;
                nuevo.Primero = new NodoValor();
                nuevo.Primero.Valor = x;
                nuevo.Primero.Sig = null;
                primero = nuevo;
            }
        }

        public void Eliminar(int c)
        {
            throw new NotImplementedException();
        }

        public void EliminarValor(int c, int x)
        {
            throw new NotImplementedException();
        }

        public IConjunto Recuperar(int c)
        {
            throw new NotImplementedException();
        }

        public IConjunto Claves()
        {
            throw new NotImplementedException();
        }
    }
}
