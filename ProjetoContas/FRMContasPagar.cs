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
    public partial class FRMContasPagar : Form
    {
        private void Habilita()
        {
            cd_DocumentoTextBox.Enabled = true;
            ds_DocumentoTextBox.Enabled = true;
            dt_EmissaoDateTimePicker.Enabled = true;
            dt_VencimentoDateTimePicker.Enabled = true;
            vl_DocumentoTextBox.Enabled = true;
            dt_PagamentoDateTimePicker.Enabled = true;
            vl_PagoTextBox.Enabled = true;
            id_FornecedorTextBox.Enabled = true;
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
            cd_DocumentoTextBox.Enabled = false;
            ds_DocumentoTextBox.Enabled = false;
            dt_EmissaoDateTimePicker.Enabled = false;
            dt_VencimentoDateTimePicker.Enabled = false;
            vl_DocumentoTextBox.Enabled = false;
            dt_PagamentoDateTimePicker.Enabled = false;
            vl_PagoTextBox.Enabled = false;
            id_FornecedorTextBox.Enabled = false;
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

        public FRMContasPagar()
        {
            InitializeComponent();
        }

        private void tb_ContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_ContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContasPagarTableAdapter.Fill(this.bd_ContasDataSet.tb_ContasPagar);
            Desabilita();

        }

        private void id_FornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_FornecedorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_DocumentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_DocumentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_EmissaoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt_VencimentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vl_DocumentoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_PagamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vl_PagoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cd_ContaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_DocumentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_ContasPagarBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_ContasPagarBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_ContasPagarBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_ContasPagarBindingSource.RemoveCurrent();
            tb_ContasPagarTableAdapter.Update(bd_ContasDataSet.tb_ContasPagar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_ContasPagarBindingSource.EndEdit();
            tb_ContasPagarTableAdapter.Update(bd_ContasDataSet.tb_ContasPagar);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_ContasPagarBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CONTAS A PAGAR" + (char)10 + (char)10;
            strDados += "CÓDIGO: " + cd_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "CÓDIGO DO DOCUMENTO: " + cd_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "DESCRIÇÃO DO DOCUMENTO: " + ds_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "DATA DE EMISSÃO: " + dt_EmissaoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "DATA DE VENCIMENTO: " + dt_VencimentoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "VALOR: " + vl_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "DATA DE PAGAMENTO: " + dt_PagamentoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "VALOR PAGO: " + vl_PagoTextBox.Text + (char)10 + (char)10;
            strDados += "CÓDIGO DO FORNECEDOR: " + id_FornecedorTextBox.Text;

            objImpressao.DrawString(strDados, new Font("arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FRMPesquisaContasPagar fpcp = new FRMPesquisaContasPagar();
            fpcp.ShowDialog();
            cod = fpcp.getCodigo();
            if(cod == 0)
            {
                reg = tb_ContasPagarBindingSource.Find("cd_Conta", cod);
                tb_ContasPagarBindingSource.Position = reg;
            }
        }
    }
}
