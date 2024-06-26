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
    public class DALLaboratorios
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                string sql = "INSERT INTO tb_laboratorio (nome, data_criacao, data_ult_alteracao) " +
                             "VALUES (@Nome, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", laboratorio.Nome),
                    new SqlParameter("@DataCriacao", laboratorio.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", laboratorio.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarLaboratorio(Laboratorio laboratorio)
        {
            try
            {
                string sql = "UPDATE tb_laboratorio SET nome = @Nome, " +
                             "data_ult_alteracao = @DataUltimaAlteracao WHERE id_laboratorio = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Nome", laboratorio.Nome),
                    new SqlParameter("@DataUltimaAlteracao", laboratorio.DataUltimaAlteracao),
                    new SqlParameter("@Id", laboratorio.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirLaboratorio(int laboratorioId)
        {
            try
            {
                string sql = "DELETE FROM tb_laboratorio WHERE id_laboratorio = @Id";
                SqlParameter parametro = new SqlParameter("@Id", laboratorioId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir laboratório", ex);
                return false;
            }
        }

        public Laboratorio BuscarLaboratorioPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_laboratorio WHERE id_laboratorio = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateLaboratorioFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar laboratório por ID", ex);
                return null;
            }
        }

        public List<Laboratorio> ListarLaboratorios()
        {
            try
            {
                string sql = "SELECT * FROM tb_laboratorio";
                DataTable dataTable = banco.ExecutarConsulta(sql,null);
                return CreateLaboratoriosListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar laboratórios", ex);
                return new List<Laboratorio>();
            }
        }

        private Laboratorio CreateLaboratorioFromDataRow(DataRow row)
        {
            return new Laboratorio
            {
                ID = Convert.ToInt32(row["id_laboratorio"]),
                Nome = row["nome"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Laboratorio> CreateLaboratoriosListFromDataTable(DataTable dataTable)
        {
            List<Laboratorio> laboratorios = new List<Laboratorio>();
            foreach (DataRow row in dataTable.Rows)
            {
                laboratorios.Add(CreateLaboratorioFromDataRow(row));
            }
            return laboratorios;
        }

        public List<Laboratorio> PesquisarLaboratoriosPorCriterio(string criterio, string valorPesquisa)
        {
            List<Laboratorio> laboratoriosEncontrados = new List<Laboratorio>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_laboratorio WHERE id_laboratorio LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_laboratorio WHERE nome LIKE @ValorPesquisa";
                }

                DataTable dataTable;
                if (!string.IsNullOrEmpty(query))
                {
                    dataTable = banco.ExecutarConsulta(query, new[] { parametro });
                }
                else
                {
                    return new List<Laboratorio>();
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Laboratorio laboratorio = CreateLaboratorioFromDataRow(row);
                    laboratoriosEncontrados.Add(laboratorio);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar laboratórios", ex);
                return new List<Laboratorio>();
            }

            return laboratoriosEncontrados;
        }
    }
}
