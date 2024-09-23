using ConsoleAppRefactorizaciones.Chain;
using ConsoleAppRefactorizaciones.EjemploBase;
using ConsoleAppRefactorizaciones.Funciones;
using System;
using static ConsoleAppRefactorizaciones.ExampleBase.ClassesExample;

namespace ConsoleAppRefactorizaciones
{
	class Program
	{
		static void Main(string[] args)
		{
			VerifyUser verifyUser = new VerifyUser();
			savePic savePic = new savePic();
			DataReniec dataReniec = new DataReniec();

			var processor = new Processor(verifyUser, savePic, dataReniec);
			var request1 = new ProcessRequest
			{
				RequestGetBase = new Clases.RequestGetBase{ Token ="99999", User="Peter" },
				RequestDataReniec = new Clases.RequestDataReniec{ DocumentNumber ="44212332", Country ="604", DocumentType ="21" },
			    pic = new Clases.RequestPic{ Extension="jpg", SizeByte=5000000, Name ="Client001"},
				Alfa = new Alfa(),
				Beta = new Beta(),
				Gamma = new Gamma()
			};
			Console.WriteLine("Starting process:");
			processor.Process(request1, "ProcessSavePicReniec");

			Console.WriteLine("\n---------------------------------\n");
			Console.ReadLine();

		}


		


	}
}
