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
    public partial class FRMPesquisaFornecedor : Form
    {
        private int codigo;

        public FRMPesquisaFornecedor()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_FornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_FornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_FornecedorTableAdapter.Fill(this.bd_ContasDataSet.tb_Fornecedor);

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisa.Text == "")
            {
                this.tb_FornecedorTableAdapter.Fill(this.bd_ContasDataSet.tb_Fornecedor);
            }
            else
            {
                this.tb_FornecedorTableAdapter.FillByNome(this.bd_ContasDataSet.tb_Fornecedor, "%" + txtPesquisa.Text + "%");
            }
        }

        private void tb_FornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_FornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_FornecedorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
