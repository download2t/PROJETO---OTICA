using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class ReceitaClientes : Pai
    {
        public Receita Receita { get; set; }
        public Clientes Cliente { get; set; }
        public ReceitaClientes() : base()
        {
            Receita = new Receita();
            Cliente = new Clientes();
        }
        public ReceitaClientes(Receita receita, Clientes cliente, int id, DateTime dataCriacao, DateTime ultimaAlteracao) : base(id, dataCriacao, ultimaAlteracao)
        {
            Receita = receita;
            Cliente = cliente;
        }
    }
}
