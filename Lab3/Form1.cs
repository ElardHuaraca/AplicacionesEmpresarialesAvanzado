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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            btnDesconectar.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtUsuario.ReadOnly = true;
                txtContraseña.ReadOnly = true;
            }
            else
            {
                txtUsuario.ReadOnly = false;
                txtContraseña.ReadOnly = false;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;
            String servidor = txtServidor.Text;
            String bd = txtBD.Text;
            String user = txtUsuario.Text;
            String pwd = txtContraseña.Text;

            String str = "Server=" + servidor + ";DataBase=" + bd + ";";

            if (checkBox1.Checked)
                str += "Integrated Security=true;";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";
            Console.WriteLine(str);
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnConectar.Enabled = true;
            }
            catch (Exception ex)
            {
                btnConectar.Enabled = true;
                MessageBox.Show("Error al conectar al servidor: \n" + ex.ToString());
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\nVersión del servidor: " + conn.ServerVersion +
                        "\nBase de datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" + ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                }
                else
                    MessageBox.Show("La conexion ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexion: \n" + ex.ToString());
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona ps = new Persona(conn);
            ps.Show();
        }
    }
}
