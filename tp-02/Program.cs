using System;
using System.Collections.Generic;
namespace tp_02
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolGeneral<Compuesto> raiz = new ArbolGeneral<Compuesto>(null);
			
			// Hijos directos de la raíz
			ArbolGeneral<Compuesto> n1 = new ArbolGeneral<Compuesto>(new Compuesto(10, "Soft"));
			ArbolGeneral<Compuesto> n2 = new ArbolGeneral<Compuesto>(new Compuesto(20, "Hard"));
       		ArbolGeneral<Compuesto> n3 = new ArbolGeneral<Compuesto>(new Compuesto(35, "Hard"));
       		
       		raiz.agregarHijo(n1);
       		raiz.agregarHijo(n2);
       		raiz.agregarHijo(n3);
       		
       		// hijos de n1
       		ArbolGeneral<Compuesto> n4 = new ArbolGeneral<Compuesto>(new Compuesto(10, "Soft"));
       		ArbolGeneral<Compuesto> n5 = new ArbolGeneral<Compuesto>(new Compuesto(30, "Hard"));
       		n1.agregarHijo(n4);
       		n1.agregarHijo(n5);
       		
       		// hijos de n2
       		ArbolGeneral<Compuesto> n6 = new ArbolGeneral<Compuesto>(new Compuesto(15, "Med"));
			ArbolGeneral<Compuesto> n7 = new ArbolGeneral<Compuesto>(new Compuesto(15, "Soft"));
			n2.agregarHijo(n6);
			n2.agregarHijo(n7);
       		
       		// hijo de n6
       		ArbolGeneral<Compuesto> n8 = new ArbolGeneral<Compuesto>(new Compuesto(15, "Med"));
       		n6.agregarHijo(n8);
       		
       		// Ejecutar estrategia
       		Estrategia estrategia = new Estrategia();
       		List<Compuesto> mejor = estrategia.mejorEstrategia(raiz);
       		
       		Console.WriteLine("Mejor estrategia:");
       		
       		foreach (Compuesto c in mejor){
       			Console.WriteLine(c.vueltas + " vueltas - " + c.tipo);
       		}
       		
       		Console.WriteLine("Tiempo total mínimo: " + estrategia.GetMejorTiempo());
			
			Console.ReadKey(true);
		}
	}
}