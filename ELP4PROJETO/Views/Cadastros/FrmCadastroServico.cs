using ELP4PROJETO.Controllers;
using ELP4PROJETO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroServico : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Servico oServico = new Servico();
        CTLServicos aCTLServicos;

        public FrmCadastroServico()
        {
            InitializeComponent();
            aCTLServicos = new CTLServicos();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Servico servico)
            {
                oServico = servico;
                CarregarCampos();
            }
        }

        protected override void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            cmbStatus.SelectedIndex = 0;
        }

        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtDescricao.Enabled = false;
            cmbStatus.Enabled = false;
        }

        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtDescricao.Enabled = true;
            cmbStatus.Enabled = true;
        }

        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = oServico.ID.ToString();
            txtDescricao.Text = oServico.Descricao;
            cmbStatus.Text = oServico.Status == "I" ? "Inativo" : oServico.Status == "A" ? "Ativo" : oServico.Status;
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
                Salvar();
            else if (btnSalvar.Text == "EXCLUIR")
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este serviço?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirServico();
                }
            }
        }

        private void ExcluirServico()
        {
            if (oServico != null)
            {
                try
                {
                    var result = aCTLServicos.ExcluirServico(oServico.ID);
                    if (result)
                        Close();
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o serviço. Detalhes: " + result);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir o serviço devido a outros registros estarem vinculados a este serviço.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir o serviço. Detalhes: " + ex.Message);
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

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                camposFaltantes.Add("Descrição");
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
                oServico.Descricao = txtDescricao.Text;
                oServico.Status = cmbStatus.Text[0].ToString();

                if (oServico.ID == 0)
                {
                    oServico.DataCriacao = DateTime.Now;
                    var result = aCTLServicos.AdicionarServico(oServico);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }
                else
                {
                    oServico.DataUltimaAlteracao = DateTime.Now;
                    var result = aCTLServicos.AtualizarServico(oServico);
                    if (result == "OK")
                        Close();
                    else
                        MessageBox.Show("Erro inesperado.");
                }

                return;
            }
        }
    }
}