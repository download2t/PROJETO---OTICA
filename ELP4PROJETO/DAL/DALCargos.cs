using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.Data
{
    public class DALCargos
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarCargo(Cargos cargo)
        {
            try
            {
                string sql = "INSERT INTO tb_cargos (status_cargo, cargo, data_criacao, data_ult_alteracao) " +
                             "VALUES (@StatusCargo, @Cargo, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCargo", cargo.StatusCargo),
                    new SqlParameter("@Cargo", cargo.Cargo),
                    new SqlParameter("@DataCriacao", cargo.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", cargo.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarCargo(Cargos cargo)
        {
            try
            {
                string sql = "UPDATE tb_cargos SET status_cargo = @StatusCargo, cargo = @Cargo, " +
                             "data_ult_alteracao = @DataUltimaAlteracao WHERE id_cargo = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCargo", cargo.StatusCargo),
                    new SqlParameter("@Cargo", cargo.Cargo),
                    new SqlParameter("@DataUltimaAlteracao", cargo.DataUltimaAlteracao),
                    new SqlParameter("@Id", cargo.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirCargo(int cargoId)
        {
            try
            {
                string sql = "DELETE FROM tb_cargos WHERE id_cargo = @Id";
                SqlParameter parametro = new SqlParameter("@Id", cargoId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir cargo", ex);
                return false;
            }
        }

        public Cargos BuscarCargoPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_cargos WHERE id_cargo = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateCargoFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar cargo por ID", ex);
                return null;
            }
        }

        public List<Cargos> ListarCargos(string status)
        {
            try
            {
                // Certifique-se de que o status é "I" ou "A"
                if (status != "I" && status != "A")
                {
                    throw new ArgumentException("Status deve ser 'I' ou 'A'");
                }

                string sql = "SELECT * FROM tb_cargos WHERE status_cargo = @status";
                SqlParameter[] parametros = new SqlParameter[]
                {
            new SqlParameter("@status", SqlDbType.Char) { Value = status }
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);
                return CreateCargosListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar cargos", ex);
                return new List<Cargos>();
            }
        }


        private Cargos CreateCargoFromDataRow(DataRow row)
        {
            return new Cargos
            {
                ID = Convert.ToInt32(row["id_cargo"]),
                StatusCargo = row["status_cargo"].ToString(),
                Cargo = row["cargo"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Cargos> CreateCargosListFromDataTable(DataTable dataTable)
        {
            List<Cargos> cargos = new List<Cargos>();
            foreach (DataRow row in dataTable.Rows)
            {
                cargos.Add(CreateCargoFromDataRow(row));
            }
            return cargos;
        }

     public List<Cargos> PesquisarCargosPorCriterio(string criterio, string valorPesquisa, string status)
{
    List<Cargos> cargosEncontrados = new List<Cargos>();

    try
    {
        string query = string.Empty;
        SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
        SqlParameter parametroStatus = new SqlParameter("@Status", status);

        // Verificando o critério de pesquisa
        if (criterio == "ID")
        {
            query = "SELECT * FROM tb_cargos WHERE id_cargo LIKE @ValorPesquisa";
        }
        else if (criterio == "CARGO")
        {
            query = "SELECT * FROM tb_cargos WHERE cargo LIKE @ValorPesquisa";
        }

        // Adicionar filtro de status
        if (!string.IsNullOrEmpty(status))
        {
            if (!string.IsNullOrEmpty(query))
            {
                query += " AND status_cargo = @Status";
            }
            else
            {
                query = "SELECT * FROM tb_cargos WHERE status_cargo = @Status";
            }
        }

        // Executar a consulta e preencher a lista de cargos encontrados
        DataTable dataTable;
        if (!string.IsNullOrEmpty(query))
        {
            dataTable = banco.ExecutarConsulta(query, new[] { parametro, parametroStatus });
        }
        else
        {
            dataTable = banco.ExecutarConsulta("SELECT * FROM tb_cargos WHERE status_cargo = @Status", new[] { parametroStatus });
        }

        foreach (DataRow row in dataTable.Rows)
        {
            Cargos cargo = CreateCargoFromDataRow(row);
            cargosEncontrados.Add(cargo);
        }
    }
    catch (Exception ex)
    {
        operacao.HandleException("Erro ao buscar cargos", ex);
        return null;
    }

    return cargosEncontrados;
}


    }
}
