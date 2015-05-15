using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA
{
    /// <summary>
    /// Es una estructura que nos permite almacenar valores, recuperar y 
    /// eliminar el primer valor ingresado, ademas de que nos permite 
    /// conocer si la cola tiene o no elementos
    /// </summary>
    public interface ICola
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Permite agregar un elemento en la cola.
        /// pre: Estructura inicializada
        /// pos: La estructura queda modificada con un elemeneto mas
        /// </summary>
        /// <param name="x"></param>
        void Acolar(int x);

        /// <summary>
        /// Permite eliminar el primer elemento agregado a la cola
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura queda modificada con un elemento menos
        /// </summary>
        void Desacolar();

        /// <summary>
        /// Permite conocer cual es el primer elemento ingreso a la cola
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        int Primero();

        /// <summary>
        /// Indica si la cola contiene elementos o no
        /// pre: Estructura inicializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        bool ColaVacia();
    }
}
