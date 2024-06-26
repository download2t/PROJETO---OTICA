using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Classes
{
    public class ProdutosFornecedores : Pai
    {
        private string _codigoProdutoFornecedor;
        private Fornecedores _fornecedor;
        private Produto _produto;

        public ProdutosFornecedores() : base()
        {
            _codigoProdutoFornecedor = "";
            _fornecedor = new Fornecedores();
            _produto = new Produto();
        }

        public ProdutosFornecedores(int id, string codigoProdutoFornecedor, Fornecedores fornecedor, Produto produto, DateTime dataUltAlteracao, DateTime dataCriacao) : base(id, dataCriacao, dataUltAlteracao)
        {
            CodigoProdutoFornecedor = codigoProdutoFornecedor;
            Fornecedor = fornecedor;
            Produto = produto;
        }

        public string CodigoProdutoFornecedor
        {
            get => _codigoProdutoFornecedor;
            set => _codigoProdutoFornecedor = value;
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
    }
}
