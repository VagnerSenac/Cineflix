using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roupabox;
//using System.Text.Json.Serialization;

namespace Roupabox
{
    internal class ProdutoCad
    {
        public ProdutoCad(string nome)
        {
            Nome = nome;
        }
        //[JsonPropertyName("title")]
        public string Nome { get; set; }

        //[JsonPropertyName("price")]
        public double precoProdutos { get; set; }

        //[JsonPropertyName("description")]
        public string descricaoProduto { get; set; }

        public int Quantidade { get; set; }
    }
}
