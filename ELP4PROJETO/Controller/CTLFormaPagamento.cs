using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLFormaPagamento
    {
        private DALFormaPagamento formaPagamentoDAL = new DALFormaPagamento();

        public string AdicionarFormaPagamento(FormaPagamento formaPagamento)
        {
            return formaPagamentoDAL.AdicionarFormaPagamento(formaPagamento);
        }

        public string AtualizarFormaPagamento(FormaPagamento formaPagamento)
        {
            return formaPagamentoDAL.AtualizarFormaPagamento(formaPagamento);
        }

        public bool ExcluirFormaPagamento(int formaPagamentoId)
        {
            return formaPagamentoDAL.ExcluirFormaPagamento(formaPagamentoId);
        }

        public FormaPagamento BuscarFormaPagamentoPorId(int id)
        {
            return formaPagamentoDAL.BuscarFormaPagamentoPorId(id);
        }

        public List<FormaPagamento> ListarFormasPagamento(string status)
        {
            return formaPagamentoDAL.ListarFormasPagamento(status);
        }

        public List<FormaPagamento> PesquisarFormaPorCriterio(string criterio, string valorPesquisa, string status)
        {
            return formaPagamentoDAL.PesquisarFormasPagamentoPorCriterio(criterio, valorPesquisa, status);
        }


        public void Incluir()
        {
            FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
            frmCadastroFormaPagamento.Text = "Incluir Forma de Pagamento";
            frmCadastroFormaPagamento.cmbStatus.Text = "ATIVO";
            frmCadastroFormaPagamento.cmbStatus.Enabled = false;
            frmCadastroFormaPagamento.toolTip1.SetToolTip(frmCadastroFormaPagamento.btnSalvar, "Salvar dados.");
            frmCadastroFormaPagamento.ShowDialog();
        }

        public void Alterar(FormaPagamento formaPagamento)
        {
            if (formaPagamento != null)
            {
                FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
                frmCadastroFormaPagamento.ConhecaObj(formaPagamento);
                frmCadastroFormaPagamento.Text = "Alterar Forma de Pagamento";
                frmCadastroFormaPagamento.btnSalvar.Text = "ALTERAR";
                frmCadastroFormaPagamento.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroFormaPagamento.CarregarCampos();
                frmCadastroFormaPagamento.toolTip1.SetToolTip(frmCadastroFormaPagamento.btnSalvar, "Alterar dados.");
                frmCadastroFormaPagamento.ShowDialog();
            }
        }

        public void Excluir(FormaPagamento formaPagamento)
        {
            if (formaPagamento != null)
            {
                FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
                frmCadastroFormaPagamento.ConhecaObj(formaPagamento);
                frmCadastroFormaPagamento.Text = "Excluir Forma de Pagamento";
                frmCadastroFormaPagamento.btnSalvar.Text = "EXCLUIR";
                frmCadastroFormaPagamento.toolTip1.SetToolTip(frmCadastroFormaPagamento.btnSalvar, "Excluir forma de pagamento.");
                frmCadastroFormaPagamento.btnSalvar.ForeColor = Color.White;
                frmCadastroFormaPagamento.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroFormaPagamento.CarregarCampos();
                frmCadastroFormaPagamento.BloquearCampos();
                frmCadastroFormaPagamento.ShowDialog();
            }
        }

        public void Visualizar(FormaPagamento formaPagamento)
        {
            if (formaPagamento != null)
            {
                FrmCadastroFormaPagamento frmCadastroFormaPagamento = new FrmCadastroFormaPagamento();
                frmCadastroFormaPagamento.ConhecaObj(formaPagamento);
                frmCadastroFormaPagamento.Text = "Consultar Forma de Pagamento";
                frmCadastroFormaPagamento.CarregarCampos();
                frmCadastroFormaPagamento.BloquearCampos();
                frmCadastroFormaPagamento.btnSalvar.Enabled = false;
                frmCadastroFormaPagamento.ShowDialog();
            }
        }
    }
}
