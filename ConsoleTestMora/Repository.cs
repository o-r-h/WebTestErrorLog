using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace ConsoleTestMora
{
    public class RepositorioRegistros
    {
        private const string ConnectionString = "Server=localhost;Database=DemoETL;Integrated Security=True";

        public List<Registro> ObtenerRegistrosDiaInicial()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"SELECT Id, Nombre, FechaCreacion, FechaEliminacion, Estado , Fecha
                           FROM Registro";
                return connection.Query<Registro>(sql).AsList();
            }
        }
         
        


        public List<Registro> ObtenerRegistrosDia1()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"SELECT Id, Nombre,Fecha
                           FROM Registro_Ite1"; 
                List<Registro_Ite1> result =  connection.Query<Registro_Ite1>(sql).AsList();
                List<Registro> rs = result.Select(b => new Registro { Id = b.Id, Nombre = b.Nombre, Fecha= b.Fecha, Estado =0, FechaEliminacion =null,   }).ToList();
                return rs;
            }
        }

        public  int InsertarMultiplesRegistros(List<Registro> registros)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO Registro (id, Nombre, FechaCreacion, Estado) 
                           VALUES (@Id, @Nombre, @FechaCreacion, @Estado)";
                return connection.Execute(sql, registros);
            }
        }


        public  int ActualizarMultiplesRegistros(List<Registro> registros)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"UPDATE Registro
                           SET 
                               Estado = @Estado, 
                               FechaEliminacion =  @fecha 
                           WHERE Id = @Id";
                return connection.Execute(sql, registros);
            }
        }
    }
}
