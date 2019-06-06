using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tb_Estoque
    {
        public int Id { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Usuario { get; set; }
    }
}
