namespace ProjetoContas
{
    partial class FRMPesquisaCliente
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
            this.tb_CLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CLienteTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.tb_CLienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(147, 31);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(513, 26);
            this.txtPesquisa.TabIndex = 11;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(371, 389);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CLienteBindingSource
            // 
            this.tb_CLienteBindingSource.DataMember = "tb_CLiente";
            this.tb_CLienteBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // tb_CLienteTableAdapter
            // 
            this.tb_CLienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_CLienteTableAdapter = this.tb_CLienteTableAdapter;
            this.tableAdapterManager.tb_ContaReceberTableAdapter = null;
            this.tableAdapterManager.tb_ContasPagarTableAdapter = null;
            this.tableAdapterManager.tb_FornecedorTableAdapter = null;
            this.tableAdapterManager.tb_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_CLienteDataGridView
            // 
            this.tb_CLienteDataGridView.AllowUserToAddRows = false;
            this.tb_CLienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_CLienteDataGridView.AutoGenerateColumns = false;
            this.tb_CLienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_CLienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_CLienteDataGridView.DataSource = this.tb_CLienteBindingSource;
            this.tb_CLienteDataGridView.Location = new System.Drawing.Point(90, 73);
            this.tb_CLienteDataGridView.Name = "tb_CLienteDataGridView";
            this.tb_CLienteDataGridView.ReadOnly = true;
            this.tb_CLienteDataGridView.Size = new System.Drawing.Size(625, 289);
            this.tb_CLienteDataGridView.TabIndex = 13;
            this.tb_CLienteDataGridView.DoubleClick += new System.EventHandler(this.tb_CLienteDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 460;
            // 
            // FRMPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_CLienteDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnSair);
            this.Name = "FRMPesquisaCliente";
            this.Text = "Pesquisar o Cliente";
            this.Load += new System.EventHandler(this.FRMPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_CLienteBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter tb_CLienteTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_CLienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}