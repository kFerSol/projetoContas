namespace ProjetoContas
{
    partial class FRMRelatorioContasPagar
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
            this.tb_ContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ContasPagarTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_ContasPagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_ContasPagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoContas.RelatorioContasPagar.rdlc";
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
            // tb_ContasPagarBindingSource
            // 
            this.tb_ContasPagarBindingSource.DataMember = "tb_ContasPagar";
            this.tb_ContasPagarBindingSource.DataSource = this.Bd_ContasDataSet;
            // 
            // tb_ContasPagarTableAdapter
            // 
            this.tb_ContasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // FRMRelatorioContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMRelatorioContasPagar";
            this.Text = "FRMRelatorioContasPagar";
            this.Load += new System.EventHandler(this.FRMRelatorioContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ContasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_ContasPagarBindingSource;
        private Bd_ContasDataSet Bd_ContasDataSet;
        private Bd_ContasDataSetTableAdapters.tb_ContasPagarTableAdapter tb_ContasPagarTableAdapter;
    }
}