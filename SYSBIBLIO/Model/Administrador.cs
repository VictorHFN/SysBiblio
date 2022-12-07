using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSBIBLIO.Model
{
    public class Administrador
    {
        public int CodigoAdm { get; set; }
        public int CodigoPessoa { get; set; }
        public DateTime DataCadastro { get; set; }
        public Boolean Status { get; set; }
    }
}
