using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Tb_Produto
    {
        public int Id { get; set; }

        public int IdFornecedor { get; set; }

        public string CodBarra { get; set; }

        public string Descricao { get; set; }

        public decimal ValorCusto{ get; set; }

        public decimal ValorVenda { get; set; }

        public decimal TotalItem { get; set; }

        public string TipoProduto { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataVencimento { get; set; }

        public string Lote { get; set;}
        
        public List<Tb_Fornecedor> ListaFornecedor {get; set;}

        public int Quantidade { get; set; }

        //public int IdTipoProduto { get; set; }

        public Tb_Produto()
        {
            ListaFornecedor = new List<Tb_Fornecedor>();

        }
    }
}
