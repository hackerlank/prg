using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PRG.TDA.Stc.Tests
{
    public class ColaTests
    {
        private Cola sut;

        public ColaTests()
        {
            this.sut = new Cola();
        }

        [Fact]
        public void Acolar()
        {
            this.sut.Inicializar();
            this.sut.Acolar(1);
            this.sut.Acolar(2);
            this.sut.Acolar(3);

            Assert.Equal(1, this.sut.elems[0]);
            Assert.Equal(2, this.sut.elems[1]);
            Assert.Equal(3, this.sut.elems[2]);
            Assert.Equal(3, this.sut.pos);
        }

        [Fact]
        public void Desacolar()
        {
            this.sut.Inicializar();
            this.sut.Acolar(1);
            this.sut.Acolar(2);
            this.sut.Acolar(3);
            this.sut.Desacolar();

            Assert.Equal(2, this.sut.elems[0]);
            Assert.Equal(3, this.sut.elems[1]);
            Assert.Equal(2, this.sut.pos);
        }

        [Fact]
        public void Primero()
        {
            this.sut.Inicializar();
            this.sut.Acolar(1);
            this.sut.Acolar(2);
            this.sut.Acolar(3);
            var tope = this.sut.Primero();

            Assert.Equal(1, tope);
        }

        [Fact]
        public void ColaVacia_False()
        {
            this.sut.Inicializar();
            this.sut.Acolar(1);
            this.sut.Acolar(2);
            this.sut.Acolar(3);
            var vacia = this.sut.ColaVacia();

            Assert.Equal(false, vacia);
        }

        [Fact]
        public void ColaVacia_True()
        {
            this.sut.Inicializar();
            this.sut.Acolar(1);
            this.sut.Acolar(2);
            this.sut.Acolar(3);
            this.sut.Desacolar();
            this.sut.Desacolar();
            this.sut.Desacolar();
            var vacia = this.sut.ColaVacia();

            Assert.Equal(true, vacia);
        }
    }
}
