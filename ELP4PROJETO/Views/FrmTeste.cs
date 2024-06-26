using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELP4PROJETO
{

    public partial class FrmTeste : Form
    {
        private Interfaces ainter;
        private Paises oPais;
        private Estados oEstado;
        private Cidades aCidade;
        private Clientes oCliente;
        private Fornecedores oFornecedor;
        private Funcionarios oFuncionario;
        private Cargos oCargo;
        private FormaPagamento aFormaPagamento;
        private CondicaoPagamento aCondicaoPagamento;
        private Parcela aParcela;
        private Produto oProduto;
        private Categoria aCategoria;
        private Compra aCompra;
        private ProdutosFornecedores oProdForn;
        private Marca aMarca;
        private Doutor oDoutor;
        private Laboratorio oLaboratorio;
        private Receita aReceita;
        private Button ultimoBotaoClicado;

        public FrmTeste()
        {
            InitializeComponent();
            InstanciarClasses();
        }

        private void InstanciarClasses()
        {
            ainter = new Interfaces();
            oPais = new Paises();
            oEstado = new Estados();
            aCidade = new Cidades();
            oCliente = new Clientes();
            oFornecedor = new Fornecedores();
            oFuncionario = new Funcionarios();
            oCargo = new Cargos();
            aFormaPagamento = new FormaPagamento();
            aCondicaoPagamento = new CondicaoPagamento();
            aParcela = new Parcela();
            aCategoria = new Categoria();
            aCompra = new Compra();
            oProdForn = new ProdutosFornecedores();
            aMarca = new Marca();
            aReceita = new Receita();
        }

        // menus de consulta
        private void consPaises_Click(object sender, EventArgs e)
        {
            ainter.PecaPaises(oPais);// Consultar Países
        }
        private void consEstados_Click(object sender, EventArgs e)
        {
            ainter.PecaEstados(oEstado); // Consultar Estados 
        }
        private void consCidades_Click(object sender, EventArgs e)
        {
            ainter.PecaCidades(aCidade);// Consultar Cidades
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ainter.PecaClientes(oCliente);// Consultar Clientes
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ainter.PecaFuncionarios(oFuncionario);//Consultar Funcionarios
        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ainter.PecaCargos(oCargo);//Consultar Cargos
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ainter.PecaFormaPagamento(aFormaPagamento);//Consultar Forma de pagamento
        }

        private void conCondicaoDePagamento_Click(object sender, EventArgs e)
        {
            ainter.PecaCondicaoPG(aCondicaoPagamento); // Consultar Condição de pagamentos
        }

        private void conProdutos_Click(object sender, EventArgs e)
        {
            ainter.PecaProdutos(oProduto); // Consultar Produtos;
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ainter.PecaCategorias(aCategoria); //Consultar Categorias
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ainter.PecaCompra(aCompra); // Consultar Compras.
        }

        private void compraCadastroTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCompra frm = new FrmCadastroCompra();
            frm.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ainter.PecaFornecedores(oFornecedor); // Consultar Fornecedores
        }

        private void produtosForn_Click(object sender, EventArgs e)
        {
            ainter.PecaProdutoFornecedor(oProdForn); // Consultar Produtos do Fornecedor.
        }

        private void conFornecedores_Click(object sender, EventArgs e)
        {
            ainter.PecaFornecedores(oFornecedor); // Consultar Fornecedores
        }

        private void Marca_Click(object sender, EventArgs e)
        {
            ainter.PecaMarca(aMarca); // consultar marcas
        }

        private void Doutores_Click(object sender, EventArgs e)
        {
            ainter.PecaDoutor(oDoutor); // Consultar Doutores 
        }

        private void Laboratorios_Click(object sender, EventArgs e)
        {
            ainter.PecaLaboratorio(oLaboratorio); // Consultar Laboratórios
        }

        private void Receitas_Click(object sender, EventArgs e)
        {
            ainter.PecaReceita(aReceita); // Consultar Receitas
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void AtualizarImagemBotao(Button botaoAtual, Image imagem)
        {
            // Se existir um último botão clicado, remova a imagem dele
            if (ultimoBotaoClicado != null)
            {
                ultimoBotaoClicado.Image = null;
            }

            // Defina a imagem no botão atual
            botaoAtual.Image = imagem;
            botaoAtual.ImageAlign = ContentAlignment.MiddleLeft;

            // Atualize o último botão clicado para o botão atual
            ultimoBotaoClicado = botaoAtual;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {

            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void btnLocalizacoes_Click(object sender, EventArgs e)
        {

            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            AtualizarImagemBotao(botaoAtual, Properties.Resources.Seta);
        }
    }
}
