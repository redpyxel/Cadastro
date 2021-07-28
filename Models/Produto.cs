using System;

namespace Cadastro.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Cliente { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public int IdCliente { get; set; }

    }

}