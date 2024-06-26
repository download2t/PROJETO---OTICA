using System;
using System.Collections.Generic;
using ELP4PROJETO.Cadastros;
using System.Drawing;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;

namespace test.Controllers
{
    public class CTLProdutosFornecedores
    {
        private DALProdutosFornecedores produtosFornecedoresDAL = new DALProdutosFornecedores();

        public string AdicionarProdutoFornecedor(ProdutosFornecedores produtoFornecedor)
        {
            return produtosFornecedoresDAL.AdicionarProdutoFornecedor(produtoFornecedor);
        }

        public string AtualizarProdutoFornecedor(ProdutosFornecedores produtoFornecedor)
        {
            return produtosFornecedoresDAL.AtualizarProdutoFornecedor(produtoFornecedor);
        }

        public bool ExcluirProdutoFornecedor(int idProdutoFornecedor)
        {
            return produtosFornecedoresDAL.ExcluirProdutoFornecedor(idProdutoFornecedor);
        }

        public List<ProdutosFornecedores> ListarProdutosFornecedores(string status)
        {
            return produtosFornecedoresDAL.ListarProdutosFornecedores(status);
        }

        public ProdutosFornecedores BuscarProdutoFornecedorPorId(int id)
        {
            return produtosFornecedoresDAL.BuscarProdutoFornecedorPorId(id);
        }
        public List<ProdutosFornecedores> PesquisarProdutosFornecedoresPorCriterio(string criterio, string valorPesquisa, string status)
        {
            return produtosFornecedoresDAL.PesquisarProdutosFornecedoresPorCriterio(criterio, valorPesquisa, status);
        }
        public ProdutosFornecedores BuscarProdutoFornecedorPorCodigo(string codigo)
        {
            return produtosFornecedoresDAL.BuscarProdutoFornecedorPorCodigo(codigo);
        }


        // Método para abrir formulário de inclusão de Produto Fornecedor
        public void Incluir()
        {
            // Crie uma instância do formulário para inclusão de Produto Fornecedor
            FrmCadastroProdutosFornecedor FrmCadastroProdutosFornecedor = new FrmCadastroProdutosFornecedor();
            FrmCadastroProdutosFornecedor.Text = "Incluir Produto Fornecedor";
            FrmCadastroProdutosFornecedor.toolTip1.SetToolTip(FrmCadastroProdutosFornecedor.btnSalvar, "Salvar dados.");
            FrmCadastroProdutosFornecedor.ShowDialog();
        }

        // Método para abrir formulário de alteração de Produto Fornecedor
        public void Alterar(ProdutosFornecedores produtoFornecedor)
        {
            if (produtoFornecedor != null)
            {
                FrmCadastroProdutosFornecedor FrmCadastroProdutosFornecedor = new FrmCadastroProdutosFornecedor();
                FrmCadastroProdutosFornecedor.ConhecaObj(produtoFornecedor);
                FrmCadastroProdutosFornecedor.Text = "Alterar Produto Fornecedor";
                FrmCadastroProdutosFornecedor.btnSalvar.Text = "ALTERAR";
                FrmCadastroProdutosFornecedor.btnSalvar.BackColor = Color.BurlyWood;
                FrmCadastroProdutosFornecedor.CarregarCampos();
                FrmCadastroProdutosFornecedor.toolTip1.SetToolTip(FrmCadastroProdutosFornecedor.btnSalvar, "Alterar dados.");
                FrmCadastroProdutosFornecedor.ShowDialog();
            }
        }

        // Método para abrir formulário de exclusão de Produto Fornecedor
        public void Excluir(ProdutosFornecedores produtoFornecedor)
        {
            if (produtoFornecedor != null)
            {
                FrmCadastroProdutosFornecedor FrmCadastroProdutosFornecedor = new FrmCadastroProdutosFornecedor();
                FrmCadastroProdutosFornecedor.ConhecaObj(produtoFornecedor);
                FrmCadastroProdutosFornecedor.Text = "Excluir Produto Fornecedor";
                FrmCadastroProdutosFornecedor.btnSalvar.Text = "EXCLUIR";
                FrmCadastroProdutosFornecedor.toolTip1.SetToolTip(FrmCadastroProdutosFornecedor.btnSalvar, "Excluir vinculo de produto com fornecedor.");
                FrmCadastroProdutosFornecedor.btnSalvar.ForeColor = Color.White;
                FrmCadastroProdutosFornecedor.btnSalvar.BackColor = Color.DarkRed;
                FrmCadastroProdutosFornecedor.CarregarCampos();
                FrmCadastroProdutosFornecedor.BloquearCampos();
                FrmCadastroProdutosFornecedor.ShowDialog();
            }
        }

        // Método para abrir formulário de visualização de Produto Fornecedor
        public void Visualizar(ProdutosFornecedores produtoFornecedor)
        {
            if (produtoFornecedor != null)
            {
                FrmCadastroProdutosFornecedor FrmCadastroProdutosFornecedor = new FrmCadastroProdutosFornecedor();
                FrmCadastroProdutosFornecedor.ConhecaObj(produtoFornecedor);
                FrmCadastroProdutosFornecedor.Text = "Visualizar Produto Fornecedor";
                FrmCadastroProdutosFornecedor.CarregarCampos();
                FrmCadastroProdutosFornecedor.BloquearCampos();
                FrmCadastroProdutosFornecedor.btnSalvar.Enabled = false;
                FrmCadastroProdutosFornecedor.ShowDialog();
            }
        }
    }
}
