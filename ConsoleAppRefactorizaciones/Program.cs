using ConsoleAppRefactorizaciones.Cadena;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleAppRefactorizaciones.EjemploBase.Clases;

namespace ConsoleAppRefactorizaciones
{
	class Program
	{
		static void Main(string[] args)
		{
			VerificarUsuario verificarUsuario = new VerificarUsuario();
			GuardarFoto guardarFoto = new GuardarFoto();
			DatosReniec datosReniec = new DatosReniec();

			var processor = new Processor(verificarUsuario, guardarFoto, datosReniec);
			var request1 = new ProcessRequest
			{
				RequestObtenerBase = new Clases.RequestObtenerBase{ Token ="99999", Usuario="Pedro" },
				requestConsultarReniec = new Clases.RequestConsultarReniec{ NumeroDocumento ="44212332", Pais ="604", TipoDocumento ="21" },
			    foto = new Clases.RequestFoto{ Extension="jpg", LongitudByte=5000000, Nombre ="Cliente001"},
				Alfa = new Alfa(),
				Beta = new Beta(),
				Gamma = new Gamma()
			};
			Console.WriteLine("Iniciando procesamiento Alfa -> Beta -> Delta:");
			processor.Process(request1, "ProcesoGuardarFotoReniec");

			Console.WriteLine("\n---------------------------------\n");
			Console.ReadLine();

		}


		//public void ClaseGenericaRequest(){
		//	RequestBase requestBase = new RequestBase();
		//	var x = requestBase.GetFechaFinDateTime();
		//	requestBase.FechaInicio = "2024-61-01";
		//	requestBase.FechaFin = "2024-03-01";
		//	requestBase.EvaluarFechas();
		//	Console.WriteLine(requestBase.IsValid);
		//	Console.WriteLine(requestBase.ErrorCodeResponse);
		//	Console.WriteLine(requestBase.MessageError);
		//	Console.WriteLine(requestBase.GetFechaIniDateTime());
		//	Console.WriteLine(requestBase.GetFechaFinDateTime());
		//	Console.ReadLine();

		//}


		//public class RequestBase : ReqBase
		//{
		//}


	}
}
