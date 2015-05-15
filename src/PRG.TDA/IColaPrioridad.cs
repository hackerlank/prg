using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA
{
    /// <summary>
    /// Es estructura que a cada elemento cuando ingresa a la misma se le va
    /// a asignar una prioridad, y luego los elementos van a ser recuperados 
    /// o eliminados de la estructura de acuerdo a esa prioridad.
    /// </summary>
    public interface IColaPrioridad
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Permite agregar un elemento a la cola con una cierta prioridad dada
        /// pre: Estructura inicializada
        /// pos: La estructura queda modificada con un elemento mas
        /// </summary>
        /// <param name="x"></param>
        /// <param name="p"></param>
        void AcolarPrioridad(int x, int p);

        /// <summary>
        /// Permite eliminar el elemento con mayor prioridad en la cola.
        /// En caso de tener dos elementos con la misma prioridad sale
        /// el primero ingresado
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura queda modificada con un elemento menos
        /// </summary>
        void Desacolar();

        /// <summary>
        /// Permite conocer cual es el elemento de mayor prioridad ingresado
        /// a la cola.
        /// En caso de tener dos elementos con la misma prioridad devuelve
        /// el primero ingresado
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        int Primero();

        /// <summary>
        /// Permite conocer la prioridad del elemento con mayor prioridad de
        /// la cola
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        int Prioridad();
    }
}
