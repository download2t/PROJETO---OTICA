using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DAL;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ELP4PROJETO.Controllers
{
    public class CTLServicos
    {
        private DALServico servicosDAL = new DALServico();

        public string AdicionarServico(Servico servico)
        {
            return servicosDAL.AdicionarServico(servico);
        }

        public string AtualizarServico(Servico servico)
        {
            return servicosDAL.AtualizarServico(servico);
        }

        public bool ExcluirServico(int servicoId)
        {
            return servicosDAL.ExcluirServico(servicoId);
        }

        public Servico BuscarServicoPorId(int id)
        {
            return servicosDAL.BuscarServicoPorId(id);
        }

        public List<Servico> ListarServicos(string status)
        {
            return servicosDAL.ListarServicos(status);
        }

        public List<Servico> PesquisarServicosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Servico> encontrados = servicosDAL.PesquisarServicosPorCriterio(criterio, valorPesquisa, status);
            return encontrados;
        }

        public void Incluir()
        {
            FrmCadastroServico frmCadastroServicos = new FrmCadastroServico();
            frmCadastroServicos.Text = "Incluir Serviço";
            frmCadastroServicos.cmbStatus.Text = "ATIVO";
            frmCadastroServicos.cmbStatus.Enabled = false;
            frmCadastroServicos.toolTip1.SetToolTip(frmCadastroServicos.btnSalvar, "Salvar dados.");
            frmCadastroServicos.ShowDialog();
        }

        public void Alterar(Servico servico)
        {
            if (servico != null)
            {
                FrmCadastroServico frmCadastroServicos = new FrmCadastroServico();
                frmCadastroServicos.ConhecaObj(servico);
                frmCadastroServicos.Text = "Alterar Serviço";
                frmCadastroServicos.btnSalvar.Text = "ALTERAR";
                frmCadastroServicos.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroServicos.CarregarCampos();
                frmCadastroServicos.toolTip1.SetToolTip(frmCadastroServicos.btnSalvar, "Alterar dados.");
                frmCadastroServicos.ShowDialog();
            }
        }

        public void Excluir(Servico servico)
        {
            if (servico != null)
            {
                FrmCadastroServico frmCadastroServicos = new FrmCadastroServico();
                frmCadastroServicos.ConhecaObj(servico);
                frmCadastroServicos.Text = "Excluir Serviço";
                frmCadastroServicos.btnSalvar.Text = "EXCLUIR";
                frmCadastroServicos.toolTip1.SetToolTip(frmCadastroServicos.btnSalvar, "Excluir serviço.");
                frmCadastroServicos.btnSalvar.ForeColor = Color.White;
                frmCadastroServicos.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroServicos.CarregarCampos();
                frmCadastroServicos.BloquearCampos();
                frmCadastroServicos.ShowDialog();
            }
        }

        public void Visualizar(Servico servico)
        {
            if (servico != null)
            {
                FrmCadastroServico frmCadastroServicos = new FrmCadastroServico();
                frmCadastroServicos.ConhecaObj(servico);
                frmCadastroServicos.Text = "Consultar Serviço";
                frmCadastroServicos.CarregarCampos();
                frmCadastroServicos.BloquearCampos();
                frmCadastroServicos.btnSalvar.Enabled = false;
                frmCadastroServicos.ShowDialog();
            }
        }
    }
}
