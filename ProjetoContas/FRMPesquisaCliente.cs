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
    public partial class FRMPesquisaCliente : Form
    {
        private int codigo;

        public FRMPesquisaCliente()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tb_CLienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CLienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void tb_CLienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_CLienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_CLiente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_CLienteTableAdapter.Fill(this.bd_ContasDataSet.tb_CLiente);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(txtPesquisa.Text == "")
            {
                this.tb_CLienteTableAdapter.Fill(this.bd_ContasDataSet.tb_CLiente);
            }
            else
            {
                this.tb_CLienteTableAdapter.FillByNome(this.bd_ContasDataSet.tb_CLiente, "%" + txtPesquisa.Text + "%");
            }
        }

        private void tb_CLienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_CLienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
