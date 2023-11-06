namespace ProjetoContas
{
    partial class FRMPesquisarUsuario
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
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UsuarioTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.tb_UsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_UsuarioBindingSource
            // 
            this.tb_UsuarioBindingSource.DataMember = "tb_Usuario";
            this.tb_UsuarioBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // tb_UsuarioTableAdapter
            // 
            this.tb_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_CLienteTableAdapter = null;
            this.tableAdapterManager.tb_ContaReceberTableAdapter = null;
            this.tableAdapterManager.tb_ContasPagarTableAdapter = null;
            this.tableAdapterManager.tb_FornecedorTableAdapter = null;
            this.tableAdapterManager.tb_UsuarioTableAdapter = this.tb_UsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_UsuarioDataGridView
            // 
            this.tb_UsuarioDataGridView.AllowUserToAddRows = false;
            this.tb_UsuarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_UsuarioDataGridView.AutoGenerateColumns = false;
            this.tb_UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_UsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_UsuarioDataGridView.DataSource = this.tb_UsuarioBindingSource;
            this.tb_UsuarioDataGridView.Location = new System.Drawing.Point(83, 75);
            this.tb_UsuarioDataGridView.Name = "tb_UsuarioDataGridView";
            this.tb_UsuarioDataGridView.ReadOnly = true;
            this.tb_UsuarioDataGridView.Size = new System.Drawing.Size(633, 298);
            this.tb_UsuarioDataGridView.TabIndex = 1;
            this.tb_UsuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_UsuarioDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_Usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 470;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(373, 393);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisa.Location = new System.Drawing.Point(141, 35);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(513, 26);
            this.textBoxPesquisa.TabIndex = 3;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            this.textBoxPesquisa.DoubleClick += new System.EventHandler(this.textBoxPesquisa_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRMPesquisarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tb_UsuarioDataGridView);
            this.Name = "FRMPesquisarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar o Usuário";
            this.Load += new System.EventHandler(this.FRMPesquisarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_UsuarioBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_UsuarioDataGridView;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}