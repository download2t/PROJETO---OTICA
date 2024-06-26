using ELP4PROJETO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views
{
    public partial class FrmAlterarSenha : ELP4PROJETO.Cadastros.FrmCadastros
    {
        private Funcionarios oFuncionario;
        private CTLFuncionarios aCTLFuncionarios;
        private const int senhaMinLength = 6;
        public FrmAlterarSenha()
        {
            InitializeComponent();

            oFuncionario = UsuarioLogado.Funcionario;
            txtCodigo.Text = (oFuncionario?.ID ?? 0).ToString();
            aCTLFuncionarios = new CTLFuncionarios();
        }
        private bool VerificarCamposVazios()
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha não pode estar vazio.");
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtConfirma.Text))
            {
                MessageBox.Show("Campo de confirmar Senha não pode estar vazio.");
                txtConfirma.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenhaAntiga.Text))
            {
                MessageBox.Show("Campo senha antiga Senha não pode estar vazio.");
                txtSenhaAntiga.Focus();
                return false;
            }
            return true;
        }

        protected override void Salvar()
        {
            try
            {
                if (VerificarCamposVazios())
                {
                    string senha = txtSenha.Text;
                    string confirmaSenha = txtConfirma.Text;

                    // Obtém informações do usuário autenticado
                    Funcionarios usuarioAutenticado = UsuarioLogado.Funcionario;
                    int idDoFuncionario = usuarioAutenticado.ID;

                    // Obtém a senha antiga do usuário autenticado
                    string senhaAntigaDoFuncionario = usuarioAutenticado.Senha;

                    // Verifica se a senha antiga informada está correta
                    string senhaAntigaDigitada = aCTLFuncionarios.CriptografarDados(txtSenhaAntiga.Text);
                    if (senhaAntigaDigitada != senhaAntigaDoFuncionario)
                    {
                        MessageBox.Show("Senha antiga incorreta. Por favor, verifique.");
                        return;
                    }

                    // Verifica se a nova senha e a confirmação são iguais
                    if (senha == confirmaSenha)
                    {
                        // Atualiza a senha do usuário
                        oFuncionario.ID = idDoFuncionario;
                        oFuncionario.Senha = aCTLFuncionarios.CriptografarDados(senha); // Criptografa a nova senha

                        var result = aCTLFuncionarios.AtualizarSenha(oFuncionario);
                        if (result != null)
                        {
                            if (result.ID == idDoFuncionario)
                            {
                                UsuarioLogado.Funcionario.Senha = result.Senha;
                            }
                        }
                        MessageBox.Show("Senha alterada com sucesso.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não correspondem. Por favor, verifique.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar a senha: {ex.Message}");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarRequisitosESalvar(txtSenha.Text, txtConfirma.Text);
        }

        private void AtualizarRequisitosESalvar(string senha, string confirmacao)
        {
            AtualizarLabelsRequisitos(senha, confirmacao);
            VerificarSenhasIguais(senha, confirmacao);
        }

        private void AtualizarLabelsRequisitos(string senha, string confirmacao)
        {
            lblMaiusculo.Text = senha.Any(char.IsUpper) ? "Letra Maiúscula: ✓" : "Letra Maiúscula: ✗";
            lblMinusculo.Text = senha.Any(char.IsLower) ? "Letra Minúscula: ✓" : "Letra Minúscula: ✗";
            lblCaracter.Text = senha.Length >= senhaMinLength ? "Mais de 6 caracteres: ✓" : "Mais de 6 caracteres: ✗";
            lblNumero.Text = senha.Any(char.IsDigit) ? "Caractere Numérico: ✓" : "Caractere Numérico: ✗";
            lblCaracterE.Text = senha.Any(c => !char.IsLetterOrDigit(c)) ? "Caractere Especial: ✓" : "Caractere Especial: ✗";

            lblMaiusculo.ForeColor = senha.Any(char.IsUpper) ? Color.Green : Color.Gray;
            lblMinusculo.ForeColor = senha.Any(char.IsLower) ? Color.Green : Color.Gray;
            lblCaracter.ForeColor = senha.Length >= senhaMinLength ? Color.Green : Color.Gray;
            lblNumero.ForeColor = senha.Any(char.IsDigit) ? Color.Green : Color.Gray;
            lblCaracterE.ForeColor = senha.Any(c => !char.IsLetterOrDigit(c)) ? Color.Green : Color.Gray;
        }

        private void VerificarSenhasIguais(string senha, string confirmacao)
        {
            bool senhasIguais = senha != "" && senha == confirmacao;
            lblConfirmacao.Text = senhasIguais ? "Senhas Iguais: ✓" : "Senhas Iguais: ✗";
            lblConfirmacao.ForeColor = senhasIguais ? Color.Green : Color.Gray;

            // Habilitar o botão de salvar apenas se todos os requisitos forem cumpridos    
            btnSalvar.Enabled = senha.Any(char.IsUpper) &&
                               senha.Any(char.IsLower) &&
                               senha.Length >= senhaMinLength &&
                               senha.Any(char.IsDigit) &&
                               senhasIguais &&
                               senha.Any(c => !char.IsLetterOrDigit(c));
            if (btnSalvar.Enabled)
            {
                btnSalvar.BackColor = Color.Green;
                btnSalvar.FlatAppearance.BorderColor = Color.Green;
                btnSalvar.ForeColor = Color.White;
            }
            else
            {
                btnSalvar.BackColor = Color.Transparent;
                btnSalvar.FlatAppearance.BorderColor = Color.Black;
                btnSalvar.ForeColor = Color.Black;
            }


        }
    }
}
