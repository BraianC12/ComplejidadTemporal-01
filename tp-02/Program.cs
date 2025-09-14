
using System;
using System.Collections.Generic;
namespace tp_02
{
	class Program
	{
		public static void Main(string[] args)
		{
			
		
			NodoArbol raiz = new NodoArbol(0, null);
			
			var n1 = new NodoArbol(10, "SOFT");
			raiz.AgregarNodo(n1);
			var n1_1 = new NodoArbol(10, "SOFT");
			n1.AgregarNodo(n1_1);
			n1_1.AgregarNodo(new NodoArbol(30, "HARD"));
		
			
			var n2 = new NodoArbol(20, "HARD");
			raiz.AgregarNodo(n2);
			n2.AgregarNodo(new NodoArbol(30, "HARD"));
			var n2_2 = new NodoArbol(15, "MED");
			n2.AgregarNodo(n2_2);
			n2_2.AgregarNodo(new NodoArbol(15, "MED"));

			
			var n3 = new NodoArbol(35, "HARD");
			raiz.AgregarNodo(n3);
			n3.AgregarNodo(new NodoArbol(15, "SOFT"));

			Estrategia estrategia = new Estrategia();
			var mejor = estrategia.MejorEstrategia(raiz);

			// Mostrar resultados
			double tiempoTotal = 0;
			double tiempoCambios = 0;
			
			
			Console.WriteLine("Mejor estrategia encontrada:      ");
			for (int i = 0; i < mejor.Count; i++)
			{
				var nodo = mejor[i];
				double tiempoNodo = estrategia.CalcularTiempo(nodo); 
				Console.WriteLine("Etapa " + (i + 1) + ": " + nodo.Tipo + " - " + nodo.CantDeVueltas + " vueltas - Tiempo: " + tiempoNodo);
				tiempoTotal += tiempoNodo;
				if (i > 0)
				{// Agregar penalización de 10 segundos por cada cambio de neumático(Arista)
					tiempoCambios += 10;
				}
			}

			Console.WriteLine("Tiempo total con cambios: " + (tiempoTotal + tiempoCambios));
			Console.ReadKey(true);}
		
		
	}
}