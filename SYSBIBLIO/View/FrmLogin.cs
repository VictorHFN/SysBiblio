using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SYSBIBLIO.Connection;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SYSBIBLIO.View
{
    public partial class FrmLogin : Form
    {
            SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-S6Q1RKC;Initial Catalog=SysBiblio;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
            txbUsuario.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "SELECT * FROM Login WHERE Usuario = '" + txbUsuario.Text + "' AND Senha = '" + txbSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                FrmHome home = new FrmHome();
                this.Hide();
                home.Show();
                Conexao.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbUsuario.Text = "";
                txbSenha.Text = "";
                txbUsuario.Select();
            }
        }
    }
}
