using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoTDD
{
    public class Grafo
    {
        private List<string> nodos;
        private List<Tuple<string, string>> aristas;

        public Grafo()
        {
            this.nodos = new List<string>();
            this.aristas = new List<Tuple<string, string>>();
        }

        public bool EstaVacio()
        {
            return this.nodos.Count == 0;
        }

        public void AgregarNodo(string nombreNodo)
        {
            if (this.nodos.Contains(nombreNodo))
            {
                throw new NodoRepetidoException();
            }
            this.nodos.Add(nombreNodo);
        }

        public void AgregarArista(string nodoOrigen, string nodoDestino)
        {
            Tuple<string, string> arista = new Tuple<string, string>(nodoOrigen, nodoDestino);
            this.aristas.Add(arista);
        }

        public bool SonAdyacentes(string nodoOrigen, string nodoDestino)
        {
            return this.aristas
                .Any(arista => arista.Item1.Equals(nodoOrigen)
                && arista.Item2.Equals(nodoDestino));
        }
    }
}
