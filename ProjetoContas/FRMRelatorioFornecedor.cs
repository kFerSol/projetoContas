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
    public partial class FRMRelatorioFornecedor : Form
    {
        public FRMRelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void FRMRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Bd_ContasDataSet.tb_Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_FornecedorTableAdapter.Fill(this.Bd_ContasDataSet.tb_Fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
