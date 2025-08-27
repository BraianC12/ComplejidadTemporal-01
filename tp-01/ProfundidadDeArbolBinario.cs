using System;
using System.Collections.Generic;

namespace tp_01
{
	public class ProfundidadDeArbolBinario
	{
		ArbolBinario<int>arbol;
		
		public ProfundidadDeArbolBinario(ArbolBinario<int>arbol){
			this.arbol=arbol;
		}
		
		public int SumarElementosProfundidad(int p){
			int nivel=0;
			int suma=0;
			
			//primera parte
			if(arbol.esHoja()){
				arbol.getDatoRaiz();
			}
			
			Queue<ArbolBinario<int>> numeros=new Queue<ArbolBinario<int>>();
			numeros.Enqueue(arbol);
			

			while(numeros.Count>0){
				int nodosNivel = numeros.Count; //cantidad de nodos en ese nivel
				
				for(int i=0;i<nodosNivel;i++){
					var nodo=numeros.Dequeue();
					if(nivel==p){
						suma=suma+nodo.getDatoRaiz();
					}
					
					if(nodo.HijoIzquierdo!=null){
						numeros.Enqueue(nodo.HijoIzquierdo);
					}
						
					if(nodo.HijoDerecho!=null){
						numeros.Enqueue(nodo.HijoDerecho);
					}
		
				}
					nivel++;
				
				}
			return suma;
			}
		
		
	}
}
