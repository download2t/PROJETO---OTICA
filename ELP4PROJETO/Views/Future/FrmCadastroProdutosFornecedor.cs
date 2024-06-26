using ELP4PROJETO.Classes;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroProdutosFornecedor : ELP4PROJETO.Cadastros.FrmCadastros
    {
        FrmConsultaFornecedor frmConFornecedor;
        FrmConsultaProduto frmConProd;
        ProdutosFornecedores oProdForn;
        CTLProdutosFornecedores aCTLProdutoF;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }

        public FrmCadastroProdutosFornecedor()
        {
            //Este form está desabilitado, no futuro iremos trabalhar este metodo. por enquanto ele fica desativado.
            InitializeComponent();
            oProdForn = new ProdutosFornecedores();
            aCTLProdutoF = new CTLProdutosFornecedores();
        }
        public void SetConsultaFornecedor(object obj)
        {
            frmConFornecedor = (FrmConsultaFornecedor)obj;
        }
        public void SetConsultaProdutos(object obj)
        {
            frmConProd = (FrmConsultaProduto)obj;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is ProdutosFornecedores prod)
            {
                oProdForn = prod;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            base.LimparCampos();
            txtCodigo.Clear();  
            txtProduto.Clear();
            txtCodProduto.Clear();
            txtFornecedor.Clear();
            txtCodFornecedor.Clear();
            txtCodigoDoFornecedor.Clear();
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtProduto.Enabled = false;
            txtCodProduto.Enabled = false;
            txtFornecedor.Enabled = false;
            txtCodFornecedor.Enabled = false;
            txtCodigoDoFornecedor.Enabled = false;
            btnBuscarFornecedor.Enabled=false;
            btnBuscarProduto.Enabled=false; 
        }

        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            txtProduto.Enabled = true;
            txtCodProduto.Enabled = true;
            txtFornecedor.Enabled = true;
            txtCodFornecedor.Enabled = true;
            txtCodigoDoFornecedor.Enabled = true;
            btnBuscarFornecedor.Enabled = true;
            btnBuscarProduto.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oProdForn.ID.ToString();
            txtFornecedor.Text = oProdForn.Fornecedor.NomeFantasia;
            txtCodFornecedor.Text = oProdForn.Fornecedor.ID.ToString();
            txtCodProduto.Text = oProdForn.Produto.ID.ToString();
            txtProduto.Text = oProdForn.Produto.Nome;
            txtCodigoDoFornecedor.Text = oProdForn.CodigoProdutoFornecedor;    
        }
        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirProduto();
                }
            }
        }
        private void ExcluirProduto()
        {
            if (oProdForn != null)
            {
                try
                {
                    var result = aCTLProdutoF.ExcluirProdutoFornecedor(oProdForn.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o produto. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o produto devido a outros registros estarem vinclulados a este produto.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cliente. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtCodProduto.Text))
            {
                camposFaltantes.Add("Código do produto");
            }
            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text))
            {
                camposFaltantes.Add("Código do fornecedor");
            }
            if (string.IsNullOrWhiteSpace(txtCodigoDoFornecedor.Text))
            {
                camposFaltantes.Add("Código do produto do fornecedor");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
         protected override void Salvar()
        {

            if (VerificarCamposVazios())
            {
                oProdForn.Fornecedor.ID = Convert.ToInt32(txtCodFornecedor.Text);
                oProdForn.Produto.ID = Convert.ToInt32(txtCodProduto.Text);
                oProdForn.CodigoProdutoFornecedor = txtCodigoDoFornecedor.Text;

                if (oProdForn.ID == 0)
                {
                    oProdForn.DataCriacao = DateTime.Now;
                    var result = aCTLProdutoF.AdicionarProdutoFornecedor(oProdForn);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oProdForn.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLProdutoF.AtualizarProdutoFornecedor(oProdForn);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }

                return;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodProduto_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
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
            using (FrmConsultaProduto consultaProduto = new FrmConsultaProduto())
            {
                consultaProduto.btnSair.Text = "Selecionar";
                consultaProduto.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaProduto.IdSelecionado;
                string NomeSelecionado = consultaProduto.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodProduto.Text = IdSelecionado.ToString();
                txtProduto.Text = NomeSelecionado;
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodFornecedor.Text))
                LimparFornecedor();
            else if (int.TryParse(txtCodFornecedor.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o estado correspondente
                CTLFornecedores aCTLForn = new CTLFornecedores();
                Fornecedores fornecedor = aCTLForn.BuscarFornecedorPorId(cod);

                if (fornecedor == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparFornecedor();
                }
                else if (fornecedor.StatusFornecedor == "I")
                {
                    MessageBox.Show("O Fornecedor associado a este código está inativo.");
                    LimparFornecedor();
                }
                else
                {
                    txtFornecedor.Text = fornecedor.NomeFantasia;
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
        private void LimparFornecedor()
        {
            txtFornecedor.Clear();
            txtCodFornecedor.Clear();
        }

        private void btnBuscarFornecedor_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFornecedor consultaFornecedor = new FrmConsultaFornecedor())
            {
                consultaFornecedor.btnSair.Text = "Selecionar";
                consultaFornecedor.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaFornecedor.IdSelecionado;
                string NomeSelecionado = consultaFornecedor.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodFornecedor.Text = IdSelecionado.ToString();
                txtFornecedor.Text = NomeSelecionado;
            }
        }
    }
}
