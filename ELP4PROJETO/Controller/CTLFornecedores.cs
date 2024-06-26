using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLFornecedores
    {
        private DALFornecedores fornecedoresDAL = new DALFornecedores();

        public string AdicionarFornecedor(Fornecedores fornecedor)
        {
            return fornecedoresDAL.AdicionarFornecedor(fornecedor);
        }

        public string AtualizarFornecedor(Fornecedores fornecedor)
        {
            return fornecedoresDAL.AtualizarFornecedor(fornecedor);
        }

        public bool ExcluirFornecedor(int fornecedorId)
        {
            return fornecedoresDAL.ExcluirFornecedor(fornecedorId);
        }
        public string BuscarFornecedorPorDocumento(string nome)
        {
            return fornecedoresDAL.BuscarFornecedorPorCPFouCNPJ(nome);
        }
        public string BuscarFornecedorPorRG(string nome)
        {
            return fornecedoresDAL.BuscarFornecedorPorRG(nome);
        }
        public Fornecedores BuscarFornecedorPorId(int id)
        {
            return fornecedoresDAL.BuscarFornecedorPorId(id);
        }

        public List<Fornecedores> ListarFornecedores(string status)
        {
            return fornecedoresDAL.ListarFornecedores(status);
        }

        public List<Fornecedores> PesquisarFornecedoresPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Fornecedores> encontrados = fornecedoresDAL.PesquisarFornecedoresPorCriterio(criterio, valorPesquisa, status);
            return encontrados;
        }

        public void Incluir()
        {
            FrmCadastroFornecedores frmCadastroFornecedores = new FrmCadastroFornecedores();
            frmCadastroFornecedores.Text = "Incluir Fornecedor";
            frmCadastroFornecedores.cmbStatus.Text = "ATIVO";
            frmCadastroFornecedores.VerCampos(false);
            frmCadastroFornecedores.cmbStatus.Enabled = false;
            frmCadastroFornecedores.toolTip1.SetToolTip(frmCadastroFornecedores.btnSalvar, "Salvar dados.");
            frmCadastroFornecedores.ShowDialog();
        }

        public void Alterar(Fornecedores fornecedor)
        {
            if (fornecedor != null)
            {
                FrmCadastroFornecedores frmCadastroFornecedores = new FrmCadastroFornecedores();
                frmCadastroFornecedores.ConhecaObj(fornecedor);
                frmCadastroFornecedores.Text = "Alterar Fornecedor";
                frmCadastroFornecedores.btnSalvar.Text = "ALTERAR";
                frmCadastroFornecedores.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroFornecedores.cmbTipoCliente.Enabled = false;
                frmCadastroFornecedores.CarregarCampos();
                frmCadastroFornecedores.toolTip1.SetToolTip(frmCadastroFornecedores.btnSalvar, "Alterar dados.");
                frmCadastroFornecedores.ShowDialog();
            }
        }

        public void Excluir(Fornecedores fornecedor)
        {
            if (fornecedor != null)
            {
                FrmCadastroFornecedores frmCadastroFornecedores = new FrmCadastroFornecedores();
                frmCadastroFornecedores.ConhecaObj(fornecedor);
                frmCadastroFornecedores.Text = "Excluir Fornecedor";
                frmCadastroFornecedores.btnSalvar.Text = "EXCLUIR";
                frmCadastroFornecedores.toolTip1.SetToolTip(frmCadastroFornecedores.btnSalvar, "Excluir Fornecedor.");
                frmCadastroFornecedores.btnSalvar.ForeColor = Color.White;
                frmCadastroFornecedores.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroFornecedores.cmbTipoCliente.Enabled = false;
                frmCadastroFornecedores.CarregarCampos();
                frmCadastroFornecedores.BloquearCampos();
                frmCadastroFornecedores.ShowDialog();
            }
        }

        public void Visualizar(Fornecedores fornecedor)
        {
            if (fornecedor != null)
            {
                FrmCadastroFornecedores frmCadastroFornecedores = new FrmCadastroFornecedores();
                frmCadastroFornecedores.ConhecaObj(fornecedor);
                frmCadastroFornecedores.Text = "Consultar Fornecedor";
                frmCadastroFornecedores.CarregarCampos();
                frmCadastroFornecedores.BloquearCampos();
                frmCadastroFornecedores.btnSalvar.Enabled = false;
                frmCadastroFornecedores.cmbTipoCliente.Enabled = false;
                frmCadastroFornecedores.ShowDialog();
            }
        }
    }
}
