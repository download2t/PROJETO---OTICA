using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class Funcionarios : Pai
    {
        private string _statusFuncionario;
        private string _nome;
        private string _apelido;
        private string _sexo;
        private string _rg;
        private string _cpf;
        private string _email;
        private string _senha;
        private string _telefone;
        private string _celular;
        private string _cep;
        private string _endereco;
        private int _numero;
        private string _complemento;
        private string _bairro;
        private DateTime _dataNasc;
        private Cidades _cidade;
        private Cargos _cargo;

        public Funcionarios() : base()
        {
            _statusFuncionario = "";
            _nome = "";
            _apelido = "";
            _sexo = "";
            _rg = "";
            _cpf = "";
            _email = "";
            _senha = "";
            _telefone = "";
            _celular = "";
            _cep = "";
            _endereco = "";
            _numero = 0;
            _complemento = "";
            _bairro = "";
            _dataNasc = DateTime.Now;
            _cidade = new Cidades();
            _cargo = new Cargos();
        }

        public Funcionarios(int id, string statusFuncionario, string nome, string apelido, string sexo, string rg, string cpf,
            string email, string senha, string telefone, string celular, string cep, string endereco, int numero, string complemento,
            string bairro, DateTime dataNasc, Cidades cidade, Cargos cargo, DateTime dataCriacao, DateTime dataUltAlteracao) : base(id, dataCriacao, dataUltAlteracao)
        {
            StatusFuncionario = statusFuncionario;
            Nome = nome;
            Apelido = apelido;
            Sexo = sexo;
            RG = rg;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Telefone = telefone;
            Celular = celular;
            CEP = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            DataNascimento = dataNasc;
            Cidade = cidade;
            Cargo = cargo;
        }

        public string StatusFuncionario
        {
            get => _statusFuncionario;
            set => _statusFuncionario = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public string Apelido
        {
            get => _apelido;
            set => _apelido = value;
        }

        public string Sexo
        {
            get => _sexo;
            set => _sexo = value;
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

        public string Senha
        {
            get => _senha;
            set => _senha = value;
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

        public DateTime DataNascimento
        {
            get => _dataNasc;
            set => _dataNasc = value;
        }

        public Cidades Cidade
        {
            get => _cidade;
            set => _cidade = value;
        }

        public Cargos Cargo
        {
            get => _cargo;
            set => _cargo = value;
        }
    }
}
