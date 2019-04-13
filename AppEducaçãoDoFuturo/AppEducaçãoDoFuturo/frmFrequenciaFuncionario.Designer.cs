namespace AppEducaçãoDoFuturo
{
    partial class frmFrequenciaFuncionario
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
            this.rvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.CertificadoMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CertificadoMatriculaTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.CertificadoMatriculaTableAdapter();
            this.RelatorioFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioFuncionarioTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.RelatorioFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoMatriculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvFuncionario
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.RelatorioFuncionarioBindingSource;
            this.rvFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFuncionario.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportFuncionario.rdlc";
            this.rvFuncionario.Location = new System.Drawing.Point(12, 12);
            this.rvFuncionario.Name = "rvFuncionario";
            this.rvFuncionario.ServerReport.BearerToken = null;
            this.rvFuncionario.Size = new System.Drawing.Size(916, 364);
            this.rvFuncionario.TabIndex = 0;
            // 
            // dbEducacaoDoFuturoDataSet
            // 
            this.dbEducacaoDoFuturoDataSet.DataSetName = "dbEducacaoDoFuturoDataSet";
            this.dbEducacaoDoFuturoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CertificadoMatriculaBindingSource
            // 
            this.CertificadoMatriculaBindingSource.DataMember = "CertificadoMatricula";
            this.CertificadoMatriculaBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // CertificadoMatriculaTableAdapter
            // 
            this.CertificadoMatriculaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFuncionarioBindingSource
            // 
            this.RelatorioFuncionarioBindingSource.DataMember = "RelatorioFuncionario";
            this.RelatorioFuncionarioBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // RelatorioFuncionarioTableAdapter
            // 
            this.RelatorioFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmFrequenciaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrequenciaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFrequenciaFuncionario";
            this.Load += new System.EventHandler(this.frmFrequenciaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoMatriculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFuncionario;
        private System.Windows.Forms.BindingSource CertificadoMatriculaBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.CertificadoMatriculaTableAdapter CertificadoMatriculaTableAdapter;
        private System.Windows.Forms.BindingSource RelatorioFuncionarioBindingSource;
        private dbEducacaoDoFuturoDataSetTableAdapters.RelatorioFuncionarioTableAdapter RelatorioFuncionarioTableAdapter;
    }
}