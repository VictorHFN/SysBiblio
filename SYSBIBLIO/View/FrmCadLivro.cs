using SYSBIBLIO.Connection;
using SYSBIBLIO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBIBLIO.View
{
    public partial class FrmCadLivro : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S6Q1RKC;Initial Catalog=SysBiblio;Integrated Security=True");
   
        private static string sql;
        private static SqlCommand cmd;

        public FrmCadLivro()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CadL_Click(object sender, EventArgs e)
        {
             

            Livro livro = new Livro();
            livro.NomeLivro = txbNomeL.Text;
            livro.EdicaoLivro = txbEdicao.Text;
            livro.SinopseLivro = txbSinopse.Text;
            livro.DataPublicacao = DateTime.Parse(dt_DataP.Text);
            livro.QuantidadeLivro = Int32.Parse(txbQuantidade.Text);

            
            

            sql = "INSERT INTO Livro(nomeLivro, edicaoLivro, sinopseLivro, dataPublicacao, quantidadeLivro) VALUES (" +
               "@nome," +
               "@edicao," +
               "@sinopse," +
               "@dataPublicacao," +
               "@quantidade)";
            con.Open();
            SqlCommand sqlCommand1 = new SqlCommand(sql, con);
            SqlCommand sqlCommand = sqlCommand1;
            cmd = sqlCommand;
            // Inserindo os dados do C# no comando para ser executado no banco de dados
            cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar, 50)).Value = livro.NomeLivro;
            cmd.Parameters.Add(new SqlParameter("@edicao", SqlDbType.VarChar, 30)).Value = livro.EdicaoLivro;
            cmd.Parameters.Add(new SqlParameter("@sinopse", SqlDbType.VarChar, 50)).Value = livro.SinopseLivro;
            cmd.Parameters.Add(new SqlParameter("@dataPublicacao", SqlDbType.DateTime)).Value = livro.DataPublicacao;
            cmd.Parameters.Add(new SqlParameter("@quantidade", SqlDbType.Int, 25)).Value = livro.QuantidadeLivro;

            cmd.Prepare();
            
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
           
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmListarLivro lLivro = new FrmListarLivro();
            this.Hide();
            lLivro.Show();

        }

        private void FrmCadLivro_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHomeP_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            Close();
        }
    }
}
