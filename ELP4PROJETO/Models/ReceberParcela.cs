using System;

namespace ELP4PROJETO.Classes
{
    public class ReceberParcela : Pai
    {
        private int _numParcela;
        private decimal _valor;
        private DateTime _vencimento;

        public ReceberParcela() : base()
        {
            _numParcela = 0;
            _valor = 0m;
            _vencimento = DateTime.Now;
        }

        public ReceberParcela(int id, int numParcela, decimal valor, DateTime vencimento) : base(id)
        {
            _numParcela = numParcela;
            _valor = valor;
            _vencimento = vencimento;
        }

        public int NumParcela
        {
            get => _numParcela;
            set => _numParcela = value;
        }

        public decimal Valor
        {
            get => _valor;
            set => _valor = value;
        }

        public DateTime Vencimento
        {
            get => _vencimento;
            set => _vencimento = value;
        }
    }
}
