using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class Response
	{
		public bool Success { get; set; }
		public string Message { get; set; } = "";
		public int CodeBts { get; set; } = 0;
		public object Data { get; set; }
	}
}
