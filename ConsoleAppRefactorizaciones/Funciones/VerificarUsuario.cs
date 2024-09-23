using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class VerificarUsuario : IVerificarUsuario
	{

		public Response VerificarDatoUsuario(string usuario, string token)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = ""
			};

			if (string.IsNullOrEmpty(usuario))
			{
				response.CodeBts = 400;
				response.Message = "Usuario debe tener valor";
				response.Success = false;
				return response;
			}
			return response;

		}
	}
}
