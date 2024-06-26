using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALVenda
    {
        private Banco banco = new Banco();

        public bool AdicionarVenda(Venda venda)
        {
            bool status = false;
            using (SqlConnection connection = banco.Abrir())
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Inserir a venda
                        string sql = "INSERT INTO tb_vendas (num_nf, modelo_nf, serie_nf, id_cliente, id_condicao, valor_total, data_venda, data_criacao) " +
                                     "VALUES (@NumNF, @ModeloNfv, @SerieNfv, @IdCliente, @IdCondicao, @ValorTotal, @DataVenda, @DataCriacao)";
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@NumNF", venda.NumNfv),
                            new SqlParameter("@ModeloNfv", venda.ModeloNfv),
                            new SqlParameter("@SerieNfv", venda.SerieNfv),
                            new SqlParameter("@IdCliente", venda.Cliente.ID),
                            new SqlParameter("@IdCondicao", venda.CondicaoPagamento.ID),
                            new SqlParameter("@ValorTotal", venda.ValorTotal),
                            new SqlParameter("@DataVenda", venda.DataSaida),
                            new SqlParameter("@DataCriacao", venda.DataCriacao)
                        };
                        banco.ExecutarComando(sql, parametros);

                        // Inserir os itens da venda e atualizar o estoque
                        foreach (ItemVenda itemVenda in venda.ItensVenda)
                        {
                            if (itemVenda != null)
                            {
                                // Adicionar item de venda
                                CTLItemVenda aCTLItensVenda = new CTLItemVenda();
                                itemVenda.NumNfv = venda.NumNfv;
                                itemVenda.SerieNfv = venda.SerieNfv;
                                itemVenda.ModeloNfv = venda.ModeloNfv;
                                itemVenda.Cliente.ID = venda.Cliente.ID;
                                status = aCTLItensVenda.AdicionarItemVenda(itemVenda);
                                if (!status)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aconteceu um erro ao salvar os itens da venda.");
                                    return false;
                                }

                                // Atualizar estoque do produto
                                CTLProdutos CTLProduto = new CTLProdutos();
                                Produto produto = CTLProduto.BuscarProdutoPorId(itemVenda.IdItem);
                                int estoqueantigo = produto.QtdEstoque;
                                produto.ID = itemVenda.IdItem;
                                produto.PrecoVenda = itemVenda.PrecoUnitario;
                                produto.QtdEstoque = estoqueantigo - itemVenda.QtdItem;
                                status = CTLProduto.AtualizarEstoque(produto);
                                if (!status)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aconteceu um erro ao atualizar o estoque do produto.");
                                    return false;
                                }
                            }
                        }

                        transaction.Commit();
                        status = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    }
                }
            }
            return status;
        }

        public List<Venda> BuscarListaVendasPorChave(int numNF, int ModeloNfv, int SerieNfv, int idCliente)
        {
            try
            {
                string sql = "SELECT * FROM tb_vendas WHERE num_nf = @NumNF AND modelo_nf = @ModeloNfv AND serie_nf = @SerieNfv AND id_cliente = @IdCliente";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNF", numNF),
                    new SqlParameter("@ModeloNfv", ModeloNfv),
                    new SqlParameter("@SerieNfv", SerieNfv),
                    new SqlParameter("@IdCliente", idCliente)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                List<Venda> vendas = new List<Venda>();

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = CreateVendaFromDataRow(row);
                    vendas.Add(venda);
                }

                return vendas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Venda>();
            }
        }

        public Venda BuscarVendaPorChave(int numNF, int ModeloNfv, int SerieNfv, int idCliente)
        {
            try
            {
                string sql = "SELECT * FROM tb_vendas WHERE num_nf = @NumNF AND modelo_nf = @ModeloNfv AND serie_nf = @SerieNfv AND id_cliente = @IdCliente";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNF", numNF),
                    new SqlParameter("@ModeloNfv", ModeloNfv),
                    new SqlParameter("@SerieNfv", SerieNfv),
                    new SqlParameter("@IdCliente", idCliente)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateVendaFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool ExisteVendaPorChave(int numNF, int ModeloNfv, int SerieNfv, int idCliente)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_vendas WHERE num_nf = @NumNF AND modelo_nf = @ModeloNfv AND serie_nf = @SerieNfv AND id_cliente = @IdCliente";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNF", numNF),
                    new SqlParameter("@ModeloNfv", ModeloNfv),
                    new SqlParameter("@SerieNfv", SerieNfv),
                    new SqlParameter("@IdCliente", idCliente)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    int count = Convert.ToInt32(dataTable.Rows[0][0]);
                    return count > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CancelarVenda(Venda venda)
        {
            bool status = false;

            using (SqlConnection connection = banco.Abrir())
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Obter os itens da venda
                        CTLItemVenda aCTLItensVenda = new CTLItemVenda();
                        List<ItemVenda> itensVenda = aCTLItensVenda.BuscarItensVendaPorChave2(venda.NumNfv, venda.ModeloNfv, venda.SerieNfv, venda.Cliente.ID);

                        // Verificar se a venda possui itens
                        if (itensVenda == null || itensVenda.Count == 0)
                        {
                            MessageBox.Show("Nenhum item encontrado para esta venda. Cancelamento abortado.");
                            return false;
                        }

                        // Atualiza a data de cancelamento da venda
                        string sql = "UPDATE tb_vendas SET data_cancelamento = @DataCancelamento WHERE num_nf = @NumNF AND modelo_nf = @ModeloNfv AND serie_nf = @SerieNfv AND id_cliente = @IdCliente";
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@DataCancelamento", DateTime.Today),
                            new SqlParameter("@NumNF", venda.NumNfv),
                            new SqlParameter("@ModeloNfv", venda.ModeloNfv),
                            new SqlParameter("@SerieNfv", venda.SerieNfv),
                            new SqlParameter("@IdCliente", venda.Cliente.ID)
                        };

                        banco.ExecutarComando(sql, parametros);

                        // Iterar sobre os itens da venda para ajustar o estoque
                        foreach (ItemVenda itemVenda in itensVenda)
                        {
                            if (itemVenda != null)
                            {
                                // Atualizar o estoque do produto
                                CTLProdutos CTLProduto = new CTLProdutos();
                                Produto produto = CTLProduto.BuscarProdutoPorId(itemVenda.IdItem);
                                int estoqueAntigo = produto.QtdEstoque;
                                produto.QtdEstoque = estoqueAntigo + itemVenda.QtdItem; // Devolver a quantidade vendida ao estoque
                                status = CTLProduto.AtualizarEstoque(produto);
                                if (!status)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aconteceu um erro ao atualizar o estoque do produto.");
                                    return false;
                                }
                            }
                        }

                        transaction.Commit();
                        status = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    }
                }
            }

            return status;
        }
        public List<Venda> ListarVendas(DateTime? dataInicio, DateTime? dataFim, bool? cancelada, string nomeCliente, string tipoData)
        {
            try
            {
                string sql = "SELECT * FROM tb_vendas WHERE 1 = 1";

                // Adiciona filtros de data, se fornecidos, com base no tipo de data selecionado
                if (!string.IsNullOrEmpty(tipoData))
                {
                    if (tipoData == "VENDA")
                    {
                        if (dataInicio != null && dataFim != null)
                        {
                            sql += " AND data_venda >= @DataInicio AND data_venda <= @DataFim";
                        }
                    }
                    else if (tipoData == "CANCELAMENTO")
                    {
                        if (dataInicio != null && dataFim != null)
                        {
                            sql += " AND data_cancelamento >= @DataInicio AND data_cancelamento <= @DataFim";
                        }
                    }
                }

                // Adiciona filtro de venda cancelada, se fornecido
                if (cancelada != null)
                {
                    if (cancelada == true)
                    {
                        sql += " AND data_cancelamento IS NOT NULL";
                    }
                    else
                    {
                        sql += " AND data_cancelamento IS NULL";
                    }
                }

                // Adiciona filtro de nome do cliente, se fornecido e não vazio
                if (!string.IsNullOrEmpty(nomeCliente))
                {
                    sql += " AND id_cliente IN (SELECT id_cliente FROM tb_clientes WHERE nome_cliente LIKE @NomeCliente)";
                }

                SqlParameter[] parametros =
                {
                    new SqlParameter("@DataInicio", dataInicio),
                    new SqlParameter("@DataFim", dataFim),
                    new SqlParameter("@NomeCliente", "%" + nomeCliente + "%")
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);
                return CreateVendasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Venda>();
            }
        }
        public List<Venda> ListarVendas(bool? statusCancelada)
        {
            try
            {
                string sql = "SELECT * FROM tb_vendas WHERE 1 = 1";

                // Adiciona filtro de status cancelada, se fornecido
                if (statusCancelada != null)
                {
                    if (statusCancelada == true)
                    {
                        sql += " AND data_cancelamento IS NOT NULL";
                    }
                    else
                    {
                        sql += " AND data_cancelamento IS NULL";
                    }
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateVendasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Venda>();
            }
        }

        private Venda CreateVendaFromDataRow(DataRow row)
        {
            CTLClientes aCTLClientes = new CTLClientes();
            Clientes cliente = aCTLClientes.BuscarClientePorId(Convert.ToInt32(row["id_cliente"]));
            CTLCondicaoPagamento aCTLCond = new CTLCondicaoPagamento();
            CondicaoPagamento condicao = aCTLCond.BuscarCondicaoPagamentoPorId((Convert.ToInt32(row["id_condicao"])));

            return new Venda
            {
                NumNfv = Convert.ToInt32(row["num_nf"]),
                ModeloNfv = Convert.ToInt32(row["modelo_nf"]),
                SerieNfv = Convert.ToInt32(row["serie_nf"]),
                Cliente = cliente,
                CondicaoPagamento = condicao,
                ValorTotal = Convert.ToDecimal(row["valor_total"]),
                DataEmissao = Convert.ToDateTime(row["data_venda"]),
                DataCancelamento = row["data_cancelamento"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["data_cancelamento"]),
                DataCriacao = Convert.ToDateTime(row["data_criacao"])
            };
        }

        private List<Venda> CreateVendasListFromDataTable(DataTable dataTable)
        {
            List<Venda> vendas = new List<Venda>();
            foreach (DataRow row in dataTable.Rows)
            {
                vendas.Add(CreateVendaFromDataRow(row));
            }
            return vendas;
        }
    }
}