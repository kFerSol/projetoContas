namespace ProjetoContas
{
    partial class FRMLogin
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
            this.login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_UsuarioTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(102, 58);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(52, 20);
            this.login.TabIndex = 0;
            this.login.Text = "Login:";
            this.login.Click += new System.EventHandler(this.label1_Click);
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(102, 90);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(60, 20);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(176, 55);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(134, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(176, 87);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(134, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(208, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 217);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.login);
            this.Name = "FRMLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FRMLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_UsuarioBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}