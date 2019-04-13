namespace AppEducaçãoDoFuturo
{
    partial class frmEditarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarTurma));
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPontos = new System.Windows.Forms.TextBox();
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.txtNumAlunos = new System.Windows.Forms.TextBox();
            this.lblNumAlunos = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurma
            // 
            this.dgvTurma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(58, 269);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(605, 123);
            this.dgvTurma.TabIndex = 324;
            this.dgvTurma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(58, 409);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 40);
            this.btnEditar.TabIndex = 323;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(234, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 32);
            this.lblTitulo.TabIndex = 322;
            this.lblTitulo.Text = "Formulário de Edição";
            // 
            // txtPontos
            // 
            this.txtPontos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontos.Location = new System.Drawing.Point(307, 187);
            this.txtPontos.Name = "txtPontos";
            this.txtPontos.Size = new System.Drawing.Size(115, 27);
            this.txtPontos.TabIndex = 332;
            // 
            // txtCodProf
            // 
            this.txtCodProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProf.Location = new System.Drawing.Point(255, 145);
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(299, 27);
            this.txtCodProf.TabIndex = 330;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProf.Location = new System.Drawing.Point(60, 147);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(195, 25);
            this.lblProf.TabIndex = 331;
            this.lblProf.Text = "Cód. do Professor:";
            // 
            // txtNumAlunos
            // 
            this.txtNumAlunos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAlunos.Location = new System.Drawing.Point(268, 104);
            this.txtNumAlunos.Name = "txtNumAlunos";
            this.txtNumAlunos.Size = new System.Drawing.Size(115, 27);
            this.txtNumAlunos.TabIndex = 329;
            // 
            // lblNumAlunos
            // 
            this.lblNumAlunos.AutoSize = true;
            this.lblNumAlunos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAlunos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumAlunos.Location = new System.Drawing.Point(60, 104);
            this.lblNumAlunos.Name = "lblNumAlunos";
            this.lblNumAlunos.Size = new System.Drawing.Size(208, 25);
            this.lblNumAlunos.TabIndex = 328;
            this.lblNumAlunos.Text = "Número de Alunos:";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPontos.Location = new System.Drawing.Point(62, 189);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(242, 25);
            this.lblPontos.TabIndex = 327;
            this.lblPontos.Text = "Distribuição de Pontos:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(135, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(278, 27);
            this.txtNome.TabIndex = 325;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(59, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 25);
            this.lblNome.TabIndex = 326;
            this.lblNome.Text = "Nome:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(468, 236);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(195, 27);
            this.txtBusca.TabIndex = 333;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusca.Location = new System.Drawing.Point(378, 238);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(86, 25);
            this.lblBusca.TabIndex = 334;
            this.lblBusca.Text = "Buscar:";
            // 
            // frmEditarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.txtPontos);
            this.Controls.Add(this.txtCodProf);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.txtNumAlunos);
            this.Controls.Add(this.lblNumAlunos);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarTurma";
            this.Load += new System.EventHandler(this.frmEditarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPontos;
        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.TextBox txtNumAlunos;
        private System.Windows.Forms.Label lblNumAlunos;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBusca;
    }
}