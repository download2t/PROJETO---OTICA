using System;
using System.Collections.Generic;

namespace ELP4PROJETO.Classes
{
    public class CondicaoPagamento:Pai
    {
        private string _condicao;
        private int _parcelas;
        private decimal _taxa;
        private decimal _multa;
        private decimal _desconto;
        public string _status;
        private DateTime _dataCriacao;
        private DateTime _dataUltimaAlteracao;
        public List<Parcela> uParcelas { get; set; }

        public string Status
        {
            get => _status;
            set => _status = value;
        }

        public string Condicao
        {
            get => _condicao;
            set => _condicao = value;
        }

        public int Parcelas
        {
            get => _parcelas;
            set => _parcelas = value;
        }

        public decimal Taxa
        {
            get => _taxa;
            set => _taxa = value;
        }

        public decimal Multa
        {
            get => _multa;
            set => _multa = value;
        }

        public decimal Desconto
        {
            get => _desconto;
            set => _desconto = value;
        }

        public new DateTime DataCriacao
        {
            get => _dataCriacao;
            set => _dataCriacao = value;
        }

        public new DateTime DataUltimaAlteracao
        {
            get => _dataUltimaAlteracao;
            set => _dataUltimaAlteracao = value;
        }

        public CondicaoPagamento() :base()
        {
            _condicao = "";
            _parcelas = 0;
            _taxa = 0;
            _multa = 0;
            _desconto = 0;
            _status = "";
            _dataCriacao = DateTime.Now;
            _dataUltimaAlteracao = DateTime.Now;
            List<Parcela> Parcelas = new List<Parcela>();
        }

        public CondicaoPagamento(int id, string condicao, int parcelas, decimal taxa, decimal multa, decimal desconto,string status, DateTime dataCriacao, DateTime dataUltimaAlteracao):base (id)
        {
            _condicao = condicao;
            _parcelas = parcelas;
            _taxa = taxa;
            _multa = multa;
            _desconto = desconto;
            _dataCriacao = dataCriacao;
            _dataUltimaAlteracao = dataUltimaAlteracao;
            _status =status;
        }
    }
}
