using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;


namespace ConsoleAppRefactorizaciones.Handlers
{
	public class GetReniecHandler: HandlerBase
	{
		private readonly IDataReniec dataReniec;

		public GetReniecHandler(IDataReniec dataReniec)
		{
			this.dataReniec = dataReniec;
		}

		public override void Handle(ProcessRequest request)
		{
			Console.WriteLine("Procesing data from Reniec...");
			Response response = dataReniec.GetDataReniec(request.RequestDataReniec);
			request.DataReniecHandleResult = response.Data;
			request.IsVerificarUserOk = response.Success; //todoOk
			base.Handle(request);
		}
	}
}
