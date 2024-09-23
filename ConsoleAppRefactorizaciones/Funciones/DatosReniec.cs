using ConsoleAppRefactorizaciones.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class DatosReniec : IDatosReniec
	{
		public Response GetDatosReniec(RequestConsultarReniec requestConsultarReniec)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = "",
				Data = new List<String> { "Pedro", "Perez", "00487524" }
			};
			return response;
		}
	}
}
