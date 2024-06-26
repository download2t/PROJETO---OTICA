using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ELP4PROJETO.Controllers
{
    public class CTLLaboratorios
    {
        private DALLaboratorios laboratoriosDAL = new DALLaboratorios();

        public string AdicionarLaboratorio(Laboratorio laboratorio)
        {
            return laboratoriosDAL.AdicionarLaboratorio(laboratorio);
        }

        public string AtualizarLaboratorio(Laboratorio laboratorio)
        {
            return laboratoriosDAL.AtualizarLaboratorio(laboratorio);
        }

        public bool ExcluirLaboratorio(int laboratorioId)
        {
            return laboratoriosDAL.ExcluirLaboratorio(laboratorioId);
        }

        public Laboratorio BuscarLaboratorioPorId(int id)
        {
            return laboratoriosDAL.BuscarLaboratorioPorId(id);
        }

        public List<Laboratorio> ListarLaboratorios()
        {
            return laboratoriosDAL.ListarLaboratorios();
        }

        public List<Laboratorio> PesquisarLaboratoriosPorCriterio(string criterio, string valorPesquisa)
        {
            return laboratoriosDAL.PesquisarLaboratoriosPorCriterio(criterio, valorPesquisa);
        }

        public void Incluir()
        {
            FrmCadastroLaboratorio frmCadastroLaboratorio = new FrmCadastroLaboratorio();
            frmCadastroLaboratorio.Text = "Incluir Laboratório";
            frmCadastroLaboratorio.toolTip1.SetToolTip(frmCadastroLaboratorio.btnSalvar, "Salvar dados.");
            frmCadastroLaboratorio.ShowDialog();
        }

        public void Alterar(Laboratorio laboratorio)
        {
            if (laboratorio != null)
            {
                FrmCadastroLaboratorio frmCadastroLaboratorio = new FrmCadastroLaboratorio();
                frmCadastroLaboratorio.ConhecaObj(laboratorio);
                frmCadastroLaboratorio.Text = "Alterar Laboratório";
                frmCadastroLaboratorio.btnSalvar.Text = "ALTERAR";
                frmCadastroLaboratorio.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroLaboratorio.CarregarCampos();
                frmCadastroLaboratorio.toolTip1.SetToolTip(frmCadastroLaboratorio.btnSalvar, "Alterar dados.");
                frmCadastroLaboratorio.ShowDialog();
            }
        }

        public void Excluir(Laboratorio laboratorio)
        {
            if (laboratorio != null)
            {
                FrmCadastroLaboratorio frmCadastroLaboratorio = new FrmCadastroLaboratorio();
                frmCadastroLaboratorio.ConhecaObj(laboratorio);
                frmCadastroLaboratorio.Text = "Excluir Laboratório";
                frmCadastroLaboratorio.btnSalvar.Text = "EXCLUIR";
                frmCadastroLaboratorio.toolTip1.SetToolTip(frmCadastroLaboratorio.btnSalvar, "Excluir laboratório.");
                frmCadastroLaboratorio.btnSalvar.ForeColor = Color.White;
                frmCadastroLaboratorio.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroLaboratorio.CarregarCampos();
                frmCadastroLaboratorio.BloquearCampos();
                frmCadastroLaboratorio.ShowDialog();
            }
        }

        public void Visualizar(Laboratorio laboratorio)
        {
            if (laboratorio != null)
            {
                FrmCadastroLaboratorio frmCadastroLaboratorio = new FrmCadastroLaboratorio();
                frmCadastroLaboratorio.ConhecaObj(laboratorio);
                frmCadastroLaboratorio.Text = "Consultar Laboratório";
                frmCadastroLaboratorio.CarregarCampos();
                frmCadastroLaboratorio.BloquearCampos();
                frmCadastroLaboratorio.btnSalvar.Enabled = false;
                frmCadastroLaboratorio.ShowDialog();
            }
        }
    }
}
