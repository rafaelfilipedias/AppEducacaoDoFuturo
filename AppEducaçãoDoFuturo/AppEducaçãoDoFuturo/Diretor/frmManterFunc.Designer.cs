namespace AppEducaçãoDoFuturo
{
    partial class frmManterFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManterFunc));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.btnVerFunc = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
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
            this.pnlMenu.Controls.Add(this.btnVerFunc);
            this.pnlMenu.Controls.Add(this.btnExcluirFunc);
            this.pnlMenu.Controls.Add(this.btnEditarFunc);
            this.pnlMenu.Controls.Add(this.btnCadastrarFunc);
            this.pnlMenu.Controls.Add(this.pnlMostrar);
            this.pnlMenu.Location = new System.Drawing.Point(9, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(966, 496);
            this.pnlMenu.TabIndex = 0;
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
            // btnVerFunc
            // 
            this.btnVerFunc.FlatAppearance.BorderSize = 0;
            this.btnVerFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFunc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFunc.ForeColor = System.Drawing.Color.White;
            this.btnVerFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerFunc.Location = new System.Drawing.Point(4, 360);
            this.btnVerFunc.Name = "btnVerFunc";
            this.btnVerFunc.Size = new System.Drawing.Size(183, 49);
            this.btnVerFunc.TabIndex = 266;
            this.btnVerFunc.Text = "Ver Funcionários";
            this.btnVerFunc.UseVisualStyleBackColor = true;
            this.btnVerFunc.Click += new System.EventHandler(this.btnVerFunc_Click);
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirFunc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFunc.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExcluirFunc.Location = new System.Drawing.Point(3, 315);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(183, 49);
            this.btnExcluirFunc.TabIndex = 265;
            this.btnExcluirFunc.Text = "Excluir Funcionário";
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.FlatAppearance.BorderSize = 0;
            this.btnEditarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarFunc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarFunc.ForeColor = System.Drawing.Color.White;
            this.btnEditarFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditarFunc.Location = new System.Drawing.Point(5, 270);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(183, 49);
            this.btnEditarFunc.TabIndex = 264;
            this.btnEditarFunc.Text = "Editar Funcionário";
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(4, 210);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(183, 54);
            this.btnCadastrarFunc.TabIndex = 263;
            this.btnCadastrarFunc.Text = "Cadastrar Funcionário";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // pnlMostrar
            // 
            this.pnlMostrar.Location = new System.Drawing.Point(188, 0);
            this.pnlMostrar.Name = "pnlMostrar";
            this.pnlMostrar.Size = new System.Drawing.Size(777, 495);
            this.pnlMostrar.TabIndex = 0;
            // 
            // frmManterFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManterFunc";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMostrar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnVerFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnEditarFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Button btnVoltar;
    }
}