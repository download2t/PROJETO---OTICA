using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Consultas
{
    public partial class FrmConsultaCidade : FrmConsulta
    {
        private FrmCadastroCidade frmcadCidades;
        private Cidades oCidade;
        private CTLCidades aCTLCidades;

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";

        public FrmConsultaCidade()
        {
            InitializeComponent();
            aCTLCidades = new CTLCidades();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmcadCidades = (FrmCadastroCidade)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oCidade = (Cidades)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLCidades.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idCidade = ObterIdSelecionado();
            if (idCidade > 0)
            {
                Cidades cidade = aCTLCidades.BuscarCidadePorId(idCidade);
                if (cidade != null)
                {
                    aCTLCidades.Alterar(cidade);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCidade = ObterIdSelecionado();
            if (idCidade > 0)
            {
                Cidades cidade = aCTLCidades.BuscarCidadePorId(idCidade);
                if (cidade != null)
                {
                    aCTLCidades.Excluir(cidade);
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
                Cidades cidade = selectedItem.Tag as Cidades;
                if (cidade != null)
                {
                    aCTLCidades.Visualizar(cidade);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Cidades> dados = aCTLCidades.ListarCidades(status);
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Cidades> dados)
        {
            listView1.Items.Clear();

            foreach (var cidade in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cidade.ID));
                item.SubItems.Add(cidade.Cidade);
                item.SubItems.Add(cidade.DDD);
                item.SubItems.Add(cidade.OEstado.Estado); // Verificar se isso é o que realmente deseja mostrar
                item.SubItems.Add(cidade.DataCriacao.ToString());
                item.SubItems.Add(cidade.DataUltimaAlteracao.ToString());
                item.SubItems.Add(cidade.StatusCidade == "I" ? "Inativo" : cidade.StatusCidade == "A" ? "Ativo" : cidade.StatusCidade);
                item.Tag = cidade;
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
            else if (rbCidade.Checked)
            {
                return "CIDADE"; 
            }
            else if (rbEstado.Checked)
            {
                return "ESTADO";
            }
            else if (rbPais.Checked)
            {
                return "PAIS"; 
            }
            else if (rbDDD.Checked)
            {
                return "DDD"; 
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
                var resultados = aCTLCidades.PesquisarCidadesPorCriterio(criterioPesquisa, valorPesquisa,status);

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
