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
    public partial class FRMPesquisarUsuario : Form
    {
        private int codigo;

        public FRMPesquisarUsuario()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void tb_UsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_UsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_ContasDataSet);

        }

        private void FRMPesquisarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_UsuarioTableAdapter.Fill(this.bd_ContasDataSet.tb_Usuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPesquisa.Text == "")
            {
                this.tb_UsuarioTableAdapter.Fill(this.bd_ContasDataSet.tb_Usuario);
            }
            else
            {
                this.tb_UsuarioTableAdapter.FillByNome(this.bd_ContasDataSet.tb_Usuario, "%" + textBoxPesquisa.Text + "%");
            }
        }

        private void textBoxPesquisa_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_UsuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void tb_UsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
