using ELP4PROJETO.Classes;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaCategoria : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroCategoria frmCadastro;
        CTLCategoria aCTLCategorias; // Alteração de aCTLCategoriass para aCTLCategorias
        Categoria oCategoria; // Alteração de Categorias para Categoria
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public FrmConsultaCategoria()
        {
            InitializeComponent();
            aCTLCategorias = new CTLCategoria(); // Alteração de aCTLCategoriass para aCTLCategorias
        }
   public override void SetFrmCadastro(object obj)
        {
            if (obj is FrmCadastroCategoria)
            {
                frmCadastro = (FrmCadastroCategoria)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);

            if (obj is Categoria) // Alteração de Categorias para Categoria
            {
                oCategoria = (Categoria)obj; // Alteração de Categorias para Categoria
            }
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLCategorias.Incluir(); // Alteração de aCTLCategoriass para aCTLCategorias
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idCategoria = ObterIdSelecionado(); // Alteração de idCategorias para idCategoria
            if (idCategoria > 0)
            {
                Categoria Categoria = aCTLCategorias.BuscarCategoriaPorId(idCategoria); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
                if (Categoria != null)
                {
                    aCTLCategorias.Alterar(Categoria); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCategoria = ObterIdSelecionado(); // Alteração de idCategorias para idCategoria
            if (idCategoria > 0)
            {
                Categoria Categoria = aCTLCategorias.BuscarCategoriaPorId(idCategoria); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
                if (Categoria != null)
                {
                    aCTLCategorias.Excluir(Categoria); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
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
                Categoria Categoria = selectedItem.Tag as Categoria; // Alteração de Categorias para Categoria

                if (Categoria != null)
                {
                    aCTLCategorias.Visualizar(Categoria); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
                }
            }
        }
        private void PreencherFichasListView(IEnumerable<Categoria> Categorias) // Alteração de Categorias para Categoria
        {
            listView1.Items.Clear();

            foreach (var Categoria in Categorias) // Alteração de Categorias para Categoria
            {
                ListViewItem item = new ListViewItem(Convert.ToString(Categoria.ID)); // Alteração de Categorias para Categoria
                item.SubItems.Add(Categoria.Nome); // Alteração de Categorias para Categoria
                item.Tag = Categoria; // Alteração de Categorias para Categoria
                listView1.Items.Add(item);
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Categoria> Categorias = aCTLCategorias.ListarCategoria(); // Alteração de Categorias para Categoria, aCTLCategoriass para aCTLCategorias
            PreencherFichasListView(Categorias); // Alteração de Categorias para Categoria
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLCategorias.PesquisarCategoriaPorCriterio(criterioPesquisa, valorPesquisa); // Alteração de PesquisarCategoriassPorCriterio para PesquisarCategoriasPorCriterio

                // Use o método de preenchimento para atualizar a ListView
                PreencherFichasListView(resultados); // Alteração de Categorias para Categoria
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
                return "Categoria"; // Pesquisar pelo Categoria
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
                }
                this.Close();
            }
        }
    }
}
