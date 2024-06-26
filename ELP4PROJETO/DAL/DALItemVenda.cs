using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALItemVenda
    {
        private Banco banco = new Banco();

        public bool AdicionarItemVenda(ItemVenda itemVenda)
        {
            try
            {
                string sql = "INSERT INTO tb_itens_vendas (num_nfv, modelo_nfv, serie_nfv, id_cliente, id_item, tipo_item, qtd_item, preco_unitario, total_item, desconto, data_criacao) " +
                             "VALUES (@NumNFV, @ModeloNFV, @SerieNFV, @IdCliente, @IdItem, @TipoItem, @QtdItem, @PrecoUnitario, @TotalItem, @Desconto, @DataCriacao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFV", itemVenda.NumNfv),
                    new SqlParameter("@ModeloNFV", itemVenda.ModeloNfv),
                    new SqlParameter("@SerieNFV", itemVenda.SerieNfv),
                    new SqlParameter("@IdCliente", itemVenda.Cliente.ID),
                    new SqlParameter("@IdItem", itemVenda.IdItem),
                    new SqlParameter("@TipoItem", itemVenda.TipoItem), 
                    new SqlParameter("@QtdItem", itemVenda.QtdItem),
                    new SqlParameter("@PrecoUnitario", itemVenda.PrecoUnitario),
                    new SqlParameter("@TotalItem", itemVenda.TotalItem),
                    new SqlParameter("@Desconto", (object)itemVenda.Desconto ?? DBNull.Value), // Tratando valor nulo
                    new SqlParameter("@DataCriacao", itemVenda.DataCriacao)
                };
                banco.ExecutarComando(sql, parametros);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<ItemVenda> BuscarItensVendaPorChave2(int numNFV, int modeloNFV, int serieNFV, int idCliente)
        {
            try
            {
                string sql = "SELECT * FROM tb_itens_vendas WHERE num_nfv = @NumNFV AND modelo_nfv = @ModeloNFV AND serie_nfv = @SerieNFV AND id_cliente = @IdCliente";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFV", numNFV),
                    new SqlParameter("@ModeloNFV", modeloNFV),
                    new SqlParameter("@SerieNFV", serieNFV),
                    new SqlParameter("@IdCliente", idCliente)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                List<ItemVenda> itensVenda = new List<ItemVenda>();
                foreach (DataRow row in dataTable.Rows)
                {
                    itensVenda.Add(CreateItemVendaFromDataRow(row));
                }

                return itensVenda;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ItemVenda>();
            }
        }

        public ItemVenda BuscarItemVendaPorChave(int numNFV, int modeloNFV, int serieNFV, int idCliente, int idItem, string tipoItem)
        {
            try
            {
                string sql = "SELECT * FROM tb_itens_vendas WHERE num_nfv = @NumNFV AND modelo_nfv = @ModeloNFV AND serie_nfv = @SerieNFV AND id_cliente = @IdCliente AND id_item = @IdItem AND tipo_item = @TipoItem";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@NumNFV", numNFV),
                    new SqlParameter("@ModeloNFV", modeloNFV),
                    new SqlParameter("@SerieNFV", serieNFV),
                    new SqlParameter("@IdCliente", idCliente),
                    new SqlParameter("@IdItem", idItem),
                    new SqlParameter("@TipoItem", tipoItem)
                };
                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateItemVendaFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<ItemVenda> ListarItensVenda()
        {
            try
            {
                string sql = "SELECT * FROM tb_itens_vendas";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateItensVendaListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<ItemVenda>();
            }
        }

        private ItemVenda CreateItemVendaFromDataRow(DataRow row)
        {
            // Dependendo do tipo do item ('P' ou 'S'), você pode buscar o produto ou serviço correspondente
            if (row["tipo_item"].ToString().Trim().ToUpper() == "P")
            {
                CTLProdutos aCTLProdutos = new CTLProdutos();
                Produto produto = aCTLProdutos.BuscarProdutoPorId(Convert.ToInt32(row["id_item"]));
                CTLClientes aCTLCliente = new CTLClientes();
                Clientes cliente = aCTLCliente.BuscarClientePorId(Convert.ToInt32(row["id_cliente"]));

                return new ItemVenda
                {
                    NumNfv = Convert.ToInt32(row["num_nfv"]),
                    ModeloNfv = Convert.ToInt32(row["modelo_nfv"]),
                    SerieNfv = Convert.ToInt32(row["serie_nfv"]),
                    Cliente = cliente,
                    IdItem = Convert.ToInt32(row["id_item"]),
                    TipoItem = row["tipo_item"].ToString().Trim(),
                    QtdItem = Convert.ToInt32(row["qtd_item"]),
                    PrecoUnitario = Convert.ToDecimal(row["preco_unitario"]),
                    TotalItem = Convert.ToDecimal(row["total_item"]),
                    Desconto = row["desconto"] != DBNull.Value ? Convert.ToDecimal(row["desconto"]) : (decimal?)null,
                    DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                };
            }
            else if (row["tipo_item"].ToString().Trim().ToUpper() == "S")
            {
                // Aqui você pode implementar a busca e criação para serviços, se necessário
                // Exemplo: CTLServicos aCTLServicos = new CTLServicos();
                // Servico servico = aCTLServicos.BuscarServicoPorId(Convert.ToInt32(row["id_item"]));
                // return new ItemVenda { ... };
                return null; // Implemente conforme necessário
            }
            else
            {
                throw new Exception("Tipo de item inválido.");
            }
        }

        private List<ItemVenda> CreateItensVendaListFromDataTable(DataTable dataTable)
        {
            List<ItemVenda> itensVenda = new List<ItemVenda>();
            foreach (DataRow row in dataTable.Rows)
            {
                itensVenda.Add(CreateItemVendaFromDataRow(row));
            }
            return itensVenda;
        }
    }
}
