using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class Servico : Pai
    {
        public string _descricao;
        public string _statusServico;

        public Servico() : base()
        {
            _statusServico = "";
            _descricao = "";
        }
        public Servico(int id, string descricao, string status, DateTime data_criacao, DateTime data_ult_alteracao) : base(id, data_criacao, data_ult_alteracao)
        {
            Status = status;
            Descricao = descricao;
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string Status
        {
            get { return _statusServico; }
            set { _statusServico = value; }
        }

    }
}
