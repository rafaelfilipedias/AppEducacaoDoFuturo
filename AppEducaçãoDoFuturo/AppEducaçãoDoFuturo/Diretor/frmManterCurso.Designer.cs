namespace AppEducaçãoDoFuturo
{
    partial class frmManterCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterCurso));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
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
            this.pnlMenu.Controls.Add(this.btnVerCursos);
            this.pnlMenu.Controls.Add(this.btnExcluirCurso);
            this.pnlMenu.Controls.Add(this.btnEditarCurso);
            this.pnlMenu.Controls.Add(this.btnCadastrarCurso);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Location = new System.Drawing.Point(10, 11);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(966, 496);
            this.pnlMenu.TabIndex = 1;
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
            // btnVerCursos
            // 
            this.btnVerCursos.FlatAppearance.BorderSize = 0;
            this.btnVerCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCursos.ForeColor = System.Drawing.Color.White;
            this.btnVerCursos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerCursos.Location = new System.Drawing.Point(4, 360);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(183, 49);
            this.btnVerCursos.TabIndex = 266;
            this.btnVerCursos.Text = "Ver Cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.FlatAppearance.BorderSize = 0;
            this.btnExcluirCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCurso.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirCurso.Location = new System.Drawing.Point(3, 315);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(183, 49);
            this.btnExcluirCurso.TabIndex = 265;
            this.btnExcluirCurso.Text = "Excluir Curso";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.FlatAppearance.BorderSize = 0;
            this.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEditarCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarCurso.Location = new System.Drawing.Point(3, 260);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(183, 49);
            this.btnEditarCurso.TabIndex = 264;
            this.btnEditarCurso.Text = "Editar Curso";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCurso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarCurso.TabIndex = 263;
            this.btnCadastrarCurso.Text = "Cadastrar Curso";
            this.btnCadastrarCurso.UseVisualStyleBackColor = true;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterCurso";
            this.Load += new System.EventHandler(this.frmManterCurso_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}