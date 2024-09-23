using ConsoleAppRefactorizaciones.Cadena;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefactorizaciones.Handlers
{
	public class CargarFotoHandler : HandlerBase
	{

		private readonly IGuardarFoto guardarFoto;

		public CargarFotoHandler(IGuardarFoto guardarFoto)
		{
			this.guardarFoto = guardarFoto;
		}

		public override void Handle(ProcessRequest request)
		{
			Console.WriteLine("Procesando Guardar Foto...");
			Response response = guardarFoto.GuardarFotoVisita(request.foto);
			request.IsGuardarFotoOk = response.Success; // todo Ok

			if (request.IsGuardarFotoOk)
			{
				base.Handle(request);
				if ( request.DataReniecHandleResult !=null){
					Console.WriteLine($"Leyendo datos de Reniec desde el handler foto:");
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
				Console.WriteLine("Error validando guardar foto. Terminando el procesamiento.");
				Console.WriteLine($"Response.Success: {response.Success}");
				Console.WriteLine($"Response.Message: {response.Message}");
			}

		}


	}
	
}
