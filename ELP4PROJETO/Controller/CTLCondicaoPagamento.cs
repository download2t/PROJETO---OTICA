using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLCondicaoPagamento
    {
        private CondicaoPagamento CondicaoPagamento = new CondicaoPagamento();

        private DALCondicaoPagamento condicaoPagamentoDAL = new DALCondicaoPagamento();

        public bool AdicionarCondicaoPagamento(CondicaoPagamento condicao)
        {
            CondicaoPagamento = condicao;
            return condicaoPagamentoDAL.AdicionarCondicaoPagamento(CondicaoPagamento);
        }
        public bool AtualizarCondicaoPagamento(CondicaoPagamento condicao)
        {
            CondicaoPagamento = condicao;
            return condicaoPagamentoDAL.AtualizarCondicaoPagamento(CondicaoPagamento);
        }
        public bool AtivarOuDesativarCondicaoPagamento(CondicaoPagamento condicao)
        {
            return condicaoPagamentoDAL.AtivarOuDesativarCondicaoPagamento(condicao);
        }

        public int ObterProximoIdCondicaoPagamento()
        {
            return condicaoPagamentoDAL.ObterProximoIdCondicaoPagamento();
        }
        public bool ExcluirCondicaoPagamento(int condicaoPagamentoId)
        {
            return condicaoPagamentoDAL.ExcluirCondicaoPagamento(condicaoPagamentoId);
        }
        public CondicaoPagamento BuscarCondicaoPagamentoPorId(int id)
        {
            return condicaoPagamentoDAL.BuscarCondicaoPagamentoPorId(id);
        }
        public List<CondicaoPagamento> ListarCondicoesPagamento(string status)
        {
            return condicaoPagamentoDAL.ListarCondicoesPagamento(status);
        }
        public List<CondicaoPagamento> PesquisarCondicaoPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<CondicaoPagamento> Encontrados = condicaoPagamentoDAL.PesquisarCondicaoPorCriterio(criterio, valorPesquisa, status);
            return Encontrados;
        }

        public void Incluir()
        {
            frm frm = new frm();
            frm.Text = "Incluir Condição de Pagamento";
            frm.btnLimpar.Visible = true;
            frm.btnExcluir.Visible = true;
            frm.DefinirProximoIdCondicaoPagamento();
            frm.toolTip1.SetToolTip(frm.btnSalvar, "Salvar dados.");
            frm.ShowDialog();
        }
        public void Alterar(CondicaoPagamento condicaoPagamento)
        {
            if (condicaoPagamento != null)
            {
                frm frm = new frm();
                frm.ConhecaObj(condicaoPagamento);
                frm.Text = "Alterar Condição de Pagamento";
                frm.btnSalvar.Text = "ALTERAR";
                frm.btnSalvar.BackColor = Color.BurlyWood;
                frm.btnLimpar.Visible = true;
                frm.btnExcluir.Visible = true;
                frm.Popular(condicaoPagamento);
                frm.toolTip1.SetToolTip(frm.btnSalvar, "Alterar dados.");
                frm.ShowDialog();
            }
        }
        public void Excluir(CondicaoPagamento condicaoPagamento)
        {
            if (condicaoPagamento != null)
            {
                frm frm = new frm();
                frm.ConhecaObj(condicaoPagamento);
                frm.Text = "Excluir Condição de Pagamento";
                frm.btnSalvar.ForeColor = Color.White;
                frm.btnSalvar.BackColor = Color.DarkRed;
                frm.btnSalvar.Text = "EXCLUIR";
                frm.Popular(condicaoPagamento);
                frm.BloquearCampos();
                frm.ShowDialog();
            }
        }

        public void Visualizar(CondicaoPagamento condicaoPagamento)
        {
            if (condicaoPagamento != null)
            {
                frm frm = new frm();
                frm.ConhecaObj(condicaoPagamento);
                frm.Text = "Consultar Condição de Pagamento";
                frm.btnSalvar.Enabled = false;
                frm.Popular(condicaoPagamento);
                frm.BloquearCampos();
                frm.ShowDialog();
            }
        }
        public void Desativar(CondicaoPagamento condicaoPagamento)
        {
            if (condicaoPagamento != null)
            {
                frm frm = new frm();
                frm.ConhecaObj(condicaoPagamento);
                frm.Text = "Desativar Condição de Pagamento";

                if (condicaoPagamento.Status == "A")
                    frm.btnSalvar.Text = "DESATIVAR";
                else
                    frm.btnSalvar.Text = "ATIVAR";
              
                frm.btnSalvar.BackColor = Color.DarkRed;
                frm.btnSalvar.ForeColor = Color.White;
                frm.Popular(condicaoPagamento);
                frm.BloquearCampos();
                frm.ShowDialog();
            }
        }

    }
}
