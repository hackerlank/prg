using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA
{
    /// <summary>
    /// Es una estructura que nos permite guardar elementos sin que los mismos
    /// se repitan y en donde no se tiene un orden, y permite conocer si
    /// un elemento dado se encuentra o pertenece a la estructura. Debido a que la
    /// estructura no tiene un orden, cuando recuperamos un dato la estructura nos
    /// devuelve uno cualquiera que pertenece a ella, y por otro lado cuando queremos
    /// eliminar una valor debemos indicarle cual es
    /// </summary>
    public interface IConjunto
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Permite agregar un elemento al conjunto
        /// El elemento no debe repetirse
        /// pre: Estructura inicializada
        /// pos: Si el elemento no pertence al conjunto, 
        /// la estructura queda modificada con un elemento mas,
        /// en caso contrario la estructura no queda modificada
        /// </summary>
        /// <param name="x"></param>
        void Agregar(int x);

        /// <summary>
        /// Permite eliminar del conjunto un elemento dado.
        /// pre: Estructura inicializada
        ///      La estructura debe tener al menos un elemento
        /// pos: Si elemento pertenece al conjunto, la estructura 
        /// queda modificada con un elemento menos, en caso contrario,
        /// la estructura no queda modificada
        /// </summary>
        /// <param name="x"></param>
        void Sacar(int x);

        /// <summary>
        /// Devuelve un elemento cualquiera del conjunto
        /// pre: Estructura inicalizada
        ///      La estructura debe tener al menos un elemento
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        int Elegir();

        /// <summary>
        /// Permite conocer si un elemento dado se encuentra en el conjunto
        /// pre: Estructura inicializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        bool Pertenece(int x);

        /// <summary>
        /// Indica si el conjunto contiene elemenos o no.
        /// pre: Estructura inicializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        bool ConjuntoVacio();
    }
}
