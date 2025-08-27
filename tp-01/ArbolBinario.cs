using System;
using System.Collections.Generic;
namespace tp_01
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
			
		}
	
		public int contarHojas() {
			return 0;
		}
		
		public void recorridoEntreNiveles(int n,int m) {
		}
	}
}
