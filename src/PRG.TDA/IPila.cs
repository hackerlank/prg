using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA
{
    /// <summary>
    /// Es una estructura que permite almacenar
    /// conjuntos de valores, eliminarlos y recuperarlos, con la particularidad de que el
    /// elemento que se recupera o elimina es el ultimo que ingreso
    /// </summary>
    public interface IPila
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Permite agregar un elemento a la pila. 
        /// pre: Estructura inicializada
        /// pos: La estructura queda modificada con un elemento mas
        /// </summary>
        /// <param name="x"></param>
        void Apilar(int x);

        /// <summary>
        /// Permite eliminar el ultimo elemento agregado a la pila
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura queda modificada con un elemento menos
        /// </summary>
        void Desapilar();

        /// <summary>
        /// Indica si la pila contiene elementos o no.
        /// pre: Estructura incializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        bool PilaVacia();

        /// <summary>
        /// Permite conocer cual es el ultimo elemento ingresado a la pila
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        int Tope();
    }
}