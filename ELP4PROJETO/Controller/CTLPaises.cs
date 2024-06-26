using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DAL;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace test.Controllers
{
    public class CTLPaises
    {
        private DALPaises paisesDAL = new DALPaises();

        public string AdicionarPais(Paises pais)
        {
            return paisesDAL.AdicionarPais(pais);
        }

        public string AtualizarPais(Paises pais)
        {
            if(pais.ID == 1)
            {
                var msg = "NOT";
                return msg;
            }
            return paisesDAL.AtualizarPais(pais);
        }

        public bool ExcluirPais(int paisId)
        {
            if (paisId == 1)
            {
                MessageBox.Show("Brasil não pode ser excluido!!");
                return false;
            }
            else
            {
                return paisesDAL.ExcluirPais(paisId);
            }
        }

        public Paises BuscarPaisPorId(int id)
        {
            return paisesDAL.BuscarPaisPorId(id);
        }

        public List<Paises> ListarPaises(string status)
        {
            return paisesDAL.ListarPaises(status);
        }
        public List<Paises> PesquisarPaisesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Paises> Encontrados = paisesDAL.PesquisarPaisesPorCriterio(criterio, valorPesquisa, status);
            return Encontrados;
        }

        public void Incluir()
        {
            FrmCadastroPais frmCadastroPaises = new FrmCadastroPais();
            frmCadastroPaises.Text = "Incluir País";
            frmCadastroPaises.cmbStatus.Text = "ATIVO";
            frmCadastroPaises.cmbStatus.Enabled = false;
            frmCadastroPaises.toolTip1.SetToolTip(frmCadastroPaises.btnSalvar, "Salvar dados.");
            frmCadastroPaises.ShowDialog();
        }

        public void Alterar(Paises pais)
        {
            if (pais != null)
            {
                FrmCadastroPais frmCadastroPaises = new FrmCadastroPais();
                frmCadastroPaises.ConhecaObj(pais);
                frmCadastroPaises.Text = "Alterar País";
                frmCadastroPaises.btnSalvar.Text = "ALTERAR";
                frmCadastroPaises.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroPaises.CarregarCampos();
                frmCadastroPaises.toolTip1.SetToolTip(frmCadastroPaises.btnSalvar, "Alterar dados.");
                frmCadastroPaises.ShowDialog();
            }
        }

        public void Excluir(Paises pais)
        {
            if (pais != null)
            {
                FrmCadastroPais frmCadastroPaises = new FrmCadastroPais();
                frmCadastroPaises.ConhecaObj(pais);
                frmCadastroPaises.Text = "Excluir País";
                frmCadastroPaises.btnSalvar.Text = "EXCLUIR";
                frmCadastroPaises.toolTip1.SetToolTip(frmCadastroPaises.btnSalvar, "Excluir país.");
                frmCadastroPaises.btnSalvar.ForeColor = Color.White;
                frmCadastroPaises.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroPaises.CarregarCampos();
                frmCadastroPaises.BloquearCampos();
                frmCadastroPaises.ShowDialog();
            }
        }

        public void Visualizar(Paises pais)
        {
            if (pais != null)
            {
                FrmCadastroPais frmCadastroPaises = new FrmCadastroPais();
                frmCadastroPaises.ConhecaObj(pais);
                frmCadastroPaises.Text = "Consultar País";
                frmCadastroPaises.CarregarCampos();
                frmCadastroPaises.BloquearCampos();
                frmCadastroPaises.btnSalvar.Enabled = false;
                frmCadastroPaises.ShowDialog();
            }
        }

    }
}
