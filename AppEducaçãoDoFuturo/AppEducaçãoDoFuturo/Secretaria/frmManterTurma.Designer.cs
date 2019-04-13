namespace AppEducaçãoDoFuturo
{
    partial class frmManterTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterTurma));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnVerTurma = new System.Windows.Forms.Button();
            this.btnExcluirTurma = new System.Windows.Forms.Button();
            this.btnEditarTurma = new System.Windows.Forms.Button();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(249)))));
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.picMenu);
            this.pnlMenu.Controls.Add(this.btnVerTurma);
            this.pnlMenu.Controls.Add(this.btnExcluirTurma);
            this.pnlMenu.Controls.Add(this.btnEditarTurma);
            this.pnlMenu.Controls.Add(this.btnCadastrarTurma);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Location = new System.Drawing.Point(10, 11);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(966, 496);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(249)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 28);
            this.btnVoltar.TabIndex = 268;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(13, 37);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(162, 126);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMenu.TabIndex = 267;
            this.picMenu.TabStop = false;
            // 
            // btnVerTurma
            // 
            this.btnVerTurma.FlatAppearance.BorderSize = 0;
            this.btnVerTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTurma.ForeColor = System.Drawing.Color.White;
            this.btnVerTurma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerTurma.Location = new System.Drawing.Point(4, 360);
            this.btnVerTurma.Name = "btnVerTurma";
            this.btnVerTurma.Size = new System.Drawing.Size(183, 49);
            this.btnVerTurma.TabIndex = 266;
            this.btnVerTurma.Text = "Ver Turmas";
            this.btnVerTurma.UseVisualStyleBackColor = true;
            this.btnVerTurma.Click += new System.EventHandler(this.btnVerTurma_Click);
            // 
            // btnExcluirTurma
            // 
            this.btnExcluirTurma.FlatAppearance.BorderSize = 0;
            this.btnExcluirTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTurma.ForeColor = System.Drawing.Color.White;
            this.btnExcluirTurma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirTurma.Location = new System.Drawing.Point(3, 315);
            this.btnExcluirTurma.Name = "btnExcluirTurma";
            this.btnExcluirTurma.Size = new System.Drawing.Size(183, 49);
            this.btnExcluirTurma.TabIndex = 265;
            this.btnExcluirTurma.Text = "Excluir Turma";
            this.btnExcluirTurma.UseVisualStyleBackColor = true;
            this.btnExcluirTurma.Click += new System.EventHandler(this.btnExcluirTurma_Click);
            // 
            // btnEditarTurma
            // 
            this.btnEditarTurma.FlatAppearance.BorderSize = 0;
            this.btnEditarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurma.ForeColor = System.Drawing.Color.White;
            this.btnEditarTurma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarTurma.Location = new System.Drawing.Point(4, 260);
            this.btnEditarTurma.Name = "btnEditarTurma";
            this.btnEditarTurma.Size = new System.Drawing.Size(183, 49);
            this.btnEditarTurma.TabIndex = 264;
            this.btnEditarTurma.Text = "Editar Turma";
            this.btnEditarTurma.UseVisualStyleBackColor = true;
            this.btnEditarTurma.Click += new System.EventHandler(this.btnEditarTurma_Click);
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.FlatAppearance.BorderSize = 0;
            this.btnCadastrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTurma.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarTurma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarTurma.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarTurma.TabIndex = 263;
            this.btnCadastrarTurma.Text = "Cadastrar Turma";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterTurma";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnVerTurma;
        private System.Windows.Forms.Button btnExcluirTurma;
        private System.Windows.Forms.Button btnEditarTurma;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}