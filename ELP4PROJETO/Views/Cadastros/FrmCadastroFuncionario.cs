using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroFuncionario : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Funcionarios oFuncionario;
        CTLFuncionarios aCTLFuncionarios;
        FrmConsultaFuncionario frmConFuncionarios;
        string ebrasileiro = "SIM";
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
            oFuncionario = new Funcionarios();
            aCTLFuncionarios = new CTLFuncionarios();
        }
        public void SetConsultaCidades(object obj)
        {
            frmConFuncionarios = (FrmConsultaFuncionario)obj;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Funcionarios func)
            {
                oFuncionario = func;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtNome.Clear();
            cmbSexo.SelectedIndex = 0;
            txtRG.Clear();
            txtCPF.Clear();
            txtCodCargo.Clear();
            txtCargo.Clear();
            txtApelido.Clear();
            dtNascimento.Value = DateTime.Now;
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCodCidade.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtLogradouro.Clear();
            txtComplemento.Clear();
            txtNumero.Clear();
            cmbStatus.SelectedIndex = 0;
            txtSenha.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtNome.Enabled = false;
            cmbSexo.Enabled = false;
            txtRG.Enabled = false;
            txtCPF.Enabled = false;
            txtCodCargo.Enabled = false;
            txtCargo.Enabled = false;
            txtApelido.Enabled = false;
            dtNascimento.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtCep.Enabled = false;
            txtCodCidade.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtLogradouro.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            cmbStatus.Enabled = false;
            txtSenha.Enabled = false;
            btnBuscarCargo.Enabled = false;
            btnCEP.Enabled = false;
            btnBuscarCidades.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            txtNome.Enabled = true;
            cmbSexo.Enabled = true;
            txtRG.Enabled = true;
            txtCPF.Enabled = true;
            txtCodCargo.Enabled = true;
            txtCargo.Enabled = true;
            txtApelido.Enabled = true;
            dtNascimento.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtCep.Enabled = true;
            txtCodCidade.Enabled = true;
            txtCidade.Enabled = true;
            txtBairro.Enabled = true;
            txtLogradouro.Enabled = true;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            cmbStatus.Enabled = true;
            txtSenha.Enabled = true;
            btnBuscarCargo.Enabled = true;
            btnCEP.Enabled = true;
            btnBuscarCidades.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oFuncionario.ID.ToString();
            txtNome.Text = oFuncionario.Nome;
            cmbSexo.Text = oFuncionario.Sexo == "M" ? "Masculino" : oFuncionario.Sexo == "F" ? "Feminino" : oFuncionario.Sexo;
            txtRG.Text = oFuncionario.RG;
            txtCPF.Text = oFuncionario.CPF;
            txtCodCargo.Text = oFuncionario.Cargo.ID.ToString();
            txtCargo.Text = oFuncionario.Cargo.Cargo;
            txtApelido.Text = oFuncionario.Apelido;
            dtNascimento.Value = oFuncionario.DataNascimento;
            txtEmail.Text = oFuncionario.Email;
            txtTelefone.Text = oFuncionario.Telefone;
            txtCelular.Text = oFuncionario.Celular;
            txtCep.Text = oFuncionario.CEP;
            txtCodCidade.Text = oFuncionario.Cidade.ID.ToString();
            txtCidade.Text = oFuncionario.Cidade.Cidade;
            txtBairro.Text = oFuncionario.Bairro;
            txtLogradouro.Text = oFuncionario.Endereco;
            txtComplemento.Text = oFuncionario.Complemento;
            txtNumero.Text = oFuncionario.Numero.ToString();
            cmbStatus.Text = oFuncionario.StatusFuncionario == "I" ? "Inativo" : oFuncionario.StatusFuncionario == "A" ? "Ativo" : oFuncionario.StatusFuncionario;
            if (txtCPF.Text != "")
                txtCPF.Enabled = true;
            txtRG.Enabled = true;
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
                    ExcluirFuncionario();
                }
            }
        }
        private void ExcluirFuncionario()
        {
            if (oFuncionario != null)
            {
                try
                {
                    var result = aCTLFuncionarios.ExcluirFuncionario(oFuncionario.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o funcionário. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o funcionário devido a outros registros estarem vinculados a este funcionário.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o funcionário. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Trate outras exceções gerais, se necessário
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private bool VerificarObrigatoriedadeCPF()
        {
            if (txtCPF.Enabled)
            {
                // Verifica se RG e CPF estão preenchidos
                if (string.IsNullOrWhiteSpace(txtRG.Text) || string.IsNullOrWhiteSpace(txtCPF.Text))
                {
                    MessageBox.Show("Documento RG e CPF são obrigatórios para clientes brasileiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else 
            {
                // Verifica se RG está preenchido
                if (string.IsNullOrWhiteSpace(txtRG.Text))
                {
                    MessageBox.Show("Documento RG é obrigatório para clientes brasileiros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }


        private bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (!VerificarObrigatoriedadeCPF())
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                camposFaltantes.Add("Nome");
            }

            if (string.IsNullOrWhiteSpace(cmbSexo.Text))
            {
                camposFaltantes.Add("SEXO");
            }
            if (string.IsNullOrWhiteSpace(txtCodCargo.Text))
            {
                camposFaltantes.Add("Codigo da cidade");
            }
            if (dtNascimento.Value == DateTime.Today)
            {
                camposFaltantes.Add("Data de nascimento");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                camposFaltantes.Add("E-mail");
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                camposFaltantes.Add("Cep");
            }
            if (string.IsNullOrWhiteSpace(txtCodCidade.Text))
            {
                camposFaltantes.Add("Codigo da cidade");
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                camposFaltantes.Add("Bairro");
            }
            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                camposFaltantes.Add("Logradouro");
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                camposFaltantes.Add("Numero");
            }
            if (string.IsNullOrWhiteSpace(cmbStatus.Text))
            {
                camposFaltantes.Add("Status");
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
                try
                {
                    oFuncionario.Nome = txtNome.Text;
                    oFuncionario.Sexo = cmbSexo.Text[0].ToString();
                    oFuncionario.RG = txtRG.Text;
                    oFuncionario.CPF = txtCPF.Text;
                    oFuncionario.Cargo.ID = Convert.ToInt32(txtCodCargo.Text);
                    oFuncionario.Apelido = txtApelido.Text;
                    oFuncionario.DataNascimento = dtNascimento.Value;
                    oFuncionario.Email = txtEmail.Text;
                    oFuncionario.Telefone = txtTelefone.Text;
                    oFuncionario.Celular = txtCelular.Text;
                    oFuncionario.CEP = txtCep.Text;
                    oFuncionario.Cidade.ID = Convert.ToInt32(txtCodCidade.Text);
                    oFuncionario.Bairro = txtBairro.Text;
                    oFuncionario.Endereco = txtLogradouro.Text;
                    oFuncionario.Complemento = txtComplemento.Text;
                    oFuncionario.Numero = Convert.ToInt32(txtNumero.Text);
                    oFuncionario.StatusFuncionario = cmbStatus.Text[0].ToString();

                    if (oFuncionario.ID == 0)
                    {
                        if (txtSenha.Text != "")
                        {
                            if (txtSenha.Text != "")
                            {
                                string senha = aCTLFuncionarios.CriptografarDados(txtSenha.Text);
                                oFuncionario.DataCriacao = DateTime.Now;
                                oFuncionario.Senha = senha;
                                var result = aCTLFuncionarios.AdicionarFuncionario(oFuncionario);
                                if (result == "OK")
                                    Close();
                                else
                                    MessageBox.Show("Erro ao adicionar funcionário: " + result);
                            }
                        }
                        else
                        {
                            MessageBox.Show("A senha deve ter pelo menos 6 caracteres.", "Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        oFuncionario.DataUltimaAlteracao = DateTime.Now;
                        if (txtSenha.Text != "")
                        {
                            if (txtSenha.TextLength >= 6)
                            {
                                string senha = aCTLFuncionarios.CriptografarDados(txtSenha.Text);
                                oFuncionario.Senha = senha;
                                var result = aCTLFuncionarios.AtualizarFuncionarioComSenha(oFuncionario);
                                if (result == "OK")
                                    Close();
                                else
                                    MessageBox.Show("Erro ao atualizar funcionário: " + result);
                            }
                            else
                            {
                                MessageBox.Show("Senha minima de 6 caractéres é exigida.");
                                return;
                            }

                        }
                        else
                        {
                            var result = aCTLFuncionarios.AtualizarFuncionarioSemSenha(oFuncionario);
                            if (result == "OK")
                                Close();
                            else
                                MessageBox.Show("Erro ao atualizar funcionário: " + result);
                        }
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Certifique-se de que os campos numéricos foram preenchidos corretamente." + ex.Message, "Formato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado ao salvar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRG_Leave(object sender, EventArgs e)
        {
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string documento = txtCPF.Text.Trim();

            if (!string.IsNullOrEmpty(documento))
            {
                bool isValid = Operacao.IsCpf(documento);

                if (!isValid)
                {
                    MessageBox.Show("CPF inválido. Por favor, insira um documento válido.");
                    txtCPF.Focus();
                }
            }
        }

        private void txtCodCargo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }

        private void txtCodCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodCargo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCargo.Text))
            {
                txtCodCargo.Clear();
                txtCargo.Clear();
            }
            else if (int.TryParse(txtCodCargo.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, defina o valor do txtSetor
                CTLCargos aCTLCargos = new CTLCargos();
                Cargos Valida = aCTLCargos.BuscarCargoPorId(cod);
                if (Valida == null)
                {
                    MessageBox.Show("Código inexistente.");
                    txtCodCargo.Clear();
                    txtCargo.Clear();
                    txtCodCargo.Focus();
                }
                else
                {
                    txtCargo.Text = Valida.Cargo;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                txtCodCargo.Clear();
                txtCargo.Clear();
                txtCodCargo.Focus();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }

        private void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCidade.Text))
            {
                // Se o campo txtCodCidade estiver vazio, limpe também o campo txtCidade
                txtCodCidade.Clear();
                txtCidade.Clear();
            }
            else if (int.TryParse(txtCodCidade.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique a cidade correspondente
                CTLCidades aCTLCidade = new CTLCidades();
                Cidades cidade = aCTLCidade.BuscarCidadePorId(cod);

                if (cidade == null)
                {
                    MessageBox.Show("Código inexistente.");
                    Limpar();
                }
                else if (cidade.StatusCidade == "I")
                {
                    MessageBox.Show("A cidade associada a este código está inativa.");
                    Limpar();
                }
                else
                {
                    txtCidade.Text = cidade.Cidade;
                    var result = VerificarPais();
                    if (result)
                    {
                        lblRg.Text = "RG";
                        lbRG.Visible = true;
                        lbCPF.Visible = true;
                        txtCPF.Enabled = true;
                        txtRG.Enabled = true;
                    }
                    else // Não é brasileiro
                    {
                        lblRg.Text = "Documento";
                        txtCPF.Enabled = false;
                        lbCPF .Visible = false;
                        txtRG.Enabled = true;
                    }
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
        private bool VerificarPais()
        {
            if (txtCodCidade.Text != string.Empty)
            {
                CTLCidades aCTLCidade = new CTLCidades();
                Cidades cidade = aCTLCidade.BuscarCidadePorId(Convert.ToInt32(txtCodCidade.Text));
                bool obrigatorioRGouCPF = cidade.OEstado.OPais.Pais.Equals("Brasil", StringComparison.OrdinalIgnoreCase);
                return obrigatorioRGouCPF;
            }
            else { return false; }

        }

        private void Limpar()
        {
            txtCodCidade.Clear();
            txtCidade.Clear();
            txtCodCidade.Focus();
        }


        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string fone = txtTelefone.Text.Trim();

            if (!string.IsNullOrEmpty(fone) && !Operacao.IsTelefone(fone))
            {
                MessageBox.Show("Número de telefone inválido. Por favor, insira um Número válido.");
                txtTelefone.Focus();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            string fone = txtCelular.Text.Trim();

            if (!string.IsNullOrEmpty(fone) && !Operacao.IsTelefone(fone))
            {
                MessageBox.Show("Número de celular inválido. Por favor, insira um Número válido.");
                txtCelular.Focus();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }

        private void btnBuscarCidades_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCidade frm = new FrmConsultaCidade())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCidade.Text = IdSelecionado.ToString();
                txtCidade.Text = NomeSelecionado;
                txtCodCidade_Leave(txtCodCidade, EventArgs.Empty);
            }
        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCargo frm = new FrmConsultaCargo())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                // Agora, defina os valores nos campos do seu formulário de cadastro
                txtCodCargo.Text = IdSelecionado.ToString();
                txtCargo.Text = NomeSelecionado;
            }
        }

        private async void btnCEP_Click(object sender, EventArgs e)
        {
            string cep = txtCep.Text.Trim(); // Obtém o CEP digitado no campo

            if (!string.IsNullOrEmpty(cep))
            {
                // Realiza a consulta do CEP
                string resultado = await Operacao.ConsultarCepAsync(cep);

                if (resultado != null)
                {
                    // Divida a string de resultado em campos individuais
                    string[] campos = resultado.Split(','); // THANKS GPT kkk

                    //Vc podia colocar um tipo DE RETORNO LOGRADOURO BAIRRO UF CIDADE 

                    // Encontre os valores específicos para cada campo
                    string logradouro = campos.FirstOrDefault(c => c.Contains("Logradouro:"))?.Replace("Logradouro:", "").Trim();
                    string bairro = campos.FirstOrDefault(c => c.Contains("Bairro:"))?.Replace("Bairro:", "").Trim();
                    string uf = campos.FirstOrDefault(c => c.Contains("UF:"))?.Replace("UF:", "").Trim();
                    string cidade = campos.FirstOrDefault(c => c.Contains("Cidade:"))?.Replace("Cidade:", "").Trim();

                    txtLogradouro.Text = logradouro;
                    txtBairro.Text = bairro;
                    txtCodCidade.Focus();
                    txtCodCidade.Select();
                }
                else
                {
                    // Lida com erros ou CEP inválido
                    Console.WriteLine("Erro na consulta de CEP ou CEP inválido.");
                }
            }
        }


        private void txtApelido_Leave(object sender, EventArgs e)
        {
            string apelido = txtApelido.Text;
            if (!string.IsNullOrEmpty(apelido))
            {
                var resultado = aCTLFuncionarios.BuscarEmailOuApelido(apelido);
                if (resultado != null)
                {
                    if ((resultado.ID > 0) && (resultado.ID != Convert.ToInt32(txtCodigo.Text)))
                    {
                        MessageBox.Show("Usuário já cadastrado !!");
                        txtApelido.Clear();
                    }
                }
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string apelidoOuEmail = txtEmail.Text;
            if (!string.IsNullOrEmpty(apelidoOuEmail))
            {

                var result = Operacao.IsEmail(apelidoOuEmail);
                if (result)
                {
                    var resultado = aCTLFuncionarios.BuscarEmailOuApelido(apelidoOuEmail);
                    if (resultado != null)
                    {
                        if ((resultado.ID) > 0 && (resultado.ID != Convert.ToInt32(txtCodigo.Text)))
                        {
                            MessageBox.Show("Usuário já cadastrado !!");
                            txtEmail.Clear();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Por favor insira um endereço de e-mail válido!");
                    txtEmail.Focus();
                }

            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
    }
}
