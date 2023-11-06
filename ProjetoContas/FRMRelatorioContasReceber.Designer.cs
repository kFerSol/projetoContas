namespace ProjetoContas
{
    partial class FRMRelatorioContasReceber
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
            this.Bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.tb_ContaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ContaReceberTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Bd_ContasDataSet
            // 
            this.Bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.Bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ContaReceberBindingSource
            // 
            this.tb_ContaReceberBindingSource.DataMember = "tb_ContaReceber";
            this.tb_ContaReceberBindingSource.DataSource = this.Bd_ContasDataSet;
            // 
            // tb_ContaReceberTableAdapter
            // 
            this.tb_ContaReceberTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_ContaReceberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoContas.RelatorioContasReceber.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FRMRelatorioContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMRelatorioContasReceber";
            this.Text = "FRMRelatorioContasReceber";
            this.Load += new System.EventHandler(this.FRMRelatorioContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContaReceberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tb_ContaReceberBindingSource;
        private Bd_ContasDataSet Bd_ContasDataSet;
        private Bd_ContasDataSetTableAdapters.tb_ContaReceberTableAdapter tb_ContaReceberTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}