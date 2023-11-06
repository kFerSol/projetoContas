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
    public partial class FRMUsuario : Form
    {
        private void Habilita()
        {
            nm_UsuarioTextBox.Enabled = true;
            sg_NivelTextBox.Enabled = true;
            nm_LoginTextBox.Enabled = true;
            cd_SenhaTextBox.Enabled = true;
            btnAlterar.Enabled = false;
            btnAnterior.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnImprimir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnProximo.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = true;
        }
        private void Desabilita()
        {
            nm_UsuarioTextBox.Enabled = false;
            sg_NivelTextBox.Enabled = false;
            nm_LoginTextBox.Enabled = false;
            cd_SenhaTextBox.Enabled = false;
            btnAlterar.Enabled = true;
            btnAnterior.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnImprimir.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnProximo.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
        }
        public FRMUsuario()
        {
            InitializeComponent();
        }

        private void FRMUsuario_Load(object sender, EventArgs e)
        {
            this.tb_UsuarioTableAdapter.Fill(this.bd_ContasDataSet.tb_Usuario);
            Desabilita();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_UsuarioBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tb_UsuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_UsuarioBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_UsuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_UsuarioBindingSource.RemoveCurrent();
            tb_UsuarioTableAdapter.Update(bd_ContasDataSet.tb_Usuario);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_UsuarioBindingSource.EndEdit();
            tb_UsuarioTableAdapter.Update(bd_ContasDataSet.tb_Usuario);
            Desabilita();
        }

        private void nm_LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FRMPesquisarUsuario fpu = new FRMPesquisarUsuario();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tb_UsuarioBindingSource.Find("cd_Usuario", cod);
                tb_UsuarioBindingSource.Position = reg;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados += "CÓDIGO: " + cd_usuarioTextBox.Text + (char)10 + (char)10;
            strDados += "NOME: " + nm_UsuarioTextBox.Text + (char)10 + (char)10;
            strDados += "NÍVEL: " + sg_NivelTextBox.Text + (char)10 + (char)10;
            strDados += "LOGIN: " + nm_LoginTextBox.Text;

            objImpressao.DrawString(strDados, new Font("arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80); 
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
