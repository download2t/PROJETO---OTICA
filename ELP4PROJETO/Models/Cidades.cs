using System;
using System.Collections.Generic;
using System.Linq;

namespace ELP4PROJETO.Classes
{
    public class Cidades : Pai
    {
        private string _cidade;
        private string _ddd;
        private Estados oEstado;
        private string _statusCidade;
        public Cidades() : base()
        {
            _cidade = "";
            _ddd = "";
            oEstado = new Estados();
        }
        public Cidades(int id, string cidade, string ddd, Estados oEstado, DateTime dataultAlteracao,DateTime dataCriacao,string status ) : base(id,dataCriacao,dataultAlteracao)
        {
            Cidade = cidade;
            DDD = ddd;
            OEstado = oEstado;
            StatusCidade = status;

        }
        public string StatusCidade
        {
            get => _statusCidade;
            set => _statusCidade = value;
        }
        public string Cidade
        {
            get => _cidade;
            set => _cidade = value;
        }

        public string DDD
        {
            get => _ddd;
            set => _ddd = value;
        }

        public Estados OEstado
        {
            get => oEstado;
            set => oEstado = value;
        }
    }
}
