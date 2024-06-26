using System;
using test.Controllers;

namespace ELP4PROJETO.Classes
{
    public class Parcela : Pai
    {
        private CondicaoPagamento _condicao;
        private FormaPagamento _forma;
        private int _numParcela;
        private int _diasTotais;
        private decimal _porcentagem;

        public Parcela() : base()
        {
            _condicao = new CondicaoPagamento();
            _numParcela = 0;
            _forma = new FormaPagamento();
            _diasTotais = 0;
            _porcentagem = 0.0m;
        }

        public Parcela(CondicaoPagamento condicao, int numParcela, FormaPagamento forma, int diasTotais, decimal porcentagem,
            DateTime dataCriacao, DateTime dataUltAlteracao) : base(0, dataCriacao, dataUltAlteracao)
        {
            Condicao = condicao;
            NumParcela = numParcela;
            Forma = forma;
            DiasTotais = diasTotais;
            Porcentagem = porcentagem;
        }

        public CondicaoPagamento Condicao
        {
            get => _condicao;
            set => _condicao = value;
        }

        public int NumParcela
        {
            get => _numParcela;
            set => _numParcela = value;
        }

        public FormaPagamento Forma
        {
            get => _forma;
            set => _forma = value;
        }

        public int DiasTotais
        {
            get => _diasTotais;
            set => _diasTotais = value;
        }

        public decimal Porcentagem
        {
            get => _porcentagem;
            set => _porcentagem = value;
        }
    }
}
