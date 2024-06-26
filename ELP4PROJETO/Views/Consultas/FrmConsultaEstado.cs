using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Consultas
{
    public partial class FrmConsultaEstado : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroEstado frmcadEstados;
        Estados oEstado;
        CTLEstados aCTLEstados;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";


        public FrmConsultaEstado()
        {
            InitializeComponent();
            aCTLEstados = new CTLEstados();
        }

        // Sobrescrever métodos Estado

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmcadEstados = (FrmCadastroEstado)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oEstado = (Estados)obj;
        }

        public void SetTextoBotaoSair(string texto)
        {
            btnSair.Text = texto;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLEstados.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idEstado = ObterIdSelecionado();
            if (idEstado > 0)
            {
                Estados estado = aCTLEstados.BuscarEstadoPorId(idEstado);
                if (estado != null)
                {
                    aCTLEstados.Alterar(estado);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idEstado = ObterIdSelecionado();
            if (idEstado > 0)
            {
                Estados estado = aCTLEstados.BuscarEstadoPorId(idEstado);
                if (estado != null)
                {
                    aCTLEstados.Excluir(estado);
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
                Estados estado = selectedItem.Tag as Estados;
                if (estado != null)
                {
                    aCTLEstados.Visualizar(estado);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Estados> dados = aCTLEstados.ListarEstados(status);
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Estados> dados)
        {
            listView1.Items.Clear();

            foreach (var estado in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(estado.ID));
                item.SubItems.Add(estado.Estado);
                item.SubItems.Add(estado.UF);
                item.SubItems.Add(estado.OPais.Pais); // Verificar se isso é o que realmente deseja mostrar
                item.SubItems.Add(estado.DataCriacao.ToString());
                item.SubItems.Add(estado.DataUltimaAlteracao.ToString());
                item.SubItems.Add(estado.StatusEstado == "I" ? "Inativo" : estado.StatusEstado == "A" ? "Ativo" : estado.StatusEstado);
                item.Tag = estado;
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
            else if (rbEstado.Checked)
            {
                return "ESTADO";
            }
            else if (rbPais.Checked)
            {
                return "PAIS"; 
            }
            else if (rbUF.Checked)
            {
                return "UF"; 
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
                var resultados = aCTLEstados.PesquisarEstadosPorCriterio(criterioPesquisa, valorPesquisa,status);

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
