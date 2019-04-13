namespace AppEducaçãoDoFuturo
{
    partial class frmManterFrequenciaAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterFrequenciaAluno));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVerFrequenciaProf = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlMostrar = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(249)))));
            this.pnlMenu.Controls.Add(this.btnVerFrequenciaProf);
            this.pnlMenu.Controls.Add(this.btnVoltar);
            this.pnlMenu.Controls.Add(this.picMenu);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Location = new System.Drawing.Point(10, 11);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(966, 496);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnVerFrequenciaProf
            // 
            this.btnVerFrequenciaProf.FlatAppearance.BorderSize = 0;
            this.btnVerFrequenciaProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFrequenciaProf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFrequenciaProf.ForeColor = System.Drawing.Color.White;
            this.btnVerFrequenciaProf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerFrequenciaProf.Location = new System.Drawing.Point(4, 270);
            this.btnVerFrequenciaProf.Name = "btnVerFrequenciaProf";
            this.btnVerFrequenciaProf.Size = new System.Drawing.Size(183, 49);
            this.btnVerFrequenciaProf.TabIndex = 269;
            this.btnVerFrequenciaProf.Text = "Ver Frequência";
            this.btnVerFrequenciaProf.UseVisualStyleBackColor = true;
            this.btnVerFrequenciaProf.Click += new System.EventHandler(this.btnVerFrequenciaProf_Click);
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
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrar.TabIndex = 263;
            this.btnCadastrar.Text = "Inserir Frequência ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterFrequenciaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterFrequenciaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterFrequenciaAluno";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVerFrequenciaProf;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlMostrar;
    }
}