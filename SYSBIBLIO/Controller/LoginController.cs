using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SYSBIBLIO.View;
using System.Threading.Tasks;

namespace SYSBIBLIO.Controller
{
    public class LoginController
    {
       public void abrirLogin(FrmLogin ViewAtual)
       {
           FrmLogin login = new FrmLogin();
           login.Show();
           ViewAtual.Close();
       }
    }
}
