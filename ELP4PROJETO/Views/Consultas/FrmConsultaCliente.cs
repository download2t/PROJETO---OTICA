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

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaCliente : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroCliente frmCadClientes;
        Clientes oCliente;
        CTLClientes aCTLClientes;

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";

        public FrmConsultaCliente()
        {
            InitializeComponent();
            aCTLClientes = new CTLClientes();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadClientes = (FrmCadastroCliente)obj;
            }
        }

        public override void ConhecaObj(object obj)
        {
            oCliente = (Clientes)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLClientes.Incluir();
            CarregaLV();
        }

        protected override void Alterar()
        {
            base.Alterar();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = aCTLClientes.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    aCTLClientes.Alterar(cliente);
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idCliente = ObterIdSelecionado();
            if (idCliente > 0)
            {
                Clientes cliente = aCTLClientes.BuscarClientePorId(idCliente);
                if (cliente != null)
                {
                    aCTLClientes.Excluir(cliente);
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
                Clientes cliente = selectedItem.Tag as Clientes;
                if (cliente != null)
                {
                    aCTLClientes.Visualizar(cliente);
                    CarregaLV();
                }
            }
        }

        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Clientes> dados = aCTLClientes.ListarClientes(status);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Clientes> dados)
        {
            listView1.Items.Clear();

            foreach (var cliente in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(cliente.ID));
                item.SubItems.Add(cliente.Nome);
                item.SubItems.Add(cliente.Sexo == "M" ? "Masculino" : cliente.Sexo == "F" ? "Feminino" : cliente.Sexo);
                item.SubItems.Add(string.IsNullOrWhiteSpace(cliente.RG) ? "Não Cadastrado" : Operacao.FormatarDocumento(cliente.RG));
                item.SubItems.Add(string.IsNullOrWhiteSpace(cliente.CPF) ? "Não Cadastrado" : Operacao.FormatarDocumento(cliente.CPF));
                item.SubItems.Add(cliente.DataNasc.ToString());
                item.SubItems.Add(cliente.Email);
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(cliente.Telefone) ? "Não Cadastrado" : Operacao.FormatarTelefone(cliente.Telefone)));
                item.SubItems.Add(Operacao.FormatarTelefone(string.IsNullOrEmpty(cliente.Celular) ? "Não Cadastrado" : Operacao.FormatarTelefone(cliente.Celular)));
                item.SubItems.Add(Operacao.FormatarCep(cliente.CEP));
                item.SubItems.Add(cliente.Cidade.Cidade);
                item.SubItems.Add(cliente.Bairro);
                item.SubItems.Add(cliente.Endereco);
                item.SubItems.Add(cliente.Complemento);
                item.SubItems.Add(cliente.Numero.ToString());
                item.SubItems.Add(cliente.DataCriacao.ToString());
                item.SubItems.Add(cliente.DataUltimaAlteracao.ToString());
                item.SubItems.Add(cliente.StatusCliente == "I" ? "Inativo" : cliente.StatusCliente == "A" ? "Ativo" : cliente.StatusCliente);
                item.SubItems.Add(cliente.CondicaoPagamento.Condicao);
                item.SubItems.Add(cliente.TipoCliente == "O" ? "Pessoa Física" : cliente.TipoCliente == "F" ? "Pessoa Física" : cliente.TipoCliente == "J" ? "Pessoa Júridica" : cliente.TipoCliente);
                item.Tag = cliente;
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
            else if (rbCPF.Checked)
            {
                return "CPF";
            }
            else if (rbRg.Checked)
            {
                return "RG";
            }
            else if (rbCidade.Checked)
            {
                return "CIDADE";
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
                var resultados = aCTLClientes.PesquisarClientesPorCriterio(criterioPesquisa, valorPesquisa,status);

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
