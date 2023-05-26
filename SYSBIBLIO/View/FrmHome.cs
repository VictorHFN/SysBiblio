﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSBIBLIO.View
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btncadPessoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadLivro clivro = new FrmCadLivro();
            clivro.Show();
            Close();
        }

        private void btnCadLeitor_Click(object sender, EventArgs e)
        {
            FrmListarLivro liLivro = new FrmListarLivro();
            liLivro.Show();
            Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
