namespace AppEducaçãoDoFuturo
{
    partial class frmEditarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarNota));
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.txtProva2 = new System.Windows.Forms.TextBox();
            this.lblProva2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtProva1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalho.Location = new System.Drawing.Point(139, 153);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(209, 27);
            this.txtTrabalho.TabIndex = 325;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTrabalho.Location = new System.Drawing.Point(33, 153);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(107, 25);
            this.lblTrabalho.TabIndex = 324;
            this.lblTrabalho.Text = "Trabalho:";
            // 
            // txtProva2
            // 
            this.txtProva2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProva2.Location = new System.Drawing.Point(124, 108);
            this.txtProva2.Name = "txtProva2";
            this.txtProva2.Size = new System.Drawing.Size(209, 27);
            this.txtProva2.TabIndex = 323;
            // 
            // lblProva2
            // 
            this.lblProva2.AutoSize = true;
            this.lblProva2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProva2.Location = new System.Drawing.Point(33, 110);
            this.lblProva2.Name = "lblProva2";
            this.lblProva2.Size = new System.Drawing.Size(94, 25);
            this.lblProva2.TabIndex = 322;
            this.lblProva2.Text = "Prova 2:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(303, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 32);
            this.lblTitulo.TabIndex = 321;
            this.lblTitulo.Text = "Editar Nota";
            // 
            // txtProva1
            // 
            this.txtProva1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProva1.Location = new System.Drawing.Point(124, 63);
            this.txtProva1.Name = "txtProva1";
            this.txtProva1.Size = new System.Drawing.Size(209, 27);
            this.txtProva1.TabIndex = 319;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNota1.Location = new System.Drawing.Point(33, 65);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(94, 25);
            this.lblNota1.TabIndex = 318;
            this.lblNota1.Text = "Prova 1:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(467, 194);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(195, 27);
            this.txtBusca.TabIndex = 337;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusca.Location = new System.Drawing.Point(377, 196);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(86, 25);
            this.lblBusca.TabIndex = 338;
            this.lblBusca.Text = "Buscar:";
            // 
            // dgvNota
            // 
            this.dgvNota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(38, 227);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.Size = new System.Drawing.Size(659, 123);
            this.dgvNota.TabIndex = 336;
            this.dgvNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNota_CellContentClick);
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
            this.btnEditar.Location = new System.Drawing.Point(52, 371);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 40);
            this.btnEditar.TabIndex = 335;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 508);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.txtProva2);
            this.Controls.Add(this.lblProva2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtProva1);
            this.Controls.Add(this.lblNota1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarNota";
            this.Load += new System.EventHandler(this.frmEditarNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.Label lblTrabalho;
        private System.Windows.Forms.TextBox txtProva2;
        private System.Windows.Forms.Label lblProva2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtProva1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.Button btnEditar;
    }
}