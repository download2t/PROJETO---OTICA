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
    public partial class FrmCadastroDoutores : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Doutor oDoutor;
        CTLDoutores aCTLDoutores;

        public FrmCadastroDoutores()
        {
            InitializeComponent();
            aCTLDoutores = new CTLDoutores();
            oDoutor = new Doutor();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Doutor doutor)
            {
                oDoutor = doutor;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtDoutor.Clear();
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtDoutor.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtDoutor.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oDoutor.ID.ToString();
            txtDoutor.Text = oDoutor.Nome;
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este doutor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirDoutor();
                }
            }
        }

        private void ExcluirDoutor()
        {
            if (oDoutor != null)
            {
                try
                {
                    var result = aCTLDoutores.ExcluirDoutor(oDoutor.ID);
                    if (result)
                        Close();
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o doutor.");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir o doutor devido a outros registros estarem vinculados a este doutor.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o doutor. Detalhes: " + ex.Message);
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

            if (string.IsNullOrWhiteSpace(txtDoutor.Text))
            {
                camposFaltantes.Add("Doutor");
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
                oDoutor.Nome = txtDoutor.Text;
                if (oDoutor.ID == 0)
                {
                    oDoutor.DataCriacao = DateTime.Now;
                    var result = aCTLDoutores.AdicionarDoutor(oDoutor);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oDoutor.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLDoutores.AtualizarDoutor(oDoutor);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
            }
        }

        private void txtDoutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
    }
}
