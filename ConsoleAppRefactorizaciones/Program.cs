﻿using ConsoleAppRefactorizaciones.Cadena;
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
				RequestObtenerBase = new Clases.RequestObtenerBase{ Token ="99999", Usuario="" },
				requestConsultarReniec = new Clases.RequestConsultarReniec{ NumeroDocumento ="44212332", Pais ="604", TipoDocumento ="21" },
			    foto = new Clases.RequestFoto{ Extension="jpg", LongitudByte=599000000, Nombre ="Cliente001"},
				Alfa = new Alfa(),
				Beta = new Beta(),
				Gamma = new Gamma()
			};
			Console.WriteLine("Iniciando procesamiento validarusuario -> consultar Reniec -> GuardarFoto:");
			Console.WriteLine("\n-----------------------------------------------------------------------\n");
			processor.Process(request1, "ProcesoGuardarFotoReniec");

			Console.WriteLine("\n---------------------------------\n");
			Console.WriteLine("Fin");
			Console.WriteLine("");



			//var request2 = new ProcessRequest
			//{
			//	Alfa = new Alfa(),
			//	Beta = new Beta(),
			//	Gamma = new Gamma()
			//};
			//Console.WriteLine("Iniciando procesamiento alfa -> beta -> gamma:");
			//Console.WriteLine("\n-----------------------------------------------------------------------\n");
			//processor.Process(request2, "EjemploBasico");
			//Console.WriteLine("\n---------------------------------\n");
			//Console.WriteLine("Fin");
			Console.ReadLine();
		}


		


	}
}
