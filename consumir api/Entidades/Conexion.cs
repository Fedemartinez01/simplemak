using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion
    {
        string connectionString;

        public Conexion(SqlCommand sqlCommand, SqlConnection sqlConnection)
        {
            connectionString = "Data Source=.;Initial Catalog=SystemERP_DB;Integrated Security=True";
            sqlCommand = new SqlCommand();
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = sqlConnection;
        }
    }
}
