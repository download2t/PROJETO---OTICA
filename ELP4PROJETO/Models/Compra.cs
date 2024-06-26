using System;
using System.Collections.Generic;

namespace ELP4PROJETO.Classes
{
    public class Compra : Pai
    {
        private int _numNFC;
        private int _modeloNFC;
        private int _serieNFC;
        private Fornecedores _fornecedor;
        private CondicaoPagamento _condicao;
        private decimal _valorTotal;
        private decimal _valorFrete;
        private decimal _valorSeguro;
        private decimal _valorOutrasDespesas;
        private DateTime _dataChegada;
        private DateTime _dataEmissao;
        private DateTime _dataCancelamento;
        private List<ItemCompra> _itensCompra;

        public Compra() : base()
        {
            _numNFC = 0;
            _modeloNFC = 0;
            _serieNFC = 0;
            _fornecedor = new Fornecedores();
            _condicao = new CondicaoPagamento();
            _valorTotal = 0m;
            _valorFrete = 0m;
            _valorSeguro = 0m;
            _valorOutrasDespesas = 0m;
            _dataChegada = DateTime.Now;
            _dataEmissao = DateTime.Now;
            _dataCancelamento = DateTime.Now;
            _itensCompra = new List<ItemCompra>();
        }

        public Compra(int numNFC, int modeloNFC, int serieNFC, List<ItemCompra> itensCompra, Fornecedores fornecedor, CondicaoPagamento condicao, decimal valorTotal, decimal valorFrete, decimal valorSeguro, decimal valorOutrasDespesas, DateTime dataChegada, DateTime dataEmissao, DateTime dataCancelamento, DateTime dataCriacao)
            : base(dataCriacao)
        {
            _numNFC = numNFC;
            _modeloNFC = modeloNFC;
            _serieNFC = serieNFC;
            _fornecedor = fornecedor;
            _condicao = condicao;
            _valorTotal = valorTotal;
            _valorFrete = valorFrete;
            _valorSeguro = valorSeguro;
            _valorOutrasDespesas = valorOutrasDespesas;
            _dataChegada = dataChegada;
            _itensCompra = itensCompra;
            _dataEmissao = dataEmissao;
            _dataCancelamento = dataCancelamento;
        }

        public int NumNFC
        {
            get => _numNFC;
            set => _numNFC = value;
        }

        public int ModeloNFC
        {
            get => _modeloNFC;
            set => _modeloNFC = value;
        }

        public int SerieNFC
        {
            get => _serieNFC;
            set => _serieNFC = value;
        }

        public Fornecedores Fornecedor
        {
            get => _fornecedor;
            set => _fornecedor = value;
        }

        public List<ItemCompra> ItensCompra
        {
            get => _itensCompra;
            set => _itensCompra = value;
        }

        public CondicaoPagamento Condicao
        {
            get => _condicao;
            set => _condicao = value;
        }

        public decimal ValorTotal
        {
            get => _valorTotal;
            set => _valorTotal = value;
        }

        public decimal ValorFrete
        {
            get => _valorFrete;
            set => _valorFrete = value;
        }

        public decimal ValorSeguro
        {
            get => _valorSeguro;
            set => _valorSeguro = value;
        }

        public decimal ValorOutrasDespesas
        {
            get => _valorOutrasDespesas;
            set => _valorOutrasDespesas = value;
        }

        public DateTime DataChegada
        {
            get => _dataChegada;
            set => _dataChegada = value;
        }

        public DateTime DataEmissao
        {
            get => _dataEmissao;
            set => _dataEmissao = value;
        }

        public DateTime DataCancelamento
        {
            get => _dataCancelamento;
            set => _dataCancelamento = value;
        }
    }
}
