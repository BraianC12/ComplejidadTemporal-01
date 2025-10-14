using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class RutasGrafos
    {
        private List<string> mejorRuta;
        private int mejorTiempo;

        public RutasGrafos()
        {
          
        }



        public List<string> rutasRescateOptimal(Grafo<string> zona, string baseRescate, string objetivo, int maxDuracion)
        {
            mejorRuta = new List<string>();
            mejorTiempo = int.MaxValue;

            Vertice<string> origen = null;
            Vertice<string> destino = null;

            foreach(Vertice<string> v in zona.getVertices())
            {
                if(v.getDato() == baseRescate)
                {
                    origen = v;
                }

                if (v.getDato() == objetivo)
                {
                    destino = v;
                }
            }

            if(origen==null || destino == null)
            {
                return mejorRuta;
            }

            bool[] visitados = new bool[zona.getVertices().Count];
            List<string> rutaActual = new List<string>();

            buscarRuta(zona, origen, destino, maxDuracion, 0, visitados, rutaActual);
            return mejorRuta;

        }

        private void buscarRuta(Grafo<string> zona, Vertice<string> actual, Vertice<string> destino, int maxDuracion, int tiempoAcumulado, bool[] visitados, List<string> rutaActual)
        {
            rutaActual.Add(actual.getDato());
            visitados[actual.getPosicion() - 1] = true;

            if(actual == destino)
            {
                if (tiempoAcumulado < mejorTiempo)
                {
                    mejorTiempo = tiempoAcumulado;
                    mejorRuta = new List<string>();
                    foreach(string s in rutaActual)
                    {
                        mejorRuta.Add(s);
                    }
                }
            }

            else
            {
                foreach(Arista<string> arista in actual.getAdyacentes())
                {
                    Vertice<string> siguiente = arista.getDestino();
                    int duracion = arista.getPeso();

                    if (!visitados[siguiente.getPosicion() - 1] && duracion <= maxDuracion)
                    {
                        buscarRuta(zona, siguiente, destino, maxDuracion, tiempoAcumulado + duracion, visitados, rutaActual);
                    }
                }
            }

            rutaActual.RemoveAt(rutaActual.Count - 1);
            visitados[actual.getPosicion() - 1] = false;
        }
    }
}
