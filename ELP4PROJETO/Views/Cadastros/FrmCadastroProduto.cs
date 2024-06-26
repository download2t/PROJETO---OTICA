﻿using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroProduto : ELP4PROJETO.Cadastros.FrmCadastros
    {
        FrmConsultaCategoria frmConCategoria;
        Produto oProduto;
        CTLProdutos aCTLProduto;
        CTLCategoria aCTLCategoria;
        public string caminhoFoto = "";
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private Form fotoForm;
        public FrmCadastroProduto()
        {
            InitializeComponent();
            oProduto = new Produto();
            aCTLProduto = new CTLProdutos();
            aCTLCategoria = new CTLCategoria();
        }
        public void SetConsultaCategorias(object obj)
        {
            frmConCategoria = (FrmConsultaCategoria)obj;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Produto prod)
            {
                oProduto = prod;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            base.LimparCampos();
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            txtQtdEstoque.Clear();
            txtProduto.Clear();
            txtCodCategoria.Clear();
            txtCodMarca.Clear();
            txtCategoria.Clear();
            txtReferencia.Clear();
            cmbMedida.SelectedIndex = 0;
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtDescricao.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtQtdEstoque.Enabled = false;
            txtProduto.Enabled = false;
            txtCategoria.Enabled = false;
            txtCodCategoria.Enabled = false;
            btnBuscarCategoria.Enabled = false;
            cmbMedida.Enabled = false;
            btnFoto.Enabled = false;
            txtCodMarca.Enabled = false;
            txtReferencia.Enabled = false;
            btnBuscarMarca.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtQtdEstoque.Enabled = true;
            cmbMedida.Enabled = true;
            txtProduto.Enabled = true;
            txtCodCategoria.Enabled = true;
            txtCategoria.Enabled = true;
            btnBuscarCategoria.Enabled = true;
            txtCodMarca.Enabled = true;
            btnFoto.Enabled = true;
            txtReferencia.Enabled = true;
            btnBuscarMarca.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();

            // Carrega os campos com os valores do objeto Produto
            txtCodigo.Text = oProduto.ID.ToString();
            txtDescricao.Text = oProduto.DescricaoProduto;
            txtCodMarca.Text = oProduto.Marca.ID.ToString();
            txtMarca.Text = oProduto.Marca.Nome;
            txtQtdEstoque.Text = oProduto.QtdEstoque.ToString();
            cmbMedida.Text = oProduto.UnidadeMedida;
            txtCategoria.Text = oProduto.Categoria.Nome;
            txtCodCategoria.Text = oProduto.Categoria.ID.ToString();
            txtProduto.Text = oProduto.Nome;
            txtReferencia.Text = oProduto.Referencia;

            // Formata os valores de preço para exibição correta
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtPrecoCusto.Text = oProduto.PrecoCusto.ToString("0.00", cultura);
            txtPrecoVenda.Text = oProduto.PrecoVenda.ToString("0.00", cultura);

            // Verifica se há uma foto e a carrega
            if (oProduto.Foto != null && oProduto.Foto.Length > 0)
            {
                pbFoto.BackgroundImage = null;
                using (MemoryStream ms = new MemoryStream(oProduto.Foto))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirProduto();
                }
            }
            else if (btnSalvar.Text == "Desativar" || btnSalvar.Text == "Ativar")
            {
                string acao = (btnSalvar.Text == "Desativar") ? "desativar" : "ativar";
                string mensagem = $"Tem certeza que deseja {acao} este produto?";

                DialogResult resultado = MessageBox.Show(mensagem, $"Confirmação de {acao}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        oProduto.ID = Convert.ToInt32(txtCodigo.Text);

                        oProduto.Status = (oProduto.Status == "A") ? "I" : "A"; // Se o status atual for "A", o novo status será "I" (inativo); caso contrário, será "A" (ativo)

                        aCTLProduto.AtivarOuDesativarProduto(oProduto);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao {acao} a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ExcluirProduto()
        {
            if (oProduto != null)
            {
                try
                {
                    var result = aCTLProduto.ExcluirProduto(oProduto.ID);
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

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                camposFaltantes.Add("Descrição");
            }
            if (string.IsNullOrWhiteSpace(txtCodMarca.Text))
            {
                camposFaltantes.Add("Código da Marca");
            }
            if (string.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                camposFaltantes.Add("Código da Categoria");
            }
            if (string.IsNullOrWhiteSpace(txtPrecoVenda.Text))
            {
                camposFaltantes.Add("Preço de venda");
            }
            if (string.IsNullOrWhiteSpace(txtQtdEstoque.Text))
            {
                camposFaltantes.Add("Quantidade de estoque");
            }
            if (string.IsNullOrWhiteSpace(cmbMedida.Text))
            {
                camposFaltantes.Add("Unidade de Medida");
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
                CultureInfo cultura = CultureInfo.InvariantCulture; // Usar a cultura atual do sistema
                oProduto.Nome = txtProduto.Text;
                oProduto.Categoria.ID = Convert.ToInt32(txtCodCategoria.Text);
                oProduto.DescricaoProduto = txtDescricao.Text;
                oProduto.UnidadeMedida = cmbMedida.Text;
                oProduto.Marca.ID = Convert.ToInt32(txtCodMarca.Text);
                oProduto.Referencia = txtReferencia.Text;
                oProduto.PrecoVenda = decimal.Parse(txtPrecoVenda.Text, cultura);

                if (pbFoto.Image != null)
                {
                    // Converte a imagem para um array de bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        try
                        {
                            pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                            oProduto.Foto = ms.ToArray();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("erro");
                        }
                    }
                }
                else
                {
                    oProduto.Foto = null;  // Define oProduto.Foto como null se não houver imagem
                }

                if (oProduto.ID == 0)
                {
                    oProduto.DataCriacao = DateTime.Now;
                    oProduto.PrecoCusto = 0;
                    oProduto.QtdEstoque = 0;
                    oProduto.Status = "A";
                    var result = aCTLProduto.AdicionarProduto(oProduto);
                    if (result)
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oProduto.DataUltimaAlteracao = DateTime.Now;
                    oProduto.QtdEstoque = Convert.ToInt32(txtQtdEstoque.Text);
                    oProduto.PrecoCusto = decimal.Parse(txtPrecoCusto.Text, cultura);

                    var result = aCTLProduto.AtualizarProduto(oProduto);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }

                return;
            }
        }


        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, um ponto decimal e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cmbMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Impede a entrada de caracteres no combobox
            e.Handled = true;
        }

        private void txtQtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "arquivos de imagens jpg e png |*.jpeg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
            {
                pbFoto.Load(caminhoFoto);
                pbFoto.BackgroundImage = null;
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCategoria consultaProduto = new FrmConsultaCategoria())
            {
                consultaProduto.btnSair.Text = "Selecionar";
                consultaProduto.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaProduto.IdSelecionado;
                string NomeSelecionado = consultaProduto.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCategoria.Text = IdSelecionado.ToString();
                txtCategoria.Text = NomeSelecionado;
            }
        }

        private void pbFoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (fotoForm == null || fotoForm.IsDisposed)
                {
                    fotoForm = Operacao.CriarFormFoto(pbFoto.Image);
                    fotoForm.Show();
                }
                else
                {
                    fotoForm.BringToFront();
                }
            }

        }

        private void txtCodCategoria_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }

        private void txtCodCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCategoria.Text))
            {
                Limpar();
            }
            else if (int.TryParse(txtCodCategoria.Text, out int cod) && cod > 0)
            {
                Categoria Valida = aCTLCategoria.BuscarCategoriaPorId(cod);

                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    Limpar();
                }
                else
                {
                    txtCategoria.Text = Valida.Nome;
                }

            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                Limpar();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }

        private void Limpar()
        {
            txtCodCategoria.Clear();
            txtCategoria.Clear();
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            using (FrmConsultaMarca consultaMarca = new FrmConsultaMarca())
            {
                consultaMarca.btnSair.Text = "Selecionar";
                consultaMarca.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = consultaMarca.IdSelecionado;
                string NomeSelecionado = consultaMarca.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodMarca.Text = IdSelecionado.ToString();
                txtMarca.Text = NomeSelecionado;
            }
        }

        private void txtCodMarca_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodMarca.Text))
            {
                LimparMarca();
            }
            else if (int.TryParse(txtCodMarca.Text, out int cod) && cod > 0)
            {
                CTLMarca aCtlMarca = new CTLMarca();
                Marca Valida = aCtlMarca.BuscarMarcaPorId(cod);

                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparMarca();
                }
                else
                {
                    txtMarca.Text = Valida.Nome;
                }

            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparMarca();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparMarca()
        {
            txtCodMarca.Clear();
            txtMarca.Clear();
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
    }
}
