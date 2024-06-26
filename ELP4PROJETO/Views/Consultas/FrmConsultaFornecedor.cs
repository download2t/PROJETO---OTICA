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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaFornecedor : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroFornecedores frmCadFornecedores;
        Fornecedores oFornecedor;
        CTLFornecedores aCTLFornecedores;

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaFornecedor()
        {
            InitializeComponent();
            aCTLFornecedores = new CTLFornecedores();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadFornecedores = (FrmCadastroFornecedores)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oFornecedor = (Fornecedores)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLFornecedores.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idFornecedor = ObterIdSelecionado();
            if (idFornecedor > 0)
            {
                Fornecedores fornecedor = aCTLFornecedores.BuscarFornecedorPorId(idFornecedor);
                if (fornecedor != null)
                {
                    aCTLFornecedores.Alterar(fornecedor);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idFornecedor = ObterIdSelecionado();
            if (idFornecedor > 0)
            {
                Fornecedores fornecedor = aCTLFornecedores.BuscarFornecedorPorId(idFornecedor);
                if (fornecedor != null)
                {
                    aCTLFornecedores.Excluir(fornecedor);
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
                Fornecedores fornecedor = selectedItem.Tag as Fornecedores;
                if (fornecedor != null)
                {
                    aCTLFornecedores.Visualizar(fornecedor);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Fornecedores> dados = aCTLFornecedores.ListarFornecedores(status);
            PreencherListView(dados);
        }

        private void PreencherListView(IEnumerable<Fornecedores> dados)
        {
            listView1.Items.Clear();

            foreach (var fornecedor in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(fornecedor.ID));
                item.SubItems.Add(fornecedor.NomeFantasia);
                item.SubItems.Add(fornecedor.RazaoSocial);
                item.SubItems.Add(string.IsNullOrWhiteSpace(fornecedor.InscricaoEstadual) ? "Não Cadastrado" : Operacao.FormatarDocumento(fornecedor.InscricaoEstadual));
                item.SubItems.Add(string.IsNullOrWhiteSpace(fornecedor.InscricaoMunicipal) ? "Não Cadastrado" : Operacao.FormatarDocumento(fornecedor.InscricaoMunicipal));
                item.SubItems.Add(Operacao.FormatarDocumento(fornecedor.CNPJ));
                item.SubItems.Add(Operacao.FormatarDocumento(fornecedor.RG));
                item.SubItems.Add(fornecedor.Email);
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(fornecedor.Telefone) ? "Não Cadastrado" : Operacao.FormatarTelefone(fornecedor.Telefone)));
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(fornecedor.Celular) ? "Não Cadastrado" : Operacao.FormatarTelefone(fornecedor.Celular)));
                item.SubItems.Add(Operacao.FormatarCep(fornecedor.CEP));
                item.SubItems.Add(fornecedor.Cidade.Cidade);
                item.SubItems.Add(fornecedor.Bairro);
                item.SubItems.Add(fornecedor.Endereco);
                item.SubItems.Add(fornecedor.Complemento);
                item.SubItems.Add(fornecedor.Numero.ToString());
                item.SubItems.Add(fornecedor.DataFundacao.ToString());
                item.SubItems.Add(fornecedor.DataCriacao.ToString());
                item.SubItems.Add(fornecedor.DataUltimaAlteracao.ToString());
                item.SubItems.Add(fornecedor.StatusFornecedor == "I" ? "Inativo" : fornecedor.StatusFornecedor == "A" ? "Ativo" : fornecedor.StatusFornecedor);
                item.SubItems.Add(fornecedor.CondicaoPagamento.Condicao);
                item.SubItems.Add(fornecedor.TipoFornecedor == "O" ? "Pessoa Física" : fornecedor.TipoFornecedor == "F" ? "Pessoa Física" : fornecedor.TipoFornecedor == "J" ? "Pessoa Júridica" : fornecedor.TipoFornecedor);
                item.Tag = fornecedor;
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
            else if (rbNome.Checked)
            {
                return "NOME";
            }
            else if (rbCidade.Checked)
            {
                return "CIDADE";
            }
            else if (rbCNPJ.Checked)
            {
                return "CNPJ";
            }
          
            else if (rbStatus.Checked)
            {
                return "STATUS";
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
                var resultados = aCTLFornecedores.PesquisarFornecedoresPorCriterio(criterioPesquisa, valorPesquisa, status);

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
