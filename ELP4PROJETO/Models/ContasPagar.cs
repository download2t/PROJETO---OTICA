using System;

namespace ELP4PROJETO.Classes
{
    public class ContasPagar
    {
        private int _numNFC;
        private int _modeloNFC;
        private int _serieNFC;
        private int _numParcela;
        private Fornecedores _fornecedor;
        private CondicaoPagamento _condicao;
        private decimal _valor;
        private string _situacao;
        private DateTime? _dataBaixa;
        private DateTime _dataVencimento;
        private DateTime _dataCriacao;
        private DateTime _dataUltAlteracao;

        public ContasPagar()
        {
            _numNFC = 0;
            _modeloNFC = 0;
            _serieNFC = 0;
            _numParcela = 0;
            _fornecedor = new Fornecedores();
            _condicao = new CondicaoPagamento();
            _valor = 0m;
            _situacao = "";
            _dataBaixa = null;
            _dataVencimento = DateTime.Now;
            _dataCriacao = DateTime.Now;
            _dataUltAlteracao = DateTime.Now;
        }

        public ContasPagar(int numNFC, int modeloNFC, int serieNFC, int numParcela, Fornecedores fornecedor, CondicaoPagamento condicao, decimal valor, string situacao, DateTime? dataBaixa, DateTime dataVencimento, DateTime dataCriacao, DateTime dataUltAlteracao)
        {
            _numNFC = numNFC;
            _modeloNFC = modeloNFC;
            _serieNFC = serieNFC;
            _numParcela = numParcela;
            _fornecedor = fornecedor;
            _condicao = condicao;
            _valor = valor;
            _situacao = situacao;
            _dataBaixa = dataBaixa;
            _dataVencimento = dataVencimento;
            _dataCriacao = dataCriacao;
            _dataUltAlteracao = dataUltAlteracao;
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

        public int NumParcela
        {
            get => _numParcela;
            set => _numParcela = value;
        }

        public Fornecedores Fornecedor
        {
            get => _fornecedor;
            set => _fornecedor = value;
        }

        public CondicaoPagamento Condicao
        {
            get => _condicao;
            set => _condicao = value;
        }

        public decimal Valor
        {
            get => _valor;
            set => _valor = value;
        }

        public string Situacao
        {
            get => _situacao;
            set => _situacao = value;
        }

        public DateTime? DataBaixa
        {
            get => _dataBaixa;
            set => _dataBaixa = value;
        }

        public DateTime DataVencimento
        {
            get => _dataVencimento;
            set => _dataVencimento = value;
        }

        public DateTime DataCriacao
        {
            get => _dataCriacao;
            set => _dataCriacao = value;
        }

        public DateTime DataUltAlteracao
        {
            get => _dataUltAlteracao;
            set => _dataUltAlteracao = value;
        }
    }
}
