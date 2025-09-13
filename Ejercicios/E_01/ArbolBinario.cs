using System;
using System.Collections.Generic;
namespace E_01
{
	public class ArbolBinario<T>
	{
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
		
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
		public ArbolBinario<T> HijoIzquierdo{get;set;}
		public ArbolBinario<T> HijoDerecho{get;set;}
		
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.HijoIzquierdo==null && this.HijoDerecho==null;
		}

		
		/*Actividad*/
		public void preorden() {
			Console.Write(dato);
			if(HijoIzquierdo!=null){
				HijoIzquierdo.preorden();
			}
			
			if(HijoDerecho!=null){
				HijoDerecho.preorden();
			}
		}
		
		
		public void inorden() {
			if(HijoIzquierdo!=null){
				HijoIzquierdo.inorden();
			}
			
			Console.Write(dato);
			
			if(HijoDerecho!=null){
				HijoDerecho.inorden();
			}
		}
		
	
		
		public void postorden() {
			if(HijoIzquierdo!=null){
				HijoIzquierdo.postorden();
			}
			
			if(HijoDerecho!=null){
				HijoDerecho.postorden();
			}
			
			Console.Write(dato);
		}
		
		public void recorridoPorNiveles() {
			Queue<ArbolBinario<T>> miCola = new Queue<ArbolBinario<T>>();
			
			//encolar la raiz
			miCola.Enqueue(this);
			
			
			while(miCola.Count > 0){
				//desencolar
				ArbolBinario<T>nodo = miCola.Dequeue();
				
				
				//imprimir dato del nodo	
				Console.Write(nodo.dato);
				
				if(nodo.HijoIzquierdo!=null){
					miCola.Enqueue(nodo.HijoIzquierdo);
				}
				
				if(nodo.HijoDerecho!=null){
					miCola.Enqueue(nodo.HijoDerecho);
				}
			}
			
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
			Queue<ArbolBinario<T>> miCola = new Queue<ArbolBinario<T>>();
			
			int nivel=0;
			miCola.Enqueue(this);
			
			
			while(miCola.Count > 0){
				int cantidadNodos= miCola.Count;
				
				for(int i=0; i<cantidadNodos; i++){
					ArbolBinario<T>nodo = miCola.Dequeue();
					
					if(nivel >= n && nivel <=m){
						Console.Write(nodo.dato);
					}
					
					if(nodo.HijoIzquierdo!=null){
						miCola.Enqueue(nodo.HijoIzquierdo);
					}
				
					if(nodo.HijoDerecho!=null){
						miCola.Enqueue(nodo.HijoDerecho);
					}
					
				}
				nivel++;
			
			}
		}
		
	}
}
