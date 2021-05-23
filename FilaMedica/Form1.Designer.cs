namespace FilaMedica
{
    partial class Background
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraTopo = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.lblTituloAdd = new System.Windows.Forms.Label();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.lblAtend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listPref = new System.Windows.Forms.ListBox();
            this.listNormal = new System.Windows.Forms.ListBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.BarraTopo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTopo
            // 
            this.BarraTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTopo.Controls.Add(this.iconPictureBox1);
            this.BarraTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTopo.Location = new System.Drawing.Point(0, 0);
            this.BarraTopo.Name = "BarraTopo";
            this.BarraTopo.Size = new System.Drawing.Size(1447, 61);
            this.BarraTopo.TabIndex = 0;
            this.BarraTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTopo_MouseDown);
            // 
            // labelNome
            // 
            this.labelNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelNome.Font = new System.Drawing.Font("Georgia", 13F);
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelNome.Location = new System.Drawing.Point(16, 65);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(104, 47);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRg
            // 
            this.labelRg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelRg.Font = new System.Drawing.Font("Georgia", 13F);
            this.labelRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelRg.Location = new System.Drawing.Point(21, 123);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(99, 50);
            this.labelRg.TabIndex = 5;
            this.labelRg.Text = "Rg:";
            this.labelRg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdade
            // 
            this.labelIdade.BackColor = System.Drawing.Color.Transparent;
            this.labelIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelIdade.Font = new System.Drawing.Font("Georgia", 13F);
            this.labelIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelIdade.Location = new System.Drawing.Point(16, 186);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(109, 50);
            this.labelIdade.TabIndex = 6;
            this.labelIdade.Text = "Idade:";
            this.labelIdade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 65);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 46);
            this.txtNome.TabIndex = 7;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(150, 123);
            this.txtRg.Multiline = true;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(256, 50);
            this.txtRg.TabIndex = 8;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(150, 186);
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(256, 50);
            this.txtIdade.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.lblTituloAdd);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Controls.Add(this.labelRg);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.labelIdade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 333);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdicionar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionar.IconSize = 40;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(150, 251);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(115, 56);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // lblTituloAdd
            // 
            this.lblTituloAdd.AutoSize = true;
            this.lblTituloAdd.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTituloAdd.Location = new System.Drawing.Point(121, -3);
            this.lblTituloAdd.Name = "lblTituloAdd";
            this.lblTituloAdd.Size = new System.Drawing.Size(268, 29);
            this.lblTituloAdd.TabIndex = 10;
            this.lblTituloAdd.Text = "Adicionar Pacientes:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnRemove.IconColor = System.Drawing.Color.Transparent;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 40;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(162, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(223, 80);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Atender";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // lblAtend
            // 
            this.lblAtend.BackColor = System.Drawing.Color.White;
            this.lblAtend.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblAtend.ForeColor = System.Drawing.Color.Blue;
            this.lblAtend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAtend.Location = new System.Drawing.Point(586, 104);
            this.lblAtend.Name = "lblAtend";
            this.lblAtend.Size = new System.Drawing.Size(829, 105);
            this.lblAtend.TabIndex = 12;
            this.lblAtend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(588, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 38);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fila Preferencial:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1054, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 38);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fila Normal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listPref
            // 
            this.listPref.BackColor = System.Drawing.Color.White;
            this.listPref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPref.Font = new System.Drawing.Font("Georgia", 17F);
            this.listPref.ForeColor = System.Drawing.Color.Black;
            this.listPref.FormattingEnabled = true;
            this.listPref.ItemHeight = 32;
            this.listPref.Location = new System.Drawing.Point(592, 322);
            this.listPref.Name = "listPref";
            this.listPref.Size = new System.Drawing.Size(361, 354);
            this.listPref.TabIndex = 17;
            // 
            // listNormal
            // 
            this.listNormal.BackColor = System.Drawing.Color.White;
            this.listNormal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listNormal.Font = new System.Drawing.Font("Georgia", 17F);
            this.listNormal.ForeColor = System.Drawing.Color.Black;
            this.listNormal.FormattingEnabled = true;
            this.listNormal.ItemHeight = 32;
            this.listNormal.Location = new System.Drawing.Point(1054, 322);
            this.listNormal.Name = "listNormal";
            this.listNormal.Size = new System.Drawing.Size(361, 354);
            this.listNormal.TabIndex = 18;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 40;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.Location = new System.Drawing.Point(293, 251);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 56);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 46;
            this.iconPictureBox1.Location = new System.Drawing.Point(1396, 11);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(52, 46);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 688);
            this.Controls.Add(this.listNormal);
            this.Controls.Add(this.listPref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAtend);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BarraTopo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Background";
            this.Text = "Form1";
            this.BarraTopo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTopo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private System.Windows.Forms.Label lblTituloAdd;
        private FontAwesome.Sharp.IconButton btnRemove;
        private System.Windows.Forms.Label lblAtend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPref;
        private System.Windows.Forms.ListBox listNormal;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

