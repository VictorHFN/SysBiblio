using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSBIBLIO.Model
{
    public class Leitor
    {
        public int CodigoLeitor { get; set; }
        public int CodigoPessoa { get; set; }
        public DateTime CadastroLeitor { get; set; }
        public Boolean Status { get; set; }
    }
}
