using ELP4PROJETO.Classes;
using System;

namespace ELP4PROJETO.Models
{
    public class Doutor : Pai
    {
        public string Nome { get; set; }

        public Doutor()
        {
            Nome = "";
        }

        public Doutor(string nome, int id, DateTime ultima_alteracao, DateTime data_criacao)
            : base(id, ultima_alteracao, data_criacao)
        {
            Nome = nome;
        }
    }
}
