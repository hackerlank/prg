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
    /// siempre que tengan valor asociado y son unicas
    /// </summary>
    public interface IDictionarioSimple
    {
        /// <summary>
        /// Inicializa la estructura
        /// pre: No posee
        /// pos: La estructura queda inicializada
        /// </summary>
        void Inicializar();

        /// <summary>
        /// Dada una clave y un valor, agrega al diccionario el valor quedando
        /// asociado a la clave.
        /// Si ya existe la misma clave con otro valor se sobreescribe el 
        /// valor, dejando el nuevo ingresado.
        /// pre: Estructura inicializada
        /// pos: La estructura queda modificada con una clave y un valor mas
        /// (en caso de que la clave exista, el valor sobreescribe al anterior)
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        void Agregar(int c, int v);

        /// <summary>
        /// Dada una clave elimina el valor asociado a la clave, y por
        /// consiguiente la clave ya que el diccionario no puede contener
        /// claves sin valores asociados.
        /// Si la clave no existe no se hace nada.
        /// pre: Estructura inicializada
        /// pos: La estructura queda modificada con una clave y elemento
        /// menos. En caso que la clave no exista, la estructura no queda
        /// modificada
        /// </summary>
        /// <param name="c"></param>
        void Eliminar(int c);

        /// <summary>
        /// Dada una clave devuelve el valor asociada a la clave.
        /// La clave dada debe pertenecer al diccionario
        /// pre: Estructura inicializada
        ///      La estructura debe poseer la clave
        /// pos: La estructura no queda modificada
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        int Recuperar(int c);

        /// <summary>
        /// Devuelve un conjunto de todas las claves definidas en el
        /// diccionario.
        /// En caso de que la estructura esta vacia, se devolvera 
        /// un conjunto vacio
        /// pre: Estructura inicializada
        /// </summary>
        /// <returns></returns>
        IConjunto Claves();
    }
}
