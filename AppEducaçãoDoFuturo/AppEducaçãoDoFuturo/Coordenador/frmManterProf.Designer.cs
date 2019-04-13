namespace AppEducaçãoDoFuturo
{
    partial class frmManterProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterProf));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnVerProf = new System.Windows.Forms.Button();
            this.btnExcluirProf = new System.Windows.Forms.Button();
            this.btnEditarProf = new System.Windows.Forms.Button();
            this.btnCadastrarProf = new System.Windows.Forms.Button();
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
            this.pnlMenu.Controls.Add(this.btnVerProf);
            this.pnlMenu.Controls.Add(this.btnExcluirProf);
            this.pnlMenu.Controls.Add(this.btnEditarProf);
            this.pnlMenu.Controls.Add(this.btnCadastrarProf);
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
            // btnVerProf
            // 
            this.btnVerProf.FlatAppearance.BorderSize = 0;
            this.btnVerProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProf.ForeColor = System.Drawing.Color.White;
            this.btnVerProf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerProf.Location = new System.Drawing.Point(4, 367);
            this.btnVerProf.Name = "btnVerProf";
            this.btnVerProf.Size = new System.Drawing.Size(183, 49);
            this.btnVerProf.TabIndex = 266;
            this.btnVerProf.Text = "Ver Professores";
            this.btnVerProf.UseVisualStyleBackColor = true;
            this.btnVerProf.Click += new System.EventHandler(this.btnVerProf_Click);
            // 
            // btnExcluirProf
            // 
            this.btnExcluirProf.FlatAppearance.BorderSize = 0;
            this.btnExcluirProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProf.ForeColor = System.Drawing.Color.White;
            this.btnExcluirProf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirProf.Location = new System.Drawing.Point(3, 317);
            this.btnExcluirProf.Name = "btnExcluirProf";
            this.btnExcluirProf.Size = new System.Drawing.Size(183, 49);
            this.btnExcluirProf.TabIndex = 265;
            this.btnExcluirProf.Text = "Excluir Professor";
            this.btnExcluirProf.UseVisualStyleBackColor = true;
            this.btnExcluirProf.Click += new System.EventHandler(this.btnExcluirProf_Click);
            // 
            // btnEditarProf
            // 
            this.btnEditarProf.FlatAppearance.BorderSize = 0;
            this.btnEditarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProf.ForeColor = System.Drawing.Color.White;
            this.btnEditarProf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarProf.Location = new System.Drawing.Point(5, 270);
            this.btnEditarProf.Name = "btnEditarProf";
            this.btnEditarProf.Size = new System.Drawing.Size(183, 49);
            this.btnEditarProf.TabIndex = 264;
            this.btnEditarProf.Text = "Editar Professor";
            this.btnEditarProf.UseVisualStyleBackColor = true;
            this.btnEditarProf.Click += new System.EventHandler(this.btnEditarProf_Click);
            // 
            // btnCadastrarProf
            // 
            this.btnCadastrarProf.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProf.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarProf.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrarProf.Name = "btnCadastrarProf";
            this.btnCadastrarProf.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarProf.TabIndex = 263;
            this.btnCadastrarProf.Text = "Cadastrar Professor";
            this.btnCadastrarProf.UseVisualStyleBackColor = true;
            this.btnCadastrarProf.Click += new System.EventHandler(this.btnCadastrarProf_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterProf";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnVerProf;
        private System.Windows.Forms.Button btnExcluirProf;
        private System.Windows.Forms.Button btnEditarProf;
        private System.Windows.Forms.Button btnCadastrarProf;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}