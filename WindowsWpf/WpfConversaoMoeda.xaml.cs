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
using System.Windows.Shapes;

namespace AtividadeDS.WindowsWpf
{
    /// <summary>
    /// Lógica interna para WpfConversaoMoeda.xaml
    /// </summary>
    public partial class WpfConversaoMoeda : Window
    {
        int moeda = 0;
        string resultado = "0";

        public WpfConversaoMoeda()
        {
            InitializeComponent();

        }

        private void btnDolar_Click(object sender, RoutedEventArgs e)
        {
            btnDolar.IsEnabled = false;
            btnEuro.IsEnabled = true;
            btnLibra.IsEnabled = true;
            btnBitcoin.IsEnabled = true;
            txtValor.IsEnabled = true;
            moeda = 1;
        }

        private void btnEuro_Click(object sender, RoutedEventArgs e)
        {
            btnDolar.IsEnabled = true;
            btnEuro.IsEnabled = false;
            btnLibra.IsEnabled = true;
            btnBitcoin.IsEnabled = true;
            txtValor.IsEnabled = true;
            moeda = 2;
        }

        private void btnLibra_Click(object sender, RoutedEventArgs e)
        {
            btnDolar.IsEnabled = true;
            btnEuro.IsEnabled = true;
            btnLibra.IsEnabled = false;
            btnBitcoin.IsEnabled = true;
            txtValor.IsEnabled = true;
            moeda = 3;
        }

        private void btnBitcoin_Click(object sender, RoutedEventArgs e)
        {
            btnDolar.IsEnabled = true;
            btnEuro.IsEnabled = true;
            btnLibra.IsEnabled = true;
            btnBitcoin.IsEnabled = false;
            txtValor.IsEnabled = true;
            moeda = 4;
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.IsEnabled=true;

            switch (moeda)
            {
                case 1:
                    resultado = "R$" + (Convert.ToString(Convert.ToDouble(txtValor.Text) * 4.60));
                    txtResultado.Text = resultado;
                    break;

                case 2:
                    resultado = "R$" + (Convert.ToString(Convert.ToDouble(txtValor.Text) * 5.04));
                    txtResultado.Text = resultado;
                    break;

                case 3:
                    resultado = "R$" + (Convert.ToString(Convert.ToDouble(txtValor.Text) * 6.03));
                    txtResultado.Text = resultado;
                    break;

                case 4:
                    resultado = "R$" + (Convert.ToString(Convert.ToDouble(txtValor.Text) * 213425.90));
                    txtResultado.Text = resultado;
                    break;
            }

        }
    }
}
