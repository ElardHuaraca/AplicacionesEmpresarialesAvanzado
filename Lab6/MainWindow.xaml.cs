using Business;
using Entity;
using System;
using System.Collections.Generic;
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

namespace Lab6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            ManCategoria manCategoria = new ManCategoria(0);
            manCategoria.ShowDialog();
            Cargar();
        }

        private void dgvCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCategoria;
            Categoria categoria = (Categoria)dgvCategoria.SelectedItem;
            if (null == categoria) return;
            idCategoria = Convert.ToInt32(categoria.IdCategoria);
            ManCategoria manCategoria = new ManCategoria(idCategoria);
            manCategoria.ShowDialog();
            Cargar();
        }

        private void Cargar()
        {
            BCategoria BCategoria = null;
            try
            {
                BCategoria = new BCategoria();
                dgvCategoria.ItemsSource = BCategoria.Listar(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Comuniquese con el Administrador");
            }
            finally
            {
                BCategoria = null;
            }
        }
    }
}
