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
    public class CTLDoutores
    {
        private DALDoutores doutoresDAL = new DALDoutores();

        public string AdicionarDoutor(Doutor doutor)
        {
            return doutoresDAL.AdicionarDoutor(doutor);
        }

        public string AtualizarDoutor(Doutor doutor)
        {
            return doutoresDAL.AtualizarDoutor(doutor);
        }

        public bool ExcluirDoutor(int doutorId)
        {
            return doutoresDAL.ExcluirDoutor(doutorId);
        }

        public Doutor BuscarDoutorPorId(int id)
        {
            return doutoresDAL.BuscarDoutorPorId(id);
        }

        public List<Doutor> ListarDoutores()
        {
            return doutoresDAL.ListarDoutores();
        }

        public List<Doutor> PesquisarDoutoresPorCriterio(string criterio, string valorPesquisa)
        {
            return doutoresDAL.PesquisarDoutoresPorCriterio(criterio, valorPesquisa);
        }

        public void Incluir()
        {
            FrmCadastroDoutores FrmCadastroDoutores = new FrmCadastroDoutores();
            FrmCadastroDoutores.Text = "Incluir Doutor";
            FrmCadastroDoutores.toolTip1.SetToolTip(FrmCadastroDoutores.btnSalvar, "Salvar dados.");
            FrmCadastroDoutores.ShowDialog();
        }

        public void Alterar(Doutor doutor)
        {
            if (doutor != null)
            {
                FrmCadastroDoutores FrmCadastroDoutores = new FrmCadastroDoutores();
                FrmCadastroDoutores.ConhecaObj(doutor);
                FrmCadastroDoutores.Text = "Alterar Doutor";
                FrmCadastroDoutores.btnSalvar.Text = "ALTERAR";
                FrmCadastroDoutores.btnSalvar.BackColor = Color.BurlyWood;
                FrmCadastroDoutores.CarregarCampos();
                FrmCadastroDoutores.toolTip1.SetToolTip(FrmCadastroDoutores.btnSalvar, "Alterar dados.");
                FrmCadastroDoutores.ShowDialog();
            }
        }

        public void Excluir(Doutor doutor)
        {
            if (doutor != null)
            {
                FrmCadastroDoutores FrmCadastroDoutores = new FrmCadastroDoutores();
                FrmCadastroDoutores.ConhecaObj(doutor);
                FrmCadastroDoutores.Text = "Excluir Doutor";
                FrmCadastroDoutores.btnSalvar.Text = "EXCLUIR";
                FrmCadastroDoutores.toolTip1.SetToolTip(FrmCadastroDoutores.btnSalvar, "Excluir Doutor.");
                FrmCadastroDoutores.btnSalvar.ForeColor = Color.White;
                FrmCadastroDoutores.btnSalvar.BackColor = Color.DarkRed;
                FrmCadastroDoutores.CarregarCampos();
                FrmCadastroDoutores.BloquearCampos();
                FrmCadastroDoutores.ShowDialog();
            }
        }

        public void Visualizar(Doutor doutor)
        {
            if (doutor != null)
            {
                FrmCadastroDoutores FrmCadastroDoutores = new FrmCadastroDoutores();
                FrmCadastroDoutores.ConhecaObj(doutor);
                FrmCadastroDoutores.Text = "Consultar Doutor";
                FrmCadastroDoutores.CarregarCampos();
                FrmCadastroDoutores.BloquearCampos();
                FrmCadastroDoutores.btnSalvar.Enabled = false;
                FrmCadastroDoutores.ShowDialog();
            }
        }
    }
}
