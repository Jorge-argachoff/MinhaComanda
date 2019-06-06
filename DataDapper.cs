using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Data.Common;


namespace Entities
{
    public abstract class DataDapper
    {
        static string strConexao = ConfigurationManager.ConnectionStrings["SistemaBar"].ConnectionString;

        public string _connectionString { get; set; }

        public class DapperRepositorioBase
        {

            public DapperRepositorioBase()
            {
               
                var _connectionString = strConexao;
            }
            

            public IEnumerable<T> Select<T>(string query)
            {
                return RecuperarInstancia().Query<T>(query);
            }

            public DbConnection RecuperarInstancia()
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = strConexao;

                return connection;
            }

            public Resultado InsertComId<T>(string query)
            {
                using (var connection = RecuperarInstancia())
                {

                    query += " SELECT CAST(SCOPE_IDENTITY() as int)";
                    Resultado resultado = new Resultado();
                    int id = connection.QuerySingle<int>(query);

                    resultado.RetornoId = id;

                    if (id > 0)
                        resultado.Sucesso = true;

                    return resultado;
                
                 }
            }

            public Resultado Insert<T>(string query)
            {
                using (var connection = RecuperarInstancia())
                {
                    Resultado resultado = new Resultado();
                    var id = connection.Execute(query);

                    if (id > 0)
                        resultado.Sucesso = true;

                    return resultado;

                }
            }

            

        }
    }
}
