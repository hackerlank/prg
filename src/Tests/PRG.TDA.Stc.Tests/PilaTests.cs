using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PRG.TDA.Stc.Tests
{
    public class PilaTests
    {
        private Pila sut;

        public PilaTests()
        {
            this.sut = new Pila();
        }

        [Fact]
        public void Apilar()
        {
            this.sut.Inicializar();
            this.sut.Apilar(1);
            this.sut.Apilar(2);
            this.sut.Apilar(3);

            Assert.Equal(1, this.sut.elems[0]);
            Assert.Equal(2, this.sut.elems[1]);
            Assert.Equal(3, this.sut.elems[2]);
            Assert.Equal(3, this.sut.pos);
        }

        [Fact]
        public void Desapilar()
        {
            this.sut.Inicializar();
            this.sut.Apilar(1);
            this.sut.Apilar(2);
            this.sut.Apilar(3);
            this.sut.Desapilar();

            Assert.Equal(1, this.sut.elems[0]);
            Assert.Equal(2, this.sut.elems[1]);
            Assert.Equal(3, this.sut.elems[2]);
            Assert.Equal(2, this.sut.pos);
        }

        [Fact]
        public void Tope()
        {
            this.sut.Inicializar();
            this.sut.Apilar(1);
            this.sut.Apilar(2);
            this.sut.Apilar(3);
            var tope = this.sut.Tope();

            Assert.Equal(3, tope);
        }

        [Fact]
        public void PilaVacia_False()
        {
            this.sut.Inicializar();
            this.sut.Apilar(1);
            this.sut.Apilar(2);
            this.sut.Apilar(3);
            var vacia = this.sut.PilaVacia();

            Assert.Equal(false, vacia);
        }

        [Fact]
        public void PilaVacia_True()
        {
            this.sut.Inicializar();
            this.sut.Apilar(1);
            this.sut.Apilar(2);
            this.sut.Apilar(3);
            this.sut.Desapilar();
            this.sut.Desapilar();
            this.sut.Desapilar();
            var vacia = this.sut.PilaVacia();

            Assert.Equal(true, vacia);
        }
    }
}
