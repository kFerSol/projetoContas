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
    public partial class FRMCliente : Form
    {
        private void Habilita()
        {
            nm_ClienteTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_RgTextBox.Enabled = true;
            cd_TelefoneTextBox.Enabled = true;
            ds_EmailTextBox.Enabled = true;
            ds_EnderecoTextBox.Enabled = true;
            cd_NumeroTextBox.Enabled = true;
            nm_BairroTextBox.Enabled = true;
            nm_CidadeTextBox.Enabled = true;
            sg_EstadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            btnAlterar1.Enabled = false;
            btnAnterior1.Enabled = false;
            btnCancelar1.Enabled = true;
            btnExcluir1.Enabled = false;
            btnImprimir1.Enabled = false;
            btnNovo1.Enabled = false;
            btnPesquisar1.Enabled = false;
            btnProximo1.Enabled = false;
            btnSair1.Enabled = false;
            btnSalvar1.Enabled = true;
        }
        private void Desabilita()
        {
            nm_ClienteTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_RgTextBox.Enabled = false;
            cd_TelefoneTextBox.Enabled = false;
            ds_EmailTextBox.Enabled = false;
            ds_EnderecoTextBox.Enabled = false;
            cd_NumeroTextBox.Enabled = false;
            nm_BairroTextBox.Enabled = false;
            nm_CidadeTextBox.Enabled = false;
            sg_EstadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            btnAlterar1.Enabled = true;
            btnAnterior1.Enabled = true;
            btnCancelar1.Enabled = false;
            btnExcluir1.Enabled = true;
            btnImprimir1.Enabled = true;
            btnNovo1.Enabled = true;
            btnPesquisar1.Enabled = true;
            btnProximo1.Enabled = true;
            btnSair1.Enabled = true;
            btnSalvar1.Enabled = false;
        }
        public FRMCliente()
        {
            InitializeComponent();
        }

        private void tb_CLienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CLienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMCliente_Load(object sender, EventArgs e)
        {
            this.tb_CLienteTableAdapter.Fill(this.bd_ContasDataSet.tb_CLiente);
            Desabilita();

        }

        private void btnAnterior1_Click(object sender, EventArgs e)
        {
            tb_CLienteBindingSource.MovePrevious();
        }

        private void btnProximo1_Click(object sender, EventArgs e)
        {
            tb_CLienteBindingSource.MoveNext();
        }

        private void btnNovo1_Click(object sender, EventArgs e)
        {
            tb_CLienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar1_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir1_Click(object sender, EventArgs e)
        {
            tb_CLienteBindingSource.RemoveCurrent();
            tb_CLienteTableAdapter.Update(bd_ContasDataSet.tb_CLiente);
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            Validate();
            tb_CLienteBindingSource.EndEdit();
            tb_CLienteTableAdapter.Update(bd_ContasDataSet.tb_CLiente);
            Desabilita();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            tb_CLienteBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar1_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FRMPesquisaCliente fpc = new FRMPesquisaCliente();
            fpc.ShowDialog();
            cod = fpc.getCodigo();
            if(cod == 0)
            {
                reg = tb_CLienteBindingSource.Find("cd_Cliente", cod);
                tb_CLienteBindingSource.Position = reg;
            }
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void nm_ClienteTextBox_Enter(object sender, EventArgs e)
        {
            nm_ClienteTextBox.ForeColor = Color.White;
            nm_ClienteTextBox.BackColor = Color.Blue;
        }

        private void nm_ClienteTextBox_Leave(object sender, EventArgs e)
        {
            nm_ClienteTextBox.ForeColor = Color.Black;
            nm_ClienteTextBox.BackColor = Color.White;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;
            strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
            strDados += "CÓDIGO: " + cd_ClienteTextBox.Text + (char)10 + (char)10;
            strDados += "NOME: " + nm_ClienteTextBox.Text + (char)10 + (char)10;
            strDados += "CPF: " + cd_cpfTextBox.Text + (char)10 + (char)10;
            strDados += "RG: " + cd_RgTextBox.Text + (char)10 + (char)10;
            strDados += "TELEFONE: " + cd_TelefoneTextBox.Text + (char)10 + (char)10;
            strDados += "EMAIL: " + ds_EmailTextBox.Text + (char)10 + (char)10;
            strDados += "ENDEREÇO: " + ds_EnderecoTextBox.Text + (char)10 + (char)10;
            strDados += "NÚMERO: " + cd_NumeroTextBox.Text + (char)10 + (char)10;
            strDados += "BAIRRO: " + nm_BairroTextBox.Text + (char)10 + (char)10;
            strDados += "CIDADE: " + nm_CidadeTextBox.Text + (char)10 + (char)10;
            strDados += "ESTADO: " + sg_EstadoTextBox.Text + (char)10 + (char)10;
            strDados += "CEP: " + cd_cepTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
