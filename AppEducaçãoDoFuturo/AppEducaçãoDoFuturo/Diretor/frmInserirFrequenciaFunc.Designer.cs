namespace AppEducaçãoDoFuturo
{
    partial class frmInserirFrequenciaFunc
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
            this.mskDataAtestado = new System.Windows.Forms.MaskedTextBox();
            this.lblAtestado = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(236, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 32);
            this.lblTitulo.TabIndex = 305;
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
            this.btnSalvaar.Location = new System.Drawing.Point(38, 365);
            this.btnSalvaar.Name = "btnSalvaar";
            this.btnSalvaar.Size = new System.Drawing.Size(167, 40);
            this.btnSalvaar.TabIndex = 304;
            this.btnSalvaar.Text = "Salvar";
            this.btnSalvaar.UseVisualStyleBackColor = false;
            this.btnSalvaar.Click += new System.EventHandler(this.btnSalvaar_Click);
            // 
            // mskDataAtestado
            // 
            this.mskDataAtestado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataAtestado.Location = new System.Drawing.Point(225, 124);
            this.mskDataAtestado.Mask = "99/99/9999";
            this.mskDataAtestado.Name = "mskDataAtestado";
            this.mskDataAtestado.Size = new System.Drawing.Size(96, 26);
            this.mskDataAtestado.TabIndex = 316;
            // 
            // lblAtestado
            // 
            this.lblAtestado.AutoSize = true;
            this.lblAtestado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtestado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtestado.Location = new System.Drawing.Point(32, 123);
            this.lblAtestado.Name = "lblAtestado";
            this.lblAtestado.Size = new System.Drawing.Size(197, 25);
            this.lblAtestado.TabIndex = 315;
            this.lblAtestado.Text = "Data do Atestado:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(252, 64);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(201, 27);
            this.txtCod.TabIndex = 313;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(33, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(225, 25);
            this.lblNome.TabIndex = 314;
            this.lblNome.Text = "Cód. do Funcionário:";
            // 
            // frmInserirFrequenciaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.mskDataAtestado);
            this.Controls.Add(this.lblAtestado);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvaar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirFrequenciaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInserirFrequenciaFunc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvaar;
        private System.Windows.Forms.MaskedTextBox mskDataAtestado;
        private System.Windows.Forms.Label lblAtestado;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNome;
    }
}