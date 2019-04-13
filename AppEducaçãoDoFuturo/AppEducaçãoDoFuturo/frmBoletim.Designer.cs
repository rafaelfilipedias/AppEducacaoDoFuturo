namespace AppEducaçãoDoFuturo
{
    partial class frmBoletim
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
            this.rvBoletim = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbEducacaoDoFuturoDataSet = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSet();
            this.BoletimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BoletimTableAdapter = new AppEducaçãoDoFuturo.dbEducacaoDoFuturoDataSetTableAdapters.BoletimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoletimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvBoletim
            // 
            reportDataSource1.Name = "DataSetDBEducacaoDoFuturo";
            reportDataSource1.Value = this.BoletimBindingSource;
            this.rvBoletim.LocalReport.DataSources.Add(reportDataSource1);
            this.rvBoletim.LocalReport.ReportEmbeddedResource = "AppEducaçãoDoFuturo.ReportBoletim.rdlc";
            this.rvBoletim.Location = new System.Drawing.Point(12, 12);
            this.rvBoletim.Name = "rvBoletim";
            this.rvBoletim.ServerReport.BearerToken = null;
            this.rvBoletim.Size = new System.Drawing.Size(916, 364);
            this.rvBoletim.TabIndex = 0;
            // 
            // dbEducacaoDoFuturoDataSet
            // 
            this.dbEducacaoDoFuturoDataSet.DataSetName = "dbEducacaoDoFuturoDataSet";
            this.dbEducacaoDoFuturoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BoletimBindingSource
            // 
            this.BoletimBindingSource.DataMember = "Boletim";
            this.BoletimBindingSource.DataSource = this.dbEducacaoDoFuturoDataSet;
            // 
            // BoletimTableAdapter
            // 
            this.BoletimTableAdapter.ClearBeforeFill = true;
            // 
            // frmBoletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(940, 388);
            this.Controls.Add(this.rvBoletim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoletim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBoletim";
            this.Load += new System.EventHandler(this.frmBoletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbEducacaoDoFuturoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoletimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvBoletim;
        private System.Windows.Forms.BindingSource BoletimBindingSource;
        private dbEducacaoDoFuturoDataSet dbEducacaoDoFuturoDataSet;
        private dbEducacaoDoFuturoDataSetTableAdapters.BoletimTableAdapter BoletimTableAdapter;
    }
}