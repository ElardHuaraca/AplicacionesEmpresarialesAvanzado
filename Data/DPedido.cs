using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DPedido
    {
        public List<Pedido> GetPedidos(Pedido pedido)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Pedido> pedidos = null;

            try
            {
                comandText = "USP_FECHAFECHA";
                parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Fec1", SqlDbType.DateTime);
                parameters[0].Value = pedido.FechaInicio;
                parameters[1] = new SqlParameter("@Fec2", SqlDbType.DateTime);
                parameters[1].Value = pedido.FechaFin;
                pedidos = new List<Pedido>();

                using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, comandText,
                    CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        pedidos.Add(new Pedido
                        {
                            IdPedido = reader["IdPedido"] == null ? 0 : Convert.ToInt32(reader["IdPedido"]),
                            IdCliente = reader["IdCliente"] == null ? string.Empty : Convert.ToString(reader["IdCliente"]),
                            IdEmpleado = reader["IdEmpleado"] == null ? 0 : Convert.ToInt32(reader["IdEmpleado"]),
                            FechaPedido = reader["FechaPedido"] == null ? DateTime.MinValue : Convert.ToDateTime(reader["FechaPedido"]),
                            FechaEntrega = reader["FechaEntrega"] == null ? DateTime.MinValue : Convert.ToDateTime(reader["FechaEntrega"]),
                            FechaEnvio = reader["FechaEnvio"] == null ? DateTime.MinValue : Convert.ToDateTime(reader["FechaEnvio"]),
                            FormaEnvio = reader["FormaEnvio"] == null ? 0 : Convert.ToInt32(reader["FormaEnvio"]),
                            Cargo = reader["Cargo"] == null ? 0 : Convert.ToInt32(reader["Cargo"]),
                            Destinatario = reader["Destinatario"] == null ? string.Empty : Convert.ToString(reader["Destinatario"]),
                            CiudadDestinatario = reader["CiudadDestinatario"] == null ? string.Empty : Convert.ToString(reader["CiudadDestinatario"]),
                            DireccionDestinatario = reader["DireccionDestinatario"] == null ? string.Empty : Convert.ToString(reader["DireccionDestinatario"]),
                            RegionDestinatario = reader["RegionDestinatario"] == null ? string.Empty : Convert.ToString(reader["RegionDestinatario"]),
                            CodPostalDestinatario = reader["CodPostalDestinatario"] == null ? string.Empty : Convert.ToString(reader["CodPostalDestinatario"]),
                            PaisDestinatario = reader["PaisDestinatario"] == null ? string.Empty : Convert.ToString(reader["PaisDestinatario"]),
                            FechaInicio = pedido.FechaInicio,
                            FechaFin = pedido.FechaFin
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex1: " + ex);
                throw ex;
            }
            Console.WriteLine("asdasdasddass" + pedidos[0].IdCliente);
            return pedidos;
        }

    }
}
