using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSBIBLIO.Model
{
    public class Emprestimo
    {
        public int CodigoEmprestimo { get; set; }
        public int CodigoLeitor { get; set; }
        public int CodigoBibliotecario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
