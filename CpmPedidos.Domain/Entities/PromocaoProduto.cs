using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class PromocaoProduto : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public int IdIMagem { get; set; }
        public virtual Imagem Imagem { get; set; }
        public int IdIProduto { get; set; }
        public virtual ProdutoPedido Produto { get; set; }
        public bool Ativo { get; set; }

    }
}
