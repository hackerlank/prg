using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PRG.TDA.Stc.Tests
{
    public class ConjuntoTests
    {
        private Conjunto sut;

        public ConjuntoTests()
        {
            sut = new Conjunto();
        }

        [Fact]
        public void Agregar()
        {
            sut.Inicializar();
            sut.Agregar(1);
            sut.Agregar(2);
            sut.Agregar(3);

            Assert.Equal(1, sut.elems[0]);
            Assert.Equal(2, sut.elems[1]);
            Assert.Equal(3, sut.elems[2]);
            Assert.Equal(3, sut.pos);
        }

        [Fact]
        public void Sacar()
        {
            sut.Inicializar();
            sut.Agregar(1);
            sut.Agregar(2);
            sut.Agregar(3);
            sut.Agregar(4);
            sut.Agregar(5);
            sut.Agregar(6);

            sut.Sacar(3);

            Assert.Equal(1, sut.elems[0]);
            Assert.Equal(2, sut.elems[1]);
            Assert.Equal(6, sut.elems[2]);
            Assert.Equal(4, sut.elems[3]);
            Assert.Equal(5, sut.elems[4]);
            Assert.Equal(5, sut.pos);
        }

        [Fact]
        public void Elegir()
        {
            sut.Inicializar();
            sut.Agregar(1);
            sut.Agregar(2);
            sut.Agregar(3);

            var e = sut.Elegir();

            Assert.Equal(3, e);
        }

        [Fact]
        public void Pertenece()
        {
            sut.Inicializar();
            sut.Agregar(1);
            sut.Agregar(2);
            sut.Agregar(3);

            var p = sut.Pertenece(2);

            Assert.Equal(true, p);
        }

        [Fact]
        public void ConjuntoVacio_False()
        {
            sut.Inicializar();
            sut.Agregar(1);
            sut.Agregar(2);
            sut.Agregar(3);

            var p = sut.ConjuntoVacio();

            Assert.Equal(false, p);
        }

        [Fact]
        public void ConjuntoVacio_True()
        {
            sut.Inicializar();

            var p = sut.ConjuntoVacio();

            Assert.Equal(true, p);
        }
    }
}
