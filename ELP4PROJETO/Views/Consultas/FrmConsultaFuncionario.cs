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

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaFuncionario : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroFuncionario frmCadFuncionarios;
        Funcionarios oFuncionario;
        CTLFuncionarios aCTLFuncionarios;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
            aCTLFuncionarios = new CTLFuncionarios();

        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadFuncionarios = (FrmCadastroFuncionario)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oFuncionario = (Funcionarios)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLFuncionarios.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idFunc = ObterIdSelecionado();
            if (idFunc > 0)
            {
                Funcionarios funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(idFunc);
                if (funcionario != null)
                {
                    aCTLFuncionarios.Alterar(funcionario);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idFunc = ObterIdSelecionado();
            if (idFunc > 0)
            {
                Funcionarios funcionario = aCTLFuncionarios.BuscarFuncionarioPorId(idFunc);
                if (funcionario != null)
                {
                    aCTLFuncionarios.Excluir(funcionario);
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
                Funcionarios funcionario = selectedItem.Tag as Funcionarios;
                if (funcionario != null)
                {
                    aCTLFuncionarios.Visualizar(funcionario);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Funcionarios> dados = aCTLFuncionarios.ListarFuncionarios(status);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Funcionarios> dados)
        {
            listView1.Items.Clear();

            foreach (var funcionario in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(funcionario.ID));
                item.SubItems.Add(funcionario.Nome);
                item.SubItems.Add(funcionario.Sexo == "M" ? "Masculino" : funcionario.Sexo == "F" ? "Feminino" : funcionario.Sexo);
                item.SubItems.Add(string.IsNullOrWhiteSpace(funcionario.RG) ? "Não Cadastrado" : Operacao.FormatarDocumento(funcionario.RG));
                item.SubItems.Add(string.IsNullOrWhiteSpace(funcionario.CPF) ? "Não Cadastrado" : Operacao.FormatarDocumento(funcionario.CPF));
                item.SubItems.Add(funcionario.Cargo.Cargo);
                item.SubItems.Add(funcionario.Apelido);
                item.SubItems.Add(funcionario.DataNascimento.ToString());
                item.SubItems.Add(funcionario.Email);
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(funcionario.Telefone) ? "Não Cadastrado" : Operacao.FormatarTelefone(funcionario.Telefone)));
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(funcionario.Celular) ? "Não Cadastrado" : Operacao.FormatarTelefone(funcionario.Celular)));
                item.SubItems.Add(Operacao.FormatarCep(funcionario.CEP));
                item.SubItems.Add(funcionario.Cidade.Cidade);
                item.SubItems.Add(funcionario.Bairro);
                item.SubItems.Add(funcionario.Endereco);
                item.SubItems.Add(funcionario.Complemento);
                item.SubItems.Add(funcionario.Numero.ToString());
                item.SubItems.Add(funcionario.DataCriacao.ToString());
                item.SubItems.Add(funcionario.DataUltimaAlteracao.ToString());
                item.SubItems.Add(funcionario.StatusFuncionario == "I" ? "Inativo" : funcionario.StatusFuncionario == "A" ? "Ativo" : funcionario.StatusFuncionario);

                item.Tag = funcionario;
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
            else if (rbSexo.Checked)
            {
                return "SEXO";
            }
            else if (rbCidade.Checked)
            {
                return "CIDADE";
            }
            else if (rbNome.Checked)
            {
                return "NOME";
            }
            else if (rbRg.Checked)
            {
                return "RG";
            }
            else if (rbCPF.Checked)
            {
                return "CPF";
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
                var resultados = aCTLFuncionarios.PesquisarFuncionariosPorCriterio(criterioPesquisa, valorPesquisa,status);

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
