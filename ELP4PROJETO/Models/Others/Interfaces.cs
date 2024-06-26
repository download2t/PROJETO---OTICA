using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views;
using ELP4PROJETO.Views.Cadastros;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELP4PROJETO.Classes
{
    internal class Interfaces
    {
        // Declarando Formulário de Cadastros
        FrmCadastroPais ofrmCadPaises;
        FrmCadastroEstado ofrmCadEstados;
        FrmCadastroCidade ofrmCadCidades;
        FrmCadastroCliente ofrmCadClientes;
        FrmCadastroFornecedores ofrmCadFornecedores;
        FrmCadastroCargo ofrmCadCargo;
        FrmCadastroFuncionario ofrmCadFuncionario;
        FrmCadastroFormaPagamento ofrmCadFormaPagamento;
        Frm ofrmCadCondPG; // nome do form bugou nao volta para FrmCadastroCondicaoPagamento
        FrmCadastroProduto ofrmCadProduto;
        FrmCadastroCategoria ofrmCadCategoria;
        FrmCadastroCompra ofrmCadCompra;
        FrmCadastroProdutosFornecedor ofrmCadProdForn;
        FrmCadastroMarca ofrmCadMarca;
        FrmCadastroDoutores oFrmCadDoutor;
        FrmCadastroLaboratorio ofrmCadLab;
        FrmCadastroReceita ofrmCadReceita;
        FrmCadastroServico ofrmCadServico;
        FrmCadastroVenda ofrmCadVenda;



        // Declarando Formulário de Consultas
        FrmConsultaPais ofrmConPaises;
        FrmConsultaEstado ofrmConEstados;
        FrmConsultaCidade ofrmConCidades;
        FrmConsultaCliente ofrmConClientes;
        FrmConsultaFornecedor ofrmConFornecedores;
        FrmConsultaCargo ofrmConCargo;
        FrmConsultaFuncionario ofrmConFuncionario;
        FrmConsultaFormaPagamento ofrmConFormaPagamento;
        FrmConsultaCondicaoPagamento ofrmConCondPG;
        FrmConsultaProduto ofrmConProduto;
        FrmConsultaCategoria ofrmConCategoria;
        FrmConsultaCompra ofrmConCompra;
        FrmConsultaProdutosFornecedor ofrmConProdForn;
        FrmConsultaMarca ofrmConMarca;
        FrmConsultaDoutores ofrmConDoutores;
        FrmConsultaLaboratorios ofrmConLab;
        FrmConsultaReceita ofrmConReceitas;
        FrmConsultaServico ofrmConServico;
        FrmConsultaVenda ofrmConVenda;
        FrmAlterarSenha ofrmAlterarSenha;


        public Interfaces()
        {
            //Instanciando Forms de cadastros
            ofrmCadPaises = new FrmCadastroPais();
            ofrmCadEstados = new FrmCadastroEstado();
            ofrmCadCidades = new FrmCadastroCidade();
            ofrmCadClientes = new FrmCadastroCliente();
            ofrmCadFornecedores = new FrmCadastroFornecedores();
            ofrmCadCargo = new FrmCadastroCargo();
            ofrmCadFuncionario = new FrmCadastroFuncionario();
            ofrmCadFormaPagamento = new FrmCadastroFormaPagamento();
            ofrmCadCondPG = new frm();
            ofrmCadProduto = new FrmCadastroProduto();
            ofrmCadCategoria = new FrmCadastroCategoria();
            ofrmCadCompra = new FrmCadastroCompra();
            ofrmCadProdForn = new FrmCadastroProdutosFornecedor();
            ofrmCadMarca = new FrmCadastroMarca();
            oFrmCadDoutor = new FrmCadastroDoutores();
            ofrmCadLab = new FrmCadastroLaboratorio();
            ofrmCadReceita = new FrmCadastroReceita();
            ofrmCadServico = new FrmCadastroServico();
            ofrmCadVenda = new FrmCadastroVenda();


            //Instanciando Forms de consutlas
            ofrmConPaises = new FrmConsultaPais();
            ofrmConEstados = new FrmConsultaEstado();
            ofrmConCidades = new FrmConsultaCidade();
            ofrmConClientes = new FrmConsultaCliente();
            ofrmConFornecedores = new FrmConsultaFornecedor();
            ofrmConCargo = new FrmConsultaCargo();
            ofrmConFuncionario = new FrmConsultaFuncionario();
            ofrmConFormaPagamento = new FrmConsultaFormaPagamento();
            ofrmConMarca = new FrmConsultaMarca();
            ofrmConCondPG = new FrmConsultaCondicaoPagamento();
            ofrmConProduto = new FrmConsultaProduto();
            ofrmConCategoria = new FrmConsultaCategoria();
            ofrmConCompra = new FrmConsultaCompra();
            ofrmConProdForn = new FrmConsultaProdutosFornecedor();
            ofrmConDoutores = new FrmConsultaDoutores();
            ofrmConLab = new FrmConsultaLaboratorios();
            ofrmConReceitas = new FrmConsultaReceita();
            ofrmConServico = new FrmConsultaServico();
            ofrmConVenda = new FrmConsultaVenda();
            ofrmAlterarSenha = new FrmAlterarSenha();   

            //Setar os metodos.

            ofrmConPaises.SetFrmCadastro(ofrmCadPaises); // Incluir Paises
            ofrmConEstados.SetFrmCadastro(ofrmCadEstados); //Incluir Estados 
            ofrmConCidades.SetFrmCadastro(ofrmCadCidades); //Incluir Cidades 
            ofrmConClientes.SetFrmCadastro(ofrmCadClientes); // Incluir Clientes 
            ofrmConFornecedores.SetFrmCadastro(ofrmCadFornecedores); // Incluir Fornecedores
            ofrmConCargo.SetFrmCadastro(ofrmCadCargo); // Incluir Cargo
            ofrmConFuncionario.SetFrmCadastro(ofrmCadFuncionario); // Incluir Funcionarios
            ofrmConFormaPagamento.SetFrmCadastro(ofrmCadFormaPagamento); // Incluir Forma de pagamentos
            ofrmConCondPG.SetFrmCadastro(ofrmCadCondPG); // Incluir Condição de pagamento
            ofrmConProduto.SetFrmCadastro(ofrmCadProduto); // Incluir Produtos
            ofrmConCategoria.SetFrmCadastro(ofrmCadCategoria); // Incluir Categoria
            ofrmConCompra.SetFrmCadastro(ofrmCadCompra); // Incluir Compra
            ofrmConProdForn.SetFrmCadastro(ofrmCadProdForn); // Incluir Produto do fornecedor
            ofrmConMarca.SetFrmCadastro(ofrmCadMarca); // Cadastrar Marca
            ofrmConLab.SetFrmCadastro(ofrmCadLab); // Cadastrar Laboratorios
            ofrmConDoutores.SetFrmCadastro(oFrmCadDoutor); // Cadastrar Doutores.
            ofrmConReceitas.SetFrmCadastro(ofrmCadReceita); // Cadastrar Receitas
            ofrmConServico.SetFrmCadastro(ofrmCadServico); // Cadastrar Serviços
            ofrmConVenda.SetFrmCadastro(ofrmCadVenda); // Cadastrar Compra


            ofrmCadEstados.SetConsultaPaises(ofrmConPaises);  // Consultar Paises (FORM ESTADOS)
            ofrmCadCidades.SetConsultaEstados(ofrmConEstados); // Consultar Estados (FORM CIDADES)
            ofrmCadClientes.SetConsultaCidades(ofrmConCidades); // Consultar Cidades (FORM DE CLIENTES)
            ofrmCadFornecedores.SetConsultaCidades(ofrmConCidades); // Consultar Cidade (FORM DE FORNECEDORES);
            ofrmCadProduto.SetConsultaCategorias(ofrmConCategoria); // Consultar Categorias (FORM PRODUTOS);
            ofrmCadCompra.SetConsultaFornecedor(ofrmConFornecedores); // Consultar Fornecedores(FORM COMPRA).
            ofrmCadProdForn.SetConsultaFornecedor(ofrmConFornecedores);// Consultar Fornecedores (FORM CADASTRO DE PRODUTOS DE FORNECEDORES)
            ofrmCadProdForn.SetConsultaProdutos(ofrmConProduto);// Consultar Produtos (FORM CADASTRO DE PRODUTOS DE FORNECEDORES)
            ofrmCadReceita.SetConsultaClientes(ofrmConClientes); // Consultar Cliente (Form Receitas)
            ofrmCadReceita.SetConsultaDoutores(ofrmConDoutores);// / Consultar Doutores (Form Receitas) 
            ofrmCadReceita.SetConsultaLaboratorios(ofrmConLab); //  Consultar Laboratorio (Form Receitas) 


        }
        public void PecaPaises(Paises oPais)
        {
            ofrmConPaises.ConhecaObj(oPais);
            ofrmConPaises.ShowDialog();
        }
        public void PecaEstados(Estados oEstado)
        {
            ofrmConEstados.ConhecaObj(oEstado);
            ofrmConEstados.ShowDialog();
        }
        public void PecaCidades(Cidades aCidade)
        {
            ofrmConCidades.ConhecaObj(aCidade);
            ofrmConCidades.ShowDialog();
        }
        public void PecaClientes(Clientes oCLiente)
        {
            ofrmConClientes.ConhecaObj(oCLiente);
            ofrmConClientes.ShowDialog();
        }
        public void PecaFornecedores(Fornecedores oFornecedor)
        {
            ofrmConFornecedores.ConhecaObj(oFornecedor);
            ofrmConFornecedores.ShowDialog();
        }
        public void PecaCargos(Cargos oCargo)
        {
            ofrmConCargo.ConhecaObj(oCargo);
            ofrmConCargo.ShowDialog();
        }
        public void PecaFuncionarios(Funcionarios oFunc)
        {
            ofrmConFuncionario.ConhecaObj(oFunc);
            ofrmConFuncionario.ShowDialog();
        }
        public void PecaFormaPagamento(FormaPagamento aForma)
        {
            ofrmConFormaPagamento.ConhecaObj(aForma);
            ofrmConFormaPagamento.ShowDialog();
        }

        public void PecaProdutos(Produto oProduto)
        {
            ofrmConProduto.ConhecaObj(oProduto);
            ofrmConProduto.ShowDialog();
        }
        public void PecaCategorias(Categoria aCategoria)
        {
            ofrmConCategoria.ConhecaObj(aCategoria);
            ofrmConCategoria.ShowDialog();
        }
        public void PecaCompra(Compra aCompra)
        {
            ofrmConCompra.ConhecaObj(aCompra);
            ofrmConCompra.ShowDialog();
        }
        public void PecaProdutoFornecedor(ProdutosFornecedores oProdForn)
        {
            ofrmConProdForn.ConhecaObj(oProdForn);
            ofrmConProdForn.ShowDialog();
        }
        public void PecaCondicaoPG(CondicaoPagamento aCondicao)
        {
            ofrmConCondPG.ConhecaObj(aCondicao);
            ofrmConCondPG.ShowDialog();
        }
        public void PecaMarca(Marca aMarca)
        {
            ofrmConMarca.ConhecaObj(aMarca);
            ofrmConMarca.ShowDialog();
        }

        public void PecaDoutor(Doutor oDr)
        {
            ofrmConDoutores.ConhecaObj(oDr);
            ofrmConDoutores.ShowDialog();
        }

        public void PecaLaboratorio(Laboratorio oLab)
        {
            ofrmConLab.ConhecaObj(oLab);
            ofrmConLab.ShowDialog();
        }
        public void PecaReceita(Receita aRec)
        {
            ofrmConReceitas.ConhecaObj(aRec);
            ofrmConReceitas.ShowDialog();
        }
        public void PecaServico(Servico oServ)
        {
            ofrmConServico.ConhecaObj(oServ);
            ofrmConServico.ShowDialog();
        }
        public void PecaVenda(Venda aVenda)
        {
            ofrmConVenda.ConhecaObj(aVenda);
            ofrmConVenda.ShowDialog();
        }
        public void PecaSenha(Funcionarios oFunc)
        {
            ofrmAlterarSenha.ConhecaObj(oFunc);
            ofrmAlterarSenha.ShowDialog();
        }
      
    }
}
