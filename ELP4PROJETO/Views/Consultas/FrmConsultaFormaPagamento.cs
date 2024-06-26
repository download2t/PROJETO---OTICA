using ELP4PROJETO.Classes;
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
    public partial class FrmConsultaFormaPagamento : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroFormaPagamento frmCadForma;
        FormaPagamento aForma;
        CTLFormaPagamento aCTLForma;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaFormaPagamento()
        {
            InitializeComponent();
            aCTLForma = new CTLFormaPagamento();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadForma = (FrmCadastroFormaPagamento)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            aForma = (FormaPagamento)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLForma.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idforma = ObterIdSelecionado();
            if (idforma > 0)
            {
                FormaPagamento forma = aCTLForma.BuscarFormaPagamentoPorId(idforma);
                if (forma != null)
                {
                    aCTLForma.Alterar(forma);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idforma = ObterIdSelecionado();
            if (idforma > 0)
            {
                FormaPagamento forma = aCTLForma.BuscarFormaPagamentoPorId(idforma);
                if (forma != null)
                {
                    aCTLForma.Excluir(forma);
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
                FormaPagamento forma = selectedItem.Tag as FormaPagamento;
                if (forma != null)
                {
                    aCTLForma.Visualizar(forma);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<FormaPagamento> dados = aCTLForma.ListarFormasPagamento(status);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<FormaPagamento> dados)
        {
            listView1.Items.Clear();

            foreach (var forma in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(forma.ID));
                item.SubItems.Add(forma.Forma);
                item.SubItems.Add(forma.DataCriacao.ToString());
                item.SubItems.Add(forma.DataUltimaAlteracao.ToString());
                item.SubItems.Add(forma.StatusForma == "I" ? "Inativo" : forma.StatusForma == "A" ? "Ativo" : forma.StatusForma);
                item.Tag = forma;
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
            else if (rbForma.Checked)
            {
                return "FORMA";
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
                var resultados = aCTLForma.PesquisarFormaPorCriterio(criterioPesquisa, valorPesquisa, status);

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
