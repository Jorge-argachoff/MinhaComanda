using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tb_ProdutoPedido
    {
        public int Id { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorItem { get; set; }


    }
}
