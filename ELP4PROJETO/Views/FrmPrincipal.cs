using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
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

namespace ELP4PROJETO.Views
{
    public partial class FrmPrincipal : Form
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
        private Marca aMarca;
        private Doutor oDoutor;
        private Laboratorio oLaboratorio;
        private Receita aReceita;
        private Servico oServico;
        private Venda aVenda;

        private string TagSelecionada;

        public FrmPrincipal()
        {
            InitializeComponent();

            if (UsuarioLogado.IsLoggedIn())
            {
                var funcionario = UsuarioLogado.Funcionario;// Funcionário logado no sistema.
                lblBoasVindas.Text = "Bem vindo  " + funcionario.Nome;
            }
            InstanciarClasses();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair desta sessão?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                UsuarioLogado.Logout(); //desloga o usuario autenticado
                this.Hide();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
            else
            {
                return;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja sair desta sessão?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
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
            aMarca = new Marca();
            aReceita = new Receita();
            oServico = new Servico();
            aVenda = new Venda();
        }
        private void ConfigurarBotoesMenu(List<Button> botoes, List<string> imagens, List<string> textos, List<string> tags, int visiveis)
        {
            ResetarCoresItens();
            DeixarSemFoto();
            BloquearOuDesbloquear(true); // Alterado para true pois é o valor padrão

            for (int i = 0; i < botoes.Count; i++)
            {
                botoes[i].Visible = i < visiveis;
                if (i < imagens.Count)
                {
                    botoes[i].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(imagens[i]);
                }
                if (i < textos.Count)
                {
                    botoes[i].Text = textos[i];
                    botoes[i].ForeColor = Color.Black; // Definir cor do texto como preto
                }
                if (i < tags.Count)
                {
                    botoes[i].Tag = tags[i];
                }
            }
        }
        private void VerificarTag()
        {
            if (!string.IsNullOrEmpty(TagSelecionada))
            {
                var acoes = new Dictionary<string, Action>
                {
                    { "PAISES", () => ainter.PecaPaises(oPais) },
                    { "ESTADOS", () => ainter.PecaEstados(oEstado) },
                    { "CIDADES", () => ainter.PecaCidades(aCidade) },
                    { "CLIENTES", () => ainter.PecaClientes(oCliente) },
                    { "FORNECEDORES", () => ainter.PecaFornecedores(oFornecedor) },
                    { "FUNCIONÁRIOS", () => ainter.PecaFuncionarios(oFuncionario) },
                    { "DOUTORES", () => ainter.PecaDoutor(oDoutor) },
                    { "CARGOS", () => ainter.PecaCargos(oCargo) },
                    { "FORMA DE PAGAMENTO", () => ainter.PecaFormaPagamento(aFormaPagamento) },
                    { "CONDIÇÃO DE PAGAMENTO", () => ainter.PecaCondicaoPG(aCondicaoPagamento) },
                    { "CATEGORIAS", () => ainter.PecaCategorias(aCategoria) },
                    { "PRODUTOS", () => ainter.PecaProdutos(oProduto) },
                    { "MARCAS", () => ainter.PecaMarca(aMarca) },
                    { "LABORATÓRIOS", () => ainter.PecaLaboratorio(oLaboratorio) },
                    { "RECEITAS", () => ainter.PecaReceita(aReceita) },
                    { "COMPRAS", () => ainter.PecaCompra(aCompra) },
                    { "SERVIÇO", () => ainter.PecaServico(oServico) },
                    { "VENDA", () => ainter.PecaVenda(aVenda) },
                    { "SAIR", () => btnSair_Click(null, EventArgs.Empty) },
                    { "LOG_OUT", () => btnLogout_Click(null, EventArgs.Empty) },
                    { "ALTERAR SENHA", () => ainter.PecaSenha(oFuncionario) },
                };

                if (acoes.ContainsKey(TagSelecionada))
                {
                    acoes[TagSelecionada]();
                }
                else
                {
                    MessageBox.Show("Ação não definida para esta tag.");
                }
            }
        }

        private void btnLocalizacoes_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnLocalizacoes);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Paises", "Estados", "Cidades" }, //IMG
                new List<string> { "PAÍSES", "ESTADOS", "CIDADES" }, //TEXT
                new List<string> { "PAISES", "ESTADOS", "CIDADES" }, //TAG
                3);
        }
        private void btnPessoas_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnPessoas);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Clientes", "Fornecedores", "Funcionarios", "Doutores" }, //IMG
                new List<string> { "CLIENTES", "FORNECEDORES", "FUNCIONÁRIOS", "DOUTORES" }, //TEXT
                new List<string> { "CLIENTES", "FORNECEDORES", "FUNCIONÁRIOS", "DOUTORES" }, //TAG
                4);
        }
        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnPagamentos);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Forma_Pagamento", "Condicao_pagamento" }, //IMG
                new List<string> { "FORMA DE PAGAMENTO", "CONDIÇÃO DE PAGAMENTO" }, // TEXT
                new List<string> { "FORMA DE PAGAMENTO", "CONDIÇÃO DE PAGAMENTO" }, //TAG 
                2);
        }
        private void btnFuncao_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnFuncao);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Cargos" }, // IMG
                new List<string> { "CARGOS" }, //TEXT
                new List<string> { "CARGOS" }, // TAG
                1);
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;

            DestacarMenu(btnProdutos);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Categorias", "Produtos", "Marcas" }, // IMG
                new List<string> { "CATEGORIAS", "PRODUTOS", "MARCAS" }, // TEXT
                new List<string> { "CATEGORIAS", "PRODUTOS", "MARCAS" }, // TAG
                3);
        }
        private void btnServicos_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnServicos);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "Laboratorios", "Receitas", "Compras", "Vendas", "Servicos" }, // IMG 
                new List<string> { "LABORATÓRIOS", "RECEITAS", "COMPRAS", "VENDAS", "SERVIÇOS" }, // TEXT
                new List<string> { "LABORATÓRIOS", "RECEITAS", "COMPRAS", "VENDA", "SERVIÇO" },  // TAG
                5);
        }

        private void btnATENDIMENTO_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnATENDIMENTO);
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 },
                new List<string> { "sem_foto", "sem_foto", "sem_foto", "sem_foto", "sem_foto" }, //IMG
                new List<string> { "CONSULTAR PREÇO", "ORÇAMENTO", "VENDA", "RECEITAS2", "NFC-e" }, //TEXT
                new List<string> { "CONSULTAR PREÇO", "ORÇAMENTO", "VENDA", "RECEITAS2", "NFC-e" }, //TAG
                5);
        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnFinanceiro); // Destacar o botão do menu clicado

            // Configurar os botões do menu com imagens, textos e tags específicos para "Financeiro"
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 }, // Lista de botões
                new List<string> { "sem_foto", "sem_foto", "sem_foto", "sem_foto" }, // Lista de nomes de imagens
                new List<string> { "CAIXA", "CONTAS A PAGAR", "CONTAS A RECEBER", "FLUXO DE CAIXA" }, // Lista de textos dos botões
                new List<string> { "CAIXA", "CONTAS A PAGAR", "CONTAS A RECEBER", "FLUXO DE CAIXA" }, // Lista de tags dos botões
                4); // 
            BloquearOuDesbloquear(false); // deixar estes campos bloqueados

        }
        private void btnSistema_Click(object sender, EventArgs e)
        {
            Button botaoAtual = (Button)sender;
            DestacarMenu(btnSistema); // Destacar o botão do menu clicado

            // Configurar os botões do menu com imagens, textos e tags específicos para "Financeiro"
            ConfigurarBotoesMenu(
                new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 }, // Lista de botões
                new List<string> { "Sair", "Logout", "Alterar_Senha" }, // Lista de nomes de imagens
                new List<string> { "SAIR", "LOG_OUT", "ALTERAR SENHA" }, // Lista de textos dos botões
                new List<string> { "SAIR", "LOG_OUT", "ALTERAR SENHA" }, // Lista de tags dos botões
                3); // 
            BloquearOuDesbloquear(true); // deixar estes campos bloqueados

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn1.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn2.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn3.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn4.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn5.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn6.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn7.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            TagSelecionada = btn8.Tag.ToString();
            VerificarTag();
            DestacarItemMenu(btn8);
        }
        private void DestacarMenu(Button btn)
        {
            DestacarBotao(btn, new List<Button>
            {
                btnLocalizacoes, btnPessoas, btnPagamentos, btnFuncao,
                btnProdutos, btnServicos, btnATENDIMENTO, btnFinanceiro, btnSistema
            }, Color.FromArgb(135, 155, 183), Color.FromArgb(45, 65, 93), lblDesc);
            pbFoto.Visible = false;
        }
        private void DestacarItemMenu(Button btn)
        {
            foreach (Button b in new List<Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8 })
            {
                b.BackColor = Color.FromArgb(135, 155, 183);
                b.ForeColor = Color.Black; // Resetar a cor do texto dos outros botões para preto
            }

            btn.BackColor = Color.FromArgb(45, 65, 93); // Cor de fundo destacada
            btn.ForeColor = Color.White; // Alterar a cor do texto do botão destacado para branco
            lblDescricaoItem.Text = btn.Text; // Atualizar descrição
        }
        private void DestacarBotao(Button btn, List<Button> botoes, Color corPadrao, Color corDestaque, Label lbl)
        {
            foreach (Button b in botoes)
            {
                b.BackColor = corPadrao;
                b.ForeColor = Color.Black; // Reseta a cor do texto dos outros botões para preto
            }
            btn.BackColor = corDestaque;
            btn.ForeColor = Color.White; // Altera a cor do texto do botão destacado para branco
            lbl.Text = btn.Text;
        }
        private void BloquearOuDesbloquear(bool valor)
        {
            btn1.Enabled = valor;
            btn2.Enabled = valor;
            btn3.Enabled = valor;
            btn4.Enabled = valor;
            btn5.Enabled = valor;
            btn6.Enabled = valor;
            btn7.Enabled = valor;
            btn8.Enabled = valor;
        }
        private void ResetarCoresItens()
        {
            btn1.BackColor = Color.FromArgb(135, 155, 183);
            btn2.BackColor = Color.FromArgb(135, 155, 183);
            btn3.BackColor = Color.FromArgb(135, 155, 183);
            btn4.BackColor = Color.FromArgb(135, 155, 183);
            btn5.BackColor = Color.FromArgb(135, 155, 183);
            btn6.BackColor = Color.FromArgb(135, 155, 183);
            btn7.BackColor = Color.FromArgb(135, 155, 183);
            btn8.BackColor = Color.FromArgb(135, 155, 183);
            lblDescricaoItem.Text = "";
        }

        private void DeixarSemFoto()
        {
            btn1.BackgroundImage = Properties.Resources.sem_foto;
            btn2.BackgroundImage = Properties.Resources.sem_foto;
            btn3.BackgroundImage = Properties.Resources.sem_foto;
            btn4.BackgroundImage = Properties.Resources.sem_foto;
            btn5.BackgroundImage = Properties.Resources.sem_foto;
            btn6.BackgroundImage = Properties.Resources.sem_foto;
            btn7.BackgroundImage = Properties.Resources.sem_foto;
            btn8.BackgroundImage = Properties.Resources.sem_foto;
        }
        private void FrmTestes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedores frm = new FrmCadastroFornecedores();
            frm.ShowDialog();
        }


    }
}
