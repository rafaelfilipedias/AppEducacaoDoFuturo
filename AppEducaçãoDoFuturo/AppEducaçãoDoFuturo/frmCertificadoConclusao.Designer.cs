namespace AppEducaçãoDoFuturo
{
    partial class frmCertificadoConclusao
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
            this.rvConclusao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.CertificadoConclusaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CertificadoConclusaoTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.CertificadoConclusaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoConclusaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvConclusao
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.CertificadoConclusaoBindingSource;
            this.rvConclusao.LocalReport.DataSources.Add(reportDataSource1);
            this.rvConclusao.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportConclusao.rdlc";
            this.rvConclusao.Location = new System.Drawing.Point(12, 12);
            this.rvConclusao.Name = "rvConclusao";
            this.rvConclusao.ServerReport.BearerToken = null;
            this.rvConclusao.Size = new System.Drawing.Size(916, 364);
            this.rvConclusao.TabIndex = 0;
            // 
            // dbEducacaoDoFuturoDataSet
            // 
            this.dbEducacaoDoFuturoDataSet.DataSetName = "dbEducacaoDoFuturoDataSet";
            this.dbEducacaoDoFuturoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CertificadoConclusaoBindingSource
            // 
            this.CertificadoConclusaoBindingSource.DataMember = "CertificadoConclusao";
            this.CertificadoConclusaoBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // CertificadoConclusaoTableAdapter
            // 
            this.CertificadoConclusaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCertificadoConclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvConclusao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCertificadoConclusao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmCertificadoConclusao";
            this.Load += new System.EventHandler(this.frmCertificadoConclusao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificadoConclusaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvConclusao;
        private System.Windows.Forms.BindingSource CertificadoConclusaoBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.CertificadoConclusaoTableAdapter CertificadoConclusaoTableAdapter;
    }
}