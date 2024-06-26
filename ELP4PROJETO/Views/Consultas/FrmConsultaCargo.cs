using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
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
    public partial class FrmConsultaCargo : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroCargo frmCadCargo;
        Cargos oCargo;
        CTLCargos aCTLCargos;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        string status = "A";

        public FrmConsultaCargo()
        {
            InitializeComponent();
            aCTLCargos = new CTLCargos();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadCargo = (FrmCadastroCargo)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            oCargo = (Cargos)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLCargos.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idCargo = ObterIdSelecionado();
            if (idCargo > 0)
            {
                Cargos cargo = aCTLCargos.BuscarCargoPorId(idCargo);
                if (cargo != null)
                {
                    aCTLCargos.Alterar(cargo);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCargo = ObterIdSelecionado();
            if (idCargo > 0)
            {
                Cargos cargo = aCTLCargos.BuscarCargoPorId(idCargo);
                if (cargo != null)
                {
                    aCTLCargos.Excluir(cargo);
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
                Cargos cargo = selectedItem.Tag as Cargos;
                if (cargo != null)
                {
                    aCTLCargos.Visualizar(cargo);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Cargos> dados = aCTLCargos.ListarCargos(status);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Cargos> dados)
        {
            listView1.Items.Clear();

            foreach (var cargo in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cargo.ID));
                item.SubItems.Add(cargo.Cargo);
                item.SubItems.Add(cargo.DataCriacao.ToString());
                item.SubItems.Add(cargo.DataUltimaAlteracao.ToString());
                item.SubItems.Add(cargo.StatusCargo == "I" ? "Inativo" : cargo.StatusCargo == "A" ? "Ativo" : cargo.StatusCargo);
                item.Tag = cargo;
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
            else if (rbCargo.Checked)
            {
                return "CARGO";
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
                var resultados = aCTLCargos.PesquisarCargosPorCriterio(criterioPesquisa, valorPesquisa, status);

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
