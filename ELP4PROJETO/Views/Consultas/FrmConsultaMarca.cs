using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaMarca : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroMarca frmCadMarcas;
        Marca aMarca;
        CTLMarca aCTLMarcas;

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }


        public FrmConsultaMarca()
        {
            InitializeComponent();
            aCTLMarcas = new CTLMarca();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadMarcas = (FrmCadastroMarca)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            aMarca = (Marca)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLMarcas.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idMarca = ObterIdSelecionado();
            if (idMarca > 0)
            {
                Marca marca = aCTLMarcas.BuscarMarcaPorId(idMarca);
                if (marca != null)
                {
                    aCTLMarcas.Alterar(marca);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idMarca = ObterIdSelecionado();
            if (idMarca > 0)
            {
                Marca marca = aCTLMarcas.BuscarMarcaPorId(idMarca);
                if (marca != null)
                {
                    aCTLMarcas.Excluir(marca);
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
                Marca marca = selectedItem.Tag as Marca;
                if (marca != null)
                {
                    aCTLMarcas.Visualizar(marca);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Marca> dados = aCTLMarcas.ListarMarcas();
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Marca> dados)
        {
            listView1.Items.Clear();

            foreach (var marca in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(marca.ID));
                item.SubItems.Add(marca.Nome);
                item.SubItems.Add(marca.Descricao);
                item.SubItems.Add(marca.DataCriacao.ToString());
                item.SubItems.Add(marca.DataUltimaAlteracao.ToString());
                item.Tag = marca;
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

        private string ObterCriterioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbNome.Checked)
            {
                return "NOME";
            }
            else if (rbDescricao.Checked)
            {
                return "DESCRICAO";
            }

            return string.Empty; // Nenhum critério selecionado
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCriterioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLMarcas.PesquisarMarcasPorCriterio(criterioPesquisa, valorPesquisa);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
            }
        }
    }
}
