namespace AppEducaçãoDoFuturo
{
    partial class frmFrequenciaProfessor
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
            this.rvProfessor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.RelatorioProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioProfesorTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.RelatorioProfesorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioProfesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvProfessor
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.RelatorioProfesorBindingSource;
            this.rvProfessor.LocalReport.DataSources.Add(reportDataSource1);
            this.rvProfessor.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportProfessor.rdlc";
            this.rvProfessor.Location = new System.Drawing.Point(12, 12);
            this.rvProfessor.Name = "rvProfessor";
            this.rvProfessor.ServerReport.BearerToken = null;
            this.rvProfessor.Size = new System.Drawing.Size(916, 364);
            this.rvProfessor.TabIndex = 0;
            // 
            // dbEducacaoDoFuturoDataSet
            // 
            this.dbEducacaoDoFuturoDataSet.DataSetName = "dbEducacaoDoFuturoDataSet";
            this.dbEducacaoDoFuturoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioProfesorBindingSource
            // 
            this.RelatorioProfesorBindingSource.DataMember = "RelatorioProfesor";
            this.RelatorioProfesorBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // RelatorioProfesorTableAdapter
            // 
            this.RelatorioProfesorTableAdapter.ClearBeforeFill = true;
            // 
            // frmFrequenciaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvProfessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFrequenciaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFrequenciaProfessor";
            this.Load += new System.EventHandler(this.frmFrequenciaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioProfesorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProfessor;
        private System.Windows.Forms.BindingSource RelatorioProfesorBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.RelatorioProfesorTableAdapter RelatorioProfesorTableAdapter;
    }
}