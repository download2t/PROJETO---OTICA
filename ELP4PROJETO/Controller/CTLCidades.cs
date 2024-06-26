using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace test.Controllers
{
    public class CTLCidades
    {
        private DAOCidades cidadesDAL = new DAOCidades();

        public string AdicionarCidade(Cidades cidade)
        {
           return cidadesDAL.AdicionarCidade(cidade);
        }

        public string AtualizarCidade(Cidades cidade)
        {
            return cidadesDAL.AtualizarCidade(cidade);
        }

        public bool ExcluirCidade(int cidadeId)
        {
            return cidadesDAL.ExcluirCidade(cidadeId);
        }

        public Cidades BuscarCidadePorId(int id)
        {
            return cidadesDAL.BuscarCidadePorId(id);
        }

        public List<Cidades> ListarCidades(string status)
        {
            return cidadesDAL.ListarCidades(status);
        }
        public List<Cidades> PesquisarCidadesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Cidades> Encontrados = cidadesDAL.PesquisarCidadesPorCriterio(criterio, valorPesquisa, status);
            return Encontrados;
        }
        public Cidades Carregar(int Id)
        {
            Cidades Cidade = cidadesDAL.BuscarCidadePorId(Id);
            return Cidade;
        }
        public Cidades BuscarCidadePorNomeEUF(string nomeCidade, string uf)
        {
            return cidadesDAL.BuscarCidadePorNomeEUF(nomeCidade, uf);
        }
        public void Incluir()
        {
            FrmCadastroCidade frmCadastroCidades = new FrmCadastroCidade();
            frmCadastroCidades.Text = "Incluir Cidade";
            frmCadastroCidades.cmbStatus.Text = "ATIVO";
            frmCadastroCidades.cmbStatus.Enabled = false;
            frmCadastroCidades.toolTip1.SetToolTip(frmCadastroCidades.btnSalvar, "Salvar dados.");
            frmCadastroCidades.ShowDialog();
        }

        public void Alterar(Cidades cidade)
        {
            if (cidade != null)
            {
                FrmCadastroCidade frmCadastroCidades = new FrmCadastroCidade();
                frmCadastroCidades.ConhecaObj(cidade);
                frmCadastroCidades.Text = "Alterar Cidade";
                frmCadastroCidades.btnSalvar.Text = "ALTERAR";
                frmCadastroCidades.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroCidades.CarregarCampos();
                frmCadastroCidades.toolTip1.SetToolTip(frmCadastroCidades.btnSalvar, "Alterar dados.");
                frmCadastroCidades.ShowDialog();
            }
        }

        public void Excluir(Cidades cidade)
        {
            if (cidade != null)
            {
                FrmCadastroCidade frmCadastroCidades = new FrmCadastroCidade();
                frmCadastroCidades.ConhecaObj(cidade);
                frmCadastroCidades.Text = "Excluir Cidade";
                frmCadastroCidades.btnSalvar.Text = "EXCLUIR";
                frmCadastroCidades.toolTip1.SetToolTip(frmCadastroCidades.btnSalvar, "Excluir cidade.");
                frmCadastroCidades.btnSalvar.ForeColor = Color.White;
                frmCadastroCidades.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroCidades.CarregarCampos();
                frmCadastroCidades.BloquearCampos();   
                frmCadastroCidades.ShowDialog();
            }
        }

        public void Visualizar(Cidades cidade)
        {
            if (cidade != null)
            {
                FrmCadastroCidade frmCadastroCidades = new FrmCadastroCidade();
                frmCadastroCidades.ConhecaObj(cidade);
                frmCadastroCidades.Text = "Consultar Cidade";
                frmCadastroCidades.CarregarCampos();
                frmCadastroCidades.BloquearCampos();
                frmCadastroCidades.btnSalvar.Enabled = false;
                frmCadastroCidades.ShowDialog();
            }
        }
    }
}
