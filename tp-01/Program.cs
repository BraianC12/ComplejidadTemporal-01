using System;
using System.Collections.Generic;
namespace tp_01
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolBinario<int> raiz = new ArbolBinario<int>(1);
  			raiz.HijoIzquierdo= new ArbolBinario<int>(2);
            raiz.HijoDerecho = new ArbolBinario<int>(3);
            raiz.HijoIzquierdo.HijoIzquierdo = new ArbolBinario<int>(4);
            raiz.HijoDerecho.HijoIzquierdo = new ArbolBinario<int>(5);
            raiz.HijoDerecho.HijoDerecho = new ArbolBinario<int>(6);
            raiz.HijoDerecho.HijoIzquierdo.HijoIzquierdo = new ArbolBinario<int>(7);
            
             Console.Write("Recorrido PREORDEN: ");
            raiz.preorden();
            
            Console.Write("\nRecorrido INORDEN: ");
            raiz.inorden();
            
            Console.Write("\nRecorrido POSTORDEN: ");
            raiz.postorden();
            
            
			Console.ReadKey(true);
		}
	}
}