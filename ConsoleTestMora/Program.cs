using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestMora
{
	class Program
	{
		static void Main(string[] args)
		{
			TestEnOracle();

			Console.ReadLine();
		}


		public static void TestEnOracle()
		{
			var repo = new RepositorioOracle();
			//cargar data inicial (tabla actual)
			List<ItemProductividad> registroactual = repo.ObtenerRegistrosDiaInicial();
			//simular nueva (traer datos del servicio de BT)
			List<ItemProductividad> registroEvaluar = repo.ObtenerRegistrosNuevoDia();
			
			//setup parametros de trabajo
			DateTime paramfechaEliminacion = new DateTime(1900, 01, 01);
			DateTime paramfechaCreacion = new DateTime(2024, 09, 10);

			//filtrar registros nuevos usando hash
			var idNuevos = new HashSet<(string Cuenta, string Instancia)>(registroactual.Select(alfa => (alfa.Cuenta, alfa.Instancia)));
			var registroParaAgregar = registroEvaluar.Where(beta => !idNuevos.Contains((beta.Cuenta, beta.Instancia))).ToList();
			
			//setear parametros que estan en nulo para los nuevos registros
			registroParaAgregar.Select(re => { re.Fecha =  DateTime.Now.ToString("yyyy-MM-dd"); return re; }).ToList(); //solo seria para este ejercicio,
			registroParaAgregar.Select(re => { re.FechaCreacion = DateTime.Now.ToString("yyyy-MM-dd");  return re; }).ToList();
			registroParaAgregar.Select(re => { re.Estado = 0; return re; }).ToList(); //ya no seria necesario, con llenar la fecha de eliminacion es suficiente
			
			int resultInsert = repo.InsertarMultiplesRegistros(registroParaAgregar);

			//filtrar registros eliminados usando hash
			var paramfechaEliminacion2 = new DateTime(2024, 09, 10).ToString("yyyy-MM-dd");
			var idEliminados = new HashSet<(string Cuenta, string Instancia)>(registroEvaluar.Select(alfa => (alfa.Cuenta, alfa.Instancia)));
			var registroEliminados = registroactual.Where(alfa => !idEliminados.Contains((alfa.Cuenta, alfa.Instancia))).ToList();
			//escribir fecha eliminacion
			registroEliminados.Select(re => { re.FechaEliminacion = paramfechaEliminacion2; return re; }).ToList();
			//int resultUpdate = repo.ActualizarMultiplesRegistros(registroEliminados);

			ImprimirProcesoOracle(registroactual, registroEvaluar, registroParaAgregar, registroEliminados);

			//	Console.WriteLine($"nuevos:{registroParaAgregar.Count()}");
			//		Console.WriteLine($"eliminados:{registroEliminados.Count()}");

		}


		public static void TestEnSQlserver(){
			Stopwatch sw = new Stopwatch();
			sw.Restart();
			var repo = new RepositorioRegistros();
			//cargar data inicial
			List<Registro> registroactual = repo.ObtenerRegistrosDiaInicial();
			//obtener datos del dia (1)
			List<Registro> registroEvaluar = repo.ObtenerRegistrosDia1();

			//agregar registros nuevos usando hash
			DateTime paramfechaCreacion = new DateTime(2024, 09, 09);
			DateTime paramfechaEliminacion = new DateTime(1900, 01, 01);
			var idNuevos = new HashSet<long>(registroactual.Select(alfa => alfa.Id));
			var registroParaAgregar = registroEvaluar.Where(beta => !idNuevos.Contains(beta.Id)).ToList();
			registroParaAgregar.Select(re => { re.FechaCreacion = paramfechaCreacion; return re; }).ToList();
			registroParaAgregar.Select(re => { re.Estado = 0; return re; }).ToList();
			registroParaAgregar.Select(re => { re.FechaEliminacion = paramfechaEliminacion; return re; }).ToList();
			//int resultInsert = repo.InsertarMultiplesRegistros(registroParaAgregar);

			//marcar registros eliminados usando hash
			paramfechaEliminacion = new DateTime(2024, 09, 09);
			var idEliminados = new HashSet<long>(registroEvaluar.Select(delta => delta.Id));
			var registroEliminados = registroactual.Where(alfa => !idEliminados.Contains(alfa.Id)).ToList();
			registroEliminados.Select(re => { re.FechaEliminacion = paramfechaEliminacion; return re; }).ToList();
			//int resultUpdate = repo.ActualizarMultiplesRegistros(registroEliminados);

			//ImprimirProceso(registroactual, registroParaAgregar, registroEliminados);
			Console.WriteLine($"Tarea ejecutada: {sw.Elapsed}");
			Console.WriteLine($"nuevos:{registroParaAgregar.Count()}");
			Console.WriteLine($"eliminados:{registroEliminados.Count()}");
		}




		public static void ImprimirProceso(List<Registro> registroactual, List<Registro> nuevosRegistros, List<Registro> eliminadosRegistros)
		{
			Console.WriteLine("Registros actuales:");
			foreach (Registro item in registroactual)
			{
				Console.WriteLine($"id:{item.Id} - nombre{item.Nombre}  - eliminado: {item.Estado}");
			}
			Console.WriteLine($"------------------- Total: {registroactual.Count()}");
			Console.WriteLine(" ");
			Console.WriteLine("simulacion  iteracion");
			Console.WriteLine("Registros nuevos:");
			foreach (Registro item in nuevosRegistros)
			{
				Console.WriteLine($"id:{item.Id} - nombre{item.Nombre}  - eliminado: {item.Estado}");
				registroactual.Add(item);
			}
			Console.WriteLine($"------------------- Total: {nuevosRegistros.Count()}");
			Console.WriteLine(" ");
			Console.WriteLine("Registros eliminados:");
			foreach (Registro item in eliminadosRegistros)
			{
				Console.WriteLine($"id:{item.Id} - nombre{item.Nombre}");
			}
			Console.WriteLine($"------------------- Total: {eliminadosRegistros.Count()}");
			

		}
		public static void ImprimirProcesoOracle(List<ItemProductividad> registroactual, List<ItemProductividad> nuevodia,  List<ItemProductividad> nuevosRegistros, List<ItemProductividad> eliminadosRegistros)
		{
			Console.WriteLine("Registros actuales:");
			foreach (ItemProductividad item in registroactual)
			{
				Console.WriteLine($"Cuenta:{item.Cuenta} - Instancia{item.Instancia} ");
			}
			Console.WriteLine($"------------------- Total: {registroactual.Count()}");
			Console.WriteLine(" ");
			Console.WriteLine("Registros nuevo dia:");
			foreach (ItemProductividad item in nuevodia)
			{
				Console.WriteLine($"Cuenta:{item.Cuenta} - Instancia{item.Instancia} ");
			}
			Console.WriteLine($"------------------- Total: {nuevodia.Count()}");
			Console.WriteLine(" ");
			Console.WriteLine(" ");
			Console.WriteLine(" ");


			Console.WriteLine("simulacion  iteracion");
			Console.WriteLine("Registros nuevos:");
			foreach (ItemProductividad item in nuevosRegistros)
			{
				Console.WriteLine($"Cuenta:{item.Cuenta} - Instancia{item.Instancia} ");
				registroactual.Add(item);
			}
			Console.WriteLine($"------------------- Total: {nuevosRegistros.Count()}");
			Console.WriteLine(" ");
			Console.WriteLine("Registros eliminados:");
			foreach (ItemProductividad item in eliminadosRegistros)
			{
				Console.WriteLine($"Cuenta:{item.Cuenta} - Instancia{item.Instancia}");
			}
			Console.WriteLine($"------------------- Total: {eliminadosRegistros.Count()}");


		}
	}


	


}
