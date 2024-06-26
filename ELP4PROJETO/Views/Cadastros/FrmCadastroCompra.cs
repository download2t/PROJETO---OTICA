using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using test.Controllers;
using ELP4PROJETO.Cadastros;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using TextBox = System.Windows.Forms.TextBox;
using ELP4PROJETO.Data;
using System.Reflection;
using ELP4PROJETO.DATA;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroCompra : FrmCadastros
    {
        FrmConsultaFornecedor frmConFornecedor;
        FrmConsultaCondicaoPagamento frmConCondicao;

        CTLProdutos aCTLProdutos;
        CTLCompras aCTLCompra;
        CTLFornecedores aCTLForn;

        Compra aCompra;
        ItemCompra oItemCompra;

        Fornecedores oFornecedor;
        private List<Produto> listaProdutosCadastrados = new List<Produto>();
        private List<ItemCompra> listaItensCompraCadastrados = new List<ItemCompra>();

        public FrmCadastroCompra()
        {
            InitializeComponent();
            aCompra = new Compra();
            oItemCompra = new ItemCompra();
            aCTLProdutos = new CTLProdutos();
            aCTLCompra = new CTLCompras();
            aCTLForn = new CTLFornecedores();
            oFornecedor = new Fornecedores();
        }
        protected override void LimparCampos()
        {
            dtChegada.Value = DateTime.Now;
            dtEmissao.Value = DateTime.Now;
            txtCodProduto.Clear();
            txtUND.Clear();
            txtQtd.Clear();
            txtCusto.Clear();
            txtDesconto.Clear();
            txtTotalItens.Clear();
            txtFrete.Value = 0;
            txtSeguro.Value = 0;
            txtOutras.Value = 0;
            txtProduto.Clear();
        }
        protected virtual  bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (dtChegada.Value == DateTime.MinValue)
            {
                camposFaltantes.Add("Data de Chegada");
            }
            if (dtEmissao.Value == DateTime.MinValue)
            {
                camposFaltantes.Add("Data de Emissão");
            }
            if (string.IsNullOrWhiteSpace(txtCodProduto.Text))
            {
                camposFaltantes.Add("Código do Produto");
            }
            if (string.IsNullOrWhiteSpace(txtUND.Text))
            {
                camposFaltantes.Add("Unidade de Medida");
            }
            if (string.IsNullOrWhiteSpace(txtQtd.Text))
            {
                camposFaltantes.Add("Quantidade");
            }
            if (string.IsNullOrWhiteSpace(txtCusto.Text))
            {
                camposFaltantes.Add("Custo");
            }
            if (string.IsNullOrWhiteSpace(txtDesconto.Text))
            {
                camposFaltantes.Add("Desconto");
            }
            if (string.IsNullOrWhiteSpace(txtTotalItens.Text))
            {
                camposFaltantes.Add("Total de Itens");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR")
                Salvar();
            else if (btnSalvar.Text == "CANCELAR")
            {
                CancelarCompra();
            }
            else if (btnSalvar.Text == "EMITIR")
            {
                //
            }
        }
        protected virtual void CancelarCompra()
        {
            string mensagem = "Tem certeza que deseja cancelar a Compra?";

            DialogResult resultado = MessageBox.Show(mensagem, $"Confirmação de Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    aCompra.NumNFC = Convert.ToInt32(txtNumNFC.Value);
                    aCompra.SerieNFC = Convert.ToInt32(txtSerieNFC.Value);
                    aCompra.ModeloNFC = Convert.ToInt32(txtModeloNFC.Value);
                    aCompra.Fornecedor.ID = Convert.ToInt32(txtCodigo.Text);
                    aCompra.DataCancelamento = DateTime.Now;

                    aCTLCompra.CancelarCompra(aCompra);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao Cancelar compra: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        protected override void Salvar()
        {
            if (DgItensCompra.Rows.Count > 0)
            {
                txtFrete_Leave(txtFrete, EventArgs.Empty);
                CTLCompras aCTLCompra = new CTLCompras();
                Compra Obj = new Compra();
                Obj.Fornecedor = new Fornecedores();
                Obj.Condicao = new CondicaoPagamento();
                Obj.Fornecedor.ID = Convert.ToInt32(txtCodigo.Text);
                Obj.Condicao.ID = int.Parse(txtCodCondicao.Text);
                Obj.NumNFC = int.Parse(txtNumNFC.Text);
                Obj.ModeloNFC = int.Parse(txtModeloNFC.Text);
                Obj.SerieNFC = int.Parse(txtSerieNFC.Text);
                Obj.ValorTotal = txtTotalNota.Value;
                Obj.ValorFrete = decimal.Parse(txtFrete.Text);
                Obj.ValorSeguro = decimal.Parse(txtSeguro.Text);
                Obj.ValorOutrasDespesas = decimal.Parse(txtOutras.Text);
                Obj.DataChegada = DateTime.Parse(dtChegada.Text);
                Obj.DataEmissao = DateTime.Parse(dtEmissao.Text);
                Obj.DataCriacao = DateTime.Now;
                Obj.ItensCompra = ItensListView(Obj.NumNFC, Obj.ModeloNFC, Obj.SerieNFC, Obj.Fornecedor.ID);

                // Chamar o método AdicionarCompra2 no controlador CTLCompras
                bool result = aCTLCompra.AdicionarCompra(Obj);

                if (!result)
                {
                    MessageBox.Show("Erro ao salvar a compra.");
                }
                else
                {
                    MessageBox.Show("Compra salva com sucesso!");
                }
                this.Close();
            }
            return;
        }
        public List<ItemCompra> ItensListView(int Num_nfc, int Modelo_nfc, int Serie_nfc, int Id_fornecedor)
        {
            var vLista = new List<ItemCompra>();
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                ItemCompra ItensCompra = new ItemCompra();
                ItensCompra.NumNFC = Num_nfc;
                ItensCompra.ModeloNFC = Modelo_nfc;
                ItensCompra.SerieNFC = Serie_nfc;
                ItensCompra.Fornecedor.ID = Id_fornecedor;
                ItensCompra.Produto = aCTLProdutos.BuscarProdutoPorId(Convert.ToInt32(vLinha.Cells["id_produto"].Value));
                ItensCompra.QtdProduto = Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
                ItensCompra.PrecoCusto = Convert.ToDecimal(vLinha.Cells["custo_sugerido"].Value);
                ItensCompra.Desconto = Convert.ToDecimal(vLinha.Cells["desconto"].Value);
                ItensCompra.PercentualCompra = Convert.ToDecimal(vLinha.Cells["percentual_compra"].Value);
                ItensCompra.MediaPonderada = Convert.ToDecimal(vLinha.Cells["media_ponderada"].Value);
                ItensCompra.DataCriacao = DateTime.Now;
                vLista.Add(ItensCompra);
            }
            return vLista;
        }
  /*      public void Popular(Compra aCompra)
        {
            // Formata os valores de preço para exibição correta
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtNumNFC.Value = aCompra.NumNFC;
            txtModeloNFC.Value = aCompra.ModeloNFC;
            txtSerieNFC.Value = aCompra.SerieNFC;
            txtCodigo.Text = aCompra.Fornecedor.ID.ToString();
            txtFornecedor.Text = aCompra.Fornecedor.NomeFantasia;
            dtChegada.Value = aCompra.DataChegada;
            dtEmissao.Value = aCompra.DataEmissao;
            // dtCancelada.Value = aCompra.DataCancelamento; // Se for necessário usar, descomentar e ajustar

            txtCodCondicao.Text = aCompra.Condicao.ID.ToString();
            txtCondicao.Text = aCompra.Condicao.Condicao;
            txtFrete.Text = aCompra.ValorFrete.ToString("0.##", cultura);
            txtSeguro.Text = aCompra.ValorSeguro.ToString("0.##", cultura);
            txtOutras.Text = aCompra.ValorOutrasDespesas.ToString("0.##", cultura);
            txtTotalNota.Text = aCompra.ValorTotal.ToString("0.##", cultura);

            int codigo = Convert.ToInt32(txtNumNFC.Value);
            int modelo = Convert.ToInt32(txtModeloNFC.Value);
            int serie = Convert.ToInt32(txtSerieNFC.Value);
            int fornecedor = Convert.ToInt32(txtCodigo.Text);

            CTLItensCompra aCTLItensCompra = new CTLItensCompra();
            List<ItemCompra> Itemcompra = aCTLItensCompra.BuscarItemCompraPorChave2(codigo, modelo, serie, fornecedor);

            foreach (var item in Itemcompra)
            {
                DgItensCompra.Rows.Add(
                    item.Produto.ID,
                    item.Produto.Nome,
                    item.QtdProduto.ToString(),
                    item.PrecoCusto.ToString("F2", cultura),
                    item.Desconto.ToString("F2", cultura),
                    item.PercentualCompra.ToString("F2", cultura),
                    item.TotalCusto.ToString("F2", cultura)
                );
            }
            CarregaLV();
        }*/


        public virtual void Popular(Compra aCompra)
        {
            // Formata os valores de preço para exibição correta
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtNumNFC.Value = aCompra.NumNFC;
            txtModeloNFC.Value = aCompra.ModeloNFC;
            txtSerieNFC.Value = aCompra.SerieNFC;
            txtCodigo.Text = aCompra.Fornecedor.ID.ToString();
            txtFornecedor.Text = aCompra.Fornecedor.NomeFantasia;
            dtChegada.Value = aCompra.DataChegada;
            dtEmissao.Value = aCompra.DataEmissao;
            txtCodCondicao.Text = aCompra.Condicao.ID.ToString();
            txtCondicao.Text = aCompra.Condicao.Condicao;
            txtFrete.Text = aCompra.ValorFrete.ToString("0.##", cultura);
            txtSeguro.Text = aCompra.ValorSeguro.ToString("0.##", cultura);
            txtOutras.Text = aCompra.ValorOutrasDespesas.ToString("0.##", cultura);
            txtTotalNota.Text = aCompra.ValorTotal.ToString("0.##", cultura);


            int codigo = Convert.ToInt32(txtNumNFC.Value);
            int modelo = Convert.ToInt32(txtModeloNFC.Value);
            int serie = Convert.ToInt32(txtSerieNFC.Value);
            int fornecedor = Convert.ToInt32(txtCodigo.Text);

            CTLItensCompra aCTLItensCompra = new CTLItensCompra();
            List<ItemCompra> Itemcompra = aCTLItensCompra.BuscarItemCompraPorChave2(codigo, modelo, serie, fornecedor);

            PopularItens(Itemcompra);
            CarregaLV(); // popula a condição de pagamento.
        }
        public void PopularItens(List<ItemCompra> List)
        {
            DgItensCompra.Rows.Clear();
            foreach (ItemCompra Item in List)
            {
                DgItensCompra.Rows.Add(Item.Produto.ID,
                    Item.Produto.Nome,
                    Item.Produto.UnidadeMedida,
                    Item.QtdProduto,
                    Item.Produto.PrecoCusto,
                    Item.PrecoCusto,
                    Item.Desconto,
                    Item.PercentualCompra,
                    Item.TotalCusto,
                    Item.MediaPonderada);
            }
        }


        #region Itens do form botões eventos etc.

        private void VerificarEExecutarAcao(int nNFC, int nModelo, int nSerie, int codForn)
        {
            var compraExiste = aCTLCompra.VerificarSeCompraExiste(nNFC, nModelo, nSerie, codForn);

            if (compraExiste)
            {
                MessageBox.Show("Nota já cadastrada");
            }
            else
            {
                btnVerificar.Visible = false;
                txtCodigo.Enabled = false;
                gbDatas.Enabled = true;
                gbProdutos.Enabled = true;
                GbChave.Enabled = false; // bloqueia campo chave para não mais mudar.
            }
        }
        private void LimparFornecedor()
        {
            txtFornecedor.Clear();
            txtCodigo.Clear();
        }
        private void CarregaLV()
        {
            int cod = Convert.ToInt32(txtCodCondicao.Text);
            CTLParcelas aCTLParcela = new CTLParcelas();
            List<Parcela> dados = aCTLParcela.BuscarParcelasPorIDCondicao(cod); ;
            PreencherListView(dados);
        }
        private void PreencherListView(IEnumerable<Parcela> dados)
        {
            lvParcelas.Items.Clear();

            // Calcula o custo total com os adicionais uma vez para uso em todas as parcelas
            decimal custoTotalComAdicionais = CalcularCustoTotalComAdicionais();

            foreach (var parcela in dados)
            {
                ListViewItem item = new ListViewItem(parcela.NumParcela.ToString());
                item.SubItems.Add(parcela.DiasTotais.ToString());
                item.SubItems.Add(parcela.Forma.Forma);
                item.SubItems.Add(parcela.Porcentagem.ToString());

                // Calcula o valor da parcela com base na porcentagem e no custo total com adicionais
                decimal valorParcela = (parcela.Porcentagem / 100) * custoTotalComAdicionais;
                item.SubItems.Add(valorParcela.ToString("F2")); // Adiciona o valor da parcela na posição correta

                item.Tag = parcela;
                lvParcelas.Items.Add(item);
            }
        }

        private decimal CalcularCustoTotalComAdicionais()
        {
            decimal total = CustoTotal(); // Chama o método existente para obter o custo total atual

            // Somar os custos de frete, seguro e outros se não forem nulos ou vazios
            decimal frete = 0;
            decimal seguro = 0;
            decimal outrosCustos = 0;

            if (!string.IsNullOrEmpty(txtFrete.Text)) frete = Convert.ToDecimal(txtFrete.Text);
            if (!string.IsNullOrEmpty(txtSeguro.Text)) seguro = Convert.ToDecimal(txtSeguro.Text);
            if (!string.IsNullOrEmpty(txtOutras.Text)) outrosCustos = Convert.ToDecimal(txtOutras.Text);

            // Somar os custos extras ao total
            total += frete + seguro + outrosCustos;

            return total;
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFornecedor frm = new FrmConsultaFornecedor())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                txtCodigo.Text = IdSelecionado.ToString();
                txtFornecedor.Text = NomeSelecionado;
            }
        }
        private void LimparText()
        {
            txtCodProduto.Clear();
            txtProduto.Clear();
            txtUND.Clear();
            txtQtd.Clear();
            txtCusto.Clear();
            txtDesconto.Clear();
            txtTotalItens.Clear();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                AdicionarItens();
                LimparText();
                txtTotalNota.Text = Convert.ToString(CustoTotal());
            }
        }
        public void AdicionarItens()
        {
            // Verificar se o produto já foi adicionado
            string idProduto = txtCodProduto.Text;
            if (ProdutoJaAdicionado(idProduto))
            {
                MessageBox.Show("Este produto já foi adicionado.");
                return;
            }

            Produto Produtos = aCTLProdutos.BuscarProdutoPorId(Convert.ToInt32(txtCodProduto.Text));
            var NomeProduto = txtProduto.Text;
            var IdProduto = txtCodProduto.Text;
            var CustoSugerido = txtCusto.Text;
            var Desconto = txtDesconto.Text;
            var QtdEntrada = txtQtd.Text;
            var QtdEstoque = Produtos.QtdEstoque;
            var CustoAtual = Produtos.PrecoCusto;
            var MediaPonderada = 0;
            var Percentual = 0;

            DgItensCompra.Rows.Add(
                IdProduto,
                NomeProduto,
                QtdEstoque,
                QtdEntrada,
                CustoAtual,
                CustoSugerido,
                Desconto,
                Percentual,
                MediaPonderada
            );
            PercentualItem();
            NovoPrecoItens();
        }
        private void AtualizarTotalNota()
        {
            decimal custoItens = CustoTotal(); // Método para calcular o custo total dos itens da compra

            // Adicionar valores de frete, seguro e outras despesas
            decimal frete = Convert.ToDecimal(txtFrete.Value);
            decimal seguro = Convert.ToDecimal(txtSeguro.Value);
            decimal outras = Convert.ToDecimal(txtOutras.Value);

            decimal totalNota = custoItens + frete + seguro + outras;

            // Atualizar o valor do txtTotalNota
            txtTotalNota.Value = totalNota;
        }
        private bool ProdutoJaAdicionado(string idProduto)
        {
            foreach (DataGridViewRow row in DgItensCompra.Rows)
            {
                if (row.Cells["id_produto"].Value != null && row.Cells["id_produto"].Value.ToString() == idProduto)
                {
                    return true;
                }
            }
            return false;
        }
        public void PercentualItem()
        {
            int Total = 0;
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                Total += Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
            }
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                vLinha.Cells["percentual_compra"].Value = Math.Round(((Convert.ToDecimal(vLinha.Cells["qtd_entrada"].Value) / Total) * 100), 8);
            }
        }
        private void NovoPrecoItens()
        {
            decimal frete = 0;
            decimal seguro = 0;
            decimal outrosCustos = 0;

            if (!string.IsNullOrEmpty(txtFrete.Text)) frete = Convert.ToDecimal(txtFrete.Text);
            if (!string.IsNullOrEmpty(txtSeguro.Text)) seguro = Convert.ToDecimal(txtSeguro.Text);
            if (!string.IsNullOrEmpty(txtOutras.Text)) outrosCustos = Convert.ToDecimal(txtOutras.Text);

            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                if (vLinha != null)
                {
                    var Produto = aCTLProdutos.BuscarProdutoPorId(Convert.ToInt32(vLinha.Cells["id_produto"].Value));
                    var CustoProdutoAtual = Produto.PrecoCusto; // Preco Custo do Estoque
                    var QtdEstoqueAtual = Produto.QtdEstoque;  // Qtd em estoque
                    var PercentualCompra = Convert.ToDecimal(vLinha.Cells["percentual_compra"].Value); // porcentagem da compra 
                    var CustoEntrada = Convert.ToDecimal(txtCusto.Text); // Novo valor de entrada
                    var QtdEntradaEstoque = Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value); // qtd de entrada estoque
                    var Desconto = Convert.ToDecimal(vLinha.Cells["desconto"].Value); // desconto
                    var RatFrete = (PercentualCompra / 100) * frete; // rateio do frete co porcentagem da compra
                    var RatSeguro = (PercentualCompra / 100) * seguro; // rateio do seguro com porcentagem da compra
                    var RatOutrosCustos = (PercentualCompra / 100) * outrosCustos; // rateio dos outros c ustos com porcentagem da compra
                    var NovoCustoProduto = (RatFrete + RatSeguro + RatOutrosCustos + CustoEntrada) - Desconto; // custo real do produto com os rateios 
                    var MediaPond = ((QtdEstoqueAtual * CustoProdutoAtual) + (QtdEntradaEstoque * NovoCustoProduto)) / (QtdEstoqueAtual + QtdEntradaEstoque); // (((qtdBanco* valorBanco) + (qtNova * valorNovo)) / ( qtdTotalBanco(banco + novo) + valorTotal(banco + novo))
                    vLinha.Cells["media_ponderada"].Value = Math.Round(MediaPond, 8);

                    vLinha.Cells["custo_sugerido"].Value = NovoCustoProduto; // novo custo do produto
                }
            }
            LiberarCondicaoPagamento();
        }
        private void LiberarCondicaoPagamento()
        {
            if (DgItensCompra.Rows.Count > 0)
            {
                gbCondicao.Enabled = true;

                int cod = oFornecedor.CondicaoPagamento.ID;
                CTLCondicaoPagamento aCTLcon = new CTLCondicaoPagamento();
                CondicaoPagamento condicao = aCTLcon.BuscarCondicaoPagamentoPorId(cod);
                if (condicao != null)
                {
                    txtCodCondicao.Text = condicao.ID.ToString();
                    txtCondicao.Text = condicao.Condicao;
                    CarregaLV();
                }
            }
            else
            {
                gbCondicao.Enabled = false;
                txtCodCondicao.Text = "";
                txtCondicao.Text = "";
            }
        }
        private decimal CustoTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow vLinha in DgItensCompra.Rows)
            {
                total += Convert.ToDecimal(vLinha.Cells["qtd_entrada"].Value) * Convert.ToDecimal(vLinha.Cells["custo_sugerido"].Value);
            }
            return total;
        }
        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodProduto.Text))
                LimparProdutos();
            else if (int.TryParse(txtCodProduto.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o estado correspondente
                CTLProdutos aCTLprod = new CTLProdutos();
                Produto produto = aCTLprod.BuscarProdutoPorId(cod);

                if (produto == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparProdutos();
                }
                else
                {
                    txtProduto.Text = produto.Nome;
                    txtUND.Text = produto.QtdEstoque.ToString();

                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparProdutos();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparProdutos()
        {
            txtProduto.Clear();
            txtCodProduto.Clear();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            using (FrmConsultaProduto frm = new FrmConsultaProduto())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;
                string unidade = frm.Und;

                txtCodProduto.Text = IdSelecionado.ToString();
                txtProduto.Text = NomeSelecionado;
                txtUND.Text = unidade ;
                txtCodProduto_Leave(txtCodProduto, EventArgs.Empty);

            }
        }
        public void SetConsultaFornecedor(object obj)
        {
            frmConFornecedor = (FrmConsultaFornecedor)obj;
        }
        public void SetConsultaCondPagamento(object obj)
        {
            frmConCondicao = (FrmConsultaCondicaoPagamento)obj;
        }
        private void txtCodFornecedor_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }
        #endregion
        private void txtNumNFC_Leave(object sender, EventArgs e)
        {
            ValidarNota();
        }
        public bool ValidarNota()
        {
            if (txtNumNFC.Value > 0 && txtModeloNFC.Value > 0 && txtSerieNFC.Value > 0 && Convert.ToInt32(txtCodigo.Text) > 0)
            {
                var Obj = aCTLCompra.BuscarCompraPorChave(Convert.ToInt32(txtNumNFC.Value), Convert.ToInt32(txtModeloNFC.Value),
                    Convert.ToInt32(txtSerieNFC.Value), Convert.ToInt32(Convert.ToInt32(txtCodigo.Text)));
                if (Obj == null)
                {
                    MessageBox.Show("Nota ja cadastrada");
                    return false;
                }
                else
                {
                    Desbloquear();
                }
                return true;
            }
            return false;
        }
        public void Desbloquear()
        {
            GbChave.Enabled = false;
            gbCondicao.Enabled = true;
            gbDatas.Enabled = true;
            gbProdutos.Enabled = true;
        }
        private void txtQtd_Leave(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                // Tenta converter os valores dos campos para os cálculos
                decimal qtd = string.IsNullOrWhiteSpace(txtQtd.Text) ? 0 : decimal.Parse(txtQtd.Text, cultura);
                decimal custo = string.IsNullOrWhiteSpace(txtCusto.Text) ? 0 : decimal.Parse(txtCusto.Text, cultura);
                decimal desconto = string.IsNullOrWhiteSpace(txtDesconto.Text) ? 0 : decimal.Parse(txtDesconto.Text, cultura);

                // Calcula o total
                decimal total = (qtd * custo) - desconto;

                // Atualiza o campo txtTotal com o valor calculado
                txtTotalItens.Text = total.ToString("0.00");
            }
            catch (FormatException)
            {
                // Exibe uma mensagem de erro se a conversão falhar
                MessageBox.Show("Por favor, insira valores válidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }
        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão      
        }
        private void txtFrete_Leave(object sender, EventArgs e)
        {
            AtualizarTotalNota();
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                LimparFornecedor();
            else if (int.TryParse(txtCodigo.Text, out int cod) && cod > 0)
            {


                oFornecedor = aCTLForn.BuscarFornecedorPorId(cod);

                if (oFornecedor == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparFornecedor();
                }
                else if (oFornecedor.StatusFornecedor == "I")
                {
                    MessageBox.Show("O Fornecedor associado a este código está inativo.");
                    LimparFornecedor();
                }
                else
                {
                    txtFornecedor.Text = oFornecedor.NomeFantasia;

                    int nNFC = (int)txtNumNFC.Value;
                    int nModelo = (int)txtModeloNFC.Value;
                    int nSerie = (int)txtSerieNFC.Value;
                    int codForn = Convert.ToInt32(txtCodigo.Text);
                    VerificarEExecutarAcao(nNFC, nModelo, nSerie, codForn);

                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparFornecedor();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, um ponto decimal e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Bloqueia qualquer modificação com Ctrl
            if (Control.ModifierKeys == Keys.Control)
            {
                e.Handled = true;
            }
        }
        private void txtNumNFC_KeyPress(object sender, KeyPressEventArgs e)
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
#region itens futuros com xml.
/*
    private void btnImportarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";
            openFileDialog.Title = "Selecionar Arquivo XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProcessarXML(openFileDialog.FileName);

                    MessageBox.Show("XML importado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao importar XML: " + ex.Message);
                }
            }
        }

        private void ProcessarXML(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNodeList nNF = xmlDoc.GetElementsByTagName("nNF");
            XmlNodeList serie = xmlDoc.GetElementsByTagName("serie");
            XmlNodeList modelo = xmlDoc.GetElementsByTagName("mod");
            XmlNodeList dhEmi = xmlDoc.GetElementsByTagName("dhEmi");
            XmlNodeList dhSaiEnt = xmlDoc.GetElementsByTagName("dhSaiEnt");
            XmlNodeList vNF = xmlDoc.GetElementsByTagName("vNF");
            XmlNodeList vFrete = xmlDoc.GetElementsByTagName("vFrete");
            XmlNodeList vSeg = xmlDoc.GetElementsByTagName("vSeg");
            XmlNodeList vOutro = xmlDoc.GetElementsByTagName("vOutro");
            XmlNodeList cProd = xmlDoc.GetElementsByTagName("cProd");
            XmlNodeList xProd = xmlDoc.GetElementsByTagName("xProd");
            XmlNodeList uCom = xmlDoc.GetElementsByTagName("uCom");
            XmlNodeList qCom = xmlDoc.GetElementsByTagName("qCom");
            XmlNodeList vUnCom = xmlDoc.GetElementsByTagName("vUnCom");

            // NOTA FISCAL IDENT.
            txtNumero.Text = GetValueIfExists(nNF);
            txtSerie.Text = GetValueIfExists(serie);
            txtModelo.Text = GetValueIfExists(modelo);
            txtTotalNota.Text = GetValueIfExists(vNF);
            txtDataEmissao.Text = GetDateTimeValueIfExists(dhEmi);
            txtDataChegada.Text = GetDateTimeValueIfExists(dhSaiEnt);

            // Preencher campos com valores dos itens da NF
            double freteTotal = GetDoubleValueFromItems(xmlDoc, "vFrete");
            double seguroTotal = GetDoubleValueFromItems(xmlDoc, "vSeg");
            double outrasDespesasTotal = GetDoubleValueFromItems(xmlDoc, "vOutro");

            txtFrete.Text = freteTotal.ToString("0.00");
            txtSeguro.Text = seguroTotal.ToString("0.00");
            txtOutras.Text = outrasDespesasTotal.ToString("0.00");

            // Adicionar produtos à ListView
            for (int i = 0; i < cProd.Count; i++)
            {
                string codigoProduto = cProd[i].InnerText;
                string nomeProduto = xProd[i].InnerText;
                string unidadeMedida = uCom[i].InnerText;
                string quantidade = qCom[i].InnerText;
                string custoUnitario = vUnCom[i].InnerText;

                AdicionarNaListView(codigoProduto, nomeProduto, unidadeMedida, quantidade, custoUnitario);
            }
        }*/
#endregion