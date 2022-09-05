using NSE.Core.Contracts;
using NSE.Core.DomainObjects;
using System;

namespace NSE.Catalogo.API.Models
{
    public class Produto : Entity, IAgregateRoot
    {

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Imagem { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
