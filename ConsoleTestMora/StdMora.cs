using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestMora
{
	public class SdtMora
	{
		public List<ItemProductividad> JAQMBBTPRODUCTIVIDADITEM { get; set; }
	}

	public class ItemProductividad
	{

		public string Fecha { get; set; }

		public string Hora { get; set; }

		public string Instancia { get; set; }

		public string Numero_Operacion { get; set; }

		public string Cliente { get; set; }

		public string Cuenta { get; set; }

		public string Analista { get; set; }

		public int Estado { get; set; }

		public string FechaEliminacion { get; set; }
		public string FechaCreacion { get; set; }
	}
}


