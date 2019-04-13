namespace AppEducaçãoDoFuturo
{
    partial class frmManterAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterAluno));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnVerAlunos = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
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
            this.pnlMenu.Controls.Add(this.btnVerAlunos);
            this.pnlMenu.Controls.Add(this.btnExcluirAluno);
            this.pnlMenu.Controls.Add(this.btnEditarAluno);
            this.pnlMenu.Controls.Add(this.btnCadastrarAluno);
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
            // btnVerAlunos
            // 
            this.btnVerAlunos.FlatAppearance.BorderSize = 0;
            this.btnVerAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAlunos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAlunos.ForeColor = System.Drawing.Color.White;
            this.btnVerAlunos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerAlunos.Location = new System.Drawing.Point(4, 360);
            this.btnVerAlunos.Name = "btnVerAlunos";
            this.btnVerAlunos.Size = new System.Drawing.Size(183, 49);
            this.btnVerAlunos.TabIndex = 266;
            this.btnVerAlunos.Text = "Ver Alunos";
            this.btnVerAlunos.UseVisualStyleBackColor = true;
            this.btnVerAlunos.Click += new System.EventHandler(this.btnVerAlunos_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.FlatAppearance.BorderSize = 0;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.ForeColor = System.Drawing.Color.White;
            this.btnExcluirAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirAluno.Location = new System.Drawing.Point(3, 315);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(183, 49);
            this.btnExcluirAluno.TabIndex = 265;
            this.btnExcluirAluno.Text = "Excluir Aluno";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.FlatAppearance.BorderSize = 0;
            this.btnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.Color.White;
            this.btnEditarAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarAluno.Location = new System.Drawing.Point(4, 260);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(183, 49);
            this.btnEditarAluno.TabIndex = 264;
            this.btnEditarAluno.Text = "Editar Aluno";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarAluno.TabIndex = 263;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterAluno";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnVerAlunos;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}