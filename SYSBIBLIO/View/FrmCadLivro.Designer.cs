
namespace SYSBIBLIO.View
{
    partial class FrmCadLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadLivro));
            this.btn_ListLivro = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnHomeP = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dt_DataP = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txbQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQunt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbEdicao = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbSinopse = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txbNomeL = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCadL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCad = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ListLivro
            // 
            this.btn_ListLivro.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_ListLivro.BorderRadius = 6;
            this.btn_ListLivro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ListLivro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ListLivro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ListLivro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ListLivro.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_ListLivro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListLivro.ForeColor = System.Drawing.Color.White;
            this.btn_ListLivro.Image = ((System.Drawing.Image)(resources.GetObject("btn_ListLivro.Image")));
            this.btn_ListLivro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ListLivro.Location = new System.Drawing.Point(12, 108);
            this.btn_ListLivro.Name = "btn_ListLivro";
            this.btn_ListLivro.Size = new System.Drawing.Size(227, 45);
            this.btn_ListLivro.TabIndex = 26;
            this.btn_ListLivro.Text = "Listar Livro";
            this.btn_ListLivro.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(83, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(85, 26);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Opções";
            // 
            // btnHomeP
            // 
            this.btnHomeP.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnHomeP.BorderRadius = 6;
            this.btnHomeP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHomeP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHomeP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHomeP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHomeP.FillColor = System.Drawing.Color.DarkCyan;
            this.btnHomeP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeP.ForeColor = System.Drawing.Color.White;
            this.btnHomeP.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeP.Image")));
            this.btnHomeP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHomeP.Location = new System.Drawing.Point(12, 598);
            this.btnHomeP.Name = "btnHomeP";
            this.btnHomeP.Size = new System.Drawing.Size(227, 45);
            this.btnHomeP.TabIndex = 1;
            this.btnHomeP.Text = "Home";
            this.btnHomeP.Click += new System.EventHandler(this.btnHomeP_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.dt_DataP);
            this.guna2Panel4.Controls.Add(this.txbQuantidade);
            this.guna2Panel4.Controls.Add(this.lblQunt);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel4.Controls.Add(this.txbEdicao);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel4.Controls.Add(this.txbSinopse);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel4.Controls.Add(this.txbNomeL);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel4.Location = new System.Drawing.Point(256, 163);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1017, 473);
            this.guna2Panel4.TabIndex = 30;
            // 
            // dt_DataP
            // 
            this.dt_DataP.BorderRadius = 15;
            this.dt_DataP.Checked = true;
            this.dt_DataP.FillColor = System.Drawing.Color.DarkCyan;
            this.dt_DataP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_DataP.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_DataP.Location = new System.Drawing.Point(715, 95);
            this.dt_DataP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_DataP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_DataP.Name = "dt_DataP";
            this.dt_DataP.Size = new System.Drawing.Size(263, 36);
            this.dt_DataP.TabIndex = 16;
            this.dt_DataP.Value = new System.DateTime(2022, 12, 7, 21, 40, 39, 423);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQuantidade.DefaultText = "";
            this.txbQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbQuantidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbQuantidade.Location = new System.Drawing.Point(117, 255);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.PasswordChar = '\0';
            this.txbQuantidade.PlaceholderText = "";
            this.txbQuantidade.SelectedText = "";
            this.txbQuantidade.Size = new System.Drawing.Size(218, 23);
            this.txbQuantidade.TabIndex = 13;
            // 
            // lblQunt
            // 
            this.lblQunt.BackColor = System.Drawing.Color.Transparent;
            this.lblQunt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQunt.Location = new System.Drawing.Point(11, 255);
            this.lblQunt.Name = "lblQunt";
            this.lblQunt.Size = new System.Drawing.Size(101, 23);
            this.lblQunt.TabIndex = 12;
            this.lblQunt.Text = "Quantidade";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(548, 95);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(136, 23);
            this.guna2HtmlLabel11.TabIndex = 8;
            this.guna2HtmlLabel11.Text = "Data Publicação";
            // 
            // txbEdicao
            // 
            this.txbEdicao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEdicao.DefaultText = "";
            this.txbEdicao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEdicao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEdicao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEdicao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEdicao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEdicao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEdicao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEdicao.Location = new System.Drawing.Point(757, 31);
            this.txbEdicao.Name = "txbEdicao";
            this.txbEdicao.PasswordChar = '\0';
            this.txbEdicao.PlaceholderText = "";
            this.txbEdicao.SelectedText = "";
            this.txbEdicao.Size = new System.Drawing.Size(182, 23);
            this.txbEdicao.TabIndex = 7;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(627, 31);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(57, 23);
            this.guna2HtmlLabel12.TabIndex = 6;
            this.guna2HtmlLabel12.Text = "Edição ";
            // 
            // txbSinopse
            // 
            this.txbSinopse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSinopse.DefaultText = "";
            this.txbSinopse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSinopse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSinopse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSinopse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSinopse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSinopse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSinopse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSinopse.Location = new System.Drawing.Point(117, 134);
            this.txbSinopse.Name = "txbSinopse";
            this.txbSinopse.PasswordChar = '\0';
            this.txbSinopse.PlaceholderText = "";
            this.txbSinopse.SelectedText = "";
            this.txbSinopse.Size = new System.Drawing.Size(218, 23);
            this.txbSinopse.TabIndex = 5;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(11, 134);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(61, 23);
            this.guna2HtmlLabel13.TabIndex = 4;
            this.guna2HtmlLabel13.Text = "Sinopse";
            // 
            // txbNomeL
            // 
            this.txbNomeL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNomeL.DefaultText = "";
            this.txbNomeL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNomeL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNomeL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNomeL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNomeL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNomeL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNomeL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNomeL.Location = new System.Drawing.Point(117, 31);
            this.txbNomeL.Name = "txbNomeL";
            this.txbNomeL.PasswordChar = '\0';
            this.txbNomeL.PlaceholderText = "";
            this.txbNomeL.SelectedText = "";
            this.txbNomeL.Size = new System.Drawing.Size(218, 23);
            this.txbNomeL.TabIndex = 3;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(11, 31);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(89, 23);
            this.guna2HtmlLabel14.TabIndex = 2;
            this.guna2HtmlLabel14.Text = "Nome Livro";
            // 
            // lblCadL
            // 
            this.lblCadL.BackColor = System.Drawing.Color.Transparent;
            this.lblCadL.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadL.ForeColor = System.Drawing.Color.White;
            this.lblCadL.Location = new System.Drawing.Point(523, 33);
            this.lblCadL.Name = "lblCadL";
            this.lblCadL.Size = new System.Drawing.Size(218, 32);
            this.lblCadL.TabIndex = 32;
            this.lblCadL.Text = "Cadastro de livros";
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.White;
            this.btnCad.BorderRadius = 6;
            this.btnCad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCad.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.White;
            this.btnCad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCad.Location = new System.Drawing.Point(291, 698);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(227, 45);
            this.btnCad.TabIndex = 34;
            this.btnCad.Text = "Cadastro";
            this.btnCad.Click += new System.EventHandler(this.btn_CadL_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1224, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 51);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 40;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.lblCadL);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1276, 100);
            this.guna2Panel1.TabIndex = 31;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guna2Panel2.Controls.Add(this.btnHomeP);
            this.guna2Panel2.Controls.Add(this.btn_ListLivro);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(250, 685);
            this.guna2Panel2.TabIndex = 32;
            // 
            // FrmCadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1276, 785);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadLivro";
            this.Load += new System.EventHandler(this.FrmCadLivro_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_ListLivro;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnHomeP;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txbQuantidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQunt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox txbEdicao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2TextBox txbSinopse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2TextBox txbNomeL;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCadL;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_DataP;
        private Guna.UI2.WinForms.Guna2Button btnCad;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}