using ELP4PROJETO.Cadastros;
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroCliente : ELP4PROJETO.Cadastros.FrmCadastros
    {
        private FrmConsultaCidade frmConCidades;
        private CTLClientes aCTLClientes;
        private Clientes oCliente;
        private string TipoCliente;
        Clientes ClienteAntigo;

        public FrmCadastroCliente()
        {
            InitializeComponent();
            oCliente = new Clientes();
            aCTLClientes = new CTLClientes();
            ClienteAntigo = new Clientes();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Clientes cliente)
            {
                oCliente = cliente;
                CarregarCampos();
            }
        }
        public void SetConsultaCidades(object obj)
        {
            frmConCidades = (FrmConsultaCidade)obj;
        }
        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRG.Clear();
            txtCPFouCNPJ.Clear();
            cmbSexo.SelectedIndex = 0;
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
            txtCodigo.Clear();
            cmbStatus.SelectedIndex = 0;
        }
        protected override void Salvar()
        {
            if (VerificarCamposVazios())
            {
                if (TipoCliente == "F")
                {
                    oCliente.Sexo = cmbSexo.Text[0].ToString();
                }
                oCliente.Nome = txtNome.Text;
                oCliente.CPF = txtCPFouCNPJ.Text;
                oCliente.RG = txtRG.Text;
                oCliente.Apelido = txtApelido.Text;
                oCliente.DataNasc = dtNascimento.Value;
                oCliente.Email = txtEmail.Text;
                oCliente.Telefone = txtTelefone.Text;
                oCliente.Celular = txtCelular.Text;
                oCliente.CEP = txtCep.Text;
                oCliente.Cidade.ID = Convert.ToInt32(txtCodCidade.Text);
                oCliente.Bairro = txtBairro.Text;
                oCliente.Endereco = txtLogradouro.Text;
                oCliente.Complemento = txtComplemento.Text;
                oCliente.Numero = Convert.ToInt32(txtNumero.Text);
                oCliente.StatusCliente = cmbStatus.Text[0].ToString();
                oCliente.CondicaoPagamento.ID = Convert.ToInt32(txtCodCondicao.Text);
                oCliente.TipoCliente = TipoCliente;


                if (oCliente.ID == 0)
                {
                    oCliente.DataCriacao = DateTime.Now;
                    var result = aCTLClientes.AdicionarCliente(oCliente);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oCliente.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLClientes.AtualizarCliente(oCliente);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtNome.Enabled = false;
            txtRG.Enabled = false;
            txtCPFouCNPJ.Enabled = false;
            cmbSexo.Enabled = false;
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
            txtCodigo.Enabled = false;
            btnBuscarCidades.Enabled = false;
            cmbStatus.Enabled = false;
            btnCEP.Enabled = false;
            btnBuscarCondicaoPG.Enabled = false;
            txtCodCondicao.Enabled = false;
            txtCondicao.Enabled = false;
        }
        public void VerCampos(bool valor)
        {
            base.BloquearCampos();
            pn1.Visible = valor;
            pn2.Visible = valor;
        }
        public override void DesbloquearCampos()
        {
            base.BloquearCampos();
            txtCodigo.Enabled = true;
            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtCPFouCNPJ.Enabled = true;
            cmbSexo.Enabled = true;
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
            txtCodigo.Enabled = true;
            btnBuscarCidades.Enabled = true;
            cmbStatus.Enabled = true;
            btnCEP.Enabled = true;
            btnBuscarCondicaoPG.Enabled = true;
            txtCodCondicao.Enabled = true;
            txtCondicao.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oCliente.ID.ToString();
            txtNome.Text = oCliente.Nome;

            txtApelido.Text = oCliente.Apelido;
            dtNascimento.Value = oCliente.DataNasc;
            txtEmail.Text = oCliente.Email;
            txtTelefone.Text = oCliente.Telefone;
            txtCelular.Text = oCliente.Celular;
            txtCep.Text = oCliente.CEP;
            txtCodCidade.Text = oCliente.Cidade.ID.ToString();
            txtCidade.Text = oCliente.Cidade.Cidade;
            txtBairro.Text = oCliente.Bairro;
            txtLogradouro.Text = oCliente.Endereco;
            txtComplemento.Text = oCliente.Complemento;
            txtNumero.Text = oCliente.Numero.ToString();
            cmbStatus.Text = oCliente.StatusCliente == "I" ? "Inativo" : oCliente.StatusCliente == "A" ? "Ativo" : oCliente.StatusCliente;
            txtRG.Text = oCliente.RG;
            txtCPFouCNPJ.Text = oCliente.CPF;
            txtCodCondicao.Text = oCliente.CondicaoPagamento.ID.ToString();
            txtCondicao.Text = oCliente.CondicaoPagamento.Condicao.ToString();
            cmbTipoCliente.Text = oCliente.TipoCliente == "F" ? "PESSOA FÍSICA" : oCliente.TipoCliente == "J" ? "PESSOA JURÍDICA" : "OUTRO";
            TipoCliente = oCliente.TipoCliente;
            VerificarCamposJuridicosFisicos();
            ClienteAntigo = oCliente;
            if (TipoCliente == "F")
            {
                PessoaFisica(false);
                cmbSexo.Text = oCliente.Sexo == "M" ? "Masculino" : oCliente.Sexo == "F" ? "Feminino" : oCliente.Sexo;
            }
            else if (TipoCliente == "J")
            {
                PessoaJuridica(false);
                cmbTipoCliente.Text = "PESSOA JÚRIDICA";
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
                    ExcluirCliente();
                }
            }
        }
        private void ExcluirCliente()
        {
            if (oCliente != null)
            {
                try
                {
                    var result = aCTLClientes.ExcluirCliente(oCliente.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cliente. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o cliente devido a outros registros estarem vinculados a este cliente.");
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


            if (string.IsNullOrWhiteSpace(txtCodCidade.Text))
            {
                camposFaltantes.Add("Código da cidade");
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                camposFaltantes.Add("Nome");
            }
            if (TipoCliente == "F")
            {
                if (string.IsNullOrWhiteSpace(txtRG.Text))
                {
                    camposFaltantes.Add("RG");
                }
                if (string.IsNullOrWhiteSpace(txtCPFouCNPJ.Text))
                    if (txtCPFouCNPJ.Enabled == true)
                    {
                        camposFaltantes.Add("CPF");
                    }

            }
            else if (TipoCliente == "J")
            {
                if (string.IsNullOrWhiteSpace(txtCPFouCNPJ.Text))
                    camposFaltantes.Add("CNPJ");
            }
            if (string.IsNullOrWhiteSpace(txtCodCondicao.Text))
            {
                camposFaltantes.Add("Código da condição de pagamento");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                camposFaltantes.Add("E-mail");
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                camposFaltantes.Add("CEP");
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
                camposFaltantes.Add("Número");
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
        protected virtual bool VerificarPais()
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
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }
        private void txtCodCidade_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }
        protected virtual void txtCodCidade_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCidade.Text))
            {
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
                else
                {
                    VerificarAtivo(cidade);
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

        private void VerificarAtivo(Cidades cidade)
        {
            if (cidade.StatusCidade == "I")
            {
                var result = MessageBox.Show("A cidade associada a este código está inativa. Deseja continuar?",
                                             "Cidade Inativa",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    txtCidade.Text = cidade.Cidade;
                    VerificarCamposJuridicosFisicos();
                }
                else
                {
                    Limpar();
                }
            }
            else
            {
                txtCidade.Text = cidade.Cidade;
                VerificarCamposJuridicosFisicos();
            }
        }

        protected virtual void VerificarCamposJuridicosFisicos()
        {
            var result = VerificarPais();
            if (result)
            {
                DesbloquearCampos();
                // Caso seja brasileiro
                if (TipoCliente == "F")
                {
                    lblCpf.Visible = true;
                    lbCpfOuCnpj.Text = "CPF";
                    lbRG.Text = "RG";
                }
                else // Pessoa jurídica brasileira
                {
                    lbCpfOuCnpj.Text = "CNPJ";
                    lbRG.Text = "RG";
                }
            }
            else
            {
                // Caso não seja brasileiro

                if (TipoCliente == "F")
                {
                    txtCPFouCNPJ.Enabled = false;
                    txtCPFouCNPJ.Text = "";
                    lblCpf.Visible = false;
                    lbRG.Text = "RG";
                }
            }
        }
        private void Limpar()
        {
            txtCodCidade.Clear();
            txtCidade.Clear();
            txtCodCidade.Focus();
        }
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtRG.Text = "";
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
                if (IdSelecionado > 0)
                {
                    // Busque a cidade correspondente
                    CTLCidades aCTLCidade = new CTLCidades();
                    Cidades cidade = aCTLCidade.BuscarCidadePorId(IdSelecionado);

                    if (cidade != null)
                    {
                        VerificarAtivo(cidade);
                    }
                    else
                    {
                        MessageBox.Show("Código inexistente.");
                        Limpar();
                    }
                }
            }
        }

        protected virtual void txtCPFouCNPJ_Leave(object sender, EventArgs e)
        {
            string documento = txtCPFouCNPJ.Text.Trim();

            // Se o campo estiver vazio, sai do método
            if (string.IsNullOrEmpty(documento))
            {
                return;
            }

            // Validação inicial para tipo de documento
            if ((TipoCliente == "F" && lbCpfOuCnpj.Text == "CPF" && !Operacao.IsCpf(documento)) ||
                (TipoCliente == "J" && lbCpfOuCnpj.Text == "CNPJ" && !Operacao.IsCnpj(documento)))
            {
                MessageBox.Show("Documento inválido. Por favor, insira um documento válido.");
                txtCPFouCNPJ.Focus();
                return;
            }

            // Verifica se o documento já existe no banco de dados
            var result = aCTLClientes.BuscarClientePorDocumento(documento);
            if (result != "OK" && documento != ClienteAntigo.CPF)
            {
                MessageBox.Show("Erro, " + result);
                txtCPFouCNPJ.Focus();
                txtCPFouCNPJ.Text = "";
                return;
            }

            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }


        /*   protected virtual async void btnCEP_Click(object sender, EventArgs e)
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
           }*/
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
                    string[] campos = resultado.Split(',');

                    // Encontre os valores específicos para cada campo
                    string logradouro = campos.FirstOrDefault(c => c.Contains("Logradouro:"))?.Replace("Logradouro:", "").Trim();
                    string bairro = campos.FirstOrDefault(c => c.Contains("Bairro:"))?.Replace("Bairro:", "").Trim();
                    string uf = campos.FirstOrDefault(c => c.Contains("UF:"))?.Replace("UF:", "").Trim();
                    string cidadeNome = campos.FirstOrDefault(c => c.Contains("Cidade:"))?.Replace("Cidade:", "").Trim();

                    // Preenche os campos do formulário
                    txtLogradouro.Text = logradouro ?? string.Empty;
                    txtBairro.Text = bairro ?? string.Empty;

                    // Verifica se a cidade já está cadastrada usando o novo método
                    CTLCidades ctlCidades = new CTLCidades();
                    Cidades cidade = ctlCidades.BuscarCidadePorNomeEUF(cidadeNome, uf);

                    if (cidade != null)
                    {
                        txtCodCidade.Text = cidade.ID.ToString();
                        txtCidade.Text = cidade.Cidade;
                    }
                    else
                    {
                        // Caso a cidade não esteja cadastrada, pergunta se deseja adicionar
                        DialogResult dialogResult = MessageBox.Show($"A cidade {cidadeNome} - {uf} não está cadastrada. Deseja adicionar?", "Cidade não encontrada", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Chama o método para buscar e adicionar a cidade
                            btnBuscarCidades_Click(sender, e);
                        }
                        else
                        {
                            txtCodCidade.Text = string.Empty;
                            txtCidade.Text = cidadeNome ?? string.Empty;
                        }
                    }

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

        private void txtCodCondicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodCondicao_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCondicao.Text))
                LimparCondPg();
            else if (int.TryParse(txtCodCondicao.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o estado correspondente
                CTLCondicaoPagamento aCTLcon = new CTLCondicaoPagamento();
                CondicaoPagamento condicao = aCTLcon.BuscarCondicaoPagamentoPorId(cod);

                if (condicao == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparCondPg();
                }

                else
                {
                    txtCondicao.Text = condicao.Condicao;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparCondPg();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparCondPg()
        {
            txtCondicao.Clear();
            txtCodCondicao.Clear();
        }

        protected virtual void txtCodCondicao_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }

        private void btnBuscarCondicaoPG_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCondicaoPagamento frm = new FrmConsultaCondicaoPagamento())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();

                // Após o retorno do diálogo, você pode acessar os valores do cliente selecionado
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;

                txtCodCondicao.Text = IdSelecionado.ToString();
                txtCondicao.Text = NomeSelecionado;
                txtCodCondicao_Leave(txtCodCondicao, EventArgs.Empty);

            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }

        protected virtual void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbTipoCliente.Text))
            {
                if (cmbTipoCliente.Text.Contains("F"))
                    PessoaFisica(true);
                else if (cmbTipoCliente.Text.Contains("J"))
                    PessoaJuridica(true);
            }

        }
        protected virtual void PessoaFisica(bool limparCampos)
        {
            VerCampos(true);
            cmbSexo.Visible = true;
            lbSexo.Visible = true;
            lbOBSexo.Visible = true;
            txtApelido.Size = new System.Drawing.Size(158, 27);
            lbRG.Visible = true;
            txtRG.Visible = true;
            txtCPFouCNPJ.Size = new System.Drawing.Size(109, 27);
            lbCpfOuCnpj.Text = "CPF";
            TipoCliente = "F";
            lbCliente.Text = "Cliente";
            lbApelido.Text = "Apelido";
            lbNascimento.Text = "Data de nascimento";
            lblrg.Visible = true;
            lblCpf.Visible = true;
  
            if (limparCampos)
                LimparCampos();

        }
        protected virtual void PessoaJuridica(bool limparCampos)
        {
            VerCampos(true);
            txtCPFouCNPJ.Enabled = true;
            cmbSexo.Visible = false;
            lbSexo.Visible = false;
            lbOBSexo.Visible = false;
            lbCpfOuCnpj.Text = "CNPJ";
            txtApelido.Size = new System.Drawing.Size(303, 27);
            txtCPFouCNPJ.Size = new System.Drawing.Size(226, 27);
            lbRG.Visible = false;
            lbCliente.Text = "Razão Social";
            lbApelido.Text = "Nome Fantasia";
            lbNascimento.Text = "Data Fundação";
            lblrg.Visible= false;
            txtRG.Visible = false;
            lblCpf.Visible = true;
            lblrg.Visible = false;
            TipoCliente = "J";
            if (limparCampos)
                LimparCampos();
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!string.IsNullOrEmpty(email) && !Operacao.IsEmail(email))
            {
                MessageBox.Show("Endereço de e-mail inválido. Por favor, insira um e-mail válido.");
                txtEmail.Focus();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }

        protected virtual void txtRG_Leave(object sender, EventArgs e)
        {
            string documento = txtRG.Text.Trim();

            // Se o campo estiver vazio, sai do método
            if (string.IsNullOrEmpty(documento))
            {
                return;
            }

            // Verifica se o documento já existe no banco de dados
            var result = aCTLClientes.BuscarClientePorRG(documento);
            if (result != "OK" && documento != ClienteAntigo.RG)
            {
                MessageBox.Show("Erro, " + result);
                txtRG.Text = "";
                txtRG.Focus();
                return;
            }
        }
    }
}
