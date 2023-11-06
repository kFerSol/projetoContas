namespace ProjetoContas
{
    partial class FRMRelatorioCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_CLienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CLienteTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_CLienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoContas.RelatorioCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Bd_ContasDataSet
            // 
            this.Bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.Bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CLienteBindingSource
            // 
            this.tb_CLienteBindingSource.DataMember = "tb_CLiente";
            this.tb_CLienteBindingSource.DataSource = this.Bd_ContasDataSet;
            // 
            // tb_CLienteTableAdapter
            // 
            this.tb_CLienteTableAdapter.ClearBeforeFill = true;
            // 
            // FRMRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMRelatorioCliente";
            this.Text = "FRMRelatorioCliente";
            this.Load += new System.EventHandler(this.FRMRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CLienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_CLienteBindingSource;
        private Bd_ContasDataSet Bd_ContasDataSet;
        private Bd_ContasDataSetTableAdapters.tb_CLienteTableAdapter tb_CLienteTableAdapter;
    }
}