using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
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
    public partial class FrmConsultaReceita : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroReceita frmCadReceita;
        Receita aReceita;
        CTLReceita aCTLReceita;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        public FrmConsultaReceita()
        {
            InitializeComponent();
            aCTLReceita = new CTLReceita();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadReceita = (FrmCadastroReceita)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            aReceita = (Receita)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLReceita.Incluir();
            CarregaLV();
        }
        protected override void Alterar()
        {
            base.Alterar();
            int idReceita = ObterIdSelecionado();
            if (idReceita > 0)
            {
                Receita receita = aCTLReceita.BuscarReceitaPorId(idReceita);
                if (receita != null)
                {
                    aCTLReceita.Alterar(receita);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idReceita = ObterIdSelecionado();
            if (idReceita > 0)
            {
                Receita receita = aCTLReceita.BuscarReceitaPorId(idReceita);
                if (receita != null)
                {
                   aCTLReceita.Excluir(receita);
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
                Receita receita = selectedItem.Tag as Receita;
                if (receita != null)
                {
                    aCTLReceita.Visualizar(receita);
                    CarregaLV();
                }
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Receita> dados = aCTLReceita.ListarReceitas();
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Receita> dados)
        {
            listView1.Items.Clear();

            foreach (var receita in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(receita.ID));
                item.SubItems.Add(receita.Cliente.Nome);
                item.SubItems.Add(receita.Doutor.Nome);
                item.SubItems.Add(receita.Laboratorio.Nome);
                item.SubItems.Add(receita.DataRecebimento.ToString());
                item.SubItems.Add(receita.DataCriacao.ToString());
                item.SubItems.Add(receita.DataUltimaAlteracao.ToString());
                item.Tag = receita;
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
                }
                this.Close();
            }
        }

        private string ObterCritérioPesquisa()
        {

            if (rbCodigo.Checked)
            {
                return "ID"; // Pesquisar pelo ID
            }
            else if (rbCliente.Checked)
            {
                return "CLIENTE"; 
            }
            else if (rbLab.Checked)
            {
                return "LABORATORIO"; 
            }
            else if (rbDoutor.Checked)
            {
                return "DOUTOR";
            }
            return string.Empty; // Nenhum critério selecionado
        }

        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                 var resultados = aCTLReceita.PesquisarReceitasPorCriterio(criterioPesquisa, valorPesquisa);
                 PreencherListView(resultados);
            }
        }


    }
}
