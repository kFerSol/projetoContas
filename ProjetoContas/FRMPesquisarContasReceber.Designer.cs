namespace ProjetoContas
{
    partial class FRMPesquisarContasReceber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tb_ContasPagarDataGridView = new System.Windows.Forms.DataGridView();
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tbContaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ContaReceberTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter();
            this.cdContaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContasPagarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContaReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data:";
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(369, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tb_ContasPagarDataGridView
            // 
            this.tb_ContasPagarDataGridView.AllowUserToAddRows = false;
            this.tb_ContasPagarDataGridView.AllowUserToDeleteRows = false;
            this.tb_ContasPagarDataGridView.AutoGenerateColumns = false;
            this.tb_ContasPagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_ContasPagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdContaDataGridViewTextBoxColumn,
            this.dtEmissaoDataGridViewTextBoxColumn,
            this.dtVencimentoDataGridViewTextBoxColumn,
            this.dtPagamentoDataGridViewTextBoxColumn,
            this.vlPagoDataGridViewTextBoxColumn});
            this.tb_ContasPagarDataGridView.DataSource = this.tbContaReceberBindingSource;
            this.tb_ContasPagarDataGridView.Location = new System.Drawing.Point(84, 73);
            this.tb_ContasPagarDataGridView.Name = "tb_ContasPagarDataGridView";
            this.tb_ContasPagarDataGridView.ReadOnly = true;
            this.tb_ContasPagarDataGridView.Size = new System.Drawing.Size(633, 298);
            this.tb_ContasPagarDataGridView.TabIndex = 10;
            this.tb_ContasPagarDataGridView.DoubleClick += new System.EventHandler(this.tb_ContasPagarDataGridView_DoubleClick);
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContaReceberBindingSource
            // 
            this.tbContaReceberBindingSource.DataMember = "tb_ContaReceber";
            this.tbContaReceberBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // tb_ContaReceberTableAdapter
            // 
            this.tb_ContaReceberTableAdapter.ClearBeforeFill = true;
            // 
            // cdContaDataGridViewTextBoxColumn
            // 
            this.cdContaDataGridViewTextBoxColumn.DataPropertyName = "cd_Conta";
            this.cdContaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cdContaDataGridViewTextBoxColumn.Name = "cdContaDataGridViewTextBoxColumn";
            this.cdContaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdContaDataGridViewTextBoxColumn.Width = 75;
            // 
            // dtEmissaoDataGridViewTextBoxColumn
            // 
            this.dtEmissaoDataGridViewTextBoxColumn.DataPropertyName = "dt_Emissao";
            this.dtEmissaoDataGridViewTextBoxColumn.HeaderText = "Data de Emissão";
            this.dtEmissaoDataGridViewTextBoxColumn.Name = "dtEmissaoDataGridViewTextBoxColumn";
            this.dtEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtEmissaoDataGridViewTextBoxColumn.Width = 120;
            // 
            // dtVencimentoDataGridViewTextBoxColumn
            // 
            this.dtVencimentoDataGridViewTextBoxColumn.DataPropertyName = "dt_Vencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de Vencimento";
            this.dtVencimentoDataGridViewTextBoxColumn.Name = "dtVencimentoDataGridViewTextBoxColumn";
            this.dtVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtVencimentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // dtPagamentoDataGridViewTextBoxColumn
            // 
            this.dtPagamentoDataGridViewTextBoxColumn.DataPropertyName = "dt_Pagamento";
            this.dtPagamentoDataGridViewTextBoxColumn.HeaderText = "Data de Pagamento";
            this.dtPagamentoDataGridViewTextBoxColumn.Name = "dtPagamentoDataGridViewTextBoxColumn";
            this.dtPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPagamentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // vlPagoDataGridViewTextBoxColumn
            // 
            this.vlPagoDataGridViewTextBoxColumn.DataPropertyName = "vl_Pago";
            this.vlPagoDataGridViewTextBoxColumn.HeaderText = "Valor Pago";
            this.vlPagoDataGridViewTextBoxColumn.Name = "vlPagoDataGridViewTextBoxColumn";
            this.vlPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlPagoDataGridViewTextBoxColumn.Width = 115;
            // 
            // FRMPesquisarContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tb_ContasPagarDataGridView);
            this.Name = "FRMPesquisarContasReceber";
            this.Text = "FRMPesquisarContasReceber";
            this.Load += new System.EventHandler(this.FRMPesquisarContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContasPagarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContaReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView tb_ContasPagarDataGridView;
        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tbContaReceberBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter tb_ContaReceberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdContaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlPagoDataGridViewTextBoxColumn;
    }
}