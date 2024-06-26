using System;

namespace ELP4PROJETO.Classes
{
    public class ContasReceber : Pai
    {
        private int _idForma;
        private string _situacao;

        public ContasReceber() : base()
        {
            _idForma = 0;
            _situacao = "";
        }
        public ContasReceber(int id, int idForma, string situacao, DateTime dataCriacao) : base(id, dataCriacao)
        {
            _idForma = idForma;
            _situacao = situacao;
        }
        public int IdForma
        {
            get => _idForma;
            set => _idForma = value;
        }
        public string Situacao
        {
            get => _situacao;
            set => _situacao = value;
        }
    }
}
