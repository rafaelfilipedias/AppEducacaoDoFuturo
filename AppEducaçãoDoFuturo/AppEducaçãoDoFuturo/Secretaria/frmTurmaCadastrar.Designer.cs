namespace AppEducaçãoDoFuturo
{
    partial class frmTurmaCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurmaCadastrar));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.lblNumAlunos = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(240, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 32);
            this.lblTitulo.TabIndex = 311;
            this.lblTitulo.Text = "Formulário de Cadastro";
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
            this.btnSalvar.Location = new System.Drawing.Point(42, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(167, 40);
            this.btnSalvar.TabIndex = 310;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodProf
            // 
            this.txtCodProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProf.Location = new System.Drawing.Point(233, 142);
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(191, 27);
            this.txtCodProf.TabIndex = 308;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProf.Location = new System.Drawing.Point(38, 144);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(195, 25);
            this.lblProf.TabIndex = 309;
            this.lblProf.Text = "Cód. do Professor:";
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlunos.Location = new System.Drawing.Point(246, 101);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.Size = new System.Drawing.Size(115, 27);
            this.txtNumAlunos.TabIndex = 307;
            this.txtNumAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAlunos_KeyPress);
            // 
            // lblNumAlunos
            // 
            this.lblNumAlunos.AutoSize = true;
            this.lblNumAlunos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlunos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumAlunos.Location = new System.Drawing.Point(38, 101);
            this.lblNumAlunos.Name = "lblNumAlunos";
            this.lblNumAlunos.Size = new System.Drawing.Size(208, 25);
            this.lblNumAlunos.TabIndex = 306;
            this.lblNumAlunos.Text = "Número de Alunos:";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPontos.Location = new System.Drawing.Point(40, 186);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(242, 25);
            this.lblPontos.TabIndex = 298;
            this.lblPontos.Text = "Distribuição de Pontos:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(113, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 27);
            this.txtNome.TabIndex = 296;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(37, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 25);
            this.lblNome.TabIndex = 297;
            this.lblNome.Text = "Nome:";
            // 
            // txtPontos
            // 
            this.txtPontos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontos.Location = new System.Drawing.Point(278, 184);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(115, 27);
            this.txtPontos.TabIndex = 312;
            // 
            // frmTurmaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 426);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCodProf);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.txtNumAlunos);
            this.Controls.Add(this.lblNumAlunos);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurmaCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTurmaCadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.Label lblNumAlunos;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPontos;
    }
}