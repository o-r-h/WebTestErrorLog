using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class VerifyUser : IVerifyUser
	{

		public Response VerifyUserData(string User, string token)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = ""
			};

			if (string.IsNullOrEmpty(User))
			{
				response.CodeBts = 400;
				response.Message = "User must have value";
				response.Success = false;
				return response;
			}
			return response;

		}
	}
}
