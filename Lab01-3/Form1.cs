using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_3
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtNumero1.Text);
            b = Convert.ToDouble(txtNumero2.Text);
            MessageBox.Show($"La suma es: {Suma(a, b)}");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtNumero1.Text);
            b = Convert.ToDouble(txtNumero2.Text);
            MessageBox.Show($"La resta es: {Resta(a, b)}");
        }

        private void txtMultiplicar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtNumero1.Text);
            b = Convert.ToDouble(txtNumero2.Text);
            MessageBox.Show($"La multiplicacion es: {Multiplicacion(a, b)}");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtNumero1.Text);
            b = Convert.ToDouble(txtNumero2.Text);
            MessageBox.Show($"La division es: {Division(a, b)}");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            string display = string.Join(Environment.NewLine, Raiz());
            MessageBox.Show(display);
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            string display = string.Join(Environment.NewLine, Primos());
            MessageBox.Show($"Numeros primos: \n {display}");
        }

        private void btnTranformar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtGrados.Text);
            if (listConvert.Text.Equals("Celsius"))
            {
                MessageBox.Show($"Fahrenheit a celsius: {transforToCelsius(a)}");
            }
            else
            {
                MessageBox.Show($"Celsius a fahrenheit: {transforToFahrenheit(a)}");
            }
        }

        double Suma(double a, double b)
        {
            return a + b;
        }
        static double Resta(double a, double b)
        {
            return a - b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }

        static string[] Raiz()
        {
            string[] _S = new string[10];
            for (int i = 1; i <= 10; i++)
            {
                _S[i - 1] = $"La raiz cuadrada de {i} es: {Math.Sqrt(i)}\n";
            }
            return _S;
        }

        static double[] Primos()
        {
            double[] numeros = new double[10];
            int count = 0;
            double a = 1;
            bool primo = false;
            while (count < 10)
            {
                while (primo == false)
                {
                    if ((a % 2 == 0 || a % 3 == 0 || a % 5 == 0) && (a != 2 && a != 3 && a != 5)) { primo = false; }
                    else if (a != 1) { primo = true; numeros[count] = a; }
                    a++;
                }
                primo = false;
                count++;
            }
            return numeros;
        }

        static double transforToCelsius(double a)
        {
            return 5 * (a - 32) / 9;
        }

        static double transforToFahrenheit(double a)
        {
            return (9 * a / 5) + 32;
        }
    }
}
