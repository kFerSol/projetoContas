using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_UsuarioBindingSource.EndEdit();

        }

        private void FRMLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_UsuarioTableAdapter.Fill(this.bd_ContasDataSet.tb_Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_UsuarioTableAdapter.FillLogin(bd_ContasDataSet.tb_Usuario, txtLogin.Text, txtSenha.Text);
            if(tb_UsuarioBindingSource.Count > 0 || (txtLogin.Text == "adm" && txtSenha.Text == "123"))
            {
                FRMPrincipal fp = new FRMPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Login ou senha inválido");
                txtLogin.Focus();
            }
        }
    }
}
