using System;

namespace ELP4PROJETO.Classes
{
    public class ItemCompra : Pai
    {
        private int _numNFC;
        private int _modeloNFC;
        private int _serieNFC;
        private Fornecedores _fornecedor;
        private Produto _produto;
        private int _qtdProduto;
        private decimal _precoCusto;
        private decimal _totalCusto;
        private decimal _percentualCompra;
        private decimal _mediaPonderada;
        private decimal _desconto;
        public ItemCompra() : base()
        {
            _numNFC = 0;
            _modeloNFC = 0;
            _serieNFC = 0;
            _fornecedor = new Fornecedores();
            _produto = new Produto();
            _qtdProduto = 0;
            _precoCusto = 0m;
            _totalCusto = 0m;
            _percentualCompra = 0m;
            _mediaPonderada = 0m;
            _desconto = 0m;
        }

        public ItemCompra(decimal desconto, int numNFC, int modeloNFC, int serieNFC, Fornecedores Fornecedor, Produto oProduto, int qtdProduto, decimal precoCusto, decimal totalCusto, decimal percentualCompra, decimal mediaPonderada, DateTime dataCriacao)
            : base(dataCriacao)
        {
            _numNFC = numNFC;
            _modeloNFC = modeloNFC;
            _serieNFC = serieNFC;
            _fornecedor = Fornecedor;
            _produto = oProduto;
            _qtdProduto = qtdProduto;
            _precoCusto = precoCusto;
            _totalCusto = totalCusto;
            _percentualCompra = percentualCompra;
            _mediaPonderada = mediaPonderada;
            _desconto = desconto;
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

        public Produto Produto
        {
            get => _produto;
            set => _produto = value;
        }

        public int QtdProduto
        {
            get => _qtdProduto;
            set => _qtdProduto = value;
        }

        public decimal Desconto
        {
            get => _desconto;
            set => _desconto = value;
        }
        public decimal PrecoCusto
        {
            get => _precoCusto;
            set => _precoCusto = value;
        }

        public decimal TotalCusto
        {
            get => _totalCusto;
            set => _totalCusto = value;
        }

        public decimal PercentualCompra
        {
            get => _percentualCompra;
            set => _percentualCompra = value;
        }

        public decimal MediaPonderada
        {
            get => _mediaPonderada;
            set => _mediaPonderada = value;
        }
    }
}
