using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Persona : Form
    {
        SqlConnection conn;
        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM tbl_usuario;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String name = txtNombre.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Get_UserByName";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = name;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListado.DataSource = dt;
                dgvListado.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            List<Person> personas = new List<Person>();
            if (conn.State == ConnectionState.Open)
            {
                String name = txtNombre.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Get_UserByName";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = name;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    personas.Add(new Person
                    {
                        UsuarioId = reader[0].ToString(),
                        UsuarioNombre = reader[1].ToString(),
                        UsuarioPassword = reader[2].ToString(),
                        UsuarioFechaRegistro = (DateTime)reader[3]
                    });
                }
                dgvListado.DataSource = personas;
                reader.Close();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }
}
