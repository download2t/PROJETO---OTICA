using System;

namespace ELP4PROJETO.Classes
{
    public class Marca : Pai
    {
        private string _nome;
        private string _descricao;
        private DateTime _dataUltAlteracao;

        public Marca() : base()
        {
            Nome = "";
            Descricao = "";
            DataCriacao = DateTime.Now;
            DataUltAlteracao = DateTime.Now;
        }

        public Marca(int id, string nome, string descricao, DateTime dataCriacao, DateTime dataUltAlteracao)
            : base(id, dataCriacao, dataUltAlteracao)
        {
            Nome = nome;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataUltAlteracao = dataUltAlteracao;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public DateTime DataUltAlteracao
        {
            get => _dataUltAlteracao;
            set => _dataUltAlteracao = value;
        }
    }
}
