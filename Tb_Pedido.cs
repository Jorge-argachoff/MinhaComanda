using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Tb_Pedido
    {

        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int IdCliente { get; set; }

        public int IdVendedor { get; set; }

        public decimal ValorPedido { get; set; }
    }
}
