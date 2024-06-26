using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALFornecedores
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();
        private CTLCidades aCTLCidades = new CTLCidades();

        public string AdicionarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                string sql = "INSERT INTO tb_fornecedores (rg, tipo_fornecedor, id_condicao_pagamento, status_fornecedor, nome_fantasia, razao_social, data_fundacao, insc_municipal, insc_estadual, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, id_cidade, data_criacao, data_ult_alteracao) " +
                             "VALUES ( @rg, @tipo_fornecedor, @id_condicao_pagamento, @StatusFornecedor, @NomeFantasia, @RazaoSocial, @DataFundacao, @InscricaoMunicipal, @InscricaoEstadual, @CNPJ, @Email, @Telefone, @Celular, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @IdCidade, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusFornecedor", fornecedor.StatusFornecedor),
                    new SqlParameter("@NomeFantasia", fornecedor.NomeFantasia),
                    new SqlParameter("@RazaoSocial", fornecedor.RazaoSocial),
                    new SqlParameter("@DataFundacao", fornecedor.DataFundacao),
                    new SqlParameter("@InscricaoMunicipal", fornecedor.InscricaoMunicipal),
                    new SqlParameter("@InscricaoEstadual", fornecedor.InscricaoEstadual),
                    new SqlParameter("@CNPJ", fornecedor.CNPJ),
                    new SqlParameter("@Email", fornecedor.Email),
                    new SqlParameter("@Telefone", fornecedor.Telefone),
                    new SqlParameter("@Celular", fornecedor.Celular),
                    new SqlParameter("@CEP", fornecedor.CEP),
                    new SqlParameter("@rg", fornecedor.RG),
                    new SqlParameter("@tipo_fornecedor", fornecedor.TipoFornecedor),
                    new SqlParameter("@Endereco", fornecedor.Endereco),
                    new SqlParameter("@Numero", fornecedor.Numero),
                    new SqlParameter("@Complemento", fornecedor.Complemento),
                    new SqlParameter("@Bairro", fornecedor.Bairro),
                    new SqlParameter("@IdCidade", fornecedor.Cidade.ID),
                    new SqlParameter("@id_condicao_pagamento", fornecedor.CondicaoPagamento.ID),
                    new SqlParameter("@DataCriacao", fornecedor.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", fornecedor.DataUltimaAlteracao)
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

        public string AtualizarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                string sql = "UPDATE  tb_fornecedores SET rg = @rg, tipo_fornecedor = @tipo_fornecedor, id_condicao_pagamento = @id_condicao_pagamento, status_fornecedor = @StatusFornecedor, nome_fantasia = @NomeFantasia, razao_social = @RazaoSocial, data_fundacao = @DataFundacao, insc_municipal = @InscricaoMunicipal, insc_estadual = @InscricaoEstadual, " +
                             "cnpj = @CNPJ, email = @Email, telefone = @Telefone, celular = @Celular, cep = @CEP, endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, " +
                             "id_cidade = @IdCidade, data_ult_alteracao = @DataUltimaAlteracao WHERE id_fornecedor = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusFornecedor", fornecedor.StatusFornecedor),
                    new SqlParameter("@NomeFantasia", fornecedor.NomeFantasia),
                    new SqlParameter("@RazaoSocial", fornecedor.RazaoSocial),
                    new SqlParameter("@DataFundacao", fornecedor.DataFundacao),
                    new SqlParameter("@InscricaoMunicipal", fornecedor.InscricaoMunicipal),
                    new SqlParameter("@InscricaoEstadual", fornecedor.InscricaoEstadual),
                    new SqlParameter("@CNPJ", fornecedor.CNPJ),
                    new SqlParameter("@Email", fornecedor.Email),
                    new SqlParameter("@Telefone", fornecedor.Telefone),
                    new SqlParameter("@Celular", fornecedor.Celular),
                    new SqlParameter("@CEP", fornecedor.CEP),
                    new SqlParameter("@Endereco", fornecedor.Endereco),
                    new SqlParameter("@Numero", fornecedor.Numero),
                    new SqlParameter("@rg", fornecedor.RG),
                    new SqlParameter("@tipo_fornecedor", fornecedor.TipoFornecedor),
                    new SqlParameter("@Complemento", fornecedor.Complemento),
                    new SqlParameter("@Bairro", fornecedor.Bairro),
                    new SqlParameter("@IdCidade", fornecedor.Cidade.ID),
                    new SqlParameter("@id_condicao_pagamento", fornecedor.CondicaoPagamento.ID),
                    new SqlParameter("@DataUltimaAlteracao", fornecedor.DataUltimaAlteracao),
                    new SqlParameter("@Id", fornecedor.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirFornecedor(int fornecedorId)
        {
            try
            {
                string sql = "DELETE FROM tb_fornecedores WHERE id_fornecedor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", fornecedorId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir fornecedor", ex);
                return false; // Retorne false para indicar falha
            }
        }
        public string BuscarFornecedorPorCPFouCNPJ(string cpfoucnpj)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tb_fornecedores WHERE cnpj = @CPFouCNPJ";
                SqlParameter parametro = new SqlParameter("@CPFouCNPJ", cpfoucnpj);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0 && (int)dataTable.Rows[0][0] > 0)
                {
                    return "Fornecedor já cadastrado";
                }

                return "OK";
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar fornecedor por CPF ou CNPJ", ex);
                return "Erro ao buscar fornecedor";
            }
        }
        public string BuscarFornecedorPorRG(string cpfoucnpj)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tb_fornecedores WHERE rg = @rg";
                SqlParameter parametro = new SqlParameter("@rg", cpfoucnpj);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0 && (int)dataTable.Rows[0][0] > 0)
                {
                    return "Fornecedor já cadastrado";
                }

                return "OK";
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar fornecedor por CPF ou CNPJ", ex);
                return "Erro ao buscar fornecedor";
            }
        }
        public Fornecedores BuscarFornecedorPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_fornecedores WHERE id_fornecedor = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateFornecedorFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar fornecedor por ID", ex);
                return null;
            }
        }

        public List<Fornecedores> ListarFornecedores(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_fornecedores";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_fornecedor = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateFornecedoresListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao listar fornecedores", ex);
                return new List<Fornecedores>();
            }
        }


        private Fornecedores CreateFornecedorFromDataRow(DataRow row)
        {
            CTLCondicaoPagamento aCTLCond = new CTLCondicaoPagamento();
            var condicao = aCTLCond.BuscarCondicaoPagamentoPorId(Convert.ToInt32(row["id_condicao_pagamento"]));
            return new Fornecedores
            {
                ID = Convert.ToInt32(row["id_fornecedor"]),
                StatusFornecedor = row["status_fornecedor"].ToString(),
                NomeFantasia = row["nome_fantasia"].ToString(),
                RazaoSocial = row["razao_social"].ToString(),
                DataFundacao = Convert.ToDateTime(row["data_fundacao"]),
                InscricaoMunicipal = row["insc_municipal"].ToString(),
                InscricaoEstadual = row["insc_estadual"].ToString(),
                CNPJ = row["cnpj"].ToString(),
                RG = row["rg"].ToString(),
                Email = row["email"].ToString(),
                Telefone = row["telefone"].ToString(),
                Celular = row["celular"].ToString(),
                CEP = row["cep"].ToString(),
                Endereco = row["endereco"].ToString(),
                Numero = Convert.ToInt32(row["numero"]),
                Complemento = row["complemento"].ToString(),
                Bairro = row["bairro"].ToString(),
                Cidade = aCTLCidades.BuscarCidadePorId(Convert.ToInt32(row["id_cidade"])), // Supondo que você tenha um método para buscar a cidade pelo ID
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"]),
                CondicaoPagamento = condicao,
                TipoFornecedor = row["tipo_fornecedor"].ToString(),
            };
        }

        private List<Fornecedores> CreateFornecedoresListFromDataTable(DataTable dataTable)
        {
            List<Fornecedores> fornecedores = new List<Fornecedores>();
            // Para cada linha no DataTable, crie um objeto Fornecedores e adicione à lista de fornecedores
            foreach (DataRow row in dataTable.Rows)
            {
                fornecedores.Add(CreateFornecedorFromDataRow(row));
            }
            return fornecedores;
        }

        public List<Fornecedores> PesquisarFornecedoresPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Fornecedores> fornecedoresEncontrados = new List<Fornecedores>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Verificando o critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_fornecedores WHERE id_fornecedor LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_fornecedores WHERE nome_fantasia LIKE @ValorPesquisa";
                }
                else if (criterio == "CNPJ")
                {
                    query = "SELECT * FROM tb_fornecedores WHERE cnpj LIKE @ValorPesquisa";
                }
                else if (criterio == "CIDADE")
                {
                    // Aqui precisamos pesquisar pelo nome da cidade
                    query = "SELECT f.* FROM tb_fornecedores f JOIN tb_cidades cid ON f.id_cidade = cid.id_cidade WHERE cid.nome LIKE @ValorPesquisa";
                }
                else if (criterio == "STATUS")
                {
                    query = "SELECT * FROM tb_fornecedores WHERE status_fornecedor LIKE @ValorPesquisa";
                }

                // Adicionar filtro de status, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        query += " AND status_fornecedor = @Status";
                    }
                    else
                    {
                        query = "SELECT * FROM tb_fornecedores WHERE status_fornecedor = @Status";
                    }
                }

                // Executar a consulta e preencher a lista de fornecedores encontrados
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro, new SqlParameter("@Status", status) });

                foreach (DataRow row in dataTable.Rows)
                {
                    Fornecedores fornecedor = CreateFornecedorFromDataRow(row);
                    fornecedoresEncontrados.Add(fornecedor);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar fornecedores", ex);
                return null;
            }

            return fornecedoresEncontrados;
        }

    }
}
