using ConsoleAppRefactorizaciones.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class GuardarFoto : IGuardarFoto
	{
		public Response GuardarFotoVisita(RequestFoto foto)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = ""
			};

			if (!foto.IsValidFoto())
			{
				response.CodeBts = 400;
				response.Message = foto.MessageError;
				response.Success = false;
				return response;
			}
			return response;

		}

	}
}
