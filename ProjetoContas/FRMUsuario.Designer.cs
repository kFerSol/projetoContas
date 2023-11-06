namespace ProjetoContas
{
    partial class FRMUsuario
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
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label nm_UsuarioLabel;
            System.Windows.Forms.Label sg_NivelLabel;
            System.Windows.Forms.Label nm_LoginLabel;
            System.Windows.Forms.Label cd_SenhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUsuario));
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tb_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.nm_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.sg_NivelTextBox = new System.Windows.Forms.TextBox();
            this.nm_LoginTextBox = new System.Windows.Forms.TextBox();
            this.cd_SenhaTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tb_UsuarioTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            nm_UsuarioLabel = new System.Windows.Forms.Label();
            sg_NivelLabel = new System.Windows.Forms.Label();
            nm_LoginLabel = new System.Windows.Forms.Label();
            cd_SenhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_usuarioLabel.Location = new System.Drawing.Point(248, 91);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(63, 20);
            cd_usuarioLabel.TabIndex = 1;
            cd_usuarioLabel.Text = "Código:";
            // 
            // nm_UsuarioLabel
            // 
            nm_UsuarioLabel.AutoSize = true;
            nm_UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_UsuarioLabel.Location = new System.Drawing.Point(248, 128);
            nm_UsuarioLabel.Name = "nm_UsuarioLabel";
            nm_UsuarioLabel.Size = new System.Drawing.Size(55, 20);
            nm_UsuarioLabel.TabIndex = 3;
            nm_UsuarioLabel.Text = "Nome:";
            // 
            // sg_NivelLabel
            // 
            sg_NivelLabel.AutoSize = true;
            sg_NivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_NivelLabel.Location = new System.Drawing.Point(248, 165);
            sg_NivelLabel.Name = "sg_NivelLabel";
            sg_NivelLabel.Size = new System.Drawing.Size(46, 20);
            sg_NivelLabel.TabIndex = 5;
            sg_NivelLabel.Text = "Nível:";
            // 
            // nm_LoginLabel
            // 
            nm_LoginLabel.AutoSize = true;
            nm_LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_LoginLabel.Location = new System.Drawing.Point(248, 202);
            nm_LoginLabel.Name = "nm_LoginLabel";
            nm_LoginLabel.Size = new System.Drawing.Size(52, 20);
            nm_LoginLabel.TabIndex = 7;
            nm_LoginLabel.Text = "Login:";
            // 
            // cd_SenhaLabel
            // 
            cd_SenhaLabel.AutoSize = true;
            cd_SenhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_SenhaLabel.Location = new System.Drawing.Point(248, 239);
            cd_SenhaLabel.Name = "cd_SenhaLabel";
            cd_SenhaLabel.Size = new System.Drawing.Size(60, 20);
            cd_SenhaLabel.TabIndex = 9;
            cd_SenhaLabel.Text = "Senha:";
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_UsuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Enabled = false;
            this.cd_usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(314, 88);
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(33, 26);
            this.cd_usuarioTextBox.TabIndex = 2;
            // 
            // tb_UsuarioBindingSource
            // 
            this.tb_UsuarioBindingSource.DataMember = "tb_Usuario";
            this.tb_UsuarioBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nm_UsuarioTextBox
            // 
            this.nm_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_UsuarioBindingSource, "nm_Usuario", true));
            this.nm_UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_UsuarioTextBox.Location = new System.Drawing.Point(314, 125);
            this.nm_UsuarioTextBox.MaxLength = 50;
            this.nm_UsuarioTextBox.Name = "nm_UsuarioTextBox";
            this.nm_UsuarioTextBox.Size = new System.Drawing.Size(233, 26);
            this.nm_UsuarioTextBox.TabIndex = 4;
            // 
            // sg_NivelTextBox
            // 
            this.sg_NivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_UsuarioBindingSource, "sg_Nivel", true));
            this.sg_NivelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sg_NivelTextBox.Location = new System.Drawing.Point(314, 162);
            this.sg_NivelTextBox.MaxLength = 1;
            this.sg_NivelTextBox.Name = "sg_NivelTextBox";
            this.sg_NivelTextBox.Size = new System.Drawing.Size(33, 26);
            this.sg_NivelTextBox.TabIndex = 6;
            // 
            // nm_LoginTextBox
            // 
            this.nm_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_UsuarioBindingSource, "nm_Login", true));
            this.nm_LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_LoginTextBox.Location = new System.Drawing.Point(314, 199);
            this.nm_LoginTextBox.Name = "nm_LoginTextBox";
            this.nm_LoginTextBox.Size = new System.Drawing.Size(151, 26);
            this.nm_LoginTextBox.TabIndex = 8;
            this.nm_LoginTextBox.TextChanged += new System.EventHandler(this.nm_LoginTextBox_TextChanged);
            // 
            // cd_SenhaTextBox
            // 
            this.cd_SenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_UsuarioBindingSource, "cd_Senha", true));
            this.cd_SenhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_SenhaTextBox.Location = new System.Drawing.Point(314, 236);
            this.cd_SenhaTextBox.Name = "cd_SenhaTextBox";
            this.cd_SenhaTextBox.Size = new System.Drawing.Size(151, 26);
            this.cd_SenhaTextBox.TabIndex = 10;
            this.cd_SenhaTextBox.UseSystemPasswordChar = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(82, 339);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 30);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(219, 339);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(89, 30);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(356, 339);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 30);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(493, 339);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 30);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(630, 339);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(82, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(219, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(356, 377);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(493, 377);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(630, 377);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tb_UsuarioTableAdapter
            // 
            this.tb_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FRMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(nm_UsuarioLabel);
            this.Controls.Add(this.nm_UsuarioTextBox);
            this.Controls.Add(sg_NivelLabel);
            this.Controls.Add(this.sg_NivelTextBox);
            this.Controls.Add(nm_LoginLabel);
            this.Controls.Add(this.nm_LoginTextBox);
            this.Controls.Add(cd_SenhaLabel);
            this.Controls.Add(this.cd_SenhaTextBox);
            this.Name = "FRMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FRMUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_UsuarioBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox nm_UsuarioTextBox;
        private System.Windows.Forms.TextBox sg_NivelTextBox;
        private System.Windows.Forms.TextBox nm_LoginTextBox;
        private System.Windows.Forms.TextBox cd_SenhaTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}