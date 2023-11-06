using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoContas
{
    public partial class FRMPrincipal : Form
    {
        public FRMPrincipal()
        {
            InitializeComponent();
            FRMSplashScreen fss = new FRMSplashScreen();
            fss.Show();
            Thread.Sleep(3000);
            fss.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMUsuario fu = new FRMUsuario();
            fu.ShowDialog();
        }

        private void tb_UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCliente fc = new FRMCliente();
            fc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMFornecedor ff = new FRMFornecedor();
            ff.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMContasReceber fcr = new FRMContasReceber();
            fcr.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMContasPagar fcp = new FRMContasPagar();
            fcp.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMRelatorioUsuario fru = new FRMRelatorioUsuario();
            fru.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMRelatorioCliente frc = new FRMRelatorioCliente();
            frc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMRelatorioFornecedor frf = new FRMRelatorioFornecedor();
            frf.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMRelatorioContasPagar frcp = new FRMRelatorioContasPagar();
            frcp.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRMRelatorioContasReceber frcr = new FRMRelatorioContasReceber();
            frcr.ShowDialog();
        }
    }
}
