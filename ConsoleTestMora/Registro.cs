using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestMora
{
	public class Registro
	{
		public long Id { get; set; }   //campo unico para efectos de prueba
		public string Nombre { get; set; }
		public DateTime Fecha { get; set; }
		public int? Estado { get; set; }
		public DateTime? FechaEliminacion { get; set; }
		public DateTime? FechaCreacion { get; set; }

	}
}
