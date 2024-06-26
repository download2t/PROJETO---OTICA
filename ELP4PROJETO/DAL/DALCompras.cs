using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;
using test.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELP4PROJETO.Data
{
    public class DALCompras
    {
        private Banco banco = new Banco();

 
        public bool AdicionarCompra(Compra compra)
        {
            bool status = false;
            using (SqlConnection connection = banco.Abrir())
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Inserir a compra
                        string sql = "INSERT INTO tb_compras (num_nfc, modelo_nfc, serie_nfc, id_fornecedor, id_condicao, valor_total, valor_frete, valor_seguro, valor_outras_despesas, data_chegada, data_emissao, data_criacao) " +
                                     "VALUES (@NumNFC, @ModeloNFC, @SerieNFC, @IdFornecedor, @IdCondicao, @ValorTotal, @ValorFrete, @ValorSeguro, @ValorOutrasDespesas, @DataChegada, @DataEmissao, @DataCriacao)";
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@NumNFC", compra.NumNFC),
                            new SqlParameter("@ModeloNFC", compra.ModeloNFC),
                            new SqlParameter("@SerieNFC", compra.SerieNFC),
                            new SqlParameter("@IdFornecedor", compra.Fornecedor.ID),
                            new SqlParameter("@IdCondicao", compra.Condicao.ID),
                            new SqlParameter("@ValorTotal", compra.ValorTotal),
                            new SqlParameter("@ValorFrete", compra.ValorFrete),
                            new SqlParameter("@ValorSeguro", compra.ValorSeguro),
                            new SqlParameter("@ValorOutrasDespesas", compra.ValorOutrasDespesas),
                            new SqlParameter("@DataChegada", compra.DataChegada),
                            new SqlParameter("@DataEmissao", compra.DataEmissao), 
                            new SqlParameter("@DataCriacao", compra.DataCriacao)
                        };
                        banco.ExecutarComando(sql, parametros);

                        // Inserir os itens da compra e atualizar o estoque
                        foreach (ItemCompra itemCompra in compra.ItensCompra)
                        {
                            if (itemCompra != null)
                            {
                                // Adicionar item de compra
                                CTLItensCompra aCTLItensCompra = new CTLItensCompra();
                                itemCompra.NumNFC = compra.NumNFC;
                                itemCompra.SerieNFC = compra.SerieNFC;
                                itemCompra.ModeloNFC = compra.ModeloNFC;
                                itemCompra.Fornecedor.ID = compra.Fornecedor.ID;
                                status = aCTLItensCompra.AdicionarItemCompra(itemCompra);
                                if (!status)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Aconteceu um erro ao salvar os itens da compra.");
                                    return false;
                                }

                                // Atualizar estoque do produto
                                CTLProdutos CTLProduto = new CTLProdutos();
                                Produto produto = CTLProduto.BuscarProdutoPorId(itemCompra.Produto.ID);
                                int estoqueantigo = produto.QtdEstoque;
                                produto.ID = itemCompra.Produto.ID;
                                produto.PrecoCusto = itemCompra.MediaPonderada;
                                produto.QtdEstoque = estoqueantigo + itemCompra.QtdProduto;
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
        public List<Compra> BuscarListaComprasPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            try
            {
                string sql = "SELECT * FROM tb_compras WHERE num_nfc = @NumNFC AND modelo_nfc = @ModeloNFC AND serie_nfc = @SerieNFC AND id_fornecedor = @IdFornecedor";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFC", numNFC),
                    new SqlParameter("@ModeloNFC", modeloNFC),
                    new SqlParameter("@SerieNFC", serieNFC),
                    new SqlParameter("@IdFornecedor", idFornecedor)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                List<Compra> compras = new List<Compra>();

                foreach (DataRow row in dataTable.Rows)
                {
                    Compra compra = CreateCompraFromDataRow(row);
                    compras.Add(compra);
                }

                return compras;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Compra>();
            }
        }
        public Compra BuscarCompraPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            try
            {
                string sql = "SELECT * FROM tb_compras WHERE num_nfc = @NumNFC AND modelo_nfc = @ModeloNFC AND serie_nfc = @SerieNFC AND id_fornecedor = @IdFornecedor";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFC", numNFC),
                    new SqlParameter("@ModeloNFC", modeloNFC),
                    new SqlParameter("@SerieNFC", serieNFC),
                    new SqlParameter("@IdFornecedor", idFornecedor)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateCompraFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool ExisteCompraPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM tb_compras WHERE num_nfc = @NumNFC AND modelo_nfc = @ModeloNFC AND serie_nfc = @SerieNFC AND id_fornecedor = @IdFornecedor";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFC", numNFC),
                    new SqlParameter("@ModeloNFC", modeloNFC),
                    new SqlParameter("@SerieNFC", serieNFC),
                    new SqlParameter("@IdFornecedor", idFornecedor)
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
        public bool CancelarCompra(Compra compra)
        {
            bool status = false;

            using (SqlConnection connection = banco.Abrir())
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Obter os itens da compra
                        CTLItensCompra aCTLItensCompra = new CTLItensCompra();
                        List<ItemCompra> itensCompra = aCTLItensCompra.BuscarItemCompraPorChave2(compra.NumNFC, compra.ModeloNFC, compra.SerieNFC, compra.Fornecedor.ID);

                        // Verificar se a compra possui itens
                        if (itensCompra == null || itensCompra.Count == 0)
                        {
                            MessageBox.Show("Nenhum item encontrado para esta compra. Cancelamento abortado.");
                            return false;
                        }

                        // Atualiza a data de cancelamento da compra
                        string sql = "UPDATE tb_compras SET data_cancelamento = @DataCancelamento WHERE num_nfc = @NumNFC AND modelo_nfc = @ModeloNFC AND serie_nfc = @SerieNFC AND id_fornecedor = @IdFornecedor";
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@DataCancelamento", DateTime.Today),
                            new SqlParameter("@NumNFC", compra.NumNFC),
                            new SqlParameter("@ModeloNFC", compra.ModeloNFC),
                            new SqlParameter("@SerieNFC", compra.SerieNFC),
                            new SqlParameter("@IdFornecedor", compra.Fornecedor.ID)
                        };

                        banco.ExecutarComando(sql, parametros);

                        // Iterar sobre os itens da compra para ajustar o estoque
                        foreach (ItemCompra itemCompra in itensCompra)
                        {
                            if (itemCompra != null)
                            {
                                // Atualizar o estoque do produto
                                CTLProdutos CTLProduto = new CTLProdutos();
                                Produto produto = CTLProduto.BuscarProdutoPorId(itemCompra.Produto.ID);
                                int estoqueAntigo = produto.QtdEstoque;
                                produto.QtdEstoque = estoqueAntigo - itemCompra.QtdProduto; // Remover a quantidade adicionada
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


        public bool CancelarCompra2(Compra compra)
        {
            bool status = false;

            using (SqlConnection connection = banco.Abrir())
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Atualiza a data de cancelamento da compra
                        string sql = "UPDATE tb_compras SET data_cancelamento = @DataCancelamento WHERE num_nfc = @NumNFC AND modelo_nfc = @ModeloNFC AND serie_nfc = @SerieNFC AND id_fornecedor = @IdFornecedor";
                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@DataCancelamento", DateTime.Today),
                            new SqlParameter("@NumNFC", compra.NumNFC),
                            new SqlParameter("@ModeloNFC", compra.ModeloNFC),
                            new SqlParameter("@SerieNFC", compra.SerieNFC),
                            new SqlParameter("@IdFornecedor", compra.Fornecedor.ID)
                        };

                        banco.ExecutarComando(sql, parametros);
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
        public List<Compra> ListarCompras(DateTime? dataInicio, DateTime? dataFim, bool? cancelada, string nomeFornecedor, string tipoData)
        {
            try
            {
                string sql = "SELECT * FROM tb_compras WHERE 1 = 1";

                // Adiciona filtros de data, se fornecidos, com base no tipo de data selecionado
                if (!string.IsNullOrEmpty(tipoData))
                {
                    if (tipoData == "CHEGADA")
                    {
                        if (dataInicio != null && dataFim != null)
                        {
                            sql += " AND data_chegada >= @DataInicio AND data_chegada <= @DataFim";
                        }
                    }
                    else if (tipoData == "EMISSAO")
                    {
                        if (dataInicio != null && dataFim != null)
                        {
                            sql += " AND data_emissao >= @DataInicio AND data_emissao <= @DataFim";
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

                // Adiciona filtro de compra cancelada, se fornecido
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

                // Adiciona filtro de nome do fornecedor, se fornecido e não vazio
                if (!string.IsNullOrEmpty(nomeFornecedor))
                {
                    sql += " AND id_fornecedor IN (SELECT id_fornecedor FROM tb_fornecedores WHERE nome_fantasia LIKE @NomeFornecedor)";
                }

                SqlParameter[] parametros =
                {
                    new SqlParameter("@DataInicio", dataInicio),
                    new SqlParameter("@DataFim", dataFim),
                    new SqlParameter("@NomeFornecedor", "%" + nomeFornecedor + "%")
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);
                return CreateComprasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Compra>();
            }
        }



      public List<Compra> ListarCompras(bool? statusCancelada)
{
    try
    {
        string sql = "SELECT * FROM tb_compras WHERE 1 = 1";

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
        return CreateComprasListFromDataTable(dataTable);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return new List<Compra>();
    }
}


        private Compra CreateCompraFromDataRow(DataRow row)
        {
            CTLFornecedores aCTLForn = new CTLFornecedores();
            Fornecedores fornecedor = aCTLForn.BuscarFornecedorPorId(Convert.ToInt32(row["id_fornecedor"]));
            CTLCondicaoPagamento aCTLCond = new CTLCondicaoPagamento();
            CondicaoPagamento condicao = aCTLCond.BuscarCondicaoPagamentoPorId((Convert.ToInt32(row["id_condicao"])));


            return new Compra
            {
                NumNFC = Convert.ToInt32(row["num_nfc"]),
                ModeloNFC = Convert.ToInt32(row["modelo_nfc"]),
                SerieNFC = Convert.ToInt32(row["serie_nfc"]),
                Fornecedor = fornecedor,
                Condicao = condicao,
                ValorTotal = Convert.ToDecimal(row["valor_total"]),
                ValorFrete = Convert.ToDecimal(row["valor_frete"]),
                ValorSeguro = Convert.ToDecimal(row["valor_seguro"]),
                ValorOutrasDespesas = Convert.ToDecimal(row["valor_outras_despesas"]),
                DataChegada = Convert.ToDateTime(row["data_chegada"]),
                DataEmissao = Convert.ToDateTime(row["data_emissao"]),
                DataCancelamento = row["data_cancelamento"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["data_cancelamento"]),
                DataCriacao = Convert.ToDateTime(row["data_criacao"])
            };
        }

        private List<Compra> CreateComprasListFromDataTable(DataTable dataTable)
        {
            List<Compra> compras = new List<Compra>();
            foreach (DataRow row in dataTable.Rows)
            {
                compras.Add(CreateCompraFromDataRow(row));
            }
            return compras;
        }
    }
}
