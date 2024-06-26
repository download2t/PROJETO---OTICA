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
    public class DALDoutores
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarDoutor(Doutor doutor)
        {
            try
            {
                string sql = "INSERT INTO tb_doutores (nome, data_criacao, data_ult_alteracao) " +
                             "VALUES (@Nome, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", doutor.Nome),
                    new SqlParameter("@DataCriacao", doutor.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", doutor.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarDoutor(Doutor doutor)
        {
            try
            {
                string sql = "UPDATE tb_doutores SET nome = @Nome, " +
                             "data_ult_alteracao = @DataUltimaAlteracao WHERE id_doutor = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", doutor.Nome),
                    new SqlParameter("@DataUltimaAlteracao", doutor.DataUltimaAlteracao),
                    new SqlParameter("@Id", doutor.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirDoutor(int doutorId)
        {
            try
            {
                string sql = "DELETE FROM tb_doutores WHERE id_doutor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", doutorId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir doutor", ex);
                return false;
            }
        }

        public Doutor BuscarDoutorPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_doutores WHERE id_doutor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateDoutorFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar doutor por ID", ex);
                return null;
            }
        }

        public List<Doutor> ListarDoutores()
        {
            try
            {
                string sql = "SELECT * FROM tb_doutores";
                DataTable dataTable = banco.ExecutarConsulta(sql, null);
                return CreateDoutoresListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar doutores", ex);
                return new List<Doutor>();
            }
        }

        private Doutor CreateDoutorFromDataRow(DataRow row)
        {
            return new Doutor
            {
                ID = Convert.ToInt32(row["id_doutor"]),
                Nome = row["nome"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Doutor> CreateDoutoresListFromDataTable(DataTable dataTable)
        {
            List<Doutor> doutores = new List<Doutor>();
            foreach (DataRow row in dataTable.Rows)
            {
                doutores.Add(CreateDoutorFromDataRow(row));
            }
            return doutores;
        }

        public List<Doutor> PesquisarDoutoresPorCriterio(string criterio, string valorPesquisa)
        {
            List<Doutor> doutoresEncontrados = new List<Doutor>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_doutores WHERE id_doutor LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_doutores WHERE nome LIKE @ValorPesquisa";
                }

                DataTable dataTable;
                if (!string.IsNullOrEmpty(query))
                {
                    dataTable = banco.ExecutarConsulta(query, new[] { parametro });
                }
                else
                {
                    return new List<Doutor>();
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Doutor doutor = CreateDoutorFromDataRow(row);
                    doutoresEncontrados.Add(doutor);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar doutores", ex);
                return new List<Doutor>();
            }

            return doutoresEncontrados;
        }
    }
}
