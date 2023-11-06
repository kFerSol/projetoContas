namespace ProjetoContas
{
    partial class FRMFornecedor
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
            System.Windows.Forms.Label cd_FornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_EnderecoLabel;
            System.Windows.Forms.Label cd_NumeroLabel;
            System.Windows.Forms.Label nm_BairroLabel;
            System.Windows.Forms.Label nm_CidadeLabel;
            System.Windows.Forms.Label sg_EstadoLabel;
            System.Windows.Forms.Label cd_CEPLabel;
            System.Windows.Forms.Label cd_CNPJLabel;
            System.Windows.Forms.Label cd_IeLabel;
            System.Windows.Forms.Label cd_TelefoneLabel;
            System.Windows.Forms.Label ds_EmailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMFornecedor));
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_FornecedorTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_FornecedorTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.cd_FornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_EnderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_NumeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_BairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_CidadeTextBox = new System.Windows.Forms.TextBox();
            this.sg_EstadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_CEPTextBox = new System.Windows.Forms.TextBox();
            this.cd_CNPJTextBox = new System.Windows.Forms.TextBox();
            this.cd_IeTextBox = new System.Windows.Forms.TextBox();
            this.cd_TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.ds_EmailTextBox = new System.Windows.Forms.TextBox();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.btnPesquisar1 = new System.Windows.Forms.Button();
            this.btnExcluir1 = new System.Windows.Forms.Button();
            this.btnImprimir1 = new System.Windows.Forms.Button();
            this.btnNovo1 = new System.Windows.Forms.Button();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnAlterar1 = new System.Windows.Forms.Button();
            this.btnSalvar1 = new System.Windows.Forms.Button();
            this.btnProximo1 = new System.Windows.Forms.Button();
            this.btnAnterior1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_FornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_EnderecoLabel = new System.Windows.Forms.Label();
            cd_NumeroLabel = new System.Windows.Forms.Label();
            nm_BairroLabel = new System.Windows.Forms.Label();
            nm_CidadeLabel = new System.Windows.Forms.Label();
            sg_EstadoLabel = new System.Windows.Forms.Label();
            cd_CEPLabel = new System.Windows.Forms.Label();
            cd_CNPJLabel = new System.Windows.Forms.Label();
            cd_IeLabel = new System.Windows.Forms.Label();
            cd_TelefoneLabel = new System.Windows.Forms.Label();
            ds_EmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_FornecedorLabel
            // 
            cd_FornecedorLabel.AutoSize = true;
            cd_FornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_FornecedorLabel.Location = new System.Drawing.Point(55, 117);
            cd_FornecedorLabel.Name = "cd_FornecedorLabel";
            cd_FornecedorLabel.Size = new System.Drawing.Size(63, 20);
            cd_FornecedorLabel.TabIndex = 1;
            cd_FornecedorLabel.Text = "Código:";
            cd_FornecedorLabel.Click += new System.EventHandler(this.cd_FornecedorLabel_Click);
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(55, 144);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(55, 20);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome:";
            // 
            // ds_EnderecoLabel
            // 
            ds_EnderecoLabel.AutoSize = true;
            ds_EnderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_EnderecoLabel.Location = new System.Drawing.Point(455, 117);
            ds_EnderecoLabel.Name = "ds_EnderecoLabel";
            ds_EnderecoLabel.Size = new System.Drawing.Size(82, 20);
            ds_EnderecoLabel.TabIndex = 5;
            ds_EnderecoLabel.Text = "Endereço:";
            // 
            // cd_NumeroLabel
            // 
            cd_NumeroLabel.AutoSize = true;
            cd_NumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_NumeroLabel.Location = new System.Drawing.Point(455, 144);
            cd_NumeroLabel.Name = "cd_NumeroLabel";
            cd_NumeroLabel.Size = new System.Drawing.Size(69, 20);
            cd_NumeroLabel.TabIndex = 7;
            cd_NumeroLabel.Text = "Número:";
            // 
            // nm_BairroLabel
            // 
            nm_BairroLabel.AutoSize = true;
            nm_BairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_BairroLabel.Location = new System.Drawing.Point(455, 171);
            nm_BairroLabel.Name = "nm_BairroLabel";
            nm_BairroLabel.Size = new System.Drawing.Size(55, 20);
            nm_BairroLabel.TabIndex = 9;
            nm_BairroLabel.Text = "Bairro:";
            // 
            // nm_CidadeLabel
            // 
            nm_CidadeLabel.AutoSize = true;
            nm_CidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_CidadeLabel.Location = new System.Drawing.Point(455, 198);
            nm_CidadeLabel.Name = "nm_CidadeLabel";
            nm_CidadeLabel.Size = new System.Drawing.Size(63, 20);
            nm_CidadeLabel.TabIndex = 11;
            nm_CidadeLabel.Text = "Cidade:";
            // 
            // sg_EstadoLabel
            // 
            sg_EstadoLabel.AutoSize = true;
            sg_EstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_EstadoLabel.Location = new System.Drawing.Point(455, 225);
            sg_EstadoLabel.Name = "sg_EstadoLabel";
            sg_EstadoLabel.Size = new System.Drawing.Size(64, 20);
            sg_EstadoLabel.TabIndex = 13;
            sg_EstadoLabel.Text = "Estado:";
            // 
            // cd_CEPLabel
            // 
            cd_CEPLabel.AutoSize = true;
            cd_CEPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_CEPLabel.Location = new System.Drawing.Point(455, 252);
            cd_CEPLabel.Name = "cd_CEPLabel";
            cd_CEPLabel.Size = new System.Drawing.Size(45, 20);
            cd_CEPLabel.TabIndex = 15;
            cd_CEPLabel.Text = "CEP:";
            // 
            // cd_CNPJLabel
            // 
            cd_CNPJLabel.AutoSize = true;
            cd_CNPJLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_CNPJLabel.Location = new System.Drawing.Point(55, 171);
            cd_CNPJLabel.Name = "cd_CNPJLabel";
            cd_CNPJLabel.Size = new System.Drawing.Size(53, 20);
            cd_CNPJLabel.TabIndex = 17;
            cd_CNPJLabel.Text = "CNPJ:";
            // 
            // cd_IeLabel
            // 
            cd_IeLabel.AutoSize = true;
            cd_IeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_IeLabel.Location = new System.Drawing.Point(55, 198);
            cd_IeLabel.Name = "cd_IeLabel";
            cd_IeLabel.Size = new System.Drawing.Size(144, 20);
            cd_IeLabel.TabIndex = 19;
            cd_IeLabel.Text = "Inscrição Estadual:";
            // 
            // cd_TelefoneLabel
            // 
            cd_TelefoneLabel.AutoSize = true;
            cd_TelefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_TelefoneLabel.Location = new System.Drawing.Point(55, 225);
            cd_TelefoneLabel.Name = "cd_TelefoneLabel";
            cd_TelefoneLabel.Size = new System.Drawing.Size(75, 20);
            cd_TelefoneLabel.TabIndex = 21;
            cd_TelefoneLabel.Text = "Telefone:";
            // 
            // ds_EmailLabel
            // 
            ds_EmailLabel.AutoSize = true;
            ds_EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_EmailLabel.Location = new System.Drawing.Point(55, 252);
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
            // cd_FornecedorTextBox
            // 
            this.cd_FornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_Fornecedor", true));
            this.cd_FornecedorTextBox.Enabled = false;
            this.cd_FornecedorTextBox.Location = new System.Drawing.Point(200, 118);
            this.cd_FornecedorTextBox.Name = "cd_FornecedorTextBox";
            this.cd_FornecedorTextBox.Size = new System.Drawing.Size(34, 20);
            this.cd_FornecedorTextBox.TabIndex = 2;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(200, 144);
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_fornecedorTextBox.TabIndex = 4;
            // 
            // ds_EnderecoTextBox
            // 
            this.ds_EnderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "ds_Endereco", true));
            this.ds_EnderecoTextBox.Location = new System.Drawing.Point(541, 119);
            this.ds_EnderecoTextBox.Name = "ds_EnderecoTextBox";
            this.ds_EnderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_EnderecoTextBox.TabIndex = 6;
            // 
            // cd_NumeroTextBox
            // 
            this.cd_NumeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_Numero", true));
            this.cd_NumeroTextBox.Location = new System.Drawing.Point(541, 145);
            this.cd_NumeroTextBox.Name = "cd_NumeroTextBox";
            this.cd_NumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_NumeroTextBox.TabIndex = 8;
            // 
            // nm_BairroTextBox
            // 
            this.nm_BairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "nm_Bairro", true));
            this.nm_BairroTextBox.Location = new System.Drawing.Point(541, 171);
            this.nm_BairroTextBox.Name = "nm_BairroTextBox";
            this.nm_BairroTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_BairroTextBox.TabIndex = 10;
            // 
            // nm_CidadeTextBox
            // 
            this.nm_CidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "nm_Cidade", true));
            this.nm_CidadeTextBox.Location = new System.Drawing.Point(541, 197);
            this.nm_CidadeTextBox.Name = "nm_CidadeTextBox";
            this.nm_CidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nm_CidadeTextBox.TabIndex = 12;
            // 
            // sg_EstadoTextBox
            // 
            this.sg_EstadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "sg_Estado", true));
            this.sg_EstadoTextBox.Location = new System.Drawing.Point(541, 223);
            this.sg_EstadoTextBox.Name = "sg_EstadoTextBox";
            this.sg_EstadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sg_EstadoTextBox.TabIndex = 14;
            // 
            // cd_CEPTextBox
            // 
            this.cd_CEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_CEP", true));
            this.cd_CEPTextBox.Location = new System.Drawing.Point(541, 249);
            this.cd_CEPTextBox.Name = "cd_CEPTextBox";
            this.cd_CEPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cd_CEPTextBox.TabIndex = 16;
            this.cd_CEPTextBox.TextChanged += new System.EventHandler(this.cd_CEPTextBox_TextChanged);
            // 
            // cd_CNPJTextBox
            // 
            this.cd_CNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_CNPJ", true));
            this.cd_CNPJTextBox.Location = new System.Drawing.Point(200, 171);
            this.cd_CNPJTextBox.Name = "cd_CNPJTextBox";
            this.cd_CNPJTextBox.Size = new System.Drawing.Size(125, 20);
            this.cd_CNPJTextBox.TabIndex = 18;
            // 
            // cd_IeTextBox
            // 
            this.cd_IeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_Ie", true));
            this.cd_IeTextBox.Location = new System.Drawing.Point(200, 198);
            this.cd_IeTextBox.Name = "cd_IeTextBox";
            this.cd_IeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cd_IeTextBox.TabIndex = 20;
            // 
            // cd_TelefoneTextBox
            // 
            this.cd_TelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "cd_Telefone", true));
            this.cd_TelefoneTextBox.Location = new System.Drawing.Point(200, 225);
            this.cd_TelefoneTextBox.Name = "cd_TelefoneTextBox";
            this.cd_TelefoneTextBox.Size = new System.Drawing.Size(125, 20);
            this.cd_TelefoneTextBox.TabIndex = 22;
            // 
            // ds_EmailTextBox
            // 
            this.ds_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_FornecedorBindingSource, "ds_Email", true));
            this.ds_EmailTextBox.Location = new System.Drawing.Point(200, 252);
            this.ds_EmailTextBox.Name = "ds_EmailTextBox";
            this.ds_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.ds_EmailTextBox.TabIndex = 24;
            // 
            // btnSair1
            // 
            this.btnSair1.AutoSize = true;
            this.btnSair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair1.Location = new System.Drawing.Point(626, 369);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(80, 30);
            this.btnSair1.TabIndex = 26;
            this.btnSair1.Text = "Sair";
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // btnPesquisar1
            // 
            this.btnPesquisar1.AutoSize = true;
            this.btnPesquisar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar1.Location = new System.Drawing.Point(352, 369);
            this.btnPesquisar1.Name = "btnPesquisar1";
            this.btnPesquisar1.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar1.TabIndex = 27;
            this.btnPesquisar1.Text = "Pesquisar";
            this.btnPesquisar1.UseVisualStyleBackColor = true;
            this.btnPesquisar1.Click += new System.EventHandler(this.btnPesquisar1_Click);
            // 
            // btnExcluir1
            // 
            this.btnExcluir1.AutoSize = true;
            this.btnExcluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir1.Location = new System.Drawing.Point(626, 331);
            this.btnExcluir1.Name = "btnExcluir1";
            this.btnExcluir1.Size = new System.Drawing.Size(80, 30);
            this.btnExcluir1.TabIndex = 28;
            this.btnExcluir1.Text = "Excluir";
            this.btnExcluir1.UseVisualStyleBackColor = true;
            this.btnExcluir1.Click += new System.EventHandler(this.btnExcluir1_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.AutoSize = true;
            this.btnImprimir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir1.Location = new System.Drawing.Point(489, 369);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir1.TabIndex = 29;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.UseVisualStyleBackColor = true;
            this.btnImprimir1.Click += new System.EventHandler(this.btnImprimir1_Click);
            // 
            // btnNovo1
            // 
            this.btnNovo1.AutoSize = true;
            this.btnNovo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo1.Location = new System.Drawing.Point(352, 331);
            this.btnNovo1.Name = "btnNovo1";
            this.btnNovo1.Size = new System.Drawing.Size(80, 30);
            this.btnNovo1.TabIndex = 30;
            this.btnNovo1.Text = "Novo";
            this.btnNovo1.UseVisualStyleBackColor = true;
            this.btnNovo1.Click += new System.EventHandler(this.btnNovo1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.AutoSize = true;
            this.btnCancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar1.Location = new System.Drawing.Point(215, 369);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(82, 30);
            this.btnCancelar1.TabIndex = 31;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnAlterar1
            // 
            this.btnAlterar1.AutoSize = true;
            this.btnAlterar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar1.Location = new System.Drawing.Point(489, 331);
            this.btnAlterar1.Name = "btnAlterar1";
            this.btnAlterar1.Size = new System.Drawing.Size(80, 30);
            this.btnAlterar1.TabIndex = 32;
            this.btnAlterar1.Text = "Alterar";
            this.btnAlterar1.UseVisualStyleBackColor = true;
            this.btnAlterar1.Click += new System.EventHandler(this.btnAlterar1_Click);
            // 
            // btnSalvar1
            // 
            this.btnSalvar1.AutoSize = true;
            this.btnSalvar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar1.Location = new System.Drawing.Point(78, 369);
            this.btnSalvar1.Name = "btnSalvar1";
            this.btnSalvar1.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar1.TabIndex = 33;
            this.btnSalvar1.Text = "Salvar";
            this.btnSalvar1.UseVisualStyleBackColor = true;
            this.btnSalvar1.Click += new System.EventHandler(this.btnSalvar1_Click);
            // 
            // btnProximo1
            // 
            this.btnProximo1.AutoSize = true;
            this.btnProximo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo1.Location = new System.Drawing.Point(215, 331);
            this.btnProximo1.Name = "btnProximo1";
            this.btnProximo1.Size = new System.Drawing.Size(80, 30);
            this.btnProximo1.TabIndex = 34;
            this.btnProximo1.Text = "Próximo";
            this.btnProximo1.UseVisualStyleBackColor = true;
            this.btnProximo1.Click += new System.EventHandler(this.btnProximo1_Click);
            // 
            // btnAnterior1
            // 
            this.btnAnterior1.AutoSize = true;
            this.btnAnterior1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior1.Location = new System.Drawing.Point(78, 331);
            this.btnAnterior1.Name = "btnAnterior1";
            this.btnAnterior1.Size = new System.Drawing.Size(80, 30);
            this.btnAnterior1.TabIndex = 35;
            this.btnAnterior1.Text = "Anterior";
            this.btnAnterior1.UseVisualStyleBackColor = true;
            this.btnAnterior1.Click += new System.EventHandler(this.btnAnterior1_Click);
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
            // FRMFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(cd_FornecedorLabel);
            this.Controls.Add(this.cd_FornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
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
            this.Controls.Add(cd_CEPLabel);
            this.Controls.Add(this.cd_CEPTextBox);
            this.Controls.Add(cd_CNPJLabel);
            this.Controls.Add(this.cd_CNPJTextBox);
            this.Controls.Add(cd_IeLabel);
            this.Controls.Add(this.cd_IeTextBox);
            this.Controls.Add(cd_TelefoneLabel);
            this.Controls.Add(this.cd_TelefoneTextBox);
            this.Controls.Add(ds_EmailLabel);
            this.Controls.Add(this.ds_EmailTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FRMFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FRMFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_FornecedorBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_FornecedorTableAdapter tb_FornecedorTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_FornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_EnderecoTextBox;
        private System.Windows.Forms.TextBox cd_NumeroTextBox;
        private System.Windows.Forms.TextBox nm_BairroTextBox;
        private System.Windows.Forms.TextBox nm_CidadeTextBox;
        private System.Windows.Forms.TextBox sg_EstadoTextBox;
        private System.Windows.Forms.TextBox cd_CEPTextBox;
        private System.Windows.Forms.TextBox cd_CNPJTextBox;
        private System.Windows.Forms.TextBox cd_IeTextBox;
        private System.Windows.Forms.TextBox cd_TelefoneTextBox;
        private System.Windows.Forms.TextBox ds_EmailTextBox;
        private System.Windows.Forms.Button btnSair1;
        private System.Windows.Forms.Button btnPesquisar1;
        private System.Windows.Forms.Button btnExcluir1;
        private System.Windows.Forms.Button btnImprimir1;
        private System.Windows.Forms.Button btnNovo1;
        private System.Windows.Forms.Button btnCancelar1;
        private System.Windows.Forms.Button btnAlterar1;
        private System.Windows.Forms.Button btnSalvar1;
        private System.Windows.Forms.Button btnProximo1;
        private System.Windows.Forms.Button btnAnterior1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}