namespace AppEducaçãoDoFuturo
{
    partial class frmRelatorioAluno
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
            this.rvAluno = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.RelatorioAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioAlunoTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.RelatorioAlunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioAlunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvAluno
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.RelatorioAlunoBindingSource;
            this.rvAluno.LocalReport.DataSources.Add(reportDataSource1);
            this.rvAluno.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportAluno.rdlc";
            this.rvAluno.Location = new System.Drawing.Point(12, 12);
            this.rvAluno.Name = "rvAluno";
            this.rvAluno.ServerReport.BearerToken = null;
            this.rvAluno.Size = new System.Drawing.Size(916, 364);
            this.rvAluno.TabIndex = 0;
            // 
            // dbEducacaoDoFuturoDataSet
            // 
            this.dbEducacaoDoFuturoDataSet.DataSetName = "dbEducacaoDoFuturoDataSet";
            this.dbEducacaoDoFuturoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioAlunoBindingSource
            // 
            this.RelatorioAlunoBindingSource.DataMember = "RelatorioAluno";
            this.RelatorioAlunoBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // RelatorioAlunoTableAdapter
            // 
            this.RelatorioAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioAluno";
            this.Load += new System.EventHandler(this.frmRelatorioAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioAlunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAluno;
        private System.Windows.Forms.BindingSource RelatorioAlunoBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.RelatorioAlunoTableAdapter RelatorioAlunoTableAdapter;
    }
}