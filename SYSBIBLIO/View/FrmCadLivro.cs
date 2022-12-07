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
        private static SqlConnection con;
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
            sql = "INSERT INTO Livro(codigoLivro, nomeLivro, edicaoLivro, sinopseLivro, dataPublicacao, quantidadeLivro) VALUES (" +
               "@codigo," +
               "@nome," +
               "@edicao," +
               "@sinopse," +
               "@dataPublicacao," +
               "@quantidade";
            con.Open();
            SqlCommand sqlCommand1 = new SqlCommand(sql, con);
            SqlCommand sqlCommand = sqlCommand1;
            cmd = sqlCommand;
            // Inserindo os dados do C# no comando para ser executado no banco de dados
            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar, 13)).Value = livro.CodigoLivro;
            cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar, 50)).Value = livro.NomeLivro;
            cmd.Parameters.Add(new SqlParameter("@edicao", SqlDbType.VarChar, 30)).Value = livro.EdicaoLivro;
            cmd.Parameters.Add(new SqlParameter("@sinopse", SqlDbType.VarChar, 50)).Value = livro.SinopseLivro;
            cmd.Parameters.Add(new SqlParameter("@dataPublicacao", SqlDbType.Int)).Value = livro.DataPublicacao;
            cmd.Parameters.Add(new SqlParameter("@quantidade", SqlDbType.VarChar, 25)).Value = livro.QuantidadeLivro;
            ExecutarSemConsulta();
            FecharConexao();

        }

        private void ExecutarSemConsulta()
        {
            throw new NotImplementedException();
        }

        private void FecharConexao()
        {
            throw new NotImplementedException();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
