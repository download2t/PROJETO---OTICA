using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DAL;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLMarca
    {
        private DALMarcas marcaDAL = new DALMarcas();

        public string AdicionarMarca(Marca marca)
        {
            try
            {
                marca.DataCriacao = DateTime.Now;
                marca.DataUltAlteracao = DateTime.Now;
                marcaDAL.AdicionarMarca(marca);
                return "Marca adicionada com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao adicionar marca: " + ex.Message;
            }
        }

        public string AtualizarMarca(Marca marca)
        {
            try
            {
                marca.DataUltAlteracao = DateTime.Now;
                marcaDAL.AtualizarMarca(marca);
                return "Marca atualizada com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar marca: " + ex.Message;
            }
        }

        public bool ExcluirMarca(int marcaId)
        {
            try
            {
                return marcaDAL.ExcluirMarca(marcaId);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Marca BuscarMarcaPorId(int id)
        {
            try
            {
                return marcaDAL.BuscarMarcaPorId(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Marca> ListarMarcas()
        {
            try
            {
                return marcaDAL.ListarMarcas();
            }
            catch (Exception)
            {
                return new List<Marca>();
            }
        }

        public List<Marca> PesquisarMarcasPorCriterio(string criterio, string valorPesquisa)
        {
            try
            {
                return marcaDAL.PesquisarMarcasPorCriterio(criterio,valorPesquisa);
            }
            catch (Exception)
            {
                return new List<Marca>();
            }
        }

        public void Incluir()
        {
            FrmCadastroMarca frmCadastroMarca = new FrmCadastroMarca();
            frmCadastroMarca.Text = "Incluir Marca";
            frmCadastroMarca.toolTip1.SetToolTip(frmCadastroMarca.btnSalvar, "Salvar dados.");
            frmCadastroMarca.ShowDialog();
        }

        public void Alterar(Marca marca)
        {
            if (marca != null)
            {
                FrmCadastroMarca frmCadastroMarca = new FrmCadastroMarca();
                frmCadastroMarca.ConhecaObj(marca);
                frmCadastroMarca.Text = "Alterar Marca";
                frmCadastroMarca.btnSalvar.Text = "ALTERAR";
                frmCadastroMarca.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroMarca.CarregarCampos();
                frmCadastroMarca.toolTip1.SetToolTip(frmCadastroMarca.btnSalvar, "Alterar dados.");
                frmCadastroMarca.ShowDialog();
            }
        }

        public void Excluir(Marca marca)
        {
            if (marca != null)
            {
                FrmCadastroMarca frmCadastroMarca = new FrmCadastroMarca();
                frmCadastroMarca.ConhecaObj(marca);
                frmCadastroMarca.Text = "Excluir Marca";
                frmCadastroMarca.btnSalvar.Text = "EXCLUIR";
                frmCadastroMarca.toolTip1.SetToolTip(frmCadastroMarca.btnSalvar, "Excluir marca.");
                frmCadastroMarca.btnSalvar.ForeColor = Color.White;
                frmCadastroMarca.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroMarca.CarregarCampos();
                frmCadastroMarca.BloquearCampos();
                frmCadastroMarca.ShowDialog();
            }
        }

        public void Visualizar(Marca marca)
        {
            if (marca != null)
            {
                FrmCadastroMarca frmCadastroMarca = new FrmCadastroMarca();
                frmCadastroMarca.ConhecaObj(marca);
                frmCadastroMarca.Text = "Consultar Marca";
                frmCadastroMarca.CarregarCampos();
                frmCadastroMarca.BloquearCampos();
                frmCadastroMarca.btnSalvar.Enabled = false;
                frmCadastroMarca.ShowDialog();
            }
        }
    }
}
