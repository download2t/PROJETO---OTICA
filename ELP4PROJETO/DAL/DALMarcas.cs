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
    public class DALMarcas
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarMarca(Marca marca)
        {
            try
            {
                string sql = "INSERT INTO tb_marcas (marca, descricao, data_criacao, data_ult_alteracao) " +
                             "VALUES (@Marca, @Descricao, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Marca", marca.Nome),
                    new SqlParameter("@Descricao", marca.Descricao),
                    new SqlParameter("@DataCriacao", marca.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", marca.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarMarca(Marca marca)
        {
            try
            {
                string sql = "UPDATE tb_marcas SET marca = @Marca, descricao = @Descricao, " +
                             "data_criacao = @DataCriacao, data_ult_alteracao = @DataUltimaAlteracao " +
                             "WHERE id_marca = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Marca", marca.Nome),
                    new SqlParameter("@Descricao", marca.Descricao),
                    new SqlParameter("@DataCriacao", marca.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", marca.DataUltimaAlteracao),
                    new SqlParameter("@Id", marca.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirMarca(int marcaId)
        {
            try
            {
                string sql = "DELETE FROM tb_marcas WHERE id_marca = @Id";
                SqlParameter parametro = new SqlParameter("@Id", marcaId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao excluir marca", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir marca", ex);
                return false;
            }
        }

        public Marca BuscarMarcaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_marcas WHERE id_marca = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateMarcaFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar marca por ID", ex);
                return null;
            }
        }

        public List<Marca> ListarMarcas()
        {
            try
            {
                string sql = "SELECT * FROM tb_marcas";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateMarcasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar marcas", ex);
                return new List<Marca>();
            }
        }

        public List<Marca> PesquisarMarcasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Marca> marcasEncontradas = new List<Marca>();

            try
            {
                string query = string.Empty;
                SqlParameter parametroValorPesquisa = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Constrói a consulta SQL baseada no critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_marcas WHERE id_marca LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_marcas WHERE marca LIKE @ValorPesquisa";
                }
                else if (criterio == "DESCRICAO")
                {
                    query = "SELECT * FROM tb_marcas WHERE descricao LIKE @ValorPesquisa";
                }
                else
                {
                    throw new ArgumentException("Critério de pesquisa inválido.");
                }

                // Executa a consulta SQL e preenche a lista de marcas encontradas
                if (!string.IsNullOrEmpty(query))
                {
                    SqlParameter[] parametros = new[] { parametroValorPesquisa };
                    DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Marca marca = CreateMarcaFromDataRow(row);
                        marcasEncontradas.Add(marca);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar marcas", ex);
                return null;
            }

            return marcasEncontradas;
        }

        private Marca CreateMarcaFromDataRow(DataRow row)
        {
            return new Marca
            {
                ID = Convert.ToInt32(row["id_marca"]),
                Nome = row["marca"].ToString(),
                Descricao = row["descricao"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Marca> CreateMarcasListFromDataTable(DataTable dataTable)
        {
            List<Marca> marcas = new List<Marca>();
            foreach (DataRow row in dataTable.Rows)
            {
                marcas.Add(CreateMarcaFromDataRow(row));
            }
            return marcas;
        }
    }
}
