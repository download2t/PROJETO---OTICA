using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Models.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroFornecedores : ELP4PROJETO.Views.Cadastros.FrmCadastroCliente
    {
        FrmConsultaCidade frmConCidades;
        private CTLFornecedores aCTLFornecedores;
        private Fornecedores oFornecedor;
        private string TipoFornecedor;
        Fornecedores FornecedorAntigo;
        public FrmCadastroFornecedores()
        {
            InitializeComponent();
            FornecedorAntigo = new Fornecedores();
            oFornecedor = new Fornecedores();
            aCTLFornecedores = new CTLFornecedores();

        }
        protected override void PessoaFisica(bool limparCampos)
        {
            VerCampos(true);
            txtInscEstadual.Enabled = false;
            txtInscMunicipal.Enabled = false;
            lbRG.Visible = true;
            lblrg.Visible = true;
            txtRG.Visible = true;
            txtCPFouCNPJ.Size = new System.Drawing.Size(109, 27);
            lbCpfOuCnpj.Text = "CPF";
            lbCliente.Text = "Nome";
            lbApelido.Text = "Apelido";
            lbNascimento.Text = "Data de nascimento";
            TipoFornecedor = "F";
            if (limparCampos)
                LimparCampos();

        }
        protected override void PessoaJuridica(bool limparCampos)
        {
            VerCampos(true);
            txtInscEstadual.Enabled = true;
            txtInscMunicipal.Enabled = true;
            lbCpfOuCnpj.Text = "CNPJ";
            lbCliente.Text = "Razão Social";
            lbApelido.Text = "Nome Fantasia";
            lbNascimento.Text = "Data Fundação";
            TipoFornecedor = "J";
            lblrg.Visible = false;
            txtCPFouCNPJ.Size = new System.Drawing.Size(226, 27);
            lbRG.Visible = false;
            txtRG.Visible = false;
            if (limparCampos)
                LimparCampos();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Fornecedores fornecedor)
            {
                oFornecedor = fornecedor;
                CarregarCampos();
            }
        }
        protected override void LimparCampos()
        {
            base.LimparCampos();
            txtInscEstadual.Clear();
            txtInscMunicipal.Clear();
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtInscEstadual.Enabled = false;
            txtInscMunicipal.Enabled = false;

        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtInscEstadual.Enabled = true;
            txtInscMunicipal.Enabled = true;
        }
        public override void CarregarCampos()
        {
            txtCodigo.Text = oFornecedor.ID.ToString();
            txtNome.Text = oFornecedor.NomeFantasia;
            txtApelido.Text = oFornecedor.RazaoSocial;
            txtInscMunicipal.Text = oFornecedor.InscricaoMunicipal;
            txtInscEstadual.Text = oFornecedor.InscricaoEstadual;
            txtCPFouCNPJ.Text = oFornecedor.CNPJ;
            dtNascimento.Value = oFornecedor.DataFundacao;
            txtEmail.Text = oFornecedor.Email;
            txtTelefone.Text = oFornecedor.Telefone;
            txtCelular.Text = oFornecedor.Celular;
            txtCep.Text = oFornecedor.CEP;
            txtCodCidade.Text = oFornecedor.Cidade.ID.ToString();
            txtCidade.Text = oFornecedor.Cidade.Cidade;
            txtBairro.Text = oFornecedor.Bairro;
            txtLogradouro.Text = oFornecedor.Endereco;
            txtComplemento.Text = oFornecedor.Complemento;
            txtNumero.Text = oFornecedor.Numero.ToString();
            cmbStatus.Text = oFornecedor.StatusFornecedor == "I" ? "Inativo" : oFornecedor.StatusFornecedor == "A" ? "Ativo" : oFornecedor.StatusFornecedor;
            txtCodCondicao.Text = oFornecedor.CondicaoPagamento.ID.ToString();
            txtCondicao.Text = oFornecedor.CondicaoPagamento.Condicao;
            TipoFornecedor = oFornecedor.TipoFornecedor;
            txtRG.Text = oFornecedor.RG;
            VerificarCamposJuridicosFisicos();
            FornecedorAntigo = oFornecedor;
            if (TipoFornecedor == "F")
            {
                PessoaFisica(false);
                cmbTipoCliente.Text = "PESSOA FÍSICA";
            }

            else
            {
                PessoaJuridica(false);
                cmbTipoCliente.Text = "PESSOA JÚRIDICA";
            }
        }
        protected override void VerificarCamposJuridicosFisicos()
        {
            var result = VerificarPais();
            if (result)
            {
                DesbloquearCampos();
                // Caso seja brasileiro
                if (TipoFornecedor == "F")
                {
                    BlockInsc();
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

                if (TipoFornecedor == "F")
                {
                    BlockInsc();
                    txtCPFouCNPJ.Enabled = false;
                    txtCPFouCNPJ.Text = "";
                    lbRG.Text = "RG";
                }
            }
        }
        private void BlockInsc()
        {
            txtInscMunicipal.Enabled = false;
            txtInscEstadual.Enabled = false;
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
                    ExcluirFornecedor();
                }
            }
        }
        private void ExcluirFornecedor()
        {
            if (oFornecedor != null)
            {
                try
                {
                    var result = aCTLFornecedores.ExcluirFornecedor(oFornecedor.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o fornecedor. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir o fornecedor devido a outros registros estarem vinculados a este fornecedor.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o fornecedor. Detalhes: " + ex.Message);
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

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                camposFaltantes.Add("Nome Fantasia");
            }
            if (string.IsNullOrWhiteSpace(txtApelido.Text))
            {
                camposFaltantes.Add("Razão Social");
            }
            if (string.IsNullOrWhiteSpace(txtCPFouCNPJ.Text))
            {
                camposFaltantes.Add("CNPJ");
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                camposFaltantes.Add("E-mail");
            }
            if (string.IsNullOrWhiteSpace(txtCodCondicao.Text))
            {
                camposFaltantes.Add("Códico da condição de pagamento");
            }
            if (string.IsNullOrWhiteSpace(txtCodCidade.Text))
            {
                camposFaltantes.Add("Codigo da cidade");
            }
            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                camposFaltantes.Add("Cep");
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
                oFornecedor.NomeFantasia = txtNome.Text;
                oFornecedor.RazaoSocial = txtApelido.Text;
                oFornecedor.InscricaoMunicipal = txtInscMunicipal.Text;
                oFornecedor.InscricaoEstadual = txtInscEstadual.Text;
                oFornecedor.CNPJ = txtCPFouCNPJ.Text;
                oFornecedor.RG = txtRG.Text;
                oFornecedor.DataFundacao = dtNascimento.Value;
                oFornecedor.Email = txtEmail.Text;
                oFornecedor.Telefone = txtTelefone.Text;
                oFornecedor.Celular = txtCelular.Text;
                oFornecedor.CEP = txtCep.Text;
                oFornecedor.Cidade.ID = Convert.ToInt32(txtCodCidade.Text);
                oFornecedor.Bairro = txtBairro.Text;
                oFornecedor.Endereco = txtLogradouro.Text;
                oFornecedor.Complemento = txtComplemento.Text;
                oFornecedor.Numero = Convert.ToInt32(txtNumero.Text);
                oFornecedor.StatusFornecedor = cmbStatus.Text[0].ToString();
                oFornecedor.CondicaoPagamento.ID = Convert.ToInt32(txtCodCondicao.Text);
                oFornecedor.TipoFornecedor = TipoFornecedor;

                if (oFornecedor.ID == 0)
                {
                    oFornecedor.DataCriacao = DateTime.Now;
                    var result = aCTLFornecedores.AdicionarFornecedor(oFornecedor);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oFornecedor.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLFornecedores.AtualizarFornecedor(oFornecedor);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }
        protected override void txtCPFouCNPJ_Leave(object sender, EventArgs e)
        {
            string documento = txtCPFouCNPJ.Text.Trim();

            // Se o campo estiver vazio, sai do método
            if (string.IsNullOrEmpty(documento))
            {
                return;
            }

            // Validação inicial para tipo de documento
            if ((TipoFornecedor == "F" && lbCpfOuCnpj.Text == "CPF" && !Operacao.IsCpf(documento)) ||
                (TipoFornecedor == "J" && lbCpfOuCnpj.Text == "CNPJ" && !Operacao.IsCnpj(documento)))
            {
                MessageBox.Show("Documento inválido. Por favor, insira um documento válido.");
                txtCPFouCNPJ.Text = "";
                txtCPFouCNPJ.Focus();
                return;
            }

            // Verifica se o documento já está cadastrado
            string result = aCTLFornecedores.BuscarFornecedorPorDocumento(documento);
            if (result != "OK" && documento != FornecedorAntigo.CNPJ)
            {
                MessageBox.Show("Erro, " + result);
                txtCPFouCNPJ.Focus();
                txtCPFouCNPJ.Text = "";
                return;
            }

            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
    }
}
