namespace ProjetoContas
{
    partial class FRMCliente
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
            System.Windows.Forms.Label cd_ClienteLabel;
            System.Windows.Forms.Label nm_ClienteLabel;
            System.Windows.Forms.Label ds_EnderecoLabel;
            System.Windows.Forms.Label cd_NumeroLabel;
            System.Windows.Forms.Label nm_BairroLabel;
            System.Windows.Forms.Label nm_CidadeLabel;
            System.Windows.Forms.Label sg_EstadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_RgLabel;
            System.Windows.Forms.Label cd_TelefoneLabel;
            System.Windows.Forms.Label ds_EmailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCliente));
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_CLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CLienteTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.cd_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_NumeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_BairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_CidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_EstadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.cd_cpfTextBox = new System.Windows.Forms.TextBox();
            this.cd_RgTextBox = new System.Windows.Forms.TextBox();
            this.cd_TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.ds_EmailTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior1 = new System.Windows.Forms.Button();
            this.btnProximo1 = new System.Windows.Forms.Button();
            this.btnAlterar1 = new System.Windows.Forms.Button();
            this.btnNovo1 = new System.Windows.Forms.Button();
            this.btnExcluir1 = new System.Windows.Forms.Button();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnImprimir1 = new System.Windows.Forms.Button();
            this.btnPesquisar1 = new System.Windows.Forms.Button();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_ClienteLabel = new System.Windows.Forms.Label();
            nm_ClienteLabel = new System.Windows.Forms.Label();
            ds_EnderecoLabel = new System.Windows.Forms.Label();
            cd_NumeroLabel = new System.Windows.Forms.Label();
            nm_BairroLabel = new System.Windows.Forms.Label();
            nm_CidadeLabel = new System.Windows.Forms.Label();
            sg_EstadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_RgLabel = new System.Windows.Forms.Label();
            cd_TelefoneLabel = new System.Windows.Forms.Label();
            ds_EmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_ClienteLabel
            // 
            cd_ClienteLabel.AutoSize = true;
            cd_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ClienteLabel.Location = new System.Drawing.Point(76, 133);
            cd_ClienteLabel.Name = "cd_ClienteLabel";
            cd_ClienteLabel.Size = new System.Drawing.Size(63, 20);
            cd_ClienteLabel.TabIndex = 1;
            cd_ClienteLabel.Text = "Código:";
            // 
            // nm_ClienteLabel
            // 
            nm_ClienteLabel.AutoSize = true;
            nm_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_ClienteLabel.Location = new System.Drawing.Point(76, 160);
            nm_ClienteLabel.Name = "nm_ClienteLabel";
            nm_ClienteLabel.Size = new System.Drawing.Size(59, 20);
            nm_ClienteLabel.TabIndex = 3;
            nm_ClienteLabel.Text = "Nome: ";
            // 
            // ds_EnderecoLabel
            // 
            ds_EnderecoLabel.AutoSize = true;
            ds_EnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_EnderecoLabel.Location = new System.Drawing.Point(426, 136);
            ds_EnderecoLabel.Name = "ds_EnderecoLabel";
            ds_EnderecoLabel.Size = new System.Drawing.Size(82, 20);
            ds_EnderecoLabel.TabIndex = 5;
            ds_EnderecoLabel.Text = "Endereço:";
            // 
            // cd_NumeroLabel
            // 
            cd_NumeroLabel.AutoSize = true;
            cd_NumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_NumeroLabel.Location = new System.Drawing.Point(426, 163);
            cd_NumeroLabel.Name = "cd_NumeroLabel";
            cd_NumeroLabel.Size = new System.Drawing.Size(69, 20);
            cd_NumeroLabel.TabIndex = 7;
            cd_NumeroLabel.Text = "Número:";
            // 
            // nm_BairroLabel
            // 
            nm_BairroLabel.AutoSize = true;
            nm_BairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_BairroLabel.Location = new System.Drawing.Point(426, 190);
            nm_BairroLabel.Name = "nm_BairroLabel";
            nm_BairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_BairroLabel.TabIndex = 9;
            nm_BairroLabel.Text = "Bairro:";
            // 
            // nm_CidadeLabel
            // 
            nm_CidadeLabel.AutoSize = true;
            nm_CidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_CidadeLabel.Location = new System.Drawing.Point(426, 217);
            nm_CidadeLabel.Name = "nm_CidadeLabel";
            nm_CidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_CidadeLabel.TabIndex = 11;
            nm_CidadeLabel.Text = "Cidade:";
            // 
            // sg_EstadoLabel
            // 
            sg_EstadoLabel.AutoSize = true;
            sg_EstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_EstadoLabel.Location = new System.Drawing.Point(426, 244);
            sg_EstadoLabel.Name = "sg_EstadoLabel";
            sg_EstadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_EstadoLabel.TabIndex = 13;
            sg_EstadoLabel.Text = "Estado:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(426, 271);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 15;
            cd_cepLabel.Text = "CEP:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Location = new System.Drawing.Point(76, 187);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(44, 20);
            cd_cpfLabel.TabIndex = 17;
            cd_cpfLabel.Text = "CPF:";
            // 
            // cd_RgLabel
            // 
            cd_RgLabel.AutoSize = true;
            cd_RgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_RgLabel.Location = new System.Drawing.Point(76, 214);
            cd_RgLabel.Name = "cd_RgLabel";
            cd_RgLabel.Size = new System.Drawing.Size(38, 20);
            cd_RgLabel.TabIndex = 19;
            cd_RgLabel.Text = "RG:";
            // 
            // cd_TelefoneLabel
            // 
            cd_TelefoneLabel.AutoSize = true;
            cd_TelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_TelefoneLabel.Location = new System.Drawing.Point(76, 241);
            cd_TelefoneLabel.Name = "cd_TelefoneLabel";
            cd_TelefoneLabel.Size = new System.Drawing.Size(75, 20);
            cd_TelefoneLabel.TabIndex = 21;
            cd_TelefoneLabel.Text = "Telefone:";
            // 
            // ds_EmailLabel
            // 
            ds_EmailLabel.AutoSize = true;
            ds_EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_EmailLabel.Location = new System.Drawing.Point(76, 268);
            ds_EmailLabel.Name = "ds_EmailLabel";
            ds_EmailLabel.Size = new System.Drawing.Size(52, 20);
            ds_EmailLabel.TabIndex = 23;
            ds_EmailLabel.Text = "Email:";
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
            // cd_ClienteTextBox
            // 
            this.cd_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_Cliente", true));
            this.cd_ClienteTextBox.Enabled = false;
            this.cd_ClienteTextBox.Location = new System.Drawing.Point(153, 133);
            this.cd_ClienteTextBox.Name = "cd_ClienteTextBox";
            this.cd_ClienteTextBox.Size = new System.Drawing.Size(33, 20);
            this.cd_ClienteTextBox.TabIndex = 2;
            // 
            // nm_ClienteTextBox
            // 
            this.nm_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "nm_Cliente", true));
            this.nm_ClienteTextBox.Location = new System.Drawing.Point(153, 160);
            this.nm_ClienteTextBox.Name = "nm_ClienteTextBox";
            this.nm_ClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_ClienteTextBox.TabIndex = 4;
            this.nm_ClienteTextBox.Enter += new System.EventHandler(this.nm_ClienteTextBox_Enter);
            this.nm_ClienteTextBox.Leave += new System.EventHandler(this.nm_ClienteTextBox_Leave);
            // 
            // ds_EnderecoTextBox
            // 
            this.ds_EnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "ds_Endereco", true));
            this.ds_EnderecoTextBox.Location = new System.Drawing.Point(514, 138);
            this.ds_EnderecoTextBox.Name = "ds_EnderecoTextBox";
            this.ds_EnderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_EnderecoTextBox.TabIndex = 6;
            // 
            // cd_NumeroTextBox
            // 
            this.cd_NumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_Numero", true));
            this.cd_NumeroTextBox.Location = new System.Drawing.Point(514, 164);
            this.cd_NumeroTextBox.Name = "cd_NumeroTextBox";
            this.cd_NumeroTextBox.Size = new System.Drawing.Size(66, 20);
            this.cd_NumeroTextBox.TabIndex = 8;
            // 
            // nm_BairroTextBox
            // 
            this.nm_BairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "nm_Bairro", true));
            this.nm_BairroTextBox.Location = new System.Drawing.Point(514, 190);
            this.nm_BairroTextBox.Name = "nm_BairroTextBox";
            this.nm_BairroTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_BairroTextBox.TabIndex = 10;
            // 
            // nm_CidadeTextBox
            // 
            this.nm_CidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "nm_Cidade", true));
            this.nm_CidadeTextBox.Location = new System.Drawing.Point(514, 216);
            this.nm_CidadeTextBox.Name = "nm_CidadeTextBox";
            this.nm_CidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_CidadeTextBox.TabIndex = 12;
            // 
            // sg_EstadoTextBox
            // 
            this.sg_EstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "sg_Estado", true));
            this.sg_EstadoTextBox.Location = new System.Drawing.Point(514, 242);
            this.sg_EstadoTextBox.Name = "sg_EstadoTextBox";
            this.sg_EstadoTextBox.Size = new System.Drawing.Size(40, 20);
            this.sg_EstadoTextBox.TabIndex = 14;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Location = new System.Drawing.Point(514, 268);
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(110, 20);
            this.cd_cepTextBox.TabIndex = 16;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Location = new System.Drawing.Point(153, 187);
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(124, 20);
            this.cd_cpfTextBox.TabIndex = 18;
            // 
            // cd_RgTextBox
            // 
            this.cd_RgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_Rg", true));
            this.cd_RgTextBox.Location = new System.Drawing.Point(153, 214);
            this.cd_RgTextBox.Name = "cd_RgTextBox";
            this.cd_RgTextBox.Size = new System.Drawing.Size(124, 20);
            this.cd_RgTextBox.TabIndex = 20;
            // 
            // cd_TelefoneTextBox
            // 
            this.cd_TelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "cd_Telefone", true));
            this.cd_TelefoneTextBox.Location = new System.Drawing.Point(153, 241);
            this.cd_TelefoneTextBox.Name = "cd_TelefoneTextBox";
            this.cd_TelefoneTextBox.Size = new System.Drawing.Size(124, 20);
            this.cd_TelefoneTextBox.TabIndex = 22;
            // 
            // ds_EmailTextBox
            // 
            this.ds_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_CLienteBindingSource, "ds_Email", true));
            this.ds_EmailTextBox.Location = new System.Drawing.Point(153, 268);
            this.ds_EmailTextBox.Name = "ds_EmailTextBox";
            this.ds_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_EmailTextBox.TabIndex = 24;
            // 
            // btnAnterior1
            // 
            this.btnAnterior1.AutoSize = true;
            this.btnAnterior1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior1.Location = new System.Drawing.Point(82, 353);
            this.btnAnterior1.Name = "btnAnterior1";
            this.btnAnterior1.Size = new System.Drawing.Size(80, 30);
            this.btnAnterior1.TabIndex = 25;
            this.btnAnterior1.Text = "Anterior";
            this.btnAnterior1.UseVisualStyleBackColor = true;
            this.btnAnterior1.Click += new System.EventHandler(this.btnAnterior1_Click);
            // 
            // btnProximo1
            // 
            this.btnProximo1.AutoSize = true;
            this.btnProximo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo1.Location = new System.Drawing.Point(219, 353);
            this.btnProximo1.Name = "btnProximo1";
            this.btnProximo1.Size = new System.Drawing.Size(80, 30);
            this.btnProximo1.TabIndex = 25;
            this.btnProximo1.Text = "Próximo";
            this.btnProximo1.UseVisualStyleBackColor = true;
            this.btnProximo1.Click += new System.EventHandler(this.btnProximo1_Click);
            // 
            // btnAlterar1
            // 
            this.btnAlterar1.AutoSize = true;
            this.btnAlterar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar1.Location = new System.Drawing.Point(493, 353);
            this.btnAlterar1.Name = "btnAlterar1";
            this.btnAlterar1.Size = new System.Drawing.Size(80, 30);
            this.btnAlterar1.TabIndex = 25;
            this.btnAlterar1.Text = "Alterar";
            this.btnAlterar1.UseVisualStyleBackColor = true;
            this.btnAlterar1.Click += new System.EventHandler(this.btnAlterar1_Click);
            // 
            // btnNovo1
            // 
            this.btnNovo1.AutoSize = true;
            this.btnNovo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo1.Location = new System.Drawing.Point(356, 353);
            this.btnNovo1.Name = "btnNovo1";
            this.btnNovo1.Size = new System.Drawing.Size(80, 30);
            this.btnNovo1.TabIndex = 25;
            this.btnNovo1.Text = "Novo";
            this.btnNovo1.UseVisualStyleBackColor = true;
            this.btnNovo1.Click += new System.EventHandler(this.btnNovo1_Click);
            // 
            // btnExcluir1
            // 
            this.btnExcluir1.AutoSize = true;
            this.btnExcluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir1.Location = new System.Drawing.Point(630, 353);
            this.btnExcluir1.Name = "btnExcluir1";
            this.btnExcluir1.Size = new System.Drawing.Size(80, 30);
            this.btnExcluir1.TabIndex = 25;
            this.btnExcluir1.Text = "Excluir";
            this.btnExcluir1.UseVisualStyleBackColor = true;
            this.btnExcluir1.Click += new System.EventHandler(this.btnExcluir1_Click);
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.AutoSize = true;
            this.btnSalvar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar1.Location = new System.Drawing.Point(82, 391);
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar1.TabIndex = 25;
            this.btnSalvar1.Text = "Salvar";
            this.btnSalvar1.UseVisualStyleBackColor = true;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.AutoSize = true;
            this.btnCancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar1.Location = new System.Drawing.Point(219, 391);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(82, 30);
            this.btnCancelar1.TabIndex = 25;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.AutoSize = true;
            this.btnImprimir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir1.Location = new System.Drawing.Point(493, 391);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir1.TabIndex = 25;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.UseVisualStyleBackColor = true;
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnPesquisar1
            // 
            this.btnPesquisar1.AutoSize = true;
            this.btnPesquisar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar1.Location = new System.Drawing.Point(356, 391);
            this.btnPesquisar1.Name = "btnPesquisar1";
            this.btnPesquisar1.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar1.TabIndex = 25;
            this.btnPesquisar1.Text = "Pesquisar";
            this.btnPesquisar1.UseVisualStyleBackColor = true;
            this.btnPesquisar1.Click += new System.EventHandler(this.btnPesquisar1_Click);
            // 
            // btnSair1
            // 
            this.btnSair1.AutoSize = true;
            this.btnSair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Location = new System.Drawing.Point(630, 391);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(80, 30);
            this.btnSair1.TabIndex = 25;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FRMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.btnPesquisar1);
            this.Controls.Add(this.btnExcluir1);
            this.Controls.Add(this.btnImprimir1);
            this.Controls.Add(this.btnNovo1);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnAlterar1);
            this.Controls.Add(this.btnSalvar1);
            this.Controls.Add(this.btnProximo1);
            this.Controls.Add(this.btnAnterior1);
            this.Controls.Add(cd_ClienteLabel);
            this.Controls.Add(this.cd_ClienteTextBox);
            this.Controls.Add(nm_ClienteLabel);
            this.Controls.Add(this.nm_ClienteTextBox);
            this.Controls.Add(ds_EnderecoLabel);
            this.Controls.Add(this.ds_EnderecoTextBox);
            this.Controls.Add(cd_NumeroLabel);
            this.Controls.Add(this.cd_NumeroTextBox);
            this.Controls.Add(nm_BairroLabel);
            this.Controls.Add(this.nm_BairroTextBox);
            this.Controls.Add(nm_CidadeLabel);
            this.Controls.Add(this.nm_CidadeTextBox);
            this.Controls.Add(sg_EstadoLabel);
            this.Controls.Add(this.sg_EstadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(cd_RgLabel);
            this.Controls.Add(this.cd_RgTextBox);
            this.Controls.Add(cd_TelefoneLabel);
            this.Controls.Add(this.cd_TelefoneTextBox);
            this.Controls.Add(ds_EmailLabel);
            this.Controls.Add(this.ds_EmailTextBox);
            this.Name = "FRMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FRMCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_CLienteBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter tb_CLienteTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_ClienteTextBox;
        private System.Windows.Forms.TextBox nm_ClienteTextBox;
        private System.Windows.Forms.TextBox ds_EnderecoTextBox;
        private System.Windows.Forms.TextBox cd_NumeroTextBox;
        private System.Windows.Forms.TextBox nm_BairroTextBox;
        private System.Windows.Forms.TextBox nm_CidadeTextBox;
        private System.Windows.Forms.TextBox sg_EstadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox cd_cpfTextBox;
        private System.Windows.Forms.TextBox cd_RgTextBox;
        private System.Windows.Forms.TextBox cd_TelefoneTextBox;
        private System.Windows.Forms.TextBox ds_EmailTextBox;
        private System.Windows.Forms.Button btnAnterior1;
        private System.Windows.Forms.Button btnProximo1;
        private System.Windows.Forms.Button btnAlterar1;
        private System.Windows.Forms.Button btnNovo1;
        private System.Windows.Forms.Button btnExcluir1;
        private System.Windows.Forms.Button btnSalvar1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnImprimir1;
        private System.Windows.Forms.Button btnPesquisar1;
        private System.Windows.Forms.Button btnSair1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}