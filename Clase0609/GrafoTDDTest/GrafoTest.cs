using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GrafoTDD;

namespace GrafoTDDTest
{
    [TestClass]
    public class GrafoTest
    {
        // red
        // green
        // refactor
        [TestMethod]
        public void UnGrafoRecienCreadoEstaVacio()
        {
            Grafo grafo = new Grafo();
            Assert.IsTrue(grafo.EstaVacio());
        }

        [TestMethod]
        public void UnGrafoConUnNodoNoEsVacio()
        {
            Grafo grafo = new Grafo();
            grafo.AgregarNodo("Montevideo");
            Assert.IsFalse(grafo.EstaVacio());
        }

        [TestMethod]
        [ExpectedException(typeof(NodoRepetidoException))]
        public void UnGrafoNoPuedeTenerUnNodoRepetido()
        {
            Grafo grafo = new Grafo();
            grafo.AgregarNodo("Montevideo");
            grafo.AgregarNodo("Montevideo");
        }

        [TestMethod]
        public void SiHayUnaAristaEntreNodosSonAdyacentes()
        {
            Grafo grafo = new Grafo();
            grafo.AgregarNodo("Montevideo");
            grafo.AgregarNodo("Colonia");
            grafo.AgregarArista("Montevideo", "Colonia");
            Assert.IsTrue(grafo.SonAdyacentes("Montevideo", "Colonia"));
        }

        [TestMethod]
        public void SiHayUnaAristaEntreNodosNoSonAdyacentesEnElSentidoInverso()
        {
            Grafo grafo = new Grafo();
            grafo.AgregarNodo("Montevideo");
            grafo.AgregarNodo("Colonia");
            grafo.AgregarArista("Montevideo", "Colonia");
            Assert.IsFalse(grafo.SonAdyacentes("Colonia", "Montevideo"));
        }

        [TestMethod]
        public void SiHayUnCaminoEntreDosNodosEntoncesSonAdyacentes()
        {
            // setup
            Grafo grafo = new Grafo();
            grafo.AgregarNodo("Montevideo");
            grafo.AgregarNodo("Colonia");
            grafo.AgregarNodo("Durazno");
            grafo.AgregarArista("Montevideo", "Colonia");
            grafo.AgregarArista("Colonia", "Durazno");

            // exercise
            bool sonAdyacentes = grafo.SonAdyacentes("Montevideo", "Durazno");

            Assert.IsTrue(sonAdyacentes);
        }
    }
}
