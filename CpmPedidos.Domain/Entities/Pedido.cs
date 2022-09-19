using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class Pedido : BaseDomain
    {
        public string Numero { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public  int IdProduto { get; set; }
        public virtual List<ProdutoPedido> Produtos { get; set; }
        public TimeSpan entrega { get; set; }
    }
}
