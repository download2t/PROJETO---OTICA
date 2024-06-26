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
    public partial class FrmCadastroCargo : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Cargos oCargo;
        CTLCargos aCTLCargo;

        public FrmCadastroCargo()
        {
            InitializeComponent();
            aCTLCargo = new CTLCargos();
            oCargo = new Cargos();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Cargos cargo)
            {
                oCargo = cargo;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtCargo.Clear();
            cmbStatus.SelectedIndex = 0;
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtCargo.Enabled = false;
            cmbStatus.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtCargo.Enabled = true;
            cmbStatus.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oCargo.ID.ToString();
            txtCargo.Text = oCargo.Cargo;
            cmbStatus.Text = oCargo.StatusCargo == "I" ? "Inativo" : oCargo.StatusCargo == "A" ? "Ativo" : oCargo.StatusCargo;
        }
        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este estado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirCargo();
                }
            }
        }
        private void ExcluirCargo()
        {
            if (oCargo != null)
            {
                try
                {
                    var result = aCTLCargo.ExcluirCargo(oCargo.ID);
                    if (result)
                        Close();
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cargo. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Verifica o número de erro 547, que corresponde a violação de chave estrangeira
                    {
                        MessageBox.Show("Não é possível excluir cargo devido a outros registros estarem vinculados a este cargo.");
                    }
                    else
                    {
                        // Trate outras exceções SQL, se necessário
                        MessageBox.Show("Ocorreu um erro ao excluir o cargo. Detalhes: " + ex.Message);
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

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                camposFaltantes.Add("Cargo");
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
                oCargo.Cargo = txtCargo.Text;
                oCargo.StatusCargo = cmbStatus.Text[0].ToString();
                if (oCargo.ID == 0)
                {
                    oCargo.DataCriacao = DateTime.Now;
                    var result = aCTLCargo.AdicionarCargo(oCargo);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oCargo.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLCargo.AtualizarCargo(oCargo);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
        
    }
}
