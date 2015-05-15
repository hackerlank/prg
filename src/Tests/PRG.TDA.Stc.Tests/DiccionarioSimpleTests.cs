using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PRG.TDA.Stc.Tests
{
    public class DiccionarioSimpleTests
    {
        private DiccionarioSimple sut;

        public DiccionarioSimpleTests()
        {
            sut = new DiccionarioSimple();
        }

        [Fact]
        public void Agregar()
        {
            sut.Inicializar();
            sut.Agregar(1, 1);
            sut.Agregar(2, 1);
            sut.Agregar(3, 1);

            Assert.Equal(1, sut.elems[0].Valor);
            Assert.Equal(1, sut.elems[1].Valor);
            Assert.Equal(1, sut.elems[2].Valor);
            Assert.Equal(3, sut.pos);
        }

        [Fact]
        public void Eliminar()
        {
            sut.Inicializar();
            sut.Agregar(1, 1);
            sut.Agregar(2, 1);
            sut.Agregar(3, 1);

            sut.Eliminar(2);

            Assert.Equal(1, sut.elems[0].Clave);
            Assert.Equal(3, sut.elems[1].Clave);
            Assert.Equal(2, sut.pos);
        }

        [Fact]
        public void Recuperar()
        {
            sut.Inicializar();
            sut.Agregar(1, 1);
            sut.Agregar(2, 2);
            sut.Agregar(3, 3);

            var r = sut.Recuperar(2);

            Assert.Equal(2, r);
        }

        [Fact]
        public void Claves()
        {
            sut.Inicializar();
            sut.Agregar(1, 1);
            sut.Agregar(2, 2);
            sut.Agregar(3, 3);

            var r = sut.Claves();

            Assert.Equal(true, r.Pertenece(1));
            Assert.Equal(true, r.Pertenece(2));
            Assert.Equal(true, r.Pertenece(3));
        }
    }
}
