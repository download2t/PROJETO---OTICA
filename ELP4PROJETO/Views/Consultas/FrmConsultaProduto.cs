using ELP4PROJETO.Classes;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaProduto : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroProduto frmcadProduto;
        Produto oProduto;
        CTLProdutos aCTLProduto; // Alteração de CTLProduto para CTLProduto
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public string Und { get; private set; }
        string status = "A";
        public FrmConsultaProduto()
        {
            InitializeComponent();
            aCTLProduto = new CTLProdutos();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmcadProduto = (FrmCadastroProduto)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Produto)
            {
                oProduto = (Produto)obj;
            }
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLProduto.Incluir(); // Alteração de CTLProduto para CTLProduto
            CarregaLV();
        }
        protected override void Alterar()
        {
            base.Alterar();
            int idProduto = ObterIdSelecionado(); // Alteração de idProduto para idProduto
            if (idProduto > 0)
            {
                Produto Produto = aCTLProduto.BuscarProdutoPorId(idProduto); // Alteração de Produto para Produto, CTLProduto para CTLProduto
                if (Produto != null)
                {
                    aCTLProduto.Alterar(Produto); // Alteração de Produto para Produto, CTLProduto para CTLProduto
                    CarregaLV();
                }
            }
        }
        public override void Excluir()
        {
            base.Excluir();
            int idProduto = ObterIdSelecionado(); // Alteração de idProduto para idProduto
            if (idProduto > 0)
            {
                Produto Produto = aCTLProduto.BuscarProdutoPorId(idProduto); // Alteração de Produto para Produto, CTLProduto para CTLProduto
                if (Produto != null)
                {
                    aCTLProduto.Excluir(Produto); // Alteração de Produto para Produto, CTLProduto para CTLProduto
                    CarregaLV();
                }
            }
        }
        public override void Visualizar()
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.PerformClick();
            }
            else if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                Produto Produto = selectedItem.Tag as Produto; // Alteração de Produto para Produto

                if (Produto != null)
                {
                    aCTLProduto.Visualizar(Produto); // Alteração de Produto para Produto, CTLProduto para CTLProduto
                }
            }
        }
        private void PreencherListView(IEnumerable<Produto> Produtos) // Alteração de IEnumerable<Produto> para IEnumerable<Produto>
        {
            listView1.Items.Clear();

            foreach (var Produto in Produtos) // Alteração de var Produto em Produtos para var Produto em Produtos
            {
                ListViewItem item = new ListViewItem(Convert.ToString(Produto.ID));
                item.SubItems.Add(Produto.Categoria.Nome);
                item.SubItems.Add(Produto.Nome);
                item.SubItems.Add(Produto.DescricaoProduto);
                item.SubItems.Add(Produto.Marca.Nome);
                item.SubItems.Add(Produto.PrecoCusto.ToString("C"));
                item.SubItems.Add(Produto.PrecoVenda.ToString("C"));
                item.SubItems.Add(Produto.UnidadeMedida);
                item.SubItems.Add(Produto.QtdEstoque.ToString());
                item.SubItems.Add(Produto.DataCriacao.ToString());
                item.SubItems.Add(Produto.DataUltimaAlteracao.ToString());
                item.SubItems.Add(Produto.Status == "I" ? "Inativo" : Produto.Status == "A" ? "Ativo" : Produto.Status);
                item.SubItems.Add(Produto.Referencia);
                item.Tag = Produto;
                listView1.Items.Add(item);
            }
        }
        public override void CarregaLV()
        {

            base.CarregaLV();
            List<Produto> Produtos = aCTLProduto.ListarProdutos(status); // Alteração de List<Produto> para List<Produto>, CTLProduto para CTLProduto
            PreencherListView(Produtos); // Alteração de IEnumerable<Produto> para IEnumerable<Produto>

        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLProduto.PesquisarProdutosPorCriterio(criterioPesquisa, valorPesquisa, status);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
            }
        }
        protected override void Atualizar()
        {
            base.Atualizar();
            CarregaLV();
        }
        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbCategoria.Checked)
            {
                return "CATEGORIA"; // Pesquisar pela Produto
            }
            else if (rbProduto.Checked)
            {
                return "PRODUTO"; // Pesquisar pela Produto
            }
            return string.Empty; // Nenhum critério selecionado
        }
        protected override void Sair()
        {
            if (btnSair.Text == "Sair")
            {
                base.Sair();
            }
            else if (btnSair.Text == "Selecionar")
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    IdSelecionado = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    NomeSelecionado = listView1.SelectedItems[0].SubItems[1].Text;
                    Und = listView1.SelectedItems[0].SubItems[8].Text;
                }
                this.Close();
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInativos.Checked)
            {
                status = "I";
                btnStatus.Text = "Ativar";
            }
            else
            {
                status = "A";
                btnStatus.Text = "Desativar";
                btnIncluir.Enabled = btnAlterar.Enabled = true;
            }

            btnIncluir.Enabled = btnAlterar.Enabled = !cbInativos.Checked;
            CarregaLV();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int idCondicao = ObterIdSelecionado();
            if (idCondicao > 0)
            {
                Produto produto = aCTLProduto.BuscarProdutoPorId(idCondicao);
                if (produto != null)
                {
                    aCTLProduto.Desativar(produto);
                    CarregaLV();
                }
            }
        }
    }
}
