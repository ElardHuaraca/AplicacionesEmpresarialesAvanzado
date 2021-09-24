using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    static class SQLHelper
    {
        public static string Connection { get; } = "Data Source=ELARD-PC\\SQLEXPRESS;" +
            "Initial Catalog=Neptuno;Integrated Security=true;";

        /// <summary> 
        /// Establecer la conexión, el comando y luego ejecute el comando sin ninguna consulta. 
        /// </summary> 
        public static Int32 ExecuteNonQuery(String connectionString, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // Hay tres tipos de comandos: StoredProcedure, Text, TableDirect. El TableDirect  
                    // es solo para OLE DB.   
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }

        }

        /// <summary> 
        /// Establecer la conexion, el commando, y ejecutar el comando para solo devolver un valor. 
        /// </summary>
        public static Object ExecuteScalar(String connectionString, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary> 
        /// Establecer la conexión, el comando y luego ejecutar el comando con la consulta y retornar el reader. 
        /// </summary> 
        public static SqlDataReader ExecuteReader(String connectionString, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the  
                // IDataReader is closed. 
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}
