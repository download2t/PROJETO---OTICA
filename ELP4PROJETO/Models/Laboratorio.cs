using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class Laboratorio : Pai
    {
        public string Nome { get; set; }
        public Laboratorio()
        {
            Nome = "";
        }
        public Laboratorio(string nome, int id, DateTime ultima_alteracao, DateTime data_criacao) : base(id, ultima_alteracao, data_criacao)
        {
            Nome = nome;
        }
    }
}
