using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace ELP4PROJETO.Classes
{
    public class CTLCategoria
    {
        private DALCategoria CategoriaDAO = new DALCategoria();

        public void AdicionarCategoria(Categoria Categoria)
        {
            CategoriaDAO.AdicionarCategoria(Categoria);
        }

        public void AtualizarCategoria(Categoria Categoria)
        {
            CategoriaDAO.AtualizarCategoria(Categoria);
        }

        public void ExcluirCategoria(int CategoriaId)
        {
            CategoriaDAO.ExcluirCategoria(CategoriaId);
        }

        public Categoria BuscarCategoriaPorId(int id)
        {
            return CategoriaDAO.BuscarCategoriaPorId(id);
        }
        public List<Categoria> ListarCategoria()
        {
            return CategoriaDAO.ListarCategoria();
        }

        public void Incluir()
        {
            FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
            frmCadastroCategoria.Text = "Incluir Categoria";
            frmCadastroCategoria.toolTip1.SetToolTip(frmCadastroCategoria.btnSalvar, "Salvar dados.");
            frmCadastroCategoria.ShowDialog();
        }

        public void Alterar(Categoria Categoria)
        {
            if (Categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
                frmCadastroCategoria.ConhecaObj(Categoria);
                frmCadastroCategoria.Text = "Alterar Categoria";
                frmCadastroCategoria.btnSalvar.Text = "ALTERAR";
                frmCadastroCategoria.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroCategoria.CarregarCampos();
                frmCadastroCategoria.toolTip1.SetToolTip(frmCadastroCategoria.btnSalvar, "Alterar dados.");
                frmCadastroCategoria.ShowDialog();
            }
        }

        public void Excluir(Categoria Categoria)
        {
            if (Categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
                frmCadastroCategoria.ConhecaObj(Categoria);
                frmCadastroCategoria.CarregarCampos();
                frmCadastroCategoria.BloquearCampos();
                frmCadastroCategoria.btnSalvar.Text = "EXCLUIR";
                frmCadastroCategoria.toolTip1.SetToolTip(frmCadastroCategoria.btnSalvar, "Excluir Categoria.");
                frmCadastroCategoria.btnSalvar.ForeColor = Color.White;
                frmCadastroCategoria.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroCategoria.ShowDialog();
            }
        }

        public void Visualizar(Categoria Categoria)
        {
            if (Categoria != null)
            {
                FrmCadastroCategoria frmCadastroCategoria = new FrmCadastroCategoria();
                frmCadastroCategoria.ConhecaObj(Categoria);
                frmCadastroCategoria.CarregarCampos();
                frmCadastroCategoria.BloquearCampos();
                frmCadastroCategoria.btnSalvar.Enabled = false;
                frmCadastroCategoria.Text = "Consultar Categoria";
                frmCadastroCategoria.ShowDialog();
            }
        }
      
        public List<Categoria> PesquisarCategoriaPorCriterio(string criterio, string valorPesquisa)
        {
            List<Categoria> CategoriaEncontrados = new List<Categoria>();

            if (criterio == "ID")
            {
                // Pesquisar por ID
                if (int.TryParse(valorPesquisa, out int id))
                {
                    Categoria Categoria = BuscarCategoriaPorId(id);
                    if (Categoria != null)
                    {
                        CategoriaEncontrados.Add(Categoria);
                    }
                }
            }
            else if (criterio == "Categoria")
            {
                CategoriaEncontrados = CategoriaDAO.BuscarCategoriaPorNome(valorPesquisa);
            }

            return CategoriaEncontrados;
        }
    }
}
