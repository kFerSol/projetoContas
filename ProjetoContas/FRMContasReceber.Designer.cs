namespace ProjetoContas
{
    partial class FRMContasReceber
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
            System.Windows.Forms.Label cd_ContaLabel;
            System.Windows.Forms.Label cd_DocumentoLabel;
            System.Windows.Forms.Label ds_DocumentoLabel;
            System.Windows.Forms.Label dt_EmissaoLabel;
            System.Windows.Forms.Label dt_VencimentoLabel;
            System.Windows.Forms.Label vl_DocumetoLabel;
            System.Windows.Forms.Label dt_PagamentoLabel;
            System.Windows.Forms.Label vl_PagoLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMContasReceber));
            this.bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_ContaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ContaReceberTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter();
            this.tableAdapterManager = new ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager();
            this.cd_ContaTextBox = new System.Windows.Forms.TextBox();
            this.cd_DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.ds_DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.dt_EmissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_VencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_DocumetoTextBox = new System.Windows.Forms.TextBox();
            this.dt_PagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_PagoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_ContaLabel = new System.Windows.Forms.Label();
            cd_DocumentoLabel = new System.Windows.Forms.Label();
            ds_DocumentoLabel = new System.Windows.Forms.Label();
            dt_EmissaoLabel = new System.Windows.Forms.Label();
            dt_VencimentoLabel = new System.Windows.Forms.Label();
            vl_DocumetoLabel = new System.Windows.Forms.Label();
            dt_PagamentoLabel = new System.Windows.Forms.Label();
            vl_PagoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_ContaLabel
            // 
            cd_ContaLabel.AutoSize = true;
            cd_ContaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ContaLabel.Location = new System.Drawing.Point(357, 73);
            cd_ContaLabel.Name = "cd_ContaLabel";
            cd_ContaLabel.Size = new System.Drawing.Size(63, 20);
            cd_ContaLabel.TabIndex = 1;
            cd_ContaLabel.Text = "Código:";
            // 
            // cd_DocumentoLabel
            // 
            cd_DocumentoLabel.AutoSize = true;
            cd_DocumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_DocumentoLabel.Location = new System.Drawing.Point(22, 119);
            cd_DocumentoLabel.Name = "cd_DocumentoLabel";
            cd_DocumentoLabel.Size = new System.Drawing.Size(172, 20);
            cd_DocumentoLabel.TabIndex = 3;
            cd_DocumentoLabel.Text = "Código do Documento:";
            // 
            // ds_DocumentoLabel
            // 
            ds_DocumentoLabel.AutoSize = true;
            ds_DocumentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_DocumentoLabel.Location = new System.Drawing.Point(22, 167);
            ds_DocumentoLabel.Name = "ds_DocumentoLabel";
            ds_DocumentoLabel.Size = new System.Drawing.Size(193, 20);
            ds_DocumentoLabel.TabIndex = 5;
            ds_DocumentoLabel.Text = "Descrição do Documento:";
            // 
            // dt_EmissaoLabel
            // 
            dt_EmissaoLabel.AutoSize = true;
            dt_EmissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_EmissaoLabel.Location = new System.Drawing.Point(23, 215);
            dt_EmissaoLabel.Name = "dt_EmissaoLabel";
            dt_EmissaoLabel.Size = new System.Drawing.Size(135, 20);
            dt_EmissaoLabel.TabIndex = 7;
            dt_EmissaoLabel.Text = "Data de Emissão:";
            // 
            // dt_VencimentoLabel
            // 
            dt_VencimentoLabel.AutoSize = true;
            dt_VencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_VencimentoLabel.Location = new System.Drawing.Point(22, 263);
            dt_VencimentoLabel.Name = "dt_VencimentoLabel";
            dt_VencimentoLabel.Size = new System.Drawing.Size(159, 20);
            dt_VencimentoLabel.TabIndex = 9;
            dt_VencimentoLabel.Text = "Data de Vencimento:";
            // 
            // vl_DocumetoLabel
            // 
            vl_DocumetoLabel.AutoSize = true;
            vl_DocumetoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_DocumetoLabel.Location = new System.Drawing.Point(422, 119);
            vl_DocumetoLabel.Name = "vl_DocumetoLabel";
            vl_DocumetoLabel.Size = new System.Drawing.Size(50, 20);
            vl_DocumetoLabel.TabIndex = 11;
            vl_DocumetoLabel.Text = "Valor:";
            // 
            // dt_PagamentoLabel
            // 
            dt_PagamentoLabel.AutoSize = true;
            dt_PagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_PagamentoLabel.Location = new System.Drawing.Point(422, 167);
            dt_PagamentoLabel.Name = "dt_PagamentoLabel";
            dt_PagamentoLabel.Size = new System.Drawing.Size(156, 20);
            dt_PagamentoLabel.TabIndex = 13;
            dt_PagamentoLabel.Text = "Data de Pagamento:";
            // 
            // vl_PagoLabel
            // 
            vl_PagoLabel.AutoSize = true;
            vl_PagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_PagoLabel.Location = new System.Drawing.Point(422, 215);
            vl_PagoLabel.Name = "vl_PagoLabel";
            vl_PagoLabel.Size = new System.Drawing.Size(91, 20);
            vl_PagoLabel.TabIndex = 15;
            vl_PagoLabel.Text = "Valor Pago:";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ClienteLabel.Location = new System.Drawing.Point(422, 263);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(134, 20);
            id_ClienteLabel.TabIndex = 17;
            id_ClienteLabel.Text = "Código do Cliente";
            // 
            // bd_ContasDataSet
            // 
            this.bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ContaReceberBindingSource
            // 
            this.tb_ContaReceberBindingSource.DataMember = "tb_ContaReceber";
            this.tb_ContaReceberBindingSource.DataSource = this.bd_ContasDataSet;
            // 
            // tb_ContaReceberTableAdapter
            // 
            this.tb_ContaReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_CLienteTableAdapter = null;
            this.tableAdapterManager.tb_ContaReceberTableAdapter = this.tb_ContaReceberTableAdapter;
            this.tableAdapterManager.tb_ContasPagarTableAdapter = null;
            this.tableAdapterManager.tb_FornecedorTableAdapter = null;
            this.tableAdapterManager.tb_UsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.Bd_ContasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_ContaTextBox
            // 
            this.cd_ContaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "cd_Conta", true));
            this.cd_ContaTextBox.Enabled = false;
            this.cd_ContaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_ContaTextBox.Location = new System.Drawing.Point(426, 70);
            this.cd_ContaTextBox.Name = "cd_ContaTextBox";
            this.cd_ContaTextBox.Size = new System.Drawing.Size(38, 26);
            this.cd_ContaTextBox.TabIndex = 2;
            // 
            // cd_DocumentoTextBox
            // 
            this.cd_DocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "cd_Documento", true));
            this.cd_DocumentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_DocumentoTextBox.Location = new System.Drawing.Point(216, 114);
            this.cd_DocumentoTextBox.Name = "cd_DocumentoTextBox";
            this.cd_DocumentoTextBox.Size = new System.Drawing.Size(142, 26);
            this.cd_DocumentoTextBox.TabIndex = 4;
            // 
            // ds_DocumentoTextBox
            // 
            this.ds_DocumentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "ds_Documento", true));
            this.ds_DocumentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_DocumentoTextBox.Location = new System.Drawing.Point(216, 162);
            this.ds_DocumentoTextBox.Name = "ds_DocumentoTextBox";
            this.ds_DocumentoTextBox.Size = new System.Drawing.Size(200, 26);
            this.ds_DocumentoTextBox.TabIndex = 6;
            // 
            // dt_EmissaoDateTimePicker
            // 
            this.dt_EmissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaReceberBindingSource, "dt_Emissao", true));
            this.dt_EmissaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_EmissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_EmissaoDateTimePicker.Location = new System.Drawing.Point(216, 210);
            this.dt_EmissaoDateTimePicker.Name = "dt_EmissaoDateTimePicker";
            this.dt_EmissaoDateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.dt_EmissaoDateTimePicker.TabIndex = 8;
            this.dt_EmissaoDateTimePicker.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // dt_VencimentoDateTimePicker
            // 
            this.dt_VencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaReceberBindingSource, "dt_Vencimento", true));
            this.dt_VencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_VencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_VencimentoDateTimePicker.Location = new System.Drawing.Point(216, 258);
            this.dt_VencimentoDateTimePicker.Name = "dt_VencimentoDateTimePicker";
            this.dt_VencimentoDateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.dt_VencimentoDateTimePicker.TabIndex = 10;
            this.dt_VencimentoDateTimePicker.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // vl_DocumetoTextBox
            // 
            this.vl_DocumetoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "vl_Documeto", true));
            this.vl_DocumetoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_DocumetoTextBox.Location = new System.Drawing.Point(584, 114);
            this.vl_DocumetoTextBox.Name = "vl_DocumetoTextBox";
            this.vl_DocumetoTextBox.Size = new System.Drawing.Size(200, 26);
            this.vl_DocumetoTextBox.TabIndex = 12;
            // 
            // dt_PagamentoDateTimePicker
            // 
            this.dt_PagamentoDateTimePicker.CustomFormat = "";
            this.dt_PagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ContaReceberBindingSource, "dt_Pagamento", true));
            this.dt_PagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_PagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_PagamentoDateTimePicker.Location = new System.Drawing.Point(584, 162);
            this.dt_PagamentoDateTimePicker.Name = "dt_PagamentoDateTimePicker";
            this.dt_PagamentoDateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.dt_PagamentoDateTimePicker.TabIndex = 14;
            this.dt_PagamentoDateTimePicker.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // vl_PagoTextBox
            // 
            this.vl_PagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "vl_Pago", true));
            this.vl_PagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_PagoTextBox.Location = new System.Drawing.Point(584, 210);
            this.vl_PagoTextBox.Name = "vl_PagoTextBox";
            this.vl_PagoTextBox.Size = new System.Drawing.Size(200, 26);
            this.vl_PagoTextBox.TabIndex = 16;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ContaReceberBindingSource, "id_Cliente", true));
            this.id_ClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(584, 258);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(200, 26);
            this.id_ClienteTextBox.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(627, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(490, 373);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(89, 30);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(353, 373);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(216, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 30);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(79, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 30);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(627, 335);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 30);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(490, 335);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 30);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(353, 335);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 30);
            this.btnNovo.TabIndex = 33;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.AutoSize = true;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(216, 335);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(89, 30);
            this.btnProximo.TabIndex = 32;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(79, 335);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(89, 30);
            this.btnAnterior.TabIndex = 31;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // FRMContasReceber
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
            this.Controls.Add(cd_ContaLabel);
            this.Controls.Add(this.cd_ContaTextBox);
            this.Controls.Add(cd_DocumentoLabel);
            this.Controls.Add(this.cd_DocumentoTextBox);
            this.Controls.Add(ds_DocumentoLabel);
            this.Controls.Add(this.ds_DocumentoTextBox);
            this.Controls.Add(dt_EmissaoLabel);
            this.Controls.Add(this.dt_EmissaoDateTimePicker);
            this.Controls.Add(dt_VencimentoLabel);
            this.Controls.Add(this.dt_VencimentoDateTimePicker);
            this.Controls.Add(vl_DocumetoLabel);
            this.Controls.Add(this.vl_DocumetoTextBox);
            this.Controls.Add(dt_PagamentoLabel);
            this.Controls.Add(this.dt_PagamentoDateTimePicker);
            this.Controls.Add(vl_PagoLabel);
            this.Controls.Add(this.vl_PagoTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Name = "FRMContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMContasReceber";
            this.Load += new System.EventHandler(this.FRMContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaReceberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_ContasDataSet bd_ContasDataSet;
        private System.Windows.Forms.BindingSource tb_ContaReceberBindingSource;
        private Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter tb_ContaReceberTableAdapter;
        private Bd_ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_ContaTextBox;
        private System.Windows.Forms.TextBox cd_DocumentoTextBox;
        private System.Windows.Forms.TextBox ds_DocumentoTextBox;
        private System.Windows.Forms.DateTimePicker dt_EmissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_VencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_DocumetoTextBox;
        private System.Windows.Forms.DateTimePicker dt_PagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_PagoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}