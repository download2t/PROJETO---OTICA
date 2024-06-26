﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DAOCidades
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarCidade(Cidades cidade)
        {
            try
            {
                string sql = "INSERT INTO tb_cidades (status_cidade, nome, DDD, id_estado, data_criacao, data_ult_alteracao) " +
                             "VALUES (@StatusCidade, @Nome, @DDD, @IdEstado, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCidade", cidade.StatusCidade),
                    new SqlParameter("@Nome", cidade.Cidade),
                    new SqlParameter("@DDD", cidade.DDD),
                    new SqlParameter("@IdEstado", cidade.OEstado.ID),
                    new SqlParameter("@DataCriacao", cidade.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", cidade.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);

                // Se a execução chegou até aqui, significa que a operação foi bem-sucedida
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarCidade(Cidades cidade)
        {
            try
            {
                string sql = "UPDATE tb_cidades SET status_cidade = @StatusCidade, nome = @Nome, DDD = @DDD, id_estado = @IdEstado, " +
                             "data_criacao = @DataCriacao, data_ult_alteracao = @DataUltimaAlteracao WHERE id_cidade = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCidade", cidade.StatusCidade),
                    new SqlParameter("@Nome", cidade.Cidade),
                    new SqlParameter("@DDD", cidade.DDD),
                    new SqlParameter("@IdEstado", cidade.OEstado.ID),
                    new SqlParameter("@DataCriacao", cidade.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", cidade.DataUltimaAlteracao),
                    new SqlParameter("@Id", cidade.ID)
                };
                banco.ExecutarComando(sql, parametros);

                // Se a execução chegou até aqui, significa que a operação foi bem-sucedida
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public bool ExcluirCidade(int cidadeId)
        {
            try
            {
                string sql = "DELETE FROM tb_cidades WHERE id_cidade = @Id";
                SqlParameter parametro = new SqlParameter("@Id", cidadeId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao excluir cidade", ex);
                return false; // Retorne false para indicar falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir cidade", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Cidades BuscarCidadePorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_cidades WHERE id_cidade = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateCidadeFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar cidade por ID", ex);
                return null;
            }
        }

        public List<Cidades> ListarCidades(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_cidades";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_cidade = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateCidadesListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar cidades", ex);
                return new List<Cidades>();
            }
        }
        public Cidades BuscarCidadePorNomeEUF(string nomeCidade, string uf)
        {
            try
            {
                string query = "SELECT c.* FROM tb_cidades c JOIN tb_estados e ON c.id_estado = e.id_estado WHERE c.nome = @NomeCidade AND e.uf = @UF";
                SqlParameter[] parametros =
                {
                new SqlParameter("@NomeCidade", nomeCidade),
                new SqlParameter("@UF", uf)
            };

                DataTable dataTable = banco.ExecutarConsulta(query, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateCidadeFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar cidade por nome e UF", ex);
                return null;
            }
        }

        private Cidades CreateCidadeFromDataRow(DataRow row)
        {
            CTLEstados aCTLEstados = new CTLEstados();
            Estados estado = aCTLEstados.BuscarEstadoPorId(Convert.ToInt32(row["id_estado"]));

            return new Cidades
            {
                ID = Convert.ToInt32(row["id_cidade"]),
                Cidade = row["nome"].ToString(),
                DDD = row["DDD"].ToString(),
                OEstado = estado,
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"]),
                StatusCidade = row["status_cidade"].ToString()
            };
        }

        private List<Cidades> CreateCidadesListFromDataTable(DataTable dataTable)
        {
            List<Cidades> cidades = new List<Cidades>();
            foreach (DataRow row in dataTable.Rows)
            {
                cidades.Add(CreateCidadeFromDataRow(row));
            }
            return cidades;
        }

        public List<Cidades> PesquisarCidadesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Cidades> cidadesEncontradas = new List<Cidades>();

            try
            {
                string query = string.Empty;
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Construir a consulta com base no critério de pesquisa
                string condicao = string.Empty;
                if (criterio == "ID")
                {
                    condicao = "id_cidade LIKE @ValorPesquisa";
                }
                else if (criterio == "DDD")
                {
                    condicao = "DDD LIKE @ValorPesquisa";
                }
                else if (criterio == "ESTADO")
                {
                    condicao = "e.nome LIKE @ValorPesquisa";
                    query = "SELECT c.* FROM tb_cidades c JOIN tb_estados e ON c.id_estado = e.id_estado";
                }
                else if (criterio == "PAIS")
                {
                    condicao = "p.nome LIKE @ValorPesquisa";
                    query = "SELECT c.* FROM tb_cidades c JOIN tb_estados e ON c.id_estado = e.id_estado JOIN tb_pais p ON e.id_pais = p.id_pais";
                }
                else if (criterio == "CIDADE")
                {
                    condicao = "nome LIKE @ValorPesquisa";
                }

                // Adicionar filtro de status à condição
                condicao += " AND status_cidade = @Status";
                parametros.Add(new SqlParameter("@Status", status));

                if (!string.IsNullOrEmpty(condicao))
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        query += " WHERE " + condicao;
                    }
                    else
                    {
                        query = "SELECT * FROM tb_cidades WHERE " + condicao;
                    }
                    parametros.Add(new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%"));
                }

                // Executar a consulta e preencher a lista de cidades encontradas
                DataTable dataTable = banco.ExecutarConsulta(query, parametros.ToArray());

                foreach (DataRow row in dataTable.Rows)
                {
                    Cidades cidade = CreateCidadeFromDataRow(row);
                    cidadesEncontradas.Add(cidade);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar cidades", ex);
                return null;
            }

            return cidadesEncontradas;
        }



    }
}
