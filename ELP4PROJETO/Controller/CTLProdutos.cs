using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLProdutos
    {
        private DALProdutos produtosDAL = new DALProdutos();


        public bool AdicionarProduto(Produto produto)
        {
            return produtosDAL.AdicionarProduto(produto);
        }
 
        public bool AtualizarEstoque(Produto produto)
        {
           return produtosDAL.AtualizarProdutoEstoque(produto);
        }
        public string AtualizarProduto(Produto produto)
        {
            return produtosDAL.AtualizarProduto(produto);
        }

        public bool ExcluirProduto(int idProduto)
        {
            return produtosDAL.ExcluirProduto(idProduto);
        }

        public List<Produto> ListarProdutos(string status)
        {
            return produtosDAL.ListarProdutos(status);
        }

        public Produto BuscarProdutoPorId(int idProduto)
        {
            return produtosDAL.BuscarProdutoPorId(idProduto);

        }
        public List<Produto> ListarProdutoPorIDProduto(int id)
        {
            return produtosDAL.ListarProdutoPorIDProduto(id);
        }
        public List<Produto> PesquisarProdutosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            if (criterio == "ID" && !int.TryParse(valorPesquisa, out _))
            {
                List<Produto> lista = new List<Produto>();// lista vazia.
                return lista;
            }
            else
            {
                return produtosDAL.PesquisarProdutosPorCriterio(criterio, valorPesquisa, status);
            }
        }
        public bool AtivarOuDesativarProduto(Produto produto)
        {
            return produtosDAL.AtivarOuDesativarProdutos(produto);
        }

        public void Incluir()
        {
            FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.Text = "Incluir Produto";
            frmCadastroProduto.toolTip1.SetToolTip(frmCadastroProduto.btnSalvar, "Salvar dados.");
            frmCadastroProduto.ShowDialog();
        }

        public void Alterar(Produto produto)
        {
            if (produto != null)
            {
                FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
                frmCadastroProduto.ConhecaObj(produto);
                frmCadastroProduto.Text = "Alterar Produto";
                frmCadastroProduto.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroProduto.CarregarCampos();
                frmCadastroProduto.toolTip1.SetToolTip(frmCadastroProduto.btnSalvar, "Alterar dados.");
                frmCadastroProduto.ShowDialog();
            }
        }

        public void Excluir(Produto produto)
        {
            if (produto != null)
            {
                FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
                frmCadastroProduto.ConhecaObj(produto);
                frmCadastroProduto.Text = "Excluir Produto";
                frmCadastroProduto.btnSalvar.Text = "EXCLUIR";
                frmCadastroProduto.toolTip1.SetToolTip(frmCadastroProduto.btnSalvar, "Excluir produto.");
                frmCadastroProduto.btnSalvar.ForeColor = Color.White;
                frmCadastroProduto.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroProduto.CarregarCampos();
                frmCadastroProduto.BloquearCampos();
                frmCadastroProduto.ShowDialog();
            }
        }
        public void Visualizar(Produto produto)
        {
            if (produto != null)
            {
                FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
                frmCadastroProduto.ConhecaObj(produto);
                frmCadastroProduto.Text = "Consultar Produto";
                frmCadastroProduto.CarregarCampos();
                frmCadastroProduto.BloquearCampos();
                frmCadastroProduto.btnSalvar.Enabled = false;
                frmCadastroProduto.ShowDialog();
            }
        }
        public void Desativar(Produto oProduto)
        {
            {
                if (oProduto != null)
                {
                    FrmCadastroProduto frmProdutos = new FrmCadastroProduto();
                    frmProdutos.ConhecaObj(oProduto);
                    frmProdutos.Text = "Desativar Condição de Pagamento";

                    if (oProduto.Status == "A")
                        frmProdutos.btnSalvar.Text = "Desativar";
                    else
                        frmProdutos.btnSalvar.Text = "Ativar";

                    frmProdutos.btnSalvar.BackColor = Color.DarkRed;
                    frmProdutos.btnSalvar.ForeColor = Color.White;
                    frmProdutos.CarregarCampos();
                    frmProdutos.BloquearCampos();
                    frmProdutos.ShowDialog();
                }
            }


        }
    }
}
