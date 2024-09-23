

using ConsoleAppRefactorizaciones.Clases;

namespace ConsoleAppRefactorizaciones.Funciones
{
	public class savePic : ISavePic
	{
		public Response SavePicVista(RequestPic pic)
		{
			Response response = new Response
			{
				CodeBts = 0,
				Success = true,
				Message = ""
			};

			if (!pic.IsValidFoto())
			{
				response.CodeBts = 400;
				response.Message = pic.MessageError;
				response.Success = false;
				return response;
			}
			return response;

		}

	}
}
