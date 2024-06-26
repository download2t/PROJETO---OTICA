using ELP4PROJETO.Classes;
using ELP4PROJETO.Consultas;
using ELP4PROJETO.Controllers;
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
    public partial class FrmCadastroReceita : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Receita aReceita;
        CTLReceita aCTLReceita;
        FrmConsultaCliente frmConCliente;
        FrmConsultaLaboratorios frmConsultaLaboratorios;
        FrmConsultaDoutores frmConsultaDoutores;

        public FrmCadastroReceita()
        {
            InitializeComponent();
            aCTLReceita = new CTLReceita();
            aReceita = new Receita();
        }
        public void SetConsultaDoutores(object obj)
        {
            frmConsultaDoutores = (FrmConsultaDoutores)obj;
        }
        public void SetConsultaClientes(object obj)
        {
            frmConCliente = (FrmConsultaCliente)obj;
        }
        virtual public void SetConsultaLaboratorios(object obj)
        {
            frmConsultaLaboratorios = (FrmConsultaLaboratorios)obj;
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Receita receita)
            {
                aReceita = receita;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtCodDoutor.Clear();
            txtCodLab.Clear();
            txtCodCliente.Clear();
            txtDoutor.Clear();
            txtLab.Clear();
            txtCliente.Clear();
            OdEsfLonge.Clear();
            OdCilLonge.Clear();
            OdEixoLonge.Clear();
            OdDnpLonge.Clear();
            OdAdicaoLonge.Clear();
            OdAlturaLonge.Clear();
            EdEsfLonge.Clear();
            EdCilLonge.Clear();
            EdEixoLonge.Clear();
            EdDnpLonge.Clear();
            EdAdicaoLonge.Clear();
            EdAlturaLonge.Clear();
            OdEsfPerto.Clear();
            OdCilPerto.Clear();
            OdEixoPerto.Clear();
            OdDnpPerto.Clear();
            OeEsfPerto.Clear();
            OeCilPerto.Clear();
            OeEixoPerto.Clear();
            OeDnpPerto.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtCodigo.Enabled = false;
            txtCodDoutor.Enabled = false;
            txtCodLab.Enabled = false;
            txtCodCliente.Enabled = false;
            txtDoutor.Enabled = false;
            txtLab.Enabled = false;
            txtCliente.Enabled = false;
            OdEsfLonge.Enabled = false;
            OdCilLonge.Enabled = false;
            OdEixoLonge.Enabled = false;
            OdDnpLonge.Enabled = false;
            OdAdicaoLonge.Enabled = false;
            OdAlturaLonge.Enabled = false;
            EdEsfLonge.Enabled = false;
            EdCilLonge.Enabled = false;
            EdEixoLonge.Enabled = false;
            EdDnpLonge.Enabled = false;
            EdAdicaoLonge.Enabled = false;
            EdAlturaLonge.Enabled = false;
            OdEsfPerto.Enabled = false;
            OdCilPerto.Enabled = false;
            OdEixoPerto.Enabled = false;
            OdDnpPerto.Enabled = false;
            OeEsfPerto.Enabled = false; ;
            OeCilPerto.Enabled = false;
            OeEixoPerto.Enabled = false;
            OeDnpPerto.Enabled = false;
            btnBuscarCidades.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnBuscarLab.Enabled = false;
            dtRecebimento.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtCodDoutor.Enabled = true;
            txtCodLab.Enabled = true;
            txtCodCliente.Enabled = true;
            txtDoutor.Enabled = true;
            txtLab.Enabled = true;
            txtCliente.Enabled = true;
            OdEsfLonge.Enabled = true;
            OdCilLonge.Enabled = true;
            OdEixoLonge.Enabled = true;
            OdDnpLonge.Enabled = true;
            OdAdicaoLonge.Enabled = true;
            OdAlturaLonge.Enabled = true;
            EdEsfLonge.Enabled = true;
            EdCilLonge.Enabled = true;
            EdEixoLonge.Enabled = true;
            EdDnpLonge.Enabled = true;
            EdAdicaoLonge.Enabled = true;
            EdAlturaLonge.Enabled = true;
            OdEsfPerto.Enabled = true;
            OdCilPerto.Enabled = true;
            OdEixoPerto.Enabled = true;
            OdDnpPerto.Enabled = true;
            OeEsfPerto.Enabled = true; ;
            OeCilPerto.Enabled = true;
            OeEixoPerto.Enabled = true;
            OeDnpPerto.Enabled = true;
            btnBuscarCidades.Enabled = true;
            btnBuscarCliente.Enabled = true;
            btnBuscarLab.Enabled = true;
            dtRecebimento.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = aReceita.ID.ToString();
            txtCodDoutor.Text = aReceita.Doutor.ID.ToString();
            txtCodLab.Text = aReceita.Laboratorio.ID.ToString();
            txtCodCliente.Text = aReceita.Cliente.ID.ToString();
            txtDoutor.Text = aReceita.Doutor.Nome;
            txtLab.Text = aReceita.Laboratorio.Nome;
            txtCliente.Text = aReceita.Cliente.Nome;


            CultureInfo cultura = CultureInfo.InvariantCulture;


            OdEsfLonge.Text = aReceita.OdEsfLonge.ToString("0.00", cultura);
            OdCilLonge.Text = aReceita.OdCilLonge.ToString("0.00", cultura);
            OdEixoLonge.Text = aReceita.OdEixoLonge.ToString("0.00", cultura);
            OdDnpLonge.Text = aReceita.OdDnpLonge.ToString("0.00", cultura);
            OdAdicaoLonge.Text = aReceita.OdAdicaoLonge.ToString("0.00", cultura);
            OdAlturaLonge.Text = aReceita.OdAlturaLonge.ToString("0.00", cultura);
            EdEsfLonge.Text = aReceita.EdEsfLonge.ToString("0.00", cultura);
            EdCilLonge.Text = aReceita.EdCilLonge.ToString("0.00", cultura);
            EdEixoLonge.Text = aReceita.EdEixoLonge.ToString("0.00", cultura);
            EdDnpLonge.Text = aReceita.EdDnpLonge.ToString("0.00", cultura);
            EdAdicaoLonge.Text = aReceita.EdAdicaoLonge.ToString("0.00", cultura);
            EdAlturaLonge.Text = aReceita.EdAlturaLonge.ToString("0.00", cultura);
            OdEsfPerto.Text = aReceita.OdEsfPerto.ToString("0.00", cultura);
            OdCilPerto.Text = aReceita.OdCilPerto.ToString("0.00", cultura);
            OdEixoPerto.Text = aReceita.OdEixoPerto.ToString("0.00", cultura);
            OdDnpPerto.Text = aReceita.OdDnpPerto.ToString("0.00", cultura);
            OeEsfPerto.Text = aReceita.OeEsfPerto.ToString("0.00", cultura);
            OeCilPerto.Text = aReceita.OeCilPerto.ToString("0.00", cultura);
            OeEixoPerto.Text = aReceita.OeEixoPerto.ToString("0.00", cultura);
            OeDnpPerto.Text = aReceita.OeDnpPerto.ToString("0.00", cultura);
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta receita?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirReceita();
                }
            }
        }

        private void ExcluirReceita()
        {
            if (aReceita != null)
            {
                try
                {
                    var result = aCTLReceita.ExcluirReceita(aReceita.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir a receita.");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir a receita devido a outros registros estarem vinculados a esta receita.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir a receita. Detalhes: " + ex.Message);
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

            if (string.IsNullOrWhiteSpace(txtCodDoutor.Text))
            {
                camposFaltantes.Add("Código da Cidade");
            }
            if (string.IsNullOrWhiteSpace(txtCodLab.Text))
            {
                camposFaltantes.Add("Código do Laboratório");
            }
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                camposFaltantes.Add("Código do Cliente");
            }
            // Verifique outros campos conforme necessário

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
                CultureInfo cultura = CultureInfo.InvariantCulture;

                aReceita.Doutor.ID = Convert.ToInt32(txtCodDoutor.Text);
                aReceita.Laboratorio.ID = Convert.ToInt32(txtCodLab.Text);
                aReceita.Cliente.ID = Convert.ToInt32(txtCodCliente.Text);
                aReceita.DataRecebimento = dtRecebimento.Value;

                aReceita.OdEsfLonge = string.IsNullOrWhiteSpace(OdEsfLonge.Text) ? 0.0m : decimal.Parse(OdEsfLonge.Text, cultura);
                aReceita.OdCilLonge = string.IsNullOrWhiteSpace(OdCilLonge.Text) ? 0.0m : decimal.Parse(OdCilLonge.Text, cultura);
                aReceita.OdEixoLonge = string.IsNullOrWhiteSpace(OdEixoLonge.Text) ? 0.0m : decimal.Parse(OdEixoLonge.Text, cultura);
                aReceita.OdDnpLonge = string.IsNullOrWhiteSpace(OdDnpLonge.Text) ? 0.0m : decimal.Parse(OdDnpLonge.Text, cultura);
                aReceita.OdAdicaoLonge = string.IsNullOrWhiteSpace(OdAdicaoLonge.Text) ? 0.0m : decimal.Parse(OdAdicaoLonge.Text, cultura);
                aReceita.OdAlturaLonge = string.IsNullOrWhiteSpace(OdAlturaLonge.Text) ? 0.0m : decimal.Parse(OdAlturaLonge.Text, cultura);
                aReceita.EdEsfLonge = string.IsNullOrWhiteSpace(EdEsfLonge.Text) ? 0.0m : decimal.Parse(EdEsfLonge.Text, cultura);
                aReceita.EdCilLonge = string.IsNullOrWhiteSpace(EdCilLonge.Text) ? 0.0m : decimal.Parse(EdCilLonge.Text, cultura);
                aReceita.EdEixoLonge = string.IsNullOrWhiteSpace(EdEixoLonge.Text) ? 0.0m : decimal.Parse(EdEixoLonge.Text, cultura);
                aReceita.EdDnpLonge = string.IsNullOrWhiteSpace(EdDnpLonge.Text) ? 0.0m : decimal.Parse(EdDnpLonge.Text, cultura);
                aReceita.EdAdicaoLonge = string.IsNullOrWhiteSpace(EdAdicaoLonge.Text) ? 0.0m : decimal.Parse(EdAdicaoLonge.Text, cultura);
                aReceita.EdAlturaLonge = string.IsNullOrWhiteSpace(EdAlturaLonge.Text) ? 0.0m : decimal.Parse(EdAlturaLonge.Text, cultura);

                aReceita.OdEsfPerto = string.IsNullOrWhiteSpace(OdEsfPerto.Text) ? 0.0m : decimal.Parse(OdEsfPerto.Text, cultura);
                aReceita.OdCilPerto = string.IsNullOrWhiteSpace(OdCilPerto.Text) ? 0.0m : decimal.Parse(OdCilPerto.Text, cultura);
                aReceita.OdEixoPerto = string.IsNullOrWhiteSpace(OdEixoPerto.Text) ? 0.0m : decimal.Parse(OdEixoPerto.Text, cultura);
                aReceita.OdDnpPerto = string.IsNullOrWhiteSpace(OdDnpPerto.Text) ? 0.0m : decimal.Parse(OdDnpPerto.Text, cultura);
                aReceita.OeEsfPerto = string.IsNullOrWhiteSpace(OeEsfPerto.Text) ? 0.0m : decimal.Parse(OeEsfPerto.Text, cultura);
                aReceita.OeCilPerto = string.IsNullOrWhiteSpace(OeCilPerto.Text) ? 0.0m : decimal.Parse(OeCilPerto.Text, cultura);
                aReceita.OeEixoPerto = string.IsNullOrWhiteSpace(OeEixoPerto.Text) ? 0.0m : decimal.Parse(OeEixoPerto.Text, cultura);
                aReceita.OeDnpPerto = string.IsNullOrWhiteSpace(OeDnpPerto.Text) ? 0.0m : decimal.Parse(OeDnpPerto.Text, cultura);

                if (aReceita.ID == 0)
                {
                    aReceita.DataCriacao = DateTime.Now;
                    var result = aCTLReceita.AdicionarReceita(aReceita);
                    if (result == "OK")
                    {
                        MessageBox.Show("Sucesso !");
                        Close();
                    }  
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    aReceita.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLReceita.AtualizarReceita(aReceita);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }

        private void txtCodDoutor_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null; // Remove o botão "SALVAR" como botão padrão
        }

        private void txtCodDoutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarValorKeyPress((System.Windows.Forms.TextBox)sender, e);
        }

        private void txtCodDoutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodDoutor.Text))
            {
                txtCodDoutor.Clear();
                txtDoutor.Clear();
            }
            else if (int.TryParse(txtCodDoutor.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o status do país
                CTLDoutores aCTLD = new CTLDoutores();
                Doutor doc = aCTLD.BuscarDoutorPorId(cod);

                if (doc == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparDoutor();
                }
                else
                {
                    txtDoutor.Text = doc.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparDoutor();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparDoutor()
        {
            txtCodDoutor.Clear();
            txtDoutor.Clear();
            txtCodDoutor.Focus();
        }

        private void txtCodLab_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodLab.Text))
            {
                txtCodLab.Clear();
                txtLab.Clear();
            }
            else if (int.TryParse(txtCodLab.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o status do país
                CTLLaboratorios aCTLLab = new CTLLaboratorios();
                Laboratorio doc = aCTLLab.BuscarLaboratorioPorId(cod);

                if (doc == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparLab();
                }
                else
                {
                    txtLab.Text = doc.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparLab();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão
        }
        private void LimparLab()
        {
            txtCodLab.Clear();
            txtLab.Clear();
            txtCodLab.Focus();
        }
        private void LimparCliente()
        {
            txtCodCliente.Clear();
            txtCliente.Clear();
            txtCliente.Focus();
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCliente.Text))
            {
                txtCodCliente.Clear();
                txtCliente.Clear();
            }
            else if (int.TryParse(txtCodCliente.Text, out int cod) && cod > 0)
            {
                // Se o código for um número inteiro válido e maior que zero, verifique o status do país
                CTLClientes aCTL = new CTLClientes();
                Clientes doc = aCTL.BuscarClientePorId(cod);

                if (doc == null)
                {
                    MessageBox.Show("Código inexistente.");
                    LimparCliente();
                }
                else
                {
                    txtCliente.Text = doc.Nome;
                }
            }
            else
            {
                // Se o código não for um número inteiro válido ou não for maior que zero, limpe ambos os campos
                MessageBox.Show("Código inválido. Certifique-se de inserir um número inteiro válido maior que zero.");
                LimparCliente();
            }
            this.AcceptButton = btnSalvar; // Restaura o botão "SALVAR" como botão padrão

        }

        private void btnBuscarCidades_Click(object sender, EventArgs e)
        {
            using (FrmConsultaDoutores frm = new FrmConsultaDoutores())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;
                txtCodDoutor.Text = IdSelecionado.ToString();
                txtDoutor.Text = NomeSelecionado;
                txtCodDoutor_Leave(txtCodDoutor, EventArgs.Empty);

            }
        }

        private void btnBuscarLab_Click(object sender, EventArgs e)
        {
            using (FrmConsultaLaboratorios frm = new FrmConsultaLaboratorios())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;
                txtCodLab.Text = IdSelecionado.ToString();
                txtLab.Text = NomeSelecionado;
                txtCodLab_Leave(txtCodLab, EventArgs.Empty);

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (FrmConsultaCliente frm = new FrmConsultaCliente())
            {
                frm.btnSair.Text = "Selecionar";
                frm.ShowDialog();
                int IdSelecionado = frm.IdSelecionado;
                string NomeSelecionado = frm.NomeSelecionado;
                txtCodCliente.Text = IdSelecionado.ToString();
                txtCliente.Text = NomeSelecionado;
                txtCodCliente_Leave(txtCodCliente, EventArgs.Empty);

            }
        }

        private void OdEsfLonge_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarDecimais((System.Windows.Forms.TextBox)sender, e);
        }
    }
}
