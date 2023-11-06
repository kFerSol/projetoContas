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
    public partial class FRMRelatorioUsuario : Form
    {
        public FRMRelatorioUsuario()
        {
            InitializeComponent();
        }

        private void FRMRelatorioUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Bd_ContasDataSet.tb_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_UsuarioTableAdapter.Fill(this.Bd_ContasDataSet.tb_Usuario);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
