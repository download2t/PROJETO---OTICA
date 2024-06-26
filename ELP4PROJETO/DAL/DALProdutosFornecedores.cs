using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALProdutosFornecedores
    {
        private Banco banco;
        private Operacao operacao;
        private CTLProdutos aCTLProduto;
        private CTLFornecedores aCTLFornecedor;
        public DALProdutosFornecedores()
        {
            banco = new Banco();
            operacao = new Operacao();
            aCTLFornecedor = new CTLFornecedores();
            aCTLProduto = new CTLProdutos();
        }

        public string AdicionarProdutoFornecedor(ProdutosFornecedores produtoFornecedor)
        {
            try
            {
                string sql = "INSERT INTO tb_produtos_fornecedores (id_produto, id_fornecedor, codigo_produto_fornecedor, data_criacao, data_ult_alteracao) " +
                             "VALUES (@IdProduto, @IdFornecedor, @CodigoProdutoFornecedor, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdProduto", produtoFornecedor.Produto.ID),
                    new SqlParameter("@IdFornecedor", produtoFornecedor.Fornecedor.ID),
                    new SqlParameter("@CodigoProdutoFornecedor", produtoFornecedor.CodigoProdutoFornecedor),
                    new SqlParameter("@DataCriacao", produtoFornecedor.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", produtoFornecedor.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarProdutoFornecedor(ProdutosFornecedores produtoFornecedor)
        {
            try
            {
                string sql = "UPDATE tb_produtos_fornecedores SET id_produto = @IdProduto, id_fornecedor = @IdFornecedor, " +
                             "codigo_produto_fornecedor = @CodigoProdutoFornecedor, data_ult_alteracao = @DataUltimaAlteracao " +
                             "WHERE id_produto_fornecedor = @IdProdutoFornecedor";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdProduto", produtoFornecedor.Produto.ID),
                    new SqlParameter("@IdFornecedor", produtoFornecedor.Fornecedor.ID),
                    new SqlParameter("@CodigoProdutoFornecedor", produtoFornecedor.CodigoProdutoFornecedor),
                    new SqlParameter("@DataUltimaAlteracao", produtoFornecedor.DataUltimaAlteracao),
                    new SqlParameter("@IdProdutoFornecedor", produtoFornecedor.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirProdutoFornecedor(int idProdutoFornecedor)
        {
            try
            {
                string sql = "DELETE FROM tb_produtos_fornecedores WHERE id_produto_fornecedor = @IdProdutoFornecedor";
                SqlParameter parametro = new SqlParameter("@IdProdutoFornecedor", idProdutoFornecedor);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir produto fornecedor", ex);
                return false;
            }
        }
        public ProdutosFornecedores BuscarProdutoFornecedorPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_produtos_fornecedores WHERE id_produto_fornecedor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateProdutoFornecedorFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar produto fornecedor por ID", ex);
                return null;
            }
        }
        public ProdutosFornecedores BuscarProdutoFornecedorPorCodigo(string codigo)
        {
            try
            {
                string query = "SELECT * FROM tb_produtos_fornecedores WHERE codigo_produto_fornecedor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", codigo);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateProdutoFornecedorFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar produto fornecedor por Código", ex);
                return null;
            }
        }


        public List<ProdutosFornecedores> ListarProdutosFornecedores(string status)
        {
            try
            {
                string query = "SELECT * FROM tb_produtos_fornecedores";
                if (!string.IsNullOrEmpty(status))
                {
                    query += " WHERE status = @Status";
                }
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { new SqlParameter("@Status", status) });
                return CreateProdutosFornecedoresListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar produtos fornecedores", ex);
                return new List<ProdutosFornecedores>();
            }
        }



        private ProdutosFornecedores CreateProdutoFornecedorFromDataRow(DataRow row)
        {
            Produto produto = aCTLProduto.BuscarProdutoPorId((int)row["id_produto"]);
            Fornecedores fornecedor = aCTLFornecedor.BuscarFornecedorPorId((int)row["id_fornecedor"]);

            return new ProdutosFornecedores
            {
                ID = Convert.ToInt32(row["id_produto_fornecedor"]),
                Produto = produto,
                Fornecedor = fornecedor,
                CodigoProdutoFornecedor = row["codigo_produto_fornecedor"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<ProdutosFornecedores> CreateProdutosFornecedoresListFromDataTable(DataTable dataTable)
        {
            List<ProdutosFornecedores> produtosFornecedores = new List<ProdutosFornecedores>();

            foreach (DataRow row in dataTable.Rows)
            {
                produtosFornecedores.Add(CreateProdutoFornecedorFromDataRow(row));
            }

            return produtosFornecedores;
        }

        public List<ProdutosFornecedores> PesquisarProdutosFornecedoresPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<ProdutosFornecedores> produtosFornecedoresEncontrados = new List<ProdutosFornecedores>();

            try
            {
                string query = string.Empty;
                SqlParameter parametroValorPesquisa = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                SqlParameter parametroStatus = null;

                // Verifica se foi fornecido um status para filtragem
                if (!string.IsNullOrEmpty(status))
                {
                    parametroStatus = new SqlParameter("@Status", status);
                }

                // Constrói a consulta SQL baseada no critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_produtos_fornecedores WHERE id_produto_fornecedor LIKE @ValorPesquisa";
                }
                else if (criterio == "PRODUTOS")
                {
                    query = "SELECT pf.* FROM tb_produtos_fornecedores pf JOIN tb_produtos p ON pf.id_produto = p.id_produto WHERE p.nome LIKE @ValorPesquisa";
                }
                else if (criterio == "FORNECEDORES")
                {
                    query = "SELECT pf.* FROM tb_produtos_fornecedores pf JOIN tb_fornecedores f ON pf.id_fornecedor = f.id_fornecedor WHERE f.nome_fantasia LIKE @ValorPesquisa";
                }

                // Adiciona a condição de status à consulta, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND status = @Status";
                }

                // Executa a consulta SQL e preenche a lista de produtos fornecedores encontrados
                if (!string.IsNullOrEmpty(query))
                {
                    SqlParameter[] parametros = new[] { parametroValorPesquisa, parametroStatus }.Where(p => p != null).ToArray();
                    DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ProdutosFornecedores produtoFornecedor = CreateProdutoFornecedorFromDataRow(row);
                        produtosFornecedoresEncontrados.Add(produtoFornecedor);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar produtos fornecedores", ex);
                return null;
            }

            return produtosFornecedoresEncontrados;
        }


    }
}
