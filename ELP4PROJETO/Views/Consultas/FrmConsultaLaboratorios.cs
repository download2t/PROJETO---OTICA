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
    public partial class FrmConsultaLaboratorios : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroLaboratorio frmCadLaboratorio;
        Laboratorio oLaboratorio;
        CTLLaboratorios aCTLLaboratorios;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmConsultaLaboratorios()
        {
            InitializeComponent();
            aCTLLaboratorios = new CTLLaboratorios();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadLaboratorio = (FrmCadastroLaboratorio)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oLaboratorio = (Laboratorio)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLLaboratorios.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idLaboratorio = ObterIdSelecionado();
            if (idLaboratorio > 0)
            {
                Laboratorio laboratorio = aCTLLaboratorios.BuscarLaboratorioPorId(idLaboratorio);
                if (laboratorio != null)
                {
                    aCTLLaboratorios.Alterar(laboratorio);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idLaboratorio = ObterIdSelecionado();
            if (idLaboratorio > 0)
            {
                Laboratorio laboratorio = aCTLLaboratorios.BuscarLaboratorioPorId(idLaboratorio);
                if (laboratorio != null)
                {
                    aCTLLaboratorios.Excluir(laboratorio);
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
                Laboratorio laboratorio = selectedItem.Tag as Laboratorio;
                if (laboratorio != null)
                {
                    aCTLLaboratorios.Visualizar(laboratorio);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Laboratorio> dados = aCTLLaboratorios.ListarLaboratorios();
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Laboratorio> dados)
        {
            listView1.Items.Clear();

            foreach (var laboratorio in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(laboratorio.ID));
                item.SubItems.Add(laboratorio.Nome);
                item.SubItems.Add(laboratorio.DataCriacao.ToString());
                item.SubItems.Add(laboratorio.DataUltimaAlteracao.ToString());          
                item.Tag = laboratorio;
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
            else if (rbLab.Checked)  // Supondo que há um RadioButton chamado rbLaboratorio
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
                var resultados = aCTLLaboratorios.PesquisarLaboratoriosPorCriterio(criterioPesquisa, valorPesquisa);
                PreencherListView(resultados);
            }
        }

    }
}
