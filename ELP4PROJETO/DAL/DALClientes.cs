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
    public class DALClientes
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();
        private CTLCidades aCTLCidades = new CTLCidades();

        public string AdicionarCliente(Clientes cliente)
        {
            try
            {
                string sql = "INSERT INTO tb_clientes (tipo_cliente, status_cliente, nome, sexo, apelido, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, id_cidade, data_nasc, id_condicao_pagamento, data_criacao, data_ult_alteracao) " +
                             "VALUES (@tipo_cliente, @StatusCliente, @Nome, @Sexo, @Apelido, @RG, @CPF, @Email, @Telefone, @Celular, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @IdCidade, @DataNasc, @id_condicao_pagamento, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCliente", cliente.StatusCliente),
                    new SqlParameter("@Nome", cliente.Nome),
                    new SqlParameter("@Sexo", cliente.Sexo),
                    new SqlParameter("@Apelido", cliente.Apelido),
                    new SqlParameter("@RG", cliente.RG),
                    new SqlParameter("@CPF", cliente.CPF),
                    new SqlParameter("@Email", cliente.Email),
                    new SqlParameter("@Telefone", cliente.Telefone),
                    new SqlParameter("@Celular", cliente.Celular),
                    new SqlParameter("@CEP", cliente.CEP),
                    new SqlParameter("@Endereco", cliente.Endereco),
                    new SqlParameter("@Numero", cliente.Numero),
                    new SqlParameter("@Complemento", cliente.Complemento),
                    new SqlParameter("@Bairro", cliente.Bairro),
                    new SqlParameter("@IdCidade", cliente.Cidade.ID),
                    new SqlParameter("@DataNasc", cliente.DataNasc),
                    new SqlParameter("@DataCriacao", cliente.DataCriacao),
                    new SqlParameter("@tipo_cliente", cliente.TipoCliente),
                    new SqlParameter("@id_condicao_pagamento", cliente.CondicaoPagamento.ID),
                    new SqlParameter("@DataUltimaAlteracao", cliente.DataUltimaAlteracao)

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

        public string AtualizarCliente(Clientes cliente)
        {
            try
            {
                string sql = "UPDATE tb_clientes SET tipo_cliente = @tipo_cliente, status_cliente = @StatusCliente, nome = @Nome, sexo = @Sexo, apelido = @Apelido, rg = @RG, cpf = @CPF, email = @Email, " +
                             "telefone = @Telefone, celular = @Celular, cep = @CEP, endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, " +
                             "id_cidade = @IdCidade, data_nasc = @DataNasc, data_ult_alteracao = @DataUltimaAlteracao, id_condicao_pagamento= @id_condicao_pagamento  WHERE id_cliente = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusCliente", cliente.StatusCliente),
                    new SqlParameter("@Nome", cliente.Nome),
                    new SqlParameter("@Sexo", cliente.Sexo),
                    new SqlParameter("@Apelido", cliente.Apelido),
                    new SqlParameter("@RG", cliente.RG),
                    new SqlParameter("@CPF", cliente.CPF),
                    new SqlParameter("@Email", cliente.Email),
                    new SqlParameter("@Telefone", cliente.Telefone),
                    new SqlParameter("@Celular", cliente.Celular),
                    new SqlParameter("@CEP", cliente.CEP),
                    new SqlParameter("@Endereco", cliente.Endereco),
                    new SqlParameter("@Numero", cliente.Numero),
                    new SqlParameter("@Complemento", cliente.Complemento),
                    new SqlParameter("@Bairro", cliente.Bairro),
                    new SqlParameter("@IdCidade", cliente.Cidade.ID),
                    new SqlParameter("@DataNasc", cliente.DataNasc),
                    new SqlParameter("@id_condicao_pagamento", cliente.CondicaoPagamento.ID),
                    new SqlParameter("@DataUltimaAlteracao", cliente.DataUltimaAlteracao),
                    new SqlParameter("@tipo_cliente", cliente.TipoCliente),
                    new SqlParameter("@Id", cliente.ID)
                };
                banco.ExecutarComando(sql, parametros);

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirCliente(int clienteId)
        {
            try
            {
                string sql = "DELETE FROM tb_clientes WHERE id_cliente = @Id";
                SqlParameter parametro = new SqlParameter("@Id", clienteId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true; // Retorne true para indicar sucesso
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao excluir cliente", ex);
                return false; // Retorne false para indicar falha
            }
        }

        public Clientes BuscarClientePorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_clientes WHERE id_cliente = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateClienteFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar cliente por ID", ex);
                return null;
            }
        }
        public string BuscarClientePorCPFouCNPJ(string cpfoucnpj)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tb_clientes WHERE cpf = @CPFouCNPJ";
                SqlParameter parametro = new SqlParameter("@CPFouCNPJ", cpfoucnpj);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0 && (int)dataTable.Rows[0][0] > 0)
                {
                    return "Cliente já cadastrado";
                }

                return "OK";
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar cliente por CPF ou CNPJ", ex);
                return "Erro ao buscar cliente";
            }
        }
        public string BuscarClientePorRG(string cpfoucnpj)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tb_clientes WHERE rg = @rg";
                SqlParameter parametro = new SqlParameter("@rg", cpfoucnpj);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0 && (int)dataTable.Rows[0][0] > 0)
                {
                    return "Cliente já cadastrado";
                }

                return "OK";
            }
            catch (Exception ex)
            {
                // Trate exceções genéricas, se aplicável
                operacao.HandleException("Erro ao buscar cliente por CPF ou CNPJ", ex);
                return "Erro ao buscar cliente";
            }
        }

        public List<Clientes> ListarClientes(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_clientes";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_cliente = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateClientesListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar clientes", ex);
                return new List<Clientes>();
            }
        }


        private Clientes CreateClienteFromDataRow(DataRow row)
        {
            CTLCondicaoPagamento aCTLCond = new CTLCondicaoPagamento();
            var condicao = aCTLCond.BuscarCondicaoPagamentoPorId(Convert.ToInt32(row["id_condicao_pagamento"]));
            return new Clientes
            {
                ID = Convert.ToInt32(row["id_cliente"]),
                StatusCliente = row["status_cliente"].ToString(),
                Nome = row["nome"].ToString(),
                Sexo = row["sexo"].ToString(),
                Apelido = row["apelido"].ToString(),
                RG = row["rg"].ToString(),
                CPF = row["cpf"].ToString(),
                Email = row["email"].ToString(),
                Telefone = row["telefone"].ToString(),
                Celular = row["celular"].ToString(),
                CEP = row["cep"].ToString(),
                Endereco = row["endereco"].ToString(),
                Numero = Convert.ToInt32(row["numero"]),
                Complemento = row["complemento"].ToString(),
                Bairro = row["bairro"].ToString(),
                Cidade = aCTLCidades.BuscarCidadePorId(Convert.ToInt32(row["id_cidade"])), // Supondo que você tenha um método para buscar a cidade pelo ID
                DataNasc = Convert.ToDateTime(row["data_nasc"]),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"]),
                CondicaoPagamento = condicao,
                TipoCliente = row["tipo_cliente"].ToString()
            };
        }

        private List<Clientes> CreateClientesListFromDataTable(DataTable dataTable)
        {
            List<Clientes> clientes = new List<Clientes>();
            // Para cada linha no DataTable, crie um objeto Clientes e adicione à lista de clientes
            foreach (DataRow row in dataTable.Rows)
            {
                clientes.Add(CreateClienteFromDataRow(row));
            }
            return clientes;
        }
        public List<Clientes> PesquisarClientesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Clientes> clientesEncontrados = new List<Clientes>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Verificando o critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_clientes WHERE id_cliente LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_clientes WHERE nome LIKE @ValorPesquisa";
                }
                else if (criterio == "RG")
                {
                    query = "SELECT * FROM tb_clientes WHERE rg LIKE @ValorPesquisa";
                }
                else if (criterio == "CPF")
                {
                    query = "SELECT * FROM tb_clientes WHERE cpf LIKE @ValorPesquisa";
                }
                else if (criterio == "CNPJ")
                {
                    query = "SELECT * FROM tb_clientes WHERE cnpj LIKE @ValorPesquisa";
                }
                else if (criterio == "CIDADE")
                {
                    query = "SELECT c.* FROM tb_clientes c JOIN tb_cidades cid ON c.id_cidade = cid.id_cidade WHERE cid.nome LIKE @ValorPesquisa";
                }

                // Adicionar filtro de status, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        query += " AND status_cliente = @Status";
                    }
                    else
                    {
                        query = "SELECT * FROM tb_clientes WHERE status_cliente = @Status";
                    }
                }

                // Executar a consulta e preencher a lista de clientes encontrados
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro, new SqlParameter("@Status", status) });

                foreach (DataRow row in dataTable.Rows)
                {
                    Clientes cliente = CreateClienteFromDataRow(row);
                    clientesEncontrados.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar clientes", ex);
                return null;
            }

            return clientesEncontrados;
        }



    }
}
