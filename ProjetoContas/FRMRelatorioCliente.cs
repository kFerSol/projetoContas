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
    public partial class FRMRelatorioCliente : Form
    {
        public FRMRelatorioCliente()
        {
            InitializeComponent();
        }

        private void FRMRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Bd_ContasDataSet.tb_CLiente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_CLienteTableAdapter.Fill(this.Bd_ContasDataSet.tb_CLiente);

            this.reportViewer1.RefreshReport();
        }
    }
}
