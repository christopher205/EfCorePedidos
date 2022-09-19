using CpmPedidos.Domain.Enums;
using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class Endereco : BaseDomain
    {
        public TipoEnderecoEnum endereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string Cep { get; set; }

        public int IdCidade { get; set; }
        public virtual Cidade cidade { get; set; }
    }
}
