using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.DAL
{
    public class DALPaises
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarPais(Paises pais)
        {
            try
            {
                string sql = "INSERT INTO tb_pais (status_pais, nome, sigla, DDI, data_criacao, data_ult_alteracao) " +
                             "VALUES (@StatusPais, @Nome, @Sigla, @DDI, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {   
                    new SqlParameter("@StatusPais", pais.StatusPais),
                    new SqlParameter("@Nome", pais.Pais),
                    new SqlParameter("@Sigla", pais.Sigla),
                    new SqlParameter("@DDI", pais.Ddi),
                    new SqlParameter("@DataCriacao", pais.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", pais.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);

                // Se a execução chegou até aqui, significa que a operação foi bem-sucedida
                return "OK";
            }
            catch (Exception ex)
            {
                // Se ocorreu alguma exceção, retorna a mensagem de erro
                return ex.Message;
            }
        }

        public string AtualizarPais(Paises pais)
        {
            try
            {
                string sql = "UPDATE tb_pais SET status_pais = @StatusPais, nome = @Nome, sigla = @Sigla, DDI = @DDI, " +
                             "data_criacao = @DataCriacao, data_ult_alteracao = @DataUltimaAlteracao WHERE id_pais = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusPais", pais.StatusPais),
                    new SqlParameter("@Nome", pais.Pais),
                    new SqlParameter("@Sigla", pais.Sigla),
                    new SqlParameter("@DDI", pais.Ddi),
                    new SqlParameter("@DataCriacao", pais.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", pais.DataUltimaAlteracao),
                    new SqlParameter("@Id", pais.ID)
                };
                banco.ExecutarComando(sql, parametros);

                // Se a execução chegou até aqui, significa que a operação foi bem-sucedida
                return "OK";
            }
            catch (Exception ex)
            {
                // Se ocorreu alguma exceção, retorna a mensagem de erro
                return ex.Message;
            }
        }


        public bool ExcluirPais(int paisId)
        {
            try
            {
                string sql = "DELETE FROM tb_pais WHERE id_pais = @Id";
                SqlParameter parametro = new SqlParameter("@Id", paisId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                // Trate exceções específicas do SQL Server, se necessário
                operacao.HandleException("Erro ao excluir país", ex);
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                // Trate outras exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir país", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Paises BuscarPaisPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_pais WHERE id_pais = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreatePaisFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar país por ID", ex);
                return null;
            }
        }

        public List<Paises> ListarPaises(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_pais";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_pais = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreatePaisesListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar países", ex);
                return new List<Paises>();
            }
        }



        private Paises CreatePaisFromDataRow(DataRow row)
        {
            return new Paises
            {
                ID = Convert.ToInt32(row["id_pais"]),
                Pais = row["nome"].ToString(),
                Sigla = row["sigla"].ToString(),
                Ddi = row["DDI"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"]),
                StatusPais = row["status_pais"].ToString()
            };
        }

        private List<Paises> CreatePaisesListFromDataTable(DataTable dataTable)
        {
            List<Paises> paises = new List<Paises>();
            foreach (DataRow row in dataTable.Rows)
            {
                paises.Add(CreatePaisFromDataRow(row));
            }
            return paises;
        }

        public List<Paises> PesquisarPaisesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Paises> paisesEncontrados = new List<Paises>();

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

                // Constrói a consulta SQL baseada no critério de pesquisa e no status
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_pais WHERE id_pais LIKE @ValorPesquisa";
                }
                else if (criterio == "SIGLA")
                {
                    query = "SELECT * FROM tb_pais WHERE sigla LIKE @ValorPesquisa";
                }
                else if (criterio == "DDI")
                {
                    query = "SELECT * FROM tb_pais WHERE DDI LIKE @ValorPesquisa";
                }
                else if (criterio == "PAIS")
                {
                    query = "SELECT * FROM tb_pais WHERE nome LIKE @ValorPesquisa";
                }

                // Adiciona a condição de status à consulta, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    if (status == "A")
                    {
                        query += " AND status_pais = 'A'";
                    }
                    else if (status == "I")
                    {
                        query += " AND status_pais = 'I'";
                    }
                    else
                    {
                        // Status inválido
                        throw new ArgumentException("Status inválido. Use apenas 'A' ou 'I'.");
                    }
                }

                // Executa a consulta SQL e preenche a lista de países encontrados
                if (!string.IsNullOrEmpty(query))
                {
                    SqlParameter[] parametros = new[] { parametroValorPesquisa, parametroStatus }.Where(p => p != null).ToArray();
                    DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Paises pais = CreatePaisFromDataRow(row);
                        paisesEncontrados.Add(pais);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar países", ex);
                return null;
            }

            return paisesEncontrados;
        }





    }
}