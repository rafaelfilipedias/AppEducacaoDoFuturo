namespace AppEducaçãoDoFuturo
{
    partial class frmInserirFrequenciaAluno
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvaar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(235, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 32);
            this.lblTitulo.TabIndex = 311;
            this.lblTitulo.Text = "Inserir Frequência";
            // 
            // btnSalvaar
            // 
            this.btnSalvaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.btnSalvaar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnSalvaar.FlatAppearance.BorderSize = 0;
            this.btnSalvaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvaar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvaar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvaar.Location = new System.Drawing.Point(37, 365);
            this.btnSalvaar.Name = "btnSalvaar";
            this.btnSalvaar.Size = new System.Drawing.Size(167, 40);
            this.btnSalvaar.TabIndex = 310;
            this.btnSalvaar.Text = "Salvar";
            this.btnSalvaar.UseVisualStyleBackColor = false;
            this.btnSalvaar.Click += new System.EventHandler(this.btnSalvaar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(200, 65);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(299, 27);
            this.txtCod.TabIndex = 313;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 314;
            this.label1.Text = "Cód. do Aluno:";
            // 
            // frmInserirFrequenciaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvaar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirFrequenciaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInserirFrequenciaAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvaar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
    }
}