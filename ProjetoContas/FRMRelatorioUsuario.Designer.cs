namespace ProjetoContas
{
    partial class FRMRelatorioUsuario
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
            this.tb_UsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bd_ContasDataSet = new ProjetoContas.Bd_ContasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_UsuarioTableAdapter = new ProjetoContas.Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_UsuarioBindingSource
            // 
            this.tb_UsuarioBindingSource.DataMember = "tb_Usuario";
            this.tb_UsuarioBindingSource.DataSource = this.Bd_ContasDataSet;
            // 
            // Bd_ContasDataSet
            // 
            this.Bd_ContasDataSet.DataSetName = "Bd_ContasDataSet";
            this.Bd_ContasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_UsuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoContas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tb_UsuarioTableAdapter
            // 
            this.tb_UsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FRMRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMRelatorioUsuario";
            this.Text = "Relatório de Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_UsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bd_ContasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_UsuarioBindingSource;
        private Bd_ContasDataSet Bd_ContasDataSet;
        private Bd_ContasDataSetTableAdapters.tb_UsuarioTableAdapter tb_UsuarioTableAdapter;
    }
}