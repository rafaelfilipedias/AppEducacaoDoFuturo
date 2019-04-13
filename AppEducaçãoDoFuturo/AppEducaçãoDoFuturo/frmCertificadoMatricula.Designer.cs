namespace AppEducaçãoDoFuturo
{
    partial class frmCertificadoMatricula
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
            this.rvMatricula = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.CertificadoMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CertificadoMatriculaTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.CertificadoMatriculaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoMatriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvMatricula
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.CertificadoMatriculaBindingSource;
            this.rvMatricula.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMatricula.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportMatricula.rdlc";
            this.rvMatricula.Location = new System.Drawing.Point(12, 12);
            this.rvMatricula.Name = "rvMatricula";
            this.rvMatricula.ServerReport.BearerToken = null;
            this.rvMatricula.Size = new System.Drawing.Size(916, 364);
            this.rvMatricula.TabIndex = 0;
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
            // frmCertificadoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvMatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCertificadoMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCertificadoMatricula";
            this.Load += new System.EventHandler(this.frmCertificadoMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoMatriculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMatricula;
        private System.Windows.Forms.BindingSource CertificadoMatriculaBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.CertificadoMatriculaTableAdapter CertificadoMatriculaTableAdapter;
    }
}