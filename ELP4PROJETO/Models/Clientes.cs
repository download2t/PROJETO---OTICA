using System;

namespace ELP4PROJETO.Classes
{
    public class Clientes : Pai
    {
        private string _statusCliente;
        private string _nome;
        private string _sexo;
        private string _apelido;
        private string _rg;
        private string _cpf;
        private string _email;
        private string _telefone;
        private string _celular;
        private string _cep;
        private string _endereco;
        private int _numero;
        private string _complemento;
        private string _bairro;
        private CondicaoPagamento _condicaoPagamento;
        private Cidades aCidade;
        private DateTime _dataNasc;
        private string _tipoCliente;
        private string _outros;

        public Clientes() : base()
        {
            _statusCliente = "";
            _nome = "";
            _sexo = "";
            _apelido = "";
            _rg = "";
            _cpf = "";
            _email = "";
            _telefone = "";
            _celular = "";
            _cep = "";
            _endereco = "";
            _numero = 0;
            _complemento = "";
            _bairro = "";
            _outros = "";
            aCidade = new Cidades();
            _dataNasc = DateTime.Now;
            _condicaoPagamento = new CondicaoPagamento();
            _tipoCliente = "";
        }

        public Clientes(int id, string outros, string statusCliente, string nome, string sexo, string apelido, string rg, string cpf, string tipoCliente,
                        string email, string telefone, string celular, string cep, string endereco, int numero, CondicaoPagamento condicao,
                        string complemento, string bairro, Cidades cidade, DateTime dataNasc, DateTime dataUltAlteracao,
                        DateTime dataCriacao) : base(id, dataCriacao, dataUltAlteracao)
        {
            StatusCliente = statusCliente;
            Nome = nome;
            Sexo = sexo;
            Apelido = apelido;
            RG = rg;
            CPF = cpf;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            CEP = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            DataNasc = dataNasc;
            CondicaoPagamento = condicao;
            TipoCliente = tipoCliente;
            Outros = outros;

        }
        public string Outros
        {
            get => _outros;
            set => _outros = value;
        }


        public string StatusCliente
        {
            get => _statusCliente;
            set => _statusCliente = value;
        }

        public string TipoCliente
        {
            get => _tipoCliente;
            set => _tipoCliente = value;
        }


        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string Sexo
        {
            get => _sexo;
            set => _sexo = value;
        }

        public string Apelido
        {
            get => _apelido;
            set => _apelido = value;
        }

        public string RG
        {
            get => _rg;
            set => _rg = value;
        }

        public string CPF
        {
            get => _cpf;
            set => _cpf = value;
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
            get => aCidade;
            set => aCidade = value;
        }
        public CondicaoPagamento CondicaoPagamento
        {
            get => _condicaoPagamento;
            set => _condicaoPagamento = value;
        }

        public DateTime DataNasc
        {
            get => _dataNasc;
            set => _dataNasc = value;
        }
    }
}
