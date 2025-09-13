using System;

namespace tp_02
{
	/// <summary>
	/// Description of Compuesto.
	/// </summary>
	public class Compuesto
	{
		public int vueltas{get;set;}
		public string tipo{get;set;}
		
		
		public Compuesto (int vueltas, string tipo)
		{
			this.vueltas=vueltas;
			this.tipo=tipo;
		}
		
		
		public override string ToString()
		{
			return vueltas + " " + tipo;
		}

	}
}
