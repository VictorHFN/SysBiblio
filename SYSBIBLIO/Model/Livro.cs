using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSBIBLIO.Model
{
    public class Livro
    {
        public int CodigoLivro { get; set; }
        public string NomeLivro { get; set; }
        public string EdicaoLivro { get; set; }
        public string SinopseLivro { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int QuantidadeLivro { get; set; }

        public Livro() { }
    }
}
