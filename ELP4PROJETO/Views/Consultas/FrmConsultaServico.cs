using ELP4PROJETO.Controllers;
using ELP4PROJETO.Models;
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
    public partial class FrmConsultaServico : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroServico frmcadServico;
        Servico oServico;
        CTLServicos aCTLServicos;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaServico()
        {
            InitializeComponent();
            aCTLServicos = new CTLServicos();
        }
        // sobrescrever métodos Servico

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmcadServico = (FrmCadastroServico)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oServico = (Servico)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLServicos.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idServico = ObterIdSelecionado();
            if (idServico > 0)
            {
                Servico servico = aCTLServicos.BuscarServicoPorId(idServico);
                if (servico != null)
                {
                    aCTLServicos.Alterar(servico);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idServico = ObterIdSelecionado();
            if (idServico > 0)
            {
                Servico servico = aCTLServicos.BuscarServicoPorId(idServico);
                if (servico != null)
                {
                    aCTLServicos.Excluir(servico);
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
                Servico servico = selectedItem.Tag as Servico;
                if (servico != null)
                {
                    aCTLServicos.Visualizar(servico);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Servico> dados = aCTLServicos.ListarServicos(status);
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Servico> dados)
        {
            listView1.Items.Clear();

            foreach (var servico in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(servico.ID));
                item.SubItems.Add(servico.Descricao);
                item.SubItems.Add(servico.Status == "I" ? "Inativo" : servico.Status == "A" ? "Ativo" : servico.Status);
                item.SubItems.Add(servico.DataCriacao.ToString());
                item.SubItems.Add(servico.DataUltimaAlteracao.ToString());
                item.Tag = servico;
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
            else if (rbDescricao.Checked)
            {
                return "DESCRICAO";
            }

            return string.Empty;
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCriterioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                var resultados = aCTLServicos.PesquisarServicosPorCriterio(criterioPesquisa, valorPesquisa, status);
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
