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

namespace Lab5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<DetallePedido> DetallePedidos { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            BPedido bPedido = null;
            try
            {
                bPedido = new BPedido();
                dgvPedido.ItemsSource = bPedido.GetPedidosEntreFechas(Convert.ToDateTime(txtFechaInicio.Text),
                    Convert.ToDateTime(txtFechaFin.Text));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Comunicarse con un administrador");
            }
            finally
            {
                bPedido = null;
            }
        }

        private void dgvPedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pedido pedido = null;
            try
            {
                pedido = (Pedido)dgvPedido.SelectedItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            BDetallePedido bDetallePedido = null;
            try
            {
                bDetallePedido = new BDetallePedido();
                dgvDetallePedido.ItemsSource = bDetallePedido.GetDetallePedidosPorId(pedido.IdPedido);
                txtTotal.Text = bDetallePedido.GetDetalleTotalPorId(pedido.IdPedido).ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                bDetallePedido = null;
            }
        }
    }
}
