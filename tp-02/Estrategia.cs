
using System;
using System.Collections.Generic;
namespace tp_02
{
	public class Estrategia
	{
		
		public List<NodoArbol> MejorEstrategia(NodoArbol raiz)
		{
			var mejorRuta = new List<NodoArbol>();
			double mejorTiempo = double.MaxValue;
			
			// Buscar todas las rutas posibles
			BuscarRutas(raiz, new List<NodoArbol>(), 0, mejorRuta, ref mejorTiempo);
			
			return mejorRuta;
		}

		private void BuscarRutas(NodoArbol nodo, List<NodoArbol> rutaActual, double tiempoActual, List<NodoArbol> mejorRuta, ref double mejorTiempo)
		{
			// Si el nodo tiene tipo válido (no es raíz), agregarlo a la ruta
			if (!string.IsNullOrEmpty(nodo.Tipo))
			{
				rutaActual.Add(nodo);
				
				double tiempoNeumatico = CalcularTiempo(nodo);
				tiempoActual += tiempoNeumatico;
				
				
				if (rutaActual.Count > 1)
				{
					tiempoActual += 10;
				}
			}

			
			if (nodo.Hijos == null || nodo.Hijos.Count == 0){
				if (rutaActual.Count > 0 && tiempoActual < mejorTiempo){  // Actualizar mejor estrategia encontrada
					mejorTiempo = tiempoActual;
					mejorRuta.Clear();
					mejorRuta.AddRange(rutaActual);
				}
			}
			else{
				foreach (var hijo in nodo.Hijos){  
					BuscarRutas(hijo, new List<NodoArbol>(rutaActual), tiempoActual, mejorRuta, ref mejorTiempo);
				}
			}
		} 
		
		public double CalcularTiempo(NodoArbol nodo)
		{ 
			switch (nodo.Tipo.ToUpper())
			{
				case "SOFT":
					return nodo.CantDeVueltas * 0.0;
				case "MED":
					return nodo.CantDeVueltas * 0.4;
				case "HARD":
					return nodo.CantDeVueltas * 0.7; 
				default:
					return nodo.CantDeVueltas * 0.0; 
			}
		
		}
		
		
	}
}