using ConsoleAppRefactorizaciones.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class DataReniec : IDataReniec
	{
		public Response GetDataReniec(RequestDataReniec RequestDataReniec)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = "",
				Data = new List<String> { "Peter", "Parker", "00487524" }
			};
			return response;
		}
	}
}
