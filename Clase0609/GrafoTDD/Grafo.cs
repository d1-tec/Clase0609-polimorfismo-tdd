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
        private List<Arista> aristas;

        public Grafo()
        {
            this.nodos = new List<string>();
            this.aristas = new List<Arista>();
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
            Arista arista = new Arista() { Origen = nodoOrigen, Destino = nodoDestino };
            this.aristas.Add(arista);
        }

        public bool SonAdyacentes(string nodoOrigen, string nodoDestino)
        {
            Arista aristaABuscar = new Arista() { Origen = nodoOrigen, Destino = nodoDestino };

            bool origenYDestinoEstanConectados = this.aristas.Contains(aristaABuscar);

            if (origenYDestinoEstanConectados) return true;

            List<string> adyacentesAlOrigen = this.NodosAdyacentesAlNodo(nodoOrigen);

            return adyacentesAlOrigen.Any(nodoAdyacente => SonAdyacentes(nodoAdyacente, nodoDestino));
        }

        private List<string> NodosAdyacentesAlNodo(string nodo)
        {
            List<Arista> aristasConOrigenElNodo = this.aristas.Where(arista => arista.Origen.Equals(nodo)).ToList();

            List<string> nodosAdyacentes = new List<string>();
            
            foreach (Arista aristaActual in aristasConOrigenElNodo)
            {
                nodosAdyacentes.Add(aristaActual.Destino);
            }

            return nodosAdyacentes;
        }
    }
}
