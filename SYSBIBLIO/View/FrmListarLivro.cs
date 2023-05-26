using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SYSBIBLIO.Connection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SYSBIBLIO.Model;

namespace SYSBIBLIO.View
{
    public partial class FrmListarLivro : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S6Q1RKC;Initial Catalog=SysBiblio;Integrated Security=True");

        private static string sql;
        private static SqlCommand cmd;

        public FrmListarLivro()
        {
            InitializeComponent();
        }

        private void livroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysBiblioDataSet);

        }

        private void FrmListarLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sysBiblioDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.sysBiblioDataSet.Livro);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.CodigoLivro = Int32.Parse(dataGridViewTextBoxColumn1.HeaderText);

            this.livroBindingSource.RemoveCurrent();
            sql = "DELETE FROM Livro WHERE codigo = codigoLivro";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("codigoLivro", SqlDbType.Int, 13)).Value = livro.CodigoLivro;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadLeitor_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            Close();
        }
    }
}
