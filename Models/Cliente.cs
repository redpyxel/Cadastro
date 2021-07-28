using System;

namespace Cadastro.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DataCadastro { get; set;}

        public bool Ativo { get; set;}

    }
}
