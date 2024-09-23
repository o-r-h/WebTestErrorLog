using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;


namespace ConsoleAppRefactorizaciones.Handlers
{
	public class SavePictureHandler : HandlerBase
	{

		private readonly ISavePic savePic;

		public SavePictureHandler(ISavePic savePic)
		{
			this.savePic = savePic;
		}

		public override void Handle(ProcessRequest request)
		{
			Console.WriteLine("Proccesing save pic...");
			Response response = savePic.SavePicVista(request.pic);
			request.IsGuardarFotoOk = response.Success; // todo Ok

			if (request.IsGuardarFotoOk)
			{
				base.Handle(request);
				if ( request.DataReniecHandleResult !=null){
					Console.WriteLine($"Reading Reniec data from previous handler pic:");
					List<string> valores = (List<string>)request.DataReniecHandleResult;
					foreach (string item in valores)
					{
						Console.WriteLine($"Item: {item}");
					}
					Console.WriteLine("--");
				}
			}
			else
			{
				Console.WriteLine("Error saving pic. finishing process.");
				Console.WriteLine($"Response.Success: {response.Success}");
				Console.WriteLine($"Response.Message: {response.Message}");
			}

		}


	}
	
}
