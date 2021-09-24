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
    public class DDetallePedido
    {
        public List<DetallePedido> GetDetallePedidos(DetallePedido detallePedido)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<DetallePedido> detallePedidos = null;

            try
            {
                comandText = "USP_GetDetallePedido";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@IdPedido", SqlDbType.Int);
                parameters[0].Value = detallePedido.Pedido.IdPedido;
                detallePedidos = new List<DetallePedido>();
                using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, comandText,
                    CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        detallePedidos.Add(new DetallePedido
                        {
                            Pedido = detallePedido.Pedido,
                            IdProducto = Convert.ToInt32(reader["idproducto"]),
                            PrecioUnidad = Convert.ToDecimal(reader["preciounidad"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"]),
                            Descuento = Convert.ToDecimal(reader["descuento"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return detallePedidos;
        }
    }
}
