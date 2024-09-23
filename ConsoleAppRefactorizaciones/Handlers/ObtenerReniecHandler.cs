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
	public class ObtenerReniecHandler: HandlerBase
	{
		private readonly IDatosReniec datosReniec;

		public ObtenerReniecHandler(IDatosReniec datosReniec)
		{
			this.datosReniec = datosReniec;
		}

		public override void Handle(ProcessRequest request)
		{
			Console.WriteLine("Procesando ObtenerDatos Reniec...");
			Response response = datosReniec.GetDatosReniec(request.requestConsultarReniec);
			request.DataReniecHandleResult = response.Data;
			request.IsVerificarUsuarioOk = response.Success; //todoOk
			base.Handle(request);
		}
	}
}
