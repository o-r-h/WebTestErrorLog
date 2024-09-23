using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace ConsoleTestMora
{
	public class RepositorioOracle
	{
		private const string ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.212.81)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=VENTA)));User Id=USRMISTI2;Password=usud3s_M1st12;";


		public List<ItemProductividad> ObtenerRegistrosDiaInicial()
		{
			using (var connection = new OracleConnection(ConnectionString))
			{
				connection.Open();
				string query = @"SELECT ID, FECHA, HORA, INSTANCIA, NUMERO_OPERACION, CLIENTE, CUENTA, ANALISTA FROM BASE_MORA";
				// Ejecutamos la consulta y mapeamos el resultado a una lista de objetos
				IEnumerable<ItemProductividad> result = connection.Query<ItemProductividad>(query);
				return result.ToList();
			}
		}


		public List<ItemProductividad> ObtenerRegistrosNuevoDia()
		{
			List<ItemProductividad> items = ObtenerRegistrosDiaInicial();
			//agregamos 5 registros
			items.Add(new ItemProductividad
			{
				Analista = "SCRE0204",
				Cuenta = "1",
				Cliente = "Omar Rodriguez",
				Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
			Hora = "11:00:00",
				Instancia = "123456",
				Numero_Operacion = "4039357"
			});
			items.Add(new ItemProductividad
			{
				Analista = "SCRE0204",
				Cuenta = "2",
				Cliente = "Omar Rodriguez",
				Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
				Hora = "11:00:00",
				Instancia = "123456",
				Numero_Operacion = "4039357"
			});
			items.Add(new ItemProductividad
			{
				Analista = "SCRE0204",
				Cuenta = "3",
				Cliente = "Omar Rodriguez",
				Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
				Hora = "11:00:00",
				Instancia = "123456",
				Numero_Operacion = "4039357"
			});
			items.Add(new ItemProductividad
			{
				Analista = "SCRE0204",
				Cuenta = "4",
				Cliente = "Omar Rodriguez",
				Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
				Hora = "11:00:00",
				Instancia = "123456",
				Numero_Operacion = "4039357"
			});
			items.Add(new ItemProductividad
			{
				Analista = "SCRE0204",
				Cuenta = "5",
				Cliente = "Omar Rodriguez",
				Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
				Hora = "11:00:00",
				Instancia = "123456",
				Numero_Operacion = "4039357"
			});

			//eliminamos 3 registros
			List<string> itemEliminar = new List<string>{ "PEREZ QUINUA, JAIME" };
			items.RemoveAll(i => itemEliminar.Contains(i.Cliente));
			return items;	
			
		}


		public int InsertarMultiplesRegistros(List<ItemProductividad> registros)
		{
			using (var connection = new OracleConnection(ConnectionString))
			{
				try
				{
					connection.Open();
					string sql = @"INSERT INTO BASE_MORA ( FECHA,FECHA_CARGA, HORA,NUMERO_OPERACION,
					CUENTA, ANALISTA, CLIENTE, INSTANCIA, FECHAELIMINACION, FECHACREACION, ESTADO) 
                           VALUES ( TO_DATE(:FECHA,'YYYY-MM-DD'), 
						            TO_DATE(:FECHA,'YYYY-MM-DD'), :HORA, :NUMERO_OPERACION,
					:CUENTA, :ANALISTA, :CLIENTE, :INSTANCIA, 
					TO_DATE(:FECHAELIMINACION,'YYYY-MM-DD'), 
					TO_DATE(:FECHACREACION,'YYYY-MM-DD'), 
					:ESTADO )";
					return connection.Execute(sql, registros);
				}
				catch (System.Exception ex)
				{

					Console.WriteLine("Ocurrió un error: " + ex.Message);
					return -1;	
				}
			
			}
		}

	}
}
