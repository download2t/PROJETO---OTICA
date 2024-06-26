using ELP4PROJETO.Classes;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ELP4PROJETO.Controllers;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroLaboratorio : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Laboratorio oLaboratorio;
        CTLLaboratorios aCTLLaboratorios;

        public FrmCadastroLaboratorio()
        {
            InitializeComponent();
            aCTLLaboratorios = new CTLLaboratorios();
            oLaboratorio = new Laboratorio();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Laboratorio laboratorio)
            {
                oLaboratorio = laboratorio;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtLaboratorio.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtLaboratorio.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtLaboratorio.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oLaboratorio.ID.ToString();
            txtLaboratorio.Text = oLaboratorio.Nome;
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este laboratório?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirLaboratorio();
                }
            }
        }

        private void ExcluirLaboratorio()
        {
            if (oLaboratorio != null)
            {
                try
                {
                    var result = aCTLLaboratorios.ExcluirLaboratorio(oLaboratorio.ID);
                    if (result)
                        Close();
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o laboratório.");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir o laboratório devido a outros registros estarem vinculados a este laboratório.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o laboratório. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private bool VerificarCamposVazios()
        {
            List<string> camposFaltantes = new List<string>();

            if (string.IsNullOrWhiteSpace(txtLaboratorio.Text))
            {
                camposFaltantes.Add("Laboratório");
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
                oLaboratorio.Nome = txtLaboratorio.Text;
                if (oLaboratorio.ID == 0)
                {
                    oLaboratorio.DataCriacao = DateTime.Now;
                    var result = aCTLLaboratorios.AdicionarLaboratorio(oLaboratorio);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oLaboratorio.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLLaboratorios.AtualizarLaboratorio(oLaboratorio);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }

        private void txtLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
    }
}
