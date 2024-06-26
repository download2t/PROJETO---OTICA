using ELP4PROJETO.Classes;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaProdutosFornecedor : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroProdutosFornecedor frmCadProdF;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        CTLProdutosFornecedores aCTLProdutosF;
        ProdutosFornecedores oProdF;
        private string status = "A";
        public FrmConsultaProdutosFornecedor()
        {
            InitializeComponent();
            aCTLProdutosF = new CTLProdutosFornecedores();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadProdF = (FrmCadastroProdutosFornecedor)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oProdF = (ProdutosFornecedores)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLProdutosF.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idProdF = ObterIdSelecionado();
            if (idProdF > 0)
            {
                ProdutosFornecedores prodF = aCTLProdutosF.BuscarProdutoFornecedorPorId(idProdF);
                if (prodF != null)
                {
                    aCTLProdutosF.Alterar(prodF);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idProdF = ObterIdSelecionado();
            if (idProdF > 0)
            {
                ProdutosFornecedores prodF = aCTLProdutosF.BuscarProdutoFornecedorPorId(idProdF);
                if (prodF != null)
                {
                    aCTLProdutosF.Excluir(prodF);
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
                ProdutosFornecedores prodF = selectedItem.Tag as ProdutosFornecedores;
                if (prodF != null)
                {
                    aCTLProdutosF.Visualizar(prodF);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<ProdutosFornecedores> dados = aCTLProdutosF.ListarProdutosFornecedores(status);
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<ProdutosFornecedores> dados)
        {
            listView1.Items.Clear();

            foreach (var prodF in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(prodF.ID));
                item.SubItems.Add(prodF.Produto.ID.ToString());
                item.SubItems.Add(prodF.Produto.Nome);
                item.SubItems.Add(prodF.Fornecedor.ID.ToString());
                item.SubItems.Add(prodF.Fornecedor.NomeFantasia);
                item.SubItems.Add(prodF.CodigoProdutoFornecedor);
                item.SubItems.Add(prodF.DataCriacao.ToString());
                item.SubItems.Add(prodF.DataUltimaAlteracao.ToString());
                item.Tag = prodF;
                listView1.Items.Add(item);
            }
        }

        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
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
                }
                this.Close();
            }
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbProduto.Checked)
            {
                return "PRODUTOS";
            }
            else if (rbFornecedor.Checked)
            {
                return "FORNECEDORES";
            }

            return string.Empty; // Nenhum critério selecionado
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLProdutosF.PesquisarProdutosFornecedoresPorCriterio(criterioPesquisa, valorPesquisa, status);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInativos.Checked)
                status = "I";
            else
                status = "A";
            CarregaLV();
        }
    }
}
