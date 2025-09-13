using System;
using System.Collections.Generic;

namespace tp_02
{
	/// <summary>
	/// Description of Estrategia.
	/// </summary>
	public class Estrategia
	{
		private double mejorTiempo;
		private List<Compuesto> mejorCamino;
		
		private double CalcularTiempo(Compuesto c){
			if(c.tipo == "Soft"){
				return c.vueltas * 0.3;
			}
			
			if(c.tipo == "Med"){
				return c.vueltas * 0.4;
			}
			
			if(c.tipo == "Hard"){
				return c.vueltas * 0.7;
			}
			
			return 0;
		}
		
		private void Buscar(ArbolGeneral<Compuesto> nodo, List<Compuesto> camino, double tiempo, bool esRaiz){
			
			if(!esRaiz && nodo.getDatoRaiz() !=null){
				tiempo += CalcularTiempo(nodo.getDatoRaiz());
				camino.Add(nodo.getDatoRaiz());
			}
			
			
			if(nodo.esHoja()){
				if(tiempo<mejorTiempo){
					mejorTiempo = tiempo;
					mejorCamino= new List<Compuesto>(camino);
				}
			}
			else{
				foreach (var hijo in nodo.getHijos()){
					double tiempoHijo= tiempo;
					if(nodo.getDatoRaiz() != null) {
						tiempoHijo +=10;
					}
					Buscar(hijo, camino, tiempoHijo, false);
				}
			}
			
			}
		
		
		public List<Compuesto> mejorEstrategia(ArbolGeneral<Compuesto> arbol){
			mejorTiempo= double.MaxValue;
			mejorCamino=null;
			
			
			Buscar(arbol, new List<Compuesto>(), 0, true);
			
			
			return mejorCamino;
			
		}
		
		public double GetMejorTiempo()
		{
			return mejorTiempo;
		}
	}
}
