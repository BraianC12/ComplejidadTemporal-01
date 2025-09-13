using System;
using System.Collections.Generic;
namespace E_01
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
            
            raiz.recorridoEntreNiveles(1,2);
            
            
			Console.ReadKey(true);
		}
	}
}