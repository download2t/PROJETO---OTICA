using System;

namespace ELP4PROJETO.Classes
{
    public class Produto : Pai
    {
        private string _nome;
        private string _descricaoProduto;
        private string _unidadeMedida;
        private string _referencia;
        private Marca _marca;
        private decimal _precoCusto;
        private decimal _precoVenda;
        private int _qtdEstoque;
        private Categoria _categoria;
        private string _statusProduto;
        private byte[] _foto;

        public Produto() : base()
        {
            _nome = "";
            _foto = null;
            _categoria = new Categoria();
            _descricaoProduto = "";
            _unidadeMedida = "";
            _marca = new Marca();
            _statusProduto = "";
            _precoCusto = 0m;
            _precoVenda = 0m;
            _qtdEstoque = 0;
            _referencia = "";
        }

        public Produto(string referencia, string nome, int idProduto, string descricaoProduto, Categoria categoria, string unidadeMedida, Marca marca, decimal precoCusto, decimal precoVenda, int qtdEstoque, string status, DateTime dataCriacao, DateTime dataUltAlteracao, byte[] foto)
            : base(idProduto, dataCriacao, dataUltAlteracao)
        {
            Nome = nome;
            DescricaoProduto = descricaoProduto;
            Categoria = categoria;
            UnidadeMedida = unidadeMedida;
            Marca = marca;
            PrecoCusto = precoCusto;
            PrecoVenda = precoVenda;
            QtdEstoque = qtdEstoque;
            Foto = foto;
            Status = status;
            Referencia = referencia;
        }
        public string Status
        {
            get { return _statusProduto; }
            set { _statusProduto = value; }
        }
        public string Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string DescricaoProduto
        {
            get => _descricaoProduto;
            set => _descricaoProduto = value;
        }

        public string UnidadeMedida
        {
            get => _unidadeMedida;
            set => _unidadeMedida = value;
        }

        public Marca Marca
        {
            get => _marca;
            set => _marca = value;
        }

        public decimal PrecoCusto
        {
            get => _precoCusto;
            set => _precoCusto = value;
        }

        public decimal PrecoVenda
        {
            get => _precoVenda;
            set => _precoVenda = value;
        }

        public int QtdEstoque
        {
            get => _qtdEstoque;
            set => _qtdEstoque = value;
        }
    }
}
