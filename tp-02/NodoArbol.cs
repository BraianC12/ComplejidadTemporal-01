
using System;
using System.Collections.Generic;
namespace tp_02
{
	public class NodoArbol
	{
		private int cantDeVueltas;
		private string tipo;
		private List<NodoArbol> hijos;
		
		public NodoArbol(int cant, string t ){
			cantDeVueltas=cant;
			tipo=t;
			this.hijos=new List<NodoArbol>();
		}
		
		public int CantDeVueltas{
			get{return cantDeVueltas;}
			set{cantDeVueltas=value;}
		}
		
		public string  Tipo{
			get{return tipo;}
			set{tipo=value;}
		}
		
		public List<NodoArbol> Hijos{
			get{return hijos;}
		}
		
		public void AgregarNodo(NodoArbol nodo){
			hijos.Add(nodo);
		}
	}
}
