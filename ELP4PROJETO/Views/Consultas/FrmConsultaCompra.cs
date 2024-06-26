using ELP4PROJETO.Classes;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using test.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Views.Consultas
{
    public partial class FrmConsultaCompra : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroCompra frmCadCompras;
        CTLCompras aCTLCompras;
        Compra aCompra;

        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private bool Cancelada = false; // status da nota.

        public FrmConsultaCompra()
        {
            InitializeComponent();
            aCTLCompras = new CTLCompras();
        }

        public override void SetFrmCadastro(object obj)
        {
            if (obj != null)
            {
                frmCadCompras = (FrmCadastroCompra)obj;
            }
        }
        public override void ConhecaObj(object obj)
        {
            aCompra = (Compra)obj;
        }
        protected override void Incluir()
        {
            base.Incluir();
            aCTLCompras.Incluir();
            CarregaLV();
        }
        public override void Excluir()
        {
            int Numero = ObterIdSelecionado(0); // Obtém o número
            int Modelo = ObterIdSelecionado(1); // Obtém o modelo
            int Serie = ObterIdSelecionado(2); // Obtém a série
            int Fornecedor = ObterIdSelecionado(3); // Obtém o ID do fornecedor

            // Verifica se o ID do fornecedor é maior que 0
            if (Fornecedor > 0)
            {
                // Busca a compra com base nos IDs obtidos
                Compra compra = aCTLCompras.BuscarCompraPorChave(Numero, Modelo, Serie, Fornecedor);

                // Verifica se a compra foi encontrada
                if (compra != null)
                {
                    // Cancela a nota da compra encontrada
                    aCTLCompras.CancelarNota(compra);
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
                Compra compra = selectedItem.Tag as Compra;
                if (compra != null)
                {
                    aCTLCompras.Visualizar(compra);
                    CarregaLV();
                }
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Compra> dados = aCTLCompras.ListarCompras(Cancelada);
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Compra> dados)
        {
            listView1.Items.Clear();

            foreach (var compra in dados)
            {
                ListViewItem item = new ListViewItem(compra.NumNFC.ToString());
                item.SubItems.Add(compra.ModeloNFC.ToString());
                item.SubItems.Add(compra.SerieNFC.ToString());
                item.SubItems.Add(compra.Fornecedor.ID.ToString());
                item.SubItems.Add(compra.Fornecedor.NomeFantasia);
                item.SubItems.Add(compra.Condicao.Condicao);
                item.SubItems.Add(compra.ValorTotal.ToString("C"));
                item.SubItems.Add(compra.ValorFrete.ToString("C"));
                item.SubItems.Add(compra.ValorSeguro.ToString("C"));
                item.SubItems.Add(compra.ValorOutrasDespesas.ToString("C"));
                item.SubItems.Add(compra.DataChegada.ToString());
                item.SubItems.Add(compra.DataEmissao.ToString());
                item.SubItems.Add(compra.DataCancelamento == DateTime.MinValue ? "Não Cancelada" : compra.DataCancelamento.ToString()); // Verifica se a data de cancelamento é MinValue
                item.SubItems.Add(compra.DataCriacao.ToString());

                item.Tag = compra;
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
        private void Filtrar(DateTime? dataInicio, DateTime? dataFim, bool? cancelada, string nomeFornecedor, string tipoData)
        {
            // Chama o método de listagem passando os parâmetros de filtragem
            List<Compra> compras = aCTLCompras.ListarCompras(dataInicio, dataFim, cancelada, nomeFornecedor, tipoData);

            // Preenche o ListView com os resultados
            PreencherListView(compras);
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
                int fornecedor = Convert.ToInt32(txtForn.Value);

                List<Compra> dados = aCTLCompras.BuscarListaCompraPorChave(codigo, modelo, serie, fornecedor);
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
