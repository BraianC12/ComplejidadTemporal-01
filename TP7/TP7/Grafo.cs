using System;
using System.Collections.Generic;

namespace TP7
{
	/// <summary>
	/// Description of Grafo.
	/// </summary>
	public class Grafo<T>
	{
		public Grafo()
		{
		}
		
		private List<Vertice<T>>vertices = new List<Vertice<T>>();
	
		public void agregarVertice(Vertice<T> v) {
			v.setPosicion(vertices.Count + 1);
			vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v) {
			vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso) {
			origen.getAdyacentes().Add(new Arista<T>(destino,peso));
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}

	
		public List<Vertice<T>> getVertices() {
			return vertices;
		}

	
		public Vertice<T> vertice(int posicion) {
			return this.vertices[posicion];
		}


        public void DFS(Vertice<T> origen)
        {
            bool[] visitados = new bool[this.vertices.Count];
            this._DFS(origen, visitados);
        }

        private void _DFS(Vertice<T> origen, bool[] visitados)
        {
            //proceso el origen
            Console.Write(origen.getDato());
            //marcar origen como visitado
            visitados[origen.getPosicion() - 1] = true;
            //para cada "adyacente a origen
            foreach (var ady in origen.getAdyacentes())
            {
                if (!visitados[ady.getDestino().getPosicion() - 1])
                {
                    this._DFS(ady.getDestino(), visitados);
                }
            }
        }

        public void BFS(Vertice<T> origen)
        {
            bool[] visitados = new bool[this.vertices.Count];
            Queue<Vertice<T>> c = new Queue<Vertice<T>>();
            Vertice<T> verticeAux;

            c.Enqueue(origen);
            visitados[origen.getPosicion() - 1] = true;

            while (c.Count > 0)
            {
                verticeAux = c.Dequeue();
                Console.Write(verticeAux.getDato() + " ");

                foreach (var ady in verticeAux.getAdyacentes())
                {
                    if (!visitados[ady.getDestino().getPosicion() - 1])
                    {
                        visitados[ady.getDestino().getPosicion() - 1] = true;
                        c.Enqueue(ady.getDestino());
                    }
                }
            }
        }


    }
}
