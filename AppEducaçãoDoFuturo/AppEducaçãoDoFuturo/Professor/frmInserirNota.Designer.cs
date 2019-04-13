namespace AppEducaçãoDoFuturo
{
    partial class frmInserirNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserirNota));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtProva1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtProva2 = new System.Windows.Forms.TextBox();
            this.lblProva2 = new System.Windows.Forms.Label();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(304, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 32);
            this.lblTitulo.TabIndex = 309;
            this.lblTitulo.Text = "Inserir Nota";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(41, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 40);
            this.btnSalvar.TabIndex = 308;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtProva1
            // 
            this.txtProva1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProva1.Location = new System.Drawing.Point(129, 113);
            this.txtProva1.Name = "txtProva1";
            this.txtProva1.Size = new System.Drawing.Size(126, 27);
            this.txtProva1.TabIndex = 307;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNota1.Location = new System.Drawing.Point(38, 115);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(94, 25);
            this.lblNota1.TabIndex = 306;
            this.lblNota1.Text = "Prova 1:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(207, 69);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(167, 27);
            this.txtCod.TabIndex = 298;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(40, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(166, 25);
            this.lblNome.TabIndex = 299;
            this.lblNome.Text = "Cód. do Aluno:";
            // 
            // txtProva2
            // 
            this.txtProva2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProva2.Location = new System.Drawing.Point(129, 158);
            this.txtProva2.Name = "txtProva2";
            this.txtProva2.Size = new System.Drawing.Size(126, 27);
            this.txtProva2.TabIndex = 313;
            // 
            // lblProva2
            // 
            this.lblProva2.AutoSize = true;
            this.lblProva2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProva2.Location = new System.Drawing.Point(38, 160);
            this.lblProva2.Name = "lblProva2";
            this.lblProva2.Size = new System.Drawing.Size(94, 25);
            this.lblProva2.TabIndex = 312;
            this.lblProva2.Text = "Prova 2:";
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalho.Location = new System.Drawing.Point(144, 203);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(121, 27);
            this.txtTrabalho.TabIndex = 315;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTrabalho.Location = new System.Drawing.Point(38, 203);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(107, 25);
            this.lblTrabalho.TabIndex = 314;
            this.lblTrabalho.Text = "Trabalho:";
            // 
            // frmInserirNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.txtProva2);
            this.Controls.Add(this.lblProva2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtProva1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInserirNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInserirNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtProva1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtProva2;
        private System.Windows.Forms.Label lblProva2;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label lblTrabalho;
    }
}