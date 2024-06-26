using ELP4PROJETO.Classes;
using ELP4PROJETO.Models;
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
    public partial class FrmConsultaVenda : ELP4PROJETO.Views.Consultas.FrmConsultaCompra
    {
        FrmCadastroVenda frmCadVendas;
        CTLVenda aCTLVendas;
        Venda aVenda;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private bool Cancelada = false; // status da nota.
        public FrmConsultaVenda()
        {
            InitializeComponent();
            aCTLVendas = new CTLVenda();
        }
        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadVendas = (FrmCadastroVenda)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            aVenda = (Venda)obj;
        }

        protected override void Incluir()
        {
            aCTLVendas.Incluir();
            CarregaLV();
        }
        public override void Excluir()
        {
            int Numero = ObterIdSelecionado(0); // Obtém o número
            int Modelo = ObterIdSelecionado(1); // Obtém o modelo
            int Serie = ObterIdSelecionado(2); // Obtém a série
            int Cliente = ObterIdSelecionado(3); // Obtém o ID do cliente

            // Verifica se o ID do cliente é maior que 0
            if (Cliente > 0)
            {
                // Busca a venda com base nos IDs obtidos
                Venda venda = aCTLVendas.BuscarVendaPorChave(Numero, Modelo, Serie, Cliente);

                // Verifica se a venda foi encontrada
                if (venda != null)
                {
                    // Cancela a nota da venda encontrada
                    aCTLVendas.CancelarNota(venda);
                    CarregaLV();
                }
            }
        }
        private int ObterIdSelecionado(int posicao)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].SubItems[posicao].Text);
            }
            return 0;
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
                Venda venda = selectedItem.Tag as Venda;
                if (venda != null)
                {
                    aCTLVendas.Visualizar(venda);
                    CarregaLV();
                }
            }
        }
        public override void CarregaLV()
        {
            List<Venda> dados = aCTLVendas.ListarVendas(Cancelada);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Venda> dados)
        {
            listView1.Items.Clear();

            foreach (var venda in dados)
            {
                ListViewItem item = new ListViewItem(venda.NumNfv.ToString());
                item.SubItems.Add(venda.ModeloNfv.ToString());
                item.SubItems.Add(venda.SerieNfv.ToString());
                item.SubItems.Add(venda.Cliente.ID.ToString());
                item.SubItems.Add(venda.Cliente.Nome);
                item.SubItems.Add(venda.CondicaoPagamento.Condicao);
                item.SubItems.Add(venda.ValorTotal.ToString("C"));
                item.SubItems.Add(venda.ValorFrete.ToString("C"));
                item.SubItems.Add(venda.ValorSeguro.ToString("C"));
                item.SubItems.Add(venda.ValorOutrasDespesas.ToString("C"));
                item.SubItems.Add(venda.DataSaida.ToString());
                item.SubItems.Add(venda.DataEmissao.ToString());
                item.SubItems.Add(venda.DataCancelamento == DateTime.MinValue ? "Não Cancelada" : venda.DataCancelamento.ToString()); // Verifica se a data de cancelamento é MinValue
                item.SubItems.Add(venda.DataCriacao.ToString());

                item.Tag = venda;
                listView1.Items.Add(item);
            }
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
        protected override void Pesquisar()
        {
            // Obtém os parâmetros de filtragem
            DateTime? dataInicio = null;
            DateTime? dataFim = null;
            bool? cancelada = null;

            if (dtData1.Value.Date > DateTime.MinValue.Date)
            {
                dataInicio = dtData1.Value.Date;
            }

            if (dtData2.Value.Date > DateTime.MinValue.Date)
            {
                dataFim = dtData2.Value.Date;
            }

            if (cbCanceladas.Checked)
            {
                cancelada = true;
            }

            if (string.IsNullOrEmpty(cbDatas.Text)) // Verifica se o ComboBox de tipo de data está vazio
            {
                return;
            }

            // Chama o método de filtragem passando os parâmetros
            Filtrar(dataInicio, dataFim, cancelada, txtCodigo.Text, cbDatas.Text);
        }
        private void Filtrar(DateTime? dataInicio, DateTime? dataFim, bool? cancelada, string nomeCliente, string tipoData)
        {
            // Chama o método de listagem passando os parâmetros de filtragem
            List<Venda> vendas = aCTLVendas.ListarVendas(dataInicio, dataFim, cancelada, nomeCliente, tipoData);

            // Preenche o ListView com os resultados
            PreencherListView(vendas);
        }
        private void cbCanceladas_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbCanceladas.Checked)
            {
                btnExcluir.Enabled = true;
                Cancelada = false;
                CarregaLV();
            }
            else
            {
                Cancelada = true;
                btnExcluir.Enabled = false;
                CarregaLV();
            }
        }
        protected override void Alterar()
        {
            if (txtForn.Value > 0)
            {
                int codigo = Convert.ToInt32(txtNumero.Value);
                int modelo = Convert.ToInt32(txtModelo.Value);
                int serie = Convert.ToInt32(txtSerie.Value);
                int cliente = Convert.ToInt32(txtForn.Value);

                List<Venda> dados = aCTLVendas.BuscarListaVendaPorChave(codigo, modelo, serie, cliente);
                PreencherListView(dados);
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado é o ponto (.) ou a vírgula (,)
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Se for, cancela o evento de pressionar a tecla
                e.Handled = true;
            }
        }
    }
}
