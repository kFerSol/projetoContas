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
    public partial class FRMFornecedor : Form
    {
        private void Habilita()
        {
            nm_fornecedorTextBox.Enabled = true;
            cd_CNPJTextBox.Enabled = true;
            cd_IeTextBox.Enabled = true;
            cd_TelefoneTextBox.Enabled = true;
            ds_EmailTextBox.Enabled = true;
            ds_EnderecoTextBox.Enabled = true;
            cd_NumeroTextBox.Enabled = true;
            nm_BairroTextBox.Enabled = true;
            nm_CidadeTextBox.Enabled = true;
            sg_EstadoTextBox.Enabled = true;
            cd_CEPTextBox.Enabled = true;
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
            nm_fornecedorTextBox.Enabled = false;
            cd_CNPJTextBox.Enabled = false;
            cd_IeTextBox.Enabled = false;
            cd_TelefoneTextBox.Enabled = false;
            ds_EmailTextBox.Enabled = false;
            ds_EnderecoTextBox.Enabled = false;
            cd_NumeroTextBox.Enabled = false;
            nm_BairroTextBox.Enabled = false;
            nm_CidadeTextBox.Enabled = false;
            sg_EstadoTextBox.Enabled = false;
            cd_CEPTextBox.Enabled = false;
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
        public FRMFornecedor()
        {
            InitializeComponent();
        }

        private void tb_FornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void tb_FornecedorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMFornecedor_Load(object sender, EventArgs e)
        {
            this.tb_FornecedorTableAdapter.Fill(this.bd_ContasDataSet.tb_Fornecedor);
            Desabilita();
        }

        private void cd_FornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void cd_CEPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior1_Click(object sender, EventArgs e)
        {
            tb_FornecedorBindingSource.MovePrevious();
        }

        private void btnProximo1_Click(object sender, EventArgs e)
        {
            tb_FornecedorBindingSource.MoveNext();
        }

        private void btnNovo1_Click(object sender, EventArgs e)
        {
            tb_FornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnExcluir1_Click(object sender, EventArgs e)
        {
            tb_FornecedorBindingSource.RemoveCurrent();
            tb_FornecedorTableAdapter.Update(bd_ContasDataSet.tb_Fornecedor);
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            Validate();
            tb_FornecedorBindingSource.EndEdit();
            tb_FornecedorTableAdapter.Update(bd_ContasDataSet.tb_Fornecedor);
            Desabilita();
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            tb_FornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar1_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnPesquisar1_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FRMPesquisaFornecedor fpf = new FRMPesquisaFornecedor();
            fpf.ShowDialog();
            cod = fpf.getCodigo();
            if (cod == 0)
            {
                reg = tb_FornecedorBindingSource.Find("cd_Fornecedor", cod);
                tb_FornecedorBindingSource.Position = reg;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE FORNECEDOR" + (char)10 + (char)10;
            strDados += "CÓDIGO: " + cd_FornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "NOME: " + nm_fornecedorTextBox.Text + (char)10 + (char)10;
            strDados += "CNPJ: " + cd_CNPJTextBox.Text + (char)10 + (char)10;
            strDados += "INSCRIÇÃO ESTADUAL: " + cd_IeTextBox.Text + (char)10 + (char)10;
            strDados += "TELEFONE: " + cd_TelefoneTextBox.Text + (char)10 + (char)10;
            strDados += "EMAIL: " + ds_EmailTextBox.Text + (char)10 + (char)10;
            strDados += "ENDEREÇO: " + ds_EnderecoTextBox.Text + (char)10 + (char)10;
            strDados += "NÚMERO: " + cd_NumeroTextBox.Text + (char)10 + (char)10;
            strDados += "BAIRRO: " + nm_BairroTextBox.Text + (char)10 + (char)10;
            strDados += "CIDADE: " + nm_CidadeTextBox.Text + (char)10 + (char)10;
            strDados += "ESTADO: " + sg_EstadoTextBox.Text + (char)10 + (char)10;
            strDados += "CEP: " + cd_CEPTextBox.Text + (char)10 + (char)10;

            objImpressao.DrawString(strDados, new Font("arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
