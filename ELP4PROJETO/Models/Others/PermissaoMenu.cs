using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Classes
{
    public class PermissaoMenu : Pai
    {

        public Funcionarios _funcionario;
        public Opcoes opcao;
        public bool _podeAdicionar;
        public bool _podeAlterar;
        public bool _podeExcluir;
        public bool _podeConsultar;

        public Funcionarios Funcionario
        {
            get { return _funcionario; }
            set { _funcionario = value; }
        }
        public Opcoes Opcao
        {
            get { return opcao; }
            set { opcao = value; }
        }
        public bool PodeAdicionar
        {
            get { return _podeAdicionar; }
            set { _podeAdicionar = value; }
        }
        public bool PodeAlterar
        {
            get { return _podeAlterar; }
            set { _podeAlterar = value; }
        }
        public bool PodeExcluir
        {
            get { return _podeExcluir; }
            set { _podeExcluir = value; }
        }
        public bool PodeConsultar
        {
            get { return _podeConsultar; }
            set { _podeConsultar = value; }
        }


        public PermissaoMenu() : base()
        {
            _funcionario = new Funcionarios();
            opcao = new Opcoes();
            _podeAdicionar = false;
            _podeAlterar = false;
            _podeExcluir = false;
            _podeConsultar = false;
        }
        public PermissaoMenu(Funcionarios funcionario, Opcoes aopcao, bool adicionar, bool alterar, bool excluir, bool consultar) 
        {
            _funcionario = funcionario;
            opcao = aopcao;
            _podeAdicionar = adicionar;
            _podeAlterar = alterar;
            _podeConsultar = consultar;
            _podeExcluir = excluir;

        }
    }
}