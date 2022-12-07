using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;
using SYSBIBLIO.Properties;
using SYSBIBLIO.Model;

namespace SYSBIBLIO.Connection
{
    public class BancoDAO
    {
       
        private static SqlConnection con;
        private static string sql;
        private static SqlCommand cmd;

        public static void InserirLivro(Livro livro)
        {
            // Comando para inserir na tabela do banco de dados
            sql = "INSERT INTO livro(codigoLivro, nomeLivro, edicaoLivvro, sinopseLivro, dataPublicacao, quantidadeLivro) VALUES (" +
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

        public static Livro PegarLivro(string codigo)
        {
            Livro livro = new Livro();
            // Buscando o dado para o código informado
            sql = "SELECT * FROM livro WHERE codigo = @codigo";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar, 13)).Value = codigo;
            cmd.Prepare();

            SqlDataReader rdr = cmd.ExecuteReader();
            // Caso consiga ler, insere os dados recebidos do banco de dados para o objeto Livro, C#
            if (rdr.Read())
            {
                livro.CodigoLivro = rdr.GetInt32(0);
                livro.NomeLivro = rdr.GetString(1);
                livro.EdicaoLivro = rdr.GetString(2);
                livro.SinopseLivro = rdr.GetString(3);
                livro.DataPublicacao = rdr.GetDateTime(4);
                livro.QuantidadeLivro = rdr.GetInt32(5);
            }
            FecharConexao();
            return livro;
        }

        public static bool ExisteLivro(string codigo)
        {
            sql = "SELECT * FROM livro WHERE codigo = @codigo";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int, 13)).Value = codigo;
            cmd.Prepare();
            SqlDataReader rdr = cmd.ExecuteReader();
            bool result = rdr.Read();
            FecharConexao();
            return result;
        }

        public static List<Livro> PegarLivros()
        {
            List<Livro> livros = new List<Livro>();
            sql = "SELECT * FROM livro";
            con.Open();
            cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Livro livro = new Livro();
                livro.CodigoLivro = rdr.GetInt32(0);
                livro.NomeLivro = rdr.GetString(1);
                livro.EdicaoLivro = rdr.GetString(2);
                livro.SinopseLivro = rdr.GetString(3);
                livro.DataPublicacao = rdr.GetDateTime(4);
                livro.QuantidadeLivro = rdr.GetInt32(5);

                livros.Add(livro);
            }

            FecharConexao();
            return livros;
        }

        public static void ExcluirLivros()
        {
            sql = "DELETE FROM livro";
            con.Open();
            cmd = new SqlCommand(sql, con);
            ExecutarSemConsulta();
            FecharConexao();
        }

        public static void ExecutarSemConsulta()
        {
            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }

        public static void FecharConexao()
        {
            con.Close();
        }

        public static void ExcluirLivro(string codigo)
        {
            sql = "DELETE FROM livro WHERE codigo = @codigo";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar, 13)).Value = codigo;
            ExecutarSemConsulta();
            FecharConexao();
        }

        public static void AtualizarLivro(Livro livro)
        {
            sql = "UPDATE livro " +
                "SET nomeLivro = @nome, edicaoLivro = @edicao, sinopseLivro = @sinopse, dataPublicacao = @dataPublicacao, quantidadeLivro = @quantidade " +
                "WHERE codigo = @codigo";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.VarChar, 13)).Value = livro.CodigoLivro;
            cmd.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar, 50)).Value = livro.NomeLivro;
            cmd.Parameters.Add(new SqlParameter("@edicao", SqlDbType.VarChar, 30)).Value = livro.EdicaoLivro;
            cmd.Parameters.Add(new SqlParameter("@sinopse", SqlDbType.VarChar, 50)).Value = livro.SinopseLivro;
            cmd.Parameters.Add(new SqlParameter("@dataPublicacao", SqlDbType.Int)).Value = livro.DataPublicacao;
            cmd.Parameters.Add(new SqlParameter("@quantidade", SqlDbType.VarChar, 25)).Value = livro.QuantidadeLivro;

            ExecutarSemConsulta();
            FecharConexao();
        }
    }

}
