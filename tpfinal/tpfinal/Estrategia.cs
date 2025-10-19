
using System;
using System.Collections.Generic;
using tp1;

namespace tpfinal
{

	public class Estrategia
	{
		private int CalcularDistancia(string str1, string str2)
		{
			// using the method
			String[] strlist1 = str1.ToLower().Split(' ');
			String[] strlist2 = str2.ToLower().Split(' ');
			int distance = 1000;
			foreach (String s1 in strlist1)
			{
				foreach (String s2 in strlist2)
				{
					distance = Math.Min(distance, Utils.calculateLevenshteinDistance(s1, s2));
				}
			}

			return distance;
		}

		public String Consulta1(ArbolGeneral<DatoDistancia> arbol)
		{
			string resultado;
			if (arbol.esHoja())
			{
				return arbol.getDatoRaiz().ToString() + "\n";
			}
			else
			{
				resultado = "";
				foreach(ArbolGeneral<DatoDistancia> hijo in arbol.getHijos())
				{
					resultado = resultado + Consulta1(hijo);
				}
				return resultado;
			}
		}


		public String Consulta2(ArbolGeneral<DatoDistancia> arbol)
		{
			string result = "Implementar";

            return result;
        }

		

		public String Consulta3(ArbolGeneral<DatoDistancia> arbol)
		{
			string result = "Implementar";
		
			return result;
		}

		public void AgregarDato(ArbolGeneral<DatoDistancia> arbol, DatoDistancia dato)
		{
            //calculamos la distancia entre el dato a agregar y el nodo actual
            int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, dato.texto);

            //buscamos si ya existe un hijo con esa distancia
            ArbolGeneral<DatoDistancia> hijoExistente = null;

			foreach (var hijo in arbol.getHijos()) {
				if (CalcularDistancia(arbol.getDatoRaiz().texto, hijo.getDatoRaiz().texto) == distancia) {
					hijoExistente = hijo;
					break;
                }
			}

            //si no existe, lo agregamos como hijo
            if (hijoExistente == null) {
				arbol.agregarHijo(new ArbolGeneral<DatoDistancia>(dato));
			}

            //si existe, agregamos el dato al hijo existente
            else
            { 
				AgregarDato(hijoExistente, dato);
            }
        }

		public void Buscar(ArbolGeneral<DatoDistancia> arbol, string elementoABuscar, int umbral, List<DatoDistancia> collected)
		{
			//si el nodo existe
            if (arbol == null)
			{
				return;
			}
			 
			int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, elementoABuscar);

			//si la distancia esta dentro del umbral, agregamos el nodo a la lista
			if(distancia <= umbral)
			{
				collected.Add(arbol.getDatoRaiz());
			}

			//recorremos los hijos dentro del rango
			foreach(var hijo in arbol.getHijos())
			{
				int distanciaHijo = CalcularDistancia(arbol.getDatoRaiz().texto, hijo.getDatoRaiz().texto);
				if(distanciaHijo >= distancia - umbral && distanciaHijo <= distancia + umbral)
				{
					Buscar(hijo, elementoABuscar, umbral, collected);
				}
			}

        }
    }
}