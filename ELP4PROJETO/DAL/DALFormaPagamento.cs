﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.Data
{
    public class DALFormaPagamento
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();

        public string AdicionarFormaPagamento(FormaPagamento formaPagamento)
        {
            try
            {
                string sql = "INSERT INTO tb_forma_pagamento (status_forma, forma, data_criacao, data_ult_alteracao) " +
                             "VALUES (@StatusForma, @Forma, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusForma", formaPagamento.StatusForma),
                    new SqlParameter("@Forma", formaPagamento.Forma),
                    new SqlParameter("@DataCriacao", formaPagamento.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", formaPagamento.DataUltimaAlteracao)
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

        public string AtualizarFormaPagamento(FormaPagamento formaPagamento)
        {
            try
            {
                string sql = "UPDATE tb_forma_pagamento SET status_forma = @StatusForma, forma = @Forma, " +
                             "data_ult_alteracao = @DataUltimaAlteracao WHERE id_forma = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusForma", formaPagamento.StatusForma),
                    new SqlParameter("@Forma", formaPagamento.Forma),
                    new SqlParameter("@DataUltimaAlteracao", formaPagamento.DataUltimaAlteracao),
                    new SqlParameter("@Id", formaPagamento.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirFormaPagamento(int formaPagamentoId)
        {
            try
            {
                string sql = "DELETE FROM tb_forma_pagamento WHERE id_forma = @Id";
                SqlParameter parametro = new SqlParameter("@Id", formaPagamentoId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir forma de pagamento", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public FormaPagamento BuscarFormaPagamentoPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_forma_pagamento WHERE id_forma = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateFormaPagamentoFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar forma de pagamento por ID", ex);
                return null;
            }
        }

        public List<FormaPagamento> ListarFormasPagamento(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_forma_pagamento";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_forma = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateFormasPagamentoListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar formas de pagamento", ex);
                return new List<FormaPagamento>();
            }
        }


        private FormaPagamento CreateFormaPagamentoFromDataRow(DataRow row)
        {
            // Crie um novo objeto FormaPagamento e preencha suas propriedades com os dados da linha fornecida
            return new FormaPagamento
            {
                ID = Convert.ToInt32(row["id_forma"]),
                StatusForma = row["status_forma"].ToString(),
                Forma = row["forma"].ToString(),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<FormaPagamento> CreateFormasPagamentoListFromDataTable(DataTable dataTable)
        {
            List<FormaPagamento> formasPagamento = new List<FormaPagamento>();
            // Para cada linha no DataTable, crie um objeto FormaPagamento e adicione à lista de formas de pagamento
            foreach (DataRow row in dataTable.Rows)
            {
                formasPagamento.Add(CreateFormaPagamentoFromDataRow(row));
            }
            return formasPagamento;
        }
        public List<FormaPagamento> PesquisarFormasPagamentoPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<FormaPagamento> formasPagamentoEncontradas = new List<FormaPagamento>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Verificando o critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_forma_pagamento WHERE id_forma LIKE @ValorPesquisa";
                }
                else if (criterio == "STATUS")
                {
                    query = "SELECT * FROM tb_forma_pagamento WHERE status_forma LIKE @ValorPesquisa";
                }
                else if (criterio == "FORMA")
                {
                    query = "SELECT * FROM tb_forma_pagamento WHERE forma LIKE @ValorPesquisa";
                }

                // Adicionar filtro de status, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        query += " AND status_forma = @Status";
                    }
                    else
                    {
                        query = "SELECT * FROM tb_forma_pagamento WHERE status_forma = @Status";
                    }
                }

                // Executar a consulta e preencher a lista de formas de pagamento encontradas
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro, new SqlParameter("@Status", status) });

                foreach (DataRow row in dataTable.Rows)
                {
                    FormaPagamento formaPagamento = CreateFormaPagamentoFromDataRow(row);
                    formasPagamentoEncontradas.Add(formaPagamento);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar formas de pagamento", ex);
                return null;
            }

            return formasPagamentoEncontradas;
        }


    }
}
