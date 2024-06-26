using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaCondicaoPagamento : ELP4PROJETO.Consultas.FrmConsulta
    {
        frm frmCadCondicaoPG;
        CondicaoPagamento aCondicaoPG;
        CTLCondicaoPagamento aCTLCondicaoPG;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaCondicaoPagamento()
        {
            InitializeComponent();
            aCTLCondicaoPG = new CTLCondicaoPagamento();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadCondicaoPG = (frm)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            aCondicaoPG = (CondicaoPagamento)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLCondicaoPG.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idCondicao = ObterIdSelecionado();
            if (idCondicao > 0)
            {
                CondicaoPagamento condicao = aCTLCondicaoPG.BuscarCondicaoPagamentoPorId(idCondicao);
                if (condicao != null)
                {
                    aCTLCondicaoPG.Alterar(condicao);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCondicao = ObterIdSelecionado();
            if (idCondicao > 0)
            {
                CondicaoPagamento condicao = aCTLCondicaoPG.BuscarCondicaoPagamentoPorId(idCondicao);
                if (condicao != null)
                {
                    aCTLCondicaoPG.Excluir(condicao);
                    CarregaLV();
                }
            }
        }
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            int idCondicao = ObterIdSelecionado();
            if (idCondicao > 0)
            {
                CondicaoPagamento condicao = aCTLCondicaoPG.BuscarCondicaoPagamentoPorId(idCondicao);
                if (condicao != null)
                {
                    aCTLCondicaoPG.Desativar(condicao);
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
                CondicaoPagamento condicao = selectedItem.Tag as CondicaoPagamento;
                if (condicao != null)
                {
                    aCTLCondicaoPG.Visualizar(condicao);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<CondicaoPagamento> dados = aCTLCondicaoPG.ListarCondicoesPagamento(status);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<CondicaoPagamento> dados)
        {
            listView1.Items.Clear();

            foreach (var Condicao in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(Condicao.ID));
                item.SubItems.Add(Condicao.Condicao);
                item.SubItems.Add(Condicao.Parcelas.ToString());
                item.SubItems.Add(Condicao.Taxa.ToString());
                item.SubItems.Add(Condicao.Multa.ToString());
                item.SubItems.Add(Condicao.Desconto.ToString());
                item.SubItems.Add(Condicao.DataCriacao.ToString());
                item.SubItems.Add(Condicao.DataUltimaAlteracao.ToString());
                item.SubItems.Add(Condicao.Status == "I" ? "Inativo" : Condicao.Status == "A" ? "Ativo" : Condicao.Status);
                item.Tag = Condicao;
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
            else if (rbCondicao.Checked)
            {
                return "CONDICAO";
            }
            else if (rbParcelas.Checked)
            {
                return "PARCELAS";
            }
            return string.Empty;
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLCondicaoPG.PesquisarCondicaoPorCriterio(criterioPesquisa, valorPesquisa, status);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInativos.Checked)
            {
                status = "I";
                btnStatus.Text = "ATIVAR";
            }
            else
            {
                status = "A";
                btnStatus.Text = "DESATIVAR";
                btnIncluir.Enabled = btnAlterar.Enabled = true;
            }

            btnIncluir.Enabled = btnAlterar.Enabled = !cbInativos.Checked;
            CarregaLV();
        }

    }
}
