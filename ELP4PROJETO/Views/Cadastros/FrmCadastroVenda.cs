using ELP4PROJETO.Classes;
using ELP4PROJETO.Controllers;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroVenda : Form
    {
        FrmConsultaCliente frmConCliente;
        FrmConsultaCondicaoPagamento frmConCondicao;

        Clientes oCliente;
        Venda aVenda;
        ItemVenda oItemVenda;
        CTLVenda aCTLVenda;
        CTLProdutos aCTLProdutos;
        CTLClientes aCTLClientes;

        int ID_CLIENTE = 0; // Armazena o ID do cliente.
        int ID_CONDICAO = 0; // Armazena o ID da condição de pagamento do cliente.

        public FrmCadastroVenda()
        {
            InitializeComponent();

            aVenda = new Venda();
            oItemVenda = new ItemVenda();
            oCliente = new Clientes();

            aCTLProdutos = new CTLProdutos();
            aCTLVenda = new CTLVenda();
            aCTLClientes = new CTLClientes();
        }
        public void LimparCampos()
        {
            txtCliente.Clear();
            txtCodProduto.Clear();
            txtCPFeCNPJ.Clear();
            txtQtd.Clear();
        }
        private void Salvar()
        {
            if (DgItensVenda.Rows.Count > 0)
            {
                if (VerificarCamposVazios())
                {
                    Venda Obj = new Venda();
                    Obj.Cliente = new Clientes();
                    Obj.CondicaoPagamento = new CondicaoPagamento();
                    Obj.Cliente.ID = ID_CLIENTE;
                    Obj.CondicaoPagamento.ID = ID_CONDICAO;
                    Obj.NumNfv = 0;  // Padronizar 
                    Obj.ModeloNfv = 0;// Padronizar 
                    Obj.SerieNfv = 0; // Padronizar 
                    Obj.ValorTotal = Convert.ToDecimal(txtTotalNota.Text);
                    Obj.DataCriacao = DateTime.Now;
                    Obj.DataEmissao = DateTime.Now;
                    Obj.DataSaida = DateTime.Now;
                    Obj.ItensVenda = ItensListView(Obj.NumNfv, Obj.ModeloNfv, Obj.SerieNfv, Obj.Cliente.ID);

                    // Chamar o método AdicionarCompra2 no controlador CTLCompras
                    bool result = aCTLVenda.AdicionarVenda(Obj);

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
              
            }
            return;
        }
        public List<ItemVenda> ItensListView(int Num_nfc, int Modelo_nfc, int Serie_nfc, int Id_fornecedor)
        {
            var vLista = new List<ItemVenda>();
            foreach (DataGridViewRow vLinha in DgItensVenda.Rows)
            {
                ItemVenda ItensVenda = new ItemVenda();
                ItensVenda.NumNfv = Num_nfc;
                ItensVenda.ModeloNfv = Modelo_nfc;
                ItensVenda.SerieNfv = Serie_nfc;
                ItensVenda.Cliente.ID = Id_fornecedor;
                ItensVenda.TipoItem = cmbProdServ.Text[0].ToString();
                ItensVenda.QtdItem = Convert.ToInt32(vLinha.Cells["qtd_entrada"].Value);
                ItensVenda.PrecoUnitario = Convert.ToDecimal(vLinha.Cells["custo_sugerido"].Value);        
                ItensVenda.TotalItem = Convert.ToDecimal(txtTotalNota.Text); 
                ItensVenda.Desconto = Convert.ToDecimal(vLinha.Cells["desconto"].Value);
                ItensVenda.DataCriacao = DateTime.Now;
                vLista.Add(ItensVenda);
            }
            return vLista;
        }

        private bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                camposFaltantes.Add("Código do Produto");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodProduto.Text))
            {
                txtCodProduto.Clear();
            }
            else if (int.TryParse(txtCodProduto.Text, out int cod) && cod > 0)
            {
                if (cmbProdServ.Text == "Produtos")
                {
                    // Se o código for um número inteiro válido e maior que zero, verifique a cidade correspondente
                   Produto produto  = aCTLProdutos.BuscarProdutoPorId(cod);

                    if (produto == null)
                    {
                        MessageBox.Show("Código inexistente.");
                        txtCodProduto.Clear();
                    }
                    else if (produto.Status == "I")
                    {
                        MessageBox.Show("O produto associado a este código está inativo.");
                        txtCodProduto.Clear();
                    }
                    else
                    {
                        //Adiciona no GridView
                        // QTD + nome do produto + valor  Unit
                    }
                }
                else if (cmbProdServ.Text == "Serviço")
                {
                    // Se o código for um número inteiro válido e maior que zero, verifique a cidade correspondente
                    CTLServicos aCTLServ = new CTLServicos();
                    Servico servico = aCTLServ.BuscarServicoPorId(cod);

                    if (servico == null)
                    {
                        MessageBox.Show("Código inexistente.");
                        txtCodProduto.Clear();
                    }
                    else if (servico.Status == "I")
                    {
                        MessageBox.Show("O Serviço associado a este código está inativo.");
                        txtCodProduto.Clear();
                    }
                    else
                    {
                        //Adiciona no GridView
                        // QTD  + Nome do serviço + valor Unit
                    }
                }            
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodProduto.Clear();
            }

        }
    }
}