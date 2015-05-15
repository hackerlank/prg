using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG.TDA
{
    /// <summary>
    /// La estructura de datos diccionario se caracteriza porque cada valor
    /// ingresa a la estructura asociado a una clave, y estas claves existen 
    /// siempre que tengan valor asociado y son unicas.
    /// El diccionario multiple tiene como caracterıstica principal que cada     /// clave del diccionario puede tener asociado un conjunto de valores.
    /// </summary>
    public interface IDiccionarioMultiple
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Dada una clave y una valor, agrega al diccionario el valor
        /// quedando asociado a la clave.
        /// Una misma clave puede tener asociada un conjunto de valores,
        /// pero esos valores no se pueden repetir.
        /// En caso de que una clave ya tenga un valor dado no se hace
        /// nada.
        /// pre: Estructura inicializada
        /// pos: En caso de no poseer la clave, la estructura queda
        /// modificada con una clave y valor mas.
        /// En caso contrario, si la estructura no posee el valor, este
        /// se agrega al conjunto de los valores de la clave
        /// En caso que el valor ya exista en la clave, la estructura
        /// no queda modificada.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="x"></param>
        void Agregar(int c, int x);

        /// <summary>
        /// Dada una clave elimina todos los valores asociados a la 
        /// clave, y por consiguiente la clave ya que el diccionario
        /// no puede contener claves sin valores asociados.
        /// Si la clave no existe no se hace nada.
        /// pre: Estructura inicializada
        /// pos: Si el diccionario contiene la clave, la estructura
        /// queda modificada con una clave y conjunto de valores menos,
        /// en caso contrario, la estructura no queda modificada
        /// </summary>
        /// <param name="c"></param>
        void Eliminar(int c);

        /// <summary>
        /// Dada una clave y un valor se elimina el valor asociado a la 
        /// clave, y en caso de que la clave o el valor no existan no se
        /// hace nada.
        /// Si al eliminar el valor, la clave no tiene otros valores 
        /// asociados se debe eliminar la misma.
        /// pre: Estructura inicializada
        ///      Estructura debe contener la clave
        /// pos: Si la estructura no contiene el valor, entonces la misma
        /// no queda modificada, caso contrario, si el valor es el ultimo
        /// de la clave, la estructura queda modificada con una clave y 
        /// conjunto de valores menos, caso contrario, la estructura queda
        /// modificada con un valor menos en el conjuntos de valores de la 
        /// clave dada.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="x"></param>
        void EliminarValor(int c, int x);

        /// <summary>
        /// Dada una clave devuelve el conjunto de valores asociados a la
        /// misma. 
        /// Si la clave dada no pertenece al diccionario, se debe devolver
        /// un conjunto vacio.
        /// pre: Estructura inicializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        IConjunto Recuperar(int c);

        /// <summary>
        /// Devuelve el conjunto de todas las claves definidas en el 
        /// diccionario.
        /// pre: Estructura inicializada
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <returns></returns>
        IConjunto Claves();
    }
}
