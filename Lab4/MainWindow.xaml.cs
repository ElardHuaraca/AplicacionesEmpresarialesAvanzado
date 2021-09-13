using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLExpress;Initial Catalog=db_lab03;Integrated Security=True");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            List<Person> persons = new List<Person>();
            connection.Open();
            SqlCommand command = new SqlCommand("Get_UserByName", connection);
            command.CommandType = CommandType.StoredProcedure; 

            SqlParameter parameter = new SqlParameter();
            parameter.SqlDbType = SqlDbType.VarChar;
            parameter.Size = 50;
            parameter.Value = "";
            parameter.ParameterName = "@Name";

            command.Parameters.Add(parameter);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                persons.Add(new Person
                {
                    UsuarioId = dataReader["usuario_id"].ToString(),
                    UsuarioNombre = dataReader["usuario_nombre"].ToString(),
                    UsuarioPassword = dataReader["usuario_password"].ToString(),
                    UsuarioFechaRegistro = (DateTime)dataReader["usuario_fecha_registro"]
                });
            }

            connection.Close();
            dgvPeople.ItemsSource = persons;
        }
    }
}
