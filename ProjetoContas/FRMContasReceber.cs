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
    public partial class FRMContasReceber : Form
    {
        private void Habilita()
        {
            cd_DocumentoTextBox.Enabled = true;
            ds_DocumentoTextBox.Enabled = true;
            dt_EmissaoDateTimePicker.Enabled = true;
            dt_VencimentoDateTimePicker.Enabled = true;
            vl_DocumetoTextBox.Enabled = true;
            dt_PagamentoDateTimePicker.Enabled = true;
            vl_PagoTextBox.Enabled = true;
            id_ClienteTextBox.Enabled = true;
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
            vl_DocumetoTextBox.Enabled = false;
            dt_PagamentoDateTimePicker.Enabled = false;
            vl_PagoTextBox.Enabled = false;
            id_ClienteTextBox.Enabled = false;
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
        public FRMContasReceber()
        {
            InitializeComponent();
        }

        private void tb_ContaReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ContaReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMContasReceber_Load(object sender, EventArgs e)
        {
            this.tb_ContaReceberTableAdapter.Fill(this.bd_ContasDataSet.tb_ContaReceber);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_ContaReceberBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_ContaReceberBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_ContaReceberBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_ContaReceberBindingSource.RemoveCurrent();
            tb_ContaReceberTableAdapter.Update(bd_ContasDataSet.tb_ContaReceber);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_ContaReceberBindingSource.EndEdit();
            tb_ContaReceberTableAdapter.Update(bd_ContasDataSet.tb_ContaReceber);
            Desabilita();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_ContaReceberBindingSource.CancelEdit();
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

            strDados = "FICHA CONTAS A RECEBER" + (char)10 + (char)10;
            strDados += "CÓDIGO: " + cd_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "CÓDIGO DO DOCUMENTO: " + cd_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "DESCRIÇÃO DO DOCUMENTO: " + ds_DocumentoTextBox.Text + (char)10 + (char)10;
            strDados += "DATA DE EMISSÃO: " + dt_EmissaoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "DATA DE VENCIMENTO: " + dt_VencimentoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "VALOR: " + vl_DocumetoTextBox.Text + (char)10 + (char)10;
            strDados += "DATA DE PAGAMENTO: " + dt_PagamentoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "VALOR PAGO: " + vl_PagoTextBox.Text + (char)10 + (char)10;
            strDados += "CÓDIGO DO CLIENTE: " + cd_ContaTextBox.Text;

            objImpressao.DrawString(strDados, new Font("arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            FRMPesquisarContasReceber fpcr = new FRMPesquisarContasReceber();
            fpcr.ShowDialog();
            cod = fpcr.getCodigo();
            if (cod == 0)
            {
                reg = tb_ContaReceberBindingSource.Find("cd_Conta", cod);
                tb_ContaReceberBindingSource.Position = reg;
            }
        }
    }
}
