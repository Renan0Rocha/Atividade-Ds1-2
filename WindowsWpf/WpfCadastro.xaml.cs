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
using BibliotecaMsg;

namespace AtividadeDS.WindowsWpf
{
    /// <summary>
    /// Lógica interna para WpfCadastro.xaml
    /// </summary>
    public partial class WpfCadastro : Window
    {
        public WpfCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, RoutedEventArgs e)
        {
            VrsGlobais.usuario = txtUsuario.Text.Trim();
            VrsGlobais.senha = Convert.ToString(pswSenha2.Password);
            MessageBox.Show("Cadastro Realizado!");
            BtnCancelar_Click(sender, e);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            txtEmail.Clear();
            pswSenha.Clear();
        }
    }
}
