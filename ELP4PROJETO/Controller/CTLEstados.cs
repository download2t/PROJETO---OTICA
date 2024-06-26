using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace test.Controllers
{
    public class CTLEstados
    {
        private DALEstados estadosDAL = new DALEstados();

        public string AdicionarEstado(Estados estado)
        {
            return estadosDAL.AdicionarEstado(estado);
        }

        public string  AtualizarEstado(Estados estado)
        {
            return estadosDAL.AtualizarEstado(estado);
        }

        public bool ExcluirEstado(int estadoId)
        {
          return  estadosDAL.ExcluirEstado(estadoId);
        }

        public Estados BuscarEstadoPorId(int id)
        {
            return estadosDAL.BuscarEstadoPorId(id);
        }

        public List<Estados> ListarEstados(string status)
        {
            return estadosDAL.ListarEstados(status);
        }
        public List<Estados> PesquisarEstadosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Estados> Encontrados = estadosDAL.PesquisarEstadosPorCriterio(criterio, valorPesquisa,status);
            return Encontrados;
        }

        public void Incluir()
        {
            FrmCadastroEstado frmCadastroEstados = new FrmCadastroEstado();
            frmCadastroEstados.Text = "Incluir Estado";
            frmCadastroEstados.cmbStatus.Text = "ATIVO";
            frmCadastroEstados.cmbStatus.Enabled = false;
            frmCadastroEstados.toolTip1.SetToolTip(frmCadastroEstados.btnSalvar, "Salvar dados.");
            frmCadastroEstados.ShowDialog();
        }

        public void Alterar(Estados estado)
        {
            if (estado != null)
            {
                FrmCadastroEstado frmCadastroEstados = new FrmCadastroEstado();
                frmCadastroEstados.ConhecaObj(estado);
                frmCadastroEstados.Text = "Alterar Estado";
                frmCadastroEstados.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroEstados.CarregarCampos();
                frmCadastroEstados.toolTip1.SetToolTip(frmCadastroEstados.btnSalvar, "Alterar dados.");
                frmCadastroEstados.ShowDialog();
            }
        }

        public void Excluir(Estados estado)
        {
            if (estado != null)
            {
                FrmCadastroEstado frmCadastroEstados = new FrmCadastroEstado();
                frmCadastroEstados.ConhecaObj(estado);
                frmCadastroEstados.Text = "Excluir Estado";
                frmCadastroEstados.btnSalvar.Text = "EXCLUIR";
                frmCadastroEstados.toolTip1.SetToolTip(frmCadastroEstados.btnSalvar, "Excluir estado.");
                frmCadastroEstados.btnSalvar.ForeColor = Color.White;
                frmCadastroEstados.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroEstados.CarregarCampos();
                frmCadastroEstados.BloquearCampos(); 
                frmCadastroEstados.ShowDialog();
            }
        }

        public void Visualizar(Estados estado)
        {
            if (estado != null)
            {
                FrmCadastroEstado frmCadastroEstados = new FrmCadastroEstado();
                frmCadastroEstados.ConhecaObj(estado);
                frmCadastroEstados.Text = "Consultar Estado";
                frmCadastroEstados.CarregarCampos();
                frmCadastroEstados.BloquearCampos();
                frmCadastroEstados.btnSalvar.Enabled = false;
                frmCadastroEstados.ShowDialog();
            }
        }
    }
}
