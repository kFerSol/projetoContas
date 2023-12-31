﻿using System;
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
    public partial class FRMPesquisarContasReceber : Form
    {
        private int codigo;

        public FRMPesquisarContasReceber()
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

        private void FRMPesquisarContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_ContasDataSet.tb_ContaReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ContaReceberTableAdapter.Fill(this.bd_ContasDataSet.tb_ContaReceber);

        }

        private void tb_ContasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_ContasPagarDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Text == "")
            {
                this.tb_ContaReceberTableAdapter.Fill(this.bd_ContasDataSet.tb_ContaReceber);
            }
            else
            {
                this.tb_ContaReceberTableAdapter.FillByData(this.bd_ContasDataSet.tb_ContaReceber, dateTimePicker1.Text);
            }
        }
    }
}
