using ELP4PROJETO.Classes;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class frm : ELP4PROJETO.Cadastros.FrmCadastros
    {
        CTLCondicaoPagamento aCTLCondicaoPG = new CTLCondicaoPagamento();
        private int ultimoDias = 30; // Variável para armazenar o último valor de dias utilizado
        private CondicaoPagamento aCondicao;
        CTLParcelas aCTLParcela;
        List<Parcela> parcelasAtual;
        public frm()
        {
            InitializeComponent();
            aCondicao = new CondicaoPagamento();
            aCTLParcela = new CTLParcelas();
            parcelasAtual = new List<Parcela>();
        }
        protected override void Salvar()
        {
            if (txtPercentualTotal.Text == "100.00")
            {
                if (btnSalvar.Text == "SALVAR")
                {
                    aCondicao.DataCriacao = DateTime.Now;
                    aCondicao.Status = "A";
                    var result = aCTLCondicaoPG.AdicionarCondicaoPagamento(AdicionarGrid());
                    if (result == true)
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    //
                    aCondicao.ID = Convert.ToInt32(txtCodigo.Text);
                    var result = aCTLCondicaoPG.AtualizarCondicaoPagamento(AdicionarGrid());
                    if (result == true)
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
            else
            {
                MessageBox.Show("Impossivel salvar, o percentual não bate com 100%");
            }

        }
        public void Add()
        {
            try
            {
                int totalParcelas = DgCondicao.Rows.Count + 1;
                int dias = Convert.ToInt32(txtDias.Text);
                decimal percentualTotal = 0;

                // Calcula o percentual total
                foreach (DataGridViewRow row in DgCondicao.Rows)
                {
                    string valorCelula = row.Cells["percentual"].Value.ToString().Replace(',', '.');
                    percentualTotal += Convert.ToDecimal(valorCelula, CultureInfo.InvariantCulture);
                }

                // Substitui vírgulas por pontos e converte para decimal
                string percentualTexto = txtPercentual.Text.Replace(',', '.');
                decimal percentualAtual = Convert.ToDecimal(percentualTexto, CultureInfo.InvariantCulture);

                // Verifica se o percentual atual + o percentual total não ultrapassa 100%
                if (percentualTotal + percentualAtual > 100)
                {
                    MessageBox.Show("A soma do percentual atual com o percentual total ultrapassa 100%.");
                    return;
                }

                // Adiciona a nova linha ao DataGridView
                AddDg(totalParcelas, dias, percentualAtual);

                // Atualiza o valor do txtParcelas e txtDias
                txtParcelas.Text = totalParcelas.ToString();
                txtDias.Text = (dias + 30).ToString();
                ultimoDias = dias + 30;

                // Atualiza o valor do txtPercentualTotal
                txtPercentualTotal.Text = (percentualTotal + percentualAtual).ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de percentual inválido. Por favor, insira um número válido.");
            }
        }



        public void AddDg(int vLinha, int dias, decimal percentual)
        {
            DgCondicao.Rows.Add(
                vLinha,
                dias,
                txtCodForma.Text,
                txtForma.Text,
                percentual.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DgCondicao.Rows.Clear();
            txtPercentualTotal.Text = "0";
            txtParcelas.Text = "1";
            txtDias.Text = "30";
            ultimoDias = 30; // Reinicia o último valor de dias para 30
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifique se há uma linha selecionada
            if (DgCondicao.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = DgCondicao.SelectedRows[0];

                // Remove a linha selecionada do DataGridView
                DgCondicao.Rows.Remove(selectedRow);

                // Recalcular o percentual total
                RecalcularPercentualTotal();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada. Selecione uma linha para excluir.");
            }
        }

        private void RecalcularPercentualTotal()
        {
            decimal percentualTotal = 0;

            // Itera pelas linhas do DataGridView e soma os percentuais
            foreach (DataGridViewRow row in DgCondicao.Rows)
            {
                decimal percentual;
                if (decimal.TryParse(row.Cells["percentual"].Value?.ToString(), out percentual))
                {
                    percentualTotal += percentual;
                }
            }

            // Atualiza o valor de txtPercentualTotal.Text com o novo valor calculado
            txtPercentualTotal.Text = percentualTotal.ToString("0.00", CultureInfo.InvariantCulture);
        }


        // Evento para atualizar o último valor de dias quando o usuário alterar manualmente
        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDias.Text))
            {
                ultimoDias = Convert.ToInt32(txtDias.Text);
            }
        }


        public CondicaoPagamento AdicionarGrid()
        {
            CTLFormaPagamento ControllerForma = new CTLFormaPagamento();
            var pagamento = new CondicaoPagamento();
            List<Parcela> Lista = new List<Parcela>();
            Parcela Parcelas = null;
            pagamento.ID = Convert.ToInt32(txtCodigo.Text);
            CultureInfo cultura = CultureInfo.InvariantCulture;

            pagamento.Status = "A";
            pagamento.Condicao = Convert.ToString(txtCondicao.Text);
            pagamento.Multa = decimal.Parse(txtMulta.Text, cultura);
            pagamento.Taxa = decimal.Parse(txtTaxa.Text, cultura);
            pagamento.Desconto = decimal.Parse(txtDesconto.Text, cultura);
            pagamento.DataCriacao = DateTime.Now;
            pagamento.DataUltimaAlteracao = DateTime.Now;
            foreach (DataGridViewRow vLinha in DgCondicao.Rows)
            {
                Parcelas = new Parcela();
                Parcelas.ID = pagamento.ID;
                Parcelas.NumParcela = Convert.ToInt32(vLinha.Cells["num_parcela"].Value);
                Parcelas.DiasTotais = Convert.ToInt32(vLinha.Cells["dias_totais"].Value);
                Parcelas.Porcentagem = Convert.ToDecimal(vLinha.Cells["percentual"].Value);
                Parcelas.Forma = new FormaPagamento();
                Parcelas.Forma.ID = Convert.ToInt32(vLinha.Cells["idForma"].Value);
                Parcelas.DataCriacao = DateTime.Now;
                Parcelas.DataUltimaAlteracao = DateTime.Now;
                Lista.Add(Parcelas);
            }
            pagamento.uParcelas = Lista;
            pagamento.Parcelas = pagamento.uParcelas.Count();
            return pagamento;
        }
        public void Popular(CondicaoPagamento CondicaoPagamento)
        {
            // Formata os valores de preço para exibição correta
            CultureInfo cultura = CultureInfo.InvariantCulture;
            txtCodigo.Text = CondicaoPagamento.ID.ToString();
            txtCondicao.Text = CondicaoPagamento.Condicao.ToString();
            txtMulta.Text = CondicaoPagamento.Multa.ToString("0.00", cultura);
            txtDesconto.Text = CondicaoPagamento.Desconto.ToString("0.00", cultura);
            txtTaxa.Text = CondicaoPagamento.Taxa.ToString("0.00", cultura);
            txtDatCad.Text = CondicaoPagamento.DataCriacao.ToShortDateString();
            txtDatUltAlt.Text = CondicaoPagamento.DataUltimaAlteracao.ToShortDateString();
            int idCondicao = Convert.ToInt32(txtCodigo.Text);
            List<Parcela> parcelas = aCTLParcela.BuscarParcelasPorIDCondicao(idCondicao);

            foreach (var Parc in parcelas)
            {
                DgCondicao.Rows.Add(
                    Parc.NumParcela,
                    Parc.DiasTotais,
                    Parc.Forma.ID,
                    Parc.Forma.Forma,
                    Parc.Porcentagem
                );

                // Adiciona a parcela à lista parcelasAtual
                txtCodForma.Text = Parc.Forma.ID.ToString();
                txtForma.Text = Parc.Forma.Forma;
                parcelasAtual.Add(Parc);
            }
            txtPercentualTotal.Text = "100.00";
        }

        public void DefinirProximoIdCondicaoPagamento()
        {
            try
            {
                int proximoId = aCTLCondicaoPG.ObterProximoIdCondicaoPagamento();
                txtCodigo.Text = proximoId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao definir o próximo ID: {ex.Message}");
            }
        }
        private void tbIdForma_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }


        private void tbIdForma_Leave(object sender, EventArgs e)
        {

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (VerificarCamposVazios())
            {
                Add();
            }

        }


        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
            {
                if (DgCondicao.Rows.Count > 0)
                    Salvar();
            }
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a condição de pagamento?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        aCondicao.ID = Convert.ToInt32(txtCodigo.Text);
                        aCTLCondicaoPG.ExcluirCondicaoPagamento(aCondicao.ID);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (btnSalvar.Text == "DESATIVAR" || btnSalvar.Text == "ATIVAR")
            {
                string acao = (btnSalvar.Text == "DESATIVAR") ? "DESATIVAR" : "ATIVAR";
                string mensagem = $"Tem certeza que deseja {acao} a condição de pagamento?";

                DialogResult resultado = MessageBox.Show(mensagem, $"Confirmação de {acao}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        aCondicao.ID = Convert.ToInt32(txtCodigo.Text);

                        aCondicao.Status = (aCondicao.Status == "A") ? "I" : "A"; // Se o status atual for "A", o novo status será "I" (inativo); caso contrário, será "A" (ativo)

                        aCTLCondicaoPG.AtivarOuDesativarCondicaoPagamento(aCondicao);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao {acao} a condição de pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is CondicaoPagamento condicao)
            {
                aCondicao = condicao;
            }
        }
        protected override void LimparCampos()
        {
            txtCondicao.Clear();
            txtParcelas.Clear();
            txtDias.Clear();
            txtPercentualTotal.Clear();
            txtTaxa.Clear();
            txtMulta.Clear();
            txtDesconto.Clear();
            txtCodForma.Clear();
            txtForma.Clear();
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtCondicao.Enabled = false;
            txtParcelas.Enabled = false;
            txtDias.Enabled = false;
            txtPercentualTotal.Enabled = false;
            txtTaxa.Enabled = false;
            txtMulta.Enabled = false;
            txtDesconto.Enabled = false;
            txtCodForma.Enabled = false;
            txtForma.Enabled = false;
            btnAdicionar.Enabled = false;
            btnBuscarForma.Enabled = false;
            txtPercentual.Enabled = false;

        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtCondicao.Enabled = true;
            txtParcelas.Enabled = true;
            txtDias.Enabled = true;
            txtPercentualTotal.Enabled = true;
            txtTaxa.Enabled = true;
            txtMulta.Enabled = true;
            txtDesconto.Enabled = true;
            txtCodForma.Enabled = true;
            txtForma.Enabled = true;
            btnAdicionar.Enabled = true;
            btnBuscarForma.Enabled = true;
            txtPercentual.Enabled = true;
        }
        private bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtParcelas.Text))
            {
                camposFaltantes.Add("Parcelas");
            }
            if (string.IsNullOrWhiteSpace(txtTaxa.Text))
            {
                camposFaltantes.Add("Taxa");
            }
            if (string.IsNullOrWhiteSpace(txtMulta.Text))
            {
                camposFaltantes.Add("Multa");
            }
            if (string.IsNullOrWhiteSpace(txtDesconto.Text))
            {
                camposFaltantes.Add("Desconto");
            }
            if (string.IsNullOrWhiteSpace(txtCondicao.Text))
            {
                camposFaltantes.Add("Condição de pagamento");
            }
            if (string.IsNullOrWhiteSpace(txtCodForma.Text))
            {
                camposFaltantes.Add("Codigo de Forma de pagamento");
            }
            if (string.IsNullOrWhiteSpace(txtPercentualTotal.Text))
            {
                camposFaltantes.Add("Parcelas");
            }
            if (string.IsNullOrWhiteSpace(txtDias.Text))
            {
                camposFaltantes.Add("DiasTotais");
            }

            if (camposFaltantes.Count > 0)
            {
                string camposFaltantesStr = string.Join(", ", camposFaltantes);
                MessageBox.Show("Os seguintes campos são obrigatórios e não foram preenchidos: " + camposFaltantesStr, "Campos em Falta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnBuscarForma_Click(object sender, EventArgs e)
        {
            using (FrmConsultaFormaPagamento frm = new FrmConsultaFormaPagamento())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodForma.Text = IdSelecionado.ToString();
                txtForma.Text = NomeSelecionado;
                // Chamando explicitamente o evento Leave de txtCodPais
                txtCodForma_Leave(txtCodForma, EventArgs.Empty);

            }
        }

        private void txtCodForma_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodForma.Text))
                LimparForma();
            else if (int.TryParse(txtCodForma.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o estado correspondente
                CTLFormaPagamento aCTLF = new CTLFormaPagamento();
                FormaPagamento forma = aCTLF.BuscarFormaPagamentoPorId(cod);

                if (forma == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparForma();
                }
                else
                {
                    txtForma.Text = forma.Forma;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparForma();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparForma()
        {
            txtForma.Clear();
            txtCodForma.Clear();
            //txtParcelas.
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            //desativar Condição de pagamento.
        }

        private void txtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtPercentual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarDecimais((System.Windows.Forms.TextBox)sender, e);
        }
    }
}
