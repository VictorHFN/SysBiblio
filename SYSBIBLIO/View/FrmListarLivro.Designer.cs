
namespace SYSBIBLIO.View
{
    partial class FrmListarLivro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarLivro));
            this.sysBiblioDataSet = new SYSBIBLIO.SysBiblioDataSet();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new SYSBIBLIO.SysBiblioDataSetTableAdapters.LivroTableAdapter();
            this.tableAdapterManager = new SYSBIBLIO.SysBiblioDataSetTableAdapters.TableAdapterManager();
            this.livroDataGridView = new System.Windows.Forms.DataGridView();
            this.codigoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCadLeitor = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Alterar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Excluir = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_List = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sysBiblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sysBiblioDataSet
            // 
            this.sysBiblioDataSet.DataSetName = "SysBiblioDataSet";
            this.sysBiblioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.sysBiblioDataSet;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.UpdateOrder = SYSBIBLIO.SysBiblioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livroDataGridView
            // 
            this.livroDataGridView.AutoGenerateColumns = false;
            this.livroDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.livroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.livroDataGridView.DataSource = this.livroBindingSource;
            this.livroDataGridView.Location = new System.Drawing.Point(567, 137);
            this.livroDataGridView.Name = "livroDataGridView";
            this.livroDataGridView.Size = new System.Drawing.Size(643, 548);
            this.livroDataGridView.TabIndex = 1;
            // 
            // codigoLivroDataGridViewTextBoxColumn
            // 
            this.codigoLivroDataGridViewTextBoxColumn.DataPropertyName = "codigoLivro";
            this.codigoLivroDataGridViewTextBoxColumn.HeaderText = "codigoLivro";
            this.codigoLivroDataGridViewTextBoxColumn.Name = "codigoLivroDataGridViewTextBoxColumn";
            this.codigoLivroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeLivroDataGridViewTextBoxColumn
            // 
            this.nomeLivroDataGridViewTextBoxColumn.DataPropertyName = "nomeLivro";
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "nomeLivro";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            // 
            // edicaoLivroDataGridViewTextBoxColumn
            // 
            this.edicaoLivroDataGridViewTextBoxColumn.DataPropertyName = "edicaoLivro";
            this.edicaoLivroDataGridViewTextBoxColumn.HeaderText = "edicaoLivro";
            this.edicaoLivroDataGridViewTextBoxColumn.Name = "edicaoLivroDataGridViewTextBoxColumn";
            // 
            // sinopseLivroDataGridViewTextBoxColumn
            // 
            this.sinopseLivroDataGridViewTextBoxColumn.DataPropertyName = "sinopseLivro";
            this.sinopseLivroDataGridViewTextBoxColumn.HeaderText = "sinopseLivro";
            this.sinopseLivroDataGridViewTextBoxColumn.Name = "sinopseLivroDataGridViewTextBoxColumn";
            // 
            // dataPublicacaoDataGridViewTextBoxColumn
            // 
            this.dataPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "dataPublicacao";
            this.dataPublicacaoDataGridViewTextBoxColumn.HeaderText = "dataPublicacao";
            this.dataPublicacaoDataGridViewTextBoxColumn.Name = "dataPublicacaoDataGridViewTextBoxColumn";
            // 
            // quantidadeLivroDataGridViewTextBoxColumn
            // 
            this.quantidadeLivroDataGridViewTextBoxColumn.DataPropertyName = "quantidadeLivro";
            this.quantidadeLivroDataGridViewTextBoxColumn.HeaderText = "quantidadeLivro";
            this.quantidadeLivroDataGridViewTextBoxColumn.Name = "quantidadeLivroDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigoLivro";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigoLivro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeLivro";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeLivro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "edicaoLivro";
            this.dataGridViewTextBoxColumn3.HeaderText = "edicaoLivro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sinopseLivro";
            this.dataGridViewTextBoxColumn4.HeaderText = "sinopseLivro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataPublicacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "dataPublicacao";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantidadeLivro";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantidadeLivro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.lbl_List);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1268, 70);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guna2Panel2.Controls.Add(this.btn_Excluir);
            this.guna2Panel2.Controls.Add(this.btn_Alterar);
            this.guna2Panel2.Controls.Add(this.btnCadLeitor);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 70);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(250, 676);
            this.guna2Panel2.TabIndex = 3;
            // 
            // btnCadLeitor
            // 
            this.btnCadLeitor.BorderRadius = 6;
            this.btnCadLeitor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadLeitor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadLeitor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadLeitor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadLeitor.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCadLeitor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadLeitor.ForeColor = System.Drawing.Color.White;
            this.btnCadLeitor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadLeitor.Image")));
            this.btnCadLeitor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCadLeitor.Location = new System.Drawing.Point(9, 556);
            this.btnCadLeitor.Name = "btnCadLeitor";
            this.btnCadLeitor.Size = new System.Drawing.Size(232, 45);
            this.btnCadLeitor.TabIndex = 7;
            this.btnCadLeitor.Text = "Menu";
            this.btnCadLeitor.Click += new System.EventHandler(this.btnCadLeitor_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BorderRadius = 6;
            this.btn_Alterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Alterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Alterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Alterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Alterar.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Alterar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alterar.Image")));
            this.btn_Alterar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Alterar.Location = new System.Drawing.Point(9, 229);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(232, 45);
            this.btn_Alterar.TabIndex = 8;
            this.btn_Alterar.Text = "Alterar";
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BorderRadius = 6;
            this.btn_Excluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Excluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Excluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Excluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Excluir.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_Excluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Image")));
            this.btn_Excluir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Excluir.Location = new System.Drawing.Point(9, 160);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(232, 45);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // lbl_List
            // 
            this.lbl_List.BackColor = System.Drawing.Color.Transparent;
            this.lbl_List.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.ForeColor = System.Drawing.Color.White;
            this.lbl_List.Location = new System.Drawing.Point(519, 12);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(314, 44);
            this.lbl_List.TabIndex = 33;
            this.lbl_List.Text = "Listagem de Livros";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1207, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 51);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 40;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // FrmListarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 746);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.livroDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListarLivro";
            this.Load += new System.EventHandler(this.FrmListarLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysBiblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SysBiblioDataSet sysBiblioDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private SysBiblioDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private SysBiblioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView livroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeLivroDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Excluir;
        private Guna.UI2.WinForms.Guna2Button btn_Alterar;
        private Guna.UI2.WinForms.Guna2Button btnCadLeitor;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_List;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}