namespace AppEducaçãoDoFuturo
{
    partial class frmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCurso));
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.txtPlanoAula = new System.Windows.Forms.TextBox();
            this.lblPlanoAula = new System.Windows.Forms.Label();
            this.txtPLanoCurso = new System.Windows.Forms.TextBox();
            this.lblPlanoCurso = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.picBusca = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurso
            // 
            this.dgvCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(36, 296);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(675, 123);
            this.dgvCurso.TabIndex = 313;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(172)))), ((int)(((byte)(250)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(49, 425);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(167, 40);
            this.btnEditar.TabIndex = 312;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(230, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 32);
            this.lblTitulo.TabIndex = 311;
            this.lblTitulo.Text = "Formulário de Edição";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(259, 158);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(299, 27);
            this.txtConteudo.TabIndex = 320;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConteudo.Location = new System.Drawing.Point(44, 160);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(216, 25);
            this.lblConteudo.TabIndex = 321;
            this.lblConteudo.Text = "Conteúdo do Curso:";
            // 
            // txtPlanoAula
            // 
            this.txtPlanoAula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanoAula.Location = new System.Drawing.Point(200, 113);
            this.txtPlanoAula.Name = "txtPlanoAula";
            this.txtPlanoAula.Size = new System.Drawing.Size(299, 27);
            this.txtPlanoAula.TabIndex = 319;
            // 
            // lblPlanoAula
            // 
            this.lblPlanoAula.AutoSize = true;
            this.lblPlanoAula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanoAula.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlanoAula.Location = new System.Drawing.Point(41, 113);
            this.lblPlanoAula.Name = "lblPlanoAula";
            this.lblPlanoAula.Size = new System.Drawing.Size(162, 25);
            this.lblPlanoAula.TabIndex = 318;
            this.lblPlanoAula.Text = "Plano de Aula:";
            // 
            // txtPLanoCurso
            // 
            this.txtPLanoCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPLanoCurso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPLanoCurso.Location = new System.Drawing.Point(212, 213);
            this.txtPLanoCurso.Name = "txtPLanoCurso";
            this.txtPLanoCurso.Size = new System.Drawing.Size(337, 27);
            this.txtPLanoCurso.TabIndex = 317;
            // 
            // lblPlanoCurso
            // 
            this.lblPlanoCurso.AutoSize = true;
            this.lblPlanoCurso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanoCurso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlanoCurso.Location = new System.Drawing.Point(44, 213);
            this.lblPlanoCurso.Name = "lblPlanoCurso";
            this.lblPlanoCurso.Size = new System.Drawing.Size(172, 25);
            this.lblPlanoCurso.TabIndex = 316;
            this.lblPlanoCurso.Text = "Plano de Curso:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(116, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 27);
            this.txtNome.TabIndex = 314;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNome.Location = new System.Drawing.Point(40, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 25);
            this.lblNome.TabIndex = 315;
            this.lblNome.Text = "Nome:";
            // 
            // picBusca
            // 
            this.picBusca.Image = ((System.Drawing.Image)(resources.GetObject("picBusca.Image")));
            this.picBusca.Location = new System.Drawing.Point(451, 263);
            this.picBusca.Name = "picBusca";
            this.picBusca.Size = new System.Drawing.Size(33, 28);
            this.picBusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBusca.TabIndex = 328;
            this.picBusca.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBusca.Location = new System.Drawing.Point(490, 263);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(221, 27);
            this.txtBusca.TabIndex = 327;
            this.txtBusca.Text = "Busque pelo código ou cpf";
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.Enter += new System.EventHandler(this.txtBusca_Enter);
            // 
            // frmEditarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(154)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(758, 592);
            this.Controls.Add(this.picBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtPlanoAula);
            this.Controls.Add(this.lblPlanoAula);
            this.Controls.Add(this.txtPLanoCurso);
            this.Controls.Add(this.lblPlanoCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvCurso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarCurso";
            this.Load += new System.EventHandler(this.frmEditarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.TextBox txtPlanoAula;
        private System.Windows.Forms.Label lblPlanoAula;
        private System.Windows.Forms.TextBox txtPLanoCurso;
        private System.Windows.Forms.Label lblPlanoCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picBusca;
        private System.Windows.Forms.TextBox txtBusca;
    }
}