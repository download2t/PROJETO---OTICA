using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.Data
{
    public class DALReceitaClientes
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();


        public string AdicionarReceitaCliente(ReceitaClientes receitaCliente)
        {
            try
            {
                string sql = "INSERT INTO tb_clientes_receitas (id_receita, id_cliente, data_criacao, data_ult_alteracao) " +
                             "VALUES (@IdReceita, @IdCliente, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdReceita", receitaCliente.Receita.ID),
                    new SqlParameter("@IdCliente", receitaCliente.Cliente.ID),
                    new SqlParameter("@DataCriacao", receitaCliente.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", receitaCliente.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarReceitaCliente(ReceitaClientes receitaCliente)
        {
            try
            {
                string sql = "UPDATE tb_clientes_receitas SET id_receita = @IdReceita, id_cliente = @IdCliente, data_ult_alteracao = @DataUltimaAlteracao " +
                             "WHERE id_clientes_receitas = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@IdReceita", receitaCliente.Receita.ID),
                    new SqlParameter("@IdCliente", receitaCliente.Cliente.ID),
                    new SqlParameter("@DataUltimaAlteracao", receitaCliente.DataUltimaAlteracao),
                    new SqlParameter("@Id", receitaCliente.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirReceitaCliente(int receitaClienteId)
        {
            try
            {
                string sql = "DELETE FROM tb_clientes_receitas WHERE id_clientes_receitas = @Id";
                SqlParameter parametro = new SqlParameter("@Id", receitaClienteId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir receita do cliente", ex);
                return false;
            }
        }

        public ReceitaClientes BuscarReceitaClientePorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_clientes_receitas WHERE id_clientes_receitas = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateReceitaClienteFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar receita do cliente por ID", ex);
                return null;
            }
        }

        public List<ReceitaClientes> ListarReceitasClientes()
        {
            try
            {
                string sql = "SELECT * FROM tb_clientes_receitas";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateReceitaClientesListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar receitas dos clientes", ex);
                return new List<ReceitaClientes>();
            }
        }

        public List<ReceitaClientes> PesquisarReceitasClientesPorCriterio(string criterio, string valorPesquisa)
        {
            List<ReceitaClientes> receitasClientesEncontradas = new List<ReceitaClientes>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                if (criterio == "ID_RECEITA")
                {
                    query = "SELECT * FROM tb_clientes_receitas WHERE id_receita LIKE @ValorPesquisa";
                }
                else if (criterio == "ID_CLIENTE")
                {
                    query = "SELECT * FROM tb_clientes_receitas WHERE id_cliente LIKE @ValorPesquisa";
                }

                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                foreach (DataRow row in dataTable.Rows)
                {
                    ReceitaClientes receitaCliente = CreateReceitaClienteFromDataRow(row);
                    receitasClientesEncontradas.Add(receitaCliente);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar receitas dos clientes", ex);
                return null;
            }

            return receitasClientesEncontradas;
        }

        private ReceitaClientes CreateReceitaClienteFromDataRow(DataRow row)
        {
            DALReceita dalReceitas = new DALReceita();
            DALClientes dalClientes = new DALClientes();
            Receita receita = dalReceitas.BuscarReceitaPorId(Convert.ToInt32(row["id_receita"]));
            Clientes cliente = dalClientes.BuscarClientePorId(Convert.ToInt32(row["id_cliente"]));

            return new ReceitaClientes
            {
                ID = Convert.ToInt32(row["id_clientes_receitas"]),
                Receita = receita,
                Cliente = cliente,
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<ReceitaClientes> CreateReceitaClientesListFromDataTable(DataTable dataTable)
        {
            List<ReceitaClientes> receitasClientes = new List<ReceitaClientes>();
            foreach (DataRow row in dataTable.Rows)
            {
                receitasClientes.Add(CreateReceitaClienteFromDataRow(row));
            }
            return receitasClientes;
        }
    }
}
