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
    public partial class FRMPesquisaContasPagar : Form
    {
        private int codigo;

        public FRMPesquisaContasPagar()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMPesquisaContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_ContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContasPagarTableAdapter.Fill(this.bd_ContasDataSet.tb_ContasPagar);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "")
            {
                this.tb_ContasPagarTableAdapter.Fill(this.bd_ContasDataSet.tb_ContasPagar);
            }
            else
            {
                this.tb_ContasPagarTableAdapter.FillByData(this.bd_ContasDataSet.tb_ContasPagar, dateTimePicker1.Text);
            }
        }

        private void tb_ContasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_ContasPagarDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void tb_ContasPagarDataGridView_DockChanged(object sender, EventArgs e)
        {

        }
    }
}
