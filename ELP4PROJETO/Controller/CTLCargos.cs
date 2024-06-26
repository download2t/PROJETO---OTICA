using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLCargos
    {
        private DALCargos cargosDAL = new DALCargos();

        public string AdicionarCargo(Cargos cargo)
        {
            return cargosDAL.AdicionarCargo(cargo);
        }

        public string AtualizarCargo(Cargos cargo)
        {
            return cargosDAL.AtualizarCargo(cargo);
        }

        public bool ExcluirCargo(int cargoId)
        {
            return cargosDAL.ExcluirCargo(cargoId);
        }

        public Cargos BuscarCargoPorId(int id)
        {
            return cargosDAL.BuscarCargoPorId(id);
        }

        public List<Cargos> ListarCargos(string status)
        {
            return cargosDAL.ListarCargos(status);
        }

       public List<Cargos> PesquisarCargosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            return cargosDAL.PesquisarCargosPorCriterio(criterio, valorPesquisa, status);
        }

        public void Incluir()
        {
            FrmCadastroCargo frmCadastroCargo = new FrmCadastroCargo();
            frmCadastroCargo.Text = "Incluir Cargo";
            frmCadastroCargo.cmbStatus.Text = "ATIVO";
            frmCadastroCargo.cmbStatus.Enabled = false;
            frmCadastroCargo.toolTip1.SetToolTip(frmCadastroCargo.btnSalvar, "Salvar dados.");
            frmCadastroCargo.ShowDialog();
        }

        public void Alterar(Cargos cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargo frmCadastroCargo = new FrmCadastroCargo();
                frmCadastroCargo.ConhecaObj(cargo);
                frmCadastroCargo.Text = "Alterar Cargo";
                frmCadastroCargo.btnSalvar.Text = "ALTERAR"; 
                frmCadastroCargo.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroCargo.CarregarCampos();
                frmCadastroCargo.toolTip1.SetToolTip(frmCadastroCargo.btnSalvar, "Alterar dados.");
                frmCadastroCargo.ShowDialog();
            }
        }

        public void Excluir(Cargos cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargo frmCadastroCargo = new FrmCadastroCargo();
                frmCadastroCargo.ConhecaObj(cargo);
                frmCadastroCargo.Text = "Excluir Cargo";
                frmCadastroCargo.btnSalvar.Text = "EXCLUIR";
                frmCadastroCargo.toolTip1.SetToolTip(frmCadastroCargo.btnSalvar, "Excluir Cargo.");
                frmCadastroCargo.btnSalvar.ForeColor = Color.White;
                frmCadastroCargo.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroCargo.CarregarCampos();
                frmCadastroCargo.BloquearCampos();
              
                frmCadastroCargo.ShowDialog();
            }
        }

        public void Visualizar(Cargos cargo)
        {
            if (cargo != null)
            {
                FrmCadastroCargo frmCadastroCargo = new FrmCadastroCargo();
                frmCadastroCargo.ConhecaObj(cargo);
                frmCadastroCargo.Text = "Consultar Cargo";
                frmCadastroCargo.CarregarCampos();
                frmCadastroCargo.BloquearCampos();
                frmCadastroCargo.btnSalvar.Enabled = false;
                frmCadastroCargo.ShowDialog();
            }
        }
    }
}
