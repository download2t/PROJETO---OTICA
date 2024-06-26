using System;

namespace ELP4PROJETO.Classes
{
    public class Fornecedores : Pai
    {
        private string _statusFornecedor;
        private string _nomeFantasia;
        private string _razaoSocial;
        private DateTime _dataFundacao;
        private string _inscricaoMunicipal;
        private string _inscricaoEstadual;
        private string _cnpj;
        private string _email;
        private string _telefone;
        private string _celular;
        private string _cep;
        private string _endereco;
        private int _numero;
        private string _complemento;
        private string _bairro;
        private string _rg;
        private string _tipoFornecedor;
        private Cidades _cidade;
        private CondicaoPagamento _condicaoPagamento;

        public Fornecedores() : base()
        {
            _statusFornecedor = "";
            _nomeFantasia = "";
            _razaoSocial = "";
            _dataFundacao = DateTime.Now;
            _inscricaoMunicipal = "";
            _inscricaoEstadual = "";
            _cnpj = "";
            _email = "";
            _telefone = "";
            _celular = "";
            _cep = "";
            _endereco = "";
            _numero = 0;
            _complemento = "";
            _bairro = "";
            _rg = "";
            _tipoFornecedor = "";
            _condicaoPagamento = new CondicaoPagamento();
            _cidade = new Cidades();
        }

        public Fornecedores(int id, string statusFornecedor, string nomeFantasia, string razaoSocial, DateTime dataFundacao,
            string inscricaoMunicipal, string inscricaoEstadual, string cnpj, string email, string telefone, string celular, string tipoFornecedor,
            string cep, string endereco, int numero, string complemento, string bairro, Cidades cidade, DateTime dataCriacao, string rg,
            DateTime dataUltAlteracao, CondicaoPagamento condicaoPagamento) : base(id, dataCriacao, dataUltAlteracao)
        {
            StatusFornecedor = statusFornecedor;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            DataFundacao = dataFundacao;
            InscricaoMunicipal = inscricaoMunicipal;
            InscricaoEstadual = inscricaoEstadual;
            CNPJ = cnpj;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            CEP = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            TipoFornecedor = tipoFornecedor;
            RG = rg;
            _condicaoPagamento = condicaoPagamento;
        }
        public CondicaoPagamento CondicaoPagamento
        {
            get => _condicaoPagamento;
            set => _condicaoPagamento = value;
        }
        public string RG
        {
            get => _rg;
            set => _rg = value;
        }
        public string TipoFornecedor
        {
            get => _tipoFornecedor;
            set => _tipoFornecedor = value;
        }

        public string StatusFornecedor
        {
            get => _statusFornecedor;
            set => _statusFornecedor = value;
        }

        public string NomeFantasia
        {
            get => _nomeFantasia;
            set => _nomeFantasia = value;
        }

        public string RazaoSocial
        {
            get => _razaoSocial;
            set => _razaoSocial = value;
        }

        public DateTime DataFundacao
        {
            get => _dataFundacao;
            set => _dataFundacao = value;
        }

        public string InscricaoMunicipal
        {
            get => _inscricaoMunicipal;
            set => _inscricaoMunicipal = value;
        }

        public string InscricaoEstadual
        {
            get => _inscricaoEstadual;
            set => _inscricaoEstadual = value;
        }

        public string CNPJ
        {
            get => _cnpj;
            set => _cnpj = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Telefone
        {
            get => _telefone;
            set => _telefone = value;
        }

        public string Celular
        {
            get => _celular;
            set => _celular = value;
        }

        public string CEP
        {
            get => _cep;
            set => _cep = value;
        }

        public string Endereco
        {
            get => _endereco;
            set => _endereco = value;
        }

        public int Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public string Complemento
        {
            get => _complemento;
            set => _complemento = value;
        }

        public string Bairro
        {
            get => _bairro;
            set => _bairro = value;
        }

        public Cidades Cidade
        {
            get => _cidade;
            set => _cidade = value;
        }
    }
}
