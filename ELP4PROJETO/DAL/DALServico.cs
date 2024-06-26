using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ELP4PROJETO.DAL
{
    public class DALServico
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarServico(Servico servico)
        {
            try
            {
                string sql = "INSERT INTO tb_servicos (descricao, status_servico, data_criacao, data_ult_alteracao) " +
                             "VALUES (@Descricao, @StatusServico, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Descricao", servico.Descricao),
                    new SqlParameter("@StatusServico", servico.Status),
                    new SqlParameter("@DataCriacao", servico.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", servico.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarServico(Servico servico)
        {
            try
            {
                string sql = "UPDATE tb_servicos SET descricao = @Descricao, status_servico = @StatusServico, " +
                             "data_ult_alteracao = @DataUltimaAlteracao WHERE id_servico = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Descricao", servico.Descricao),
                    new SqlParameter("@StatusServico", servico.Status),
                    new SqlParameter("@DataUltimaAlteracao", servico.DataUltimaAlteracao),
                    new SqlParameter("@Id", servico.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirServico(int servicoId)
        {
            try
            {
                string sql = "DELETE FROM tb_servicos WHERE id_servico = @Id";
                SqlParameter parametro = new SqlParameter("@Id", servicoId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao excluir serviço", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir serviço", ex);
                return false;
            }
        }

        public Servico BuscarServicoPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_servicos WHERE id_servico = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateServicoFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar serviço por ID", ex);
                return null;
            }
        }

        public List<Servico> ListarServicos(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_servicos";
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_servico = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateServicosListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar serviços", ex);
                return new List<Servico>();
            }
        }

        private Servico CreateServicoFromDataRow(DataRow row)
        {
            return new Servico
            {
                ID = Convert.ToInt32(row["id_servico"]),
                Descricao = row["descricao"].ToString(),
                Status = row["status_servico"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Servico> CreateServicosListFromDataTable(DataTable dataTable)
        {
            List<Servico> servicos = new List<Servico>();
            foreach (DataRow row in dataTable.Rows)
            {
                servicos.Add(CreateServicoFromDataRow(row));
            }
            return servicos;
        }

        public List<Servico> PesquisarServicosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Servico> servicosEncontrados = new List<Servico>();

            try
            {
                string query = string.Empty;
                SqlParameter parametroValorPesquisa = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                SqlParameter parametroStatus = null;

                if (!string.IsNullOrEmpty(status))
                {
                    parametroStatus = new SqlParameter("@Status", status);
                }

                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_servicos WHERE id_servico LIKE @ValorPesquisa";
                }
                else if (criterio == "DESCRICAO")
                {
                    query = "SELECT * FROM tb_servicos WHERE descricao LIKE @ValorPesquisa";
                }

                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "A")
                    {
                        query += " AND status_servico = 'A'";
                    }
                    else if (status == "I")
                    {
                        query += " AND status_servico = 'I'";
                    }
                    else
                    {
                        throw new ArgumentException("Status inválido. Use apenas 'A' ou 'I'.");
                    }
                }

                if (!string.IsNullOrEmpty(query))
                {
                    SqlParameter[] parametros = new[] { parametroValorPesquisa, parametroStatus }.Where(p => p != null).ToArray();
                    DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Servico servico = CreateServicoFromDataRow(row);
                        servicosEncontrados.Add(servico);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar serviços", ex);
                return null;
            }

            return servicosEncontrados;
        }
    }
}
