namespace AppEducaçãoDoFuturo
{
    partial class frmExcluirCoordenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluirCoordenador));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.picBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvCoordenador = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(53, 401);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 40);
            this.btnExcluir.TabIndex = 313;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // picBusca
            // 
            this.picBusca.Image = ((System.Drawing.Image)(resources.GetObject("picBusca.Image")));
            this.picBusca.Location = new System.Drawing.Point(398, 188);
            this.picBusca.Name = "picBusca";
            this.picBusca.Size = new System.Drawing.Size(33, 28);
            this.picBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBusca.TabIndex = 312;
            this.picBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(437, 188);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(221, 27);
            this.txtBusca.TabIndex = 311;
            this.txtBusca.Text = "Busque pelo código ou cpf";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // dgvCoordenador
            // 
            this.dgvCoordenador.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.dgvCoordenador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordenador.Location = new System.Drawing.Point(53, 227);
            this.dgvCoordenador.Name = "dgvCoordenador";
            this.dgvCoordenador.Size = new System.Drawing.Size(605, 123);
            this.dgvCoordenador.TabIndex = 310;
            this.dgvCoordenador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoordenador_CellContentClick);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(288, 101);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(222, 27);
            this.txtCod.TabIndex = 308;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCod.Location = new System.Drawing.Point(48, 103);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(243, 25);
            this.lblCod.TabIndex = 309;
            this.lblCod.Text = "Cód. do Coordenador:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(225, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(317, 32);
            this.lblTitulo.TabIndex = 307;
            this.lblTitulo.Text = "Formulário de Exclusão";
            // 
            // frmExcluirCoordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 592);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.picBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvCoordenador);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcluirCoordenador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExcluirCoordenador";
            this.Load += new System.EventHandler(this.frmExcluirCoordenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordenador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox picBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvCoordenador;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTitulo;
    }
}