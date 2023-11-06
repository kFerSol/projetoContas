namespace ProjetoContas
{
    partial class FRMPesquisaFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_FornecedorTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_FornecedorTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.tb_FornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(143, 31);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(513, 26);
            this.txtPesquisa.TabIndex = 7;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(367, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_FornecedorBindingSource
            // 
            this.tb_FornecedorBindingSource.DataMember = "tb_Fornecedor";
            this.tb_FornecedorBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // tb_FornecedorTableAdapter
            // 
            this.tb_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_CLienteTableAdapter = null;
            this.tableAdapterManager.tb_ContaReceberTableAdapter = null;
            this.tableAdapterManager.tb_ContasPagarTableAdapter = null;
            this.tableAdapterManager.tb_FornecedorTableAdapter = this.tb_FornecedorTableAdapter;
            this.tableAdapterManager.tb_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_FornecedorDataGridView
            // 
            this.tb_FornecedorDataGridView.AllowUserToAddRows = false;
            this.tb_FornecedorDataGridView.AllowUserToDeleteRows = false;
            this.tb_FornecedorDataGridView.AutoGenerateColumns = false;
            this.tb_FornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_FornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_FornecedorDataGridView.DataSource = this.tb_FornecedorBindingSource;
            this.tb_FornecedorDataGridView.Location = new System.Drawing.Point(86, 72);
            this.tb_FornecedorDataGridView.Name = "tb_FornecedorDataGridView";
            this.tb_FornecedorDataGridView.ReadOnly = true;
            this.tb_FornecedorDataGridView.Size = new System.Drawing.Size(624, 298);
            this.tb_FornecedorDataGridView.TabIndex = 9;
            this.tb_FornecedorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_FornecedorDataGridView_CellContentClick);
            this.tb_FornecedorDataGridView.DoubleClick += new System.EventHandler(this.tb_FornecedorDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_Fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 460;
            // 
            // FRMPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_FornecedorDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnSair);
            this.Name = "FRMPesquisaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar o Fornecedor";
            this.Load += new System.EventHandler(this.FRMPesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_FornecedorBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_FornecedorTableAdapter tb_FornecedorTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_FornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}