using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ELP4PROJETO.Controllers;
using ELP4PROJETO.Models;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaDoutores : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroDoutores frmCadDoutor;
        Doutor oDoutor;
        CTLDoutores aCTLDoutores;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaDoutores()
        {
            InitializeComponent();
            aCTLDoutores = new CTLDoutores();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadDoutor = (FrmCadastroDoutores)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oDoutor = (Doutor)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLDoutores.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idDoutor = ObterIdSelecionado();
            if (idDoutor > 0)
            {
                Doutor doutor = aCTLDoutores.BuscarDoutorPorId(idDoutor);
                if (doutor != null)
                {
                    aCTLDoutores.Alterar(doutor);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idDoutor = ObterIdSelecionado();
            if (idDoutor > 0)
            {
                Doutor doutor = aCTLDoutores.BuscarDoutorPorId(idDoutor);
                if (doutor != null)
                {
                    aCTLDoutores.Excluir(doutor);
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
                Doutor doutor = selectedItem.Tag as Doutor;
                if (doutor != null)
                {
                    aCTLDoutores.Visualizar(doutor);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Doutor> dados = aCTLDoutores.ListarDoutores();
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Doutor> dados)
        {
            listView1.Items.Clear();

            foreach (var doutor in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(doutor.ID));
                item.SubItems.Add(doutor.Nome);
                item.SubItems.Add(doutor.DataCriacao.ToString());
                item.SubItems.Add(doutor.DataUltimaAlteracao.ToString());
                item.Tag = doutor;
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
            else if (rbDoutor.Checked)  // Supondo que há um RadioButton chamado rbNome
            {
                return "NOME";
            }

            return string.Empty; // Nenhum critério selecionado
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLDoutores.PesquisarDoutoresPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherListView(resultados);
            }
        }
    }
}
