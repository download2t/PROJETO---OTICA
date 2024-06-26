using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Models;
using test.Controllers;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ELP4PROJETO.Data
{
    public class DALFuncionarios
    {
        private Banco banco = new Banco();
        private Operacao operacao = new Operacao();
        private CTLCargos aCTLCargo = new CTLCargos();
        private CTLCidades aCTLCidade = new CTLCidades();

        public string AdicionarFuncionario(Funcionarios funcionario)
        {
            try
            {
                string sql = "INSERT INTO tb_funcionarios (status_funcionario, nome, apelido, sexo, rg, cpf, email, senha, telefone, celular, cep, endereco, numero, complemento, bairro, id_cargo, id_cidade, data_nasc, data_criacao, data_ult_alteracao) " +
                             "VALUES (@StatusFuncionario, @Nome, @Apelido, @Sexo, @RG, @CPF, @Email, @Senha, @Telefone, @Celular, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @IdCargo, @IdCidade, @DataNasc, @DataCriacao, @DataUltimaAlteracao)";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusFuncionario", funcionario.StatusFuncionario),
                    new SqlParameter("@Nome", funcionario.Nome),
                    new SqlParameter("@Apelido", funcionario.Apelido),
                    new SqlParameter("@Sexo", funcionario.Sexo),
                    new SqlParameter("@RG", funcionario.RG),
                    new SqlParameter("@CPF", funcionario.CPF),
                    new SqlParameter("@Email", funcionario.Email),
                    new SqlParameter("@Senha", funcionario.Senha),
                    new SqlParameter("@Telefone", funcionario.Telefone),
                    new SqlParameter("@Celular", funcionario.Celular),
                    new SqlParameter("@CEP", funcionario.CEP),
                    new SqlParameter("@Endereco", funcionario.Endereco),
                    new SqlParameter("@Numero", funcionario.Numero),
                    new SqlParameter("@Complemento", funcionario.Complemento),
                    new SqlParameter("@Bairro", funcionario.Bairro),
                    new SqlParameter("@IdCargo", funcionario.Cargo.ID),
                    new SqlParameter("@IdCidade", funcionario.Cidade.ID),
                    new SqlParameter("@DataNasc", funcionario.DataNascimento),
                    new SqlParameter("@DataCriacao", funcionario.DataCriacao),
                    new SqlParameter("@DataUltimaAlteracao", funcionario.DataUltimaAlteracao)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarFuncionarioComSenha(Funcionarios funcionario)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET status_funcionario = @StatusFuncionario, nome = @Nome, apelido = @Apelido, " +
                             "sexo = @Sexo, rg = @RG, cpf = @CPF, email = @Email, senha = @Senha, telefone = @Telefone, celular = @Celular, cep = @CEP, " +
                             "endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, id_cargo = @IdCargo, " +
                             "id_cidade = @IdCidade, data_nasc = @DataNasc, data_ult_alteracao = @DataUltimaAlteracao WHERE id_funcionario = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusFuncionario", funcionario.StatusFuncionario),
                    new SqlParameter("@Nome", funcionario.Nome),
                    new SqlParameter("@Apelido", funcionario.Apelido),
                    new SqlParameter("@Sexo", funcionario.Sexo),
                    new SqlParameter("@RG", funcionario.RG),
                    new SqlParameter("@CPF", funcionario.CPF),
                    new SqlParameter("@Email", funcionario.Email),
                    new SqlParameter("@Senha", funcionario.Senha),
                    new SqlParameter("@Telefone", funcionario.Telefone),
                    new SqlParameter("@Celular", funcionario.Celular),
                    new SqlParameter("@CEP", funcionario.CEP),
                    new SqlParameter("@Endereco", funcionario.Endereco),
                    new SqlParameter("@Numero", funcionario.Numero),
                    new SqlParameter("@Complemento", funcionario.Complemento),
                    new SqlParameter("@Bairro", funcionario.Bairro),
                    new SqlParameter("@IdCargo", funcionario.Cargo.ID),
                    new SqlParameter("@IdCidade", funcionario.Cidade.ID),
                    new SqlParameter("@DataNasc", funcionario.DataNascimento),
                    new SqlParameter("@DataUltimaAlteracao", funcionario.DataUltimaAlteracao),
                    new SqlParameter("@Id", funcionario.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Funcionarios AtualizarSenha(Funcionarios funcionario)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET data_ult_alteracao = @DataUltimaAlteracao, senha = @Senha WHERE id_funcionario = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@Senha", funcionario.Senha),
                    new SqlParameter("@DataUltimaAlteracao", funcionario.DataUltimaAlteracao),
                    new SqlParameter("@Id", funcionario.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return funcionario;
            }
            catch (Exception)
            {
                return new Funcionarios();
            }
        }
        public string AtualizarFuncionarioSemSenha(Funcionarios funcionario)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET status_funcionario = @StatusFuncionario, nome = @Nome, apelido = @Apelido, " +
                             "sexo = @Sexo, rg = @RG, cpf = @CPF, email = @Email, telefone = @Telefone, celular = @Celular, cep = @CEP, " +
                             "endereco = @Endereco, numero = @Numero, complemento = @Complemento, bairro = @Bairro, id_cargo = @IdCargo, " +
                             "id_cidade = @IdCidade, data_nasc = @DataNasc, data_ult_alteracao = @DataUltimaAlteracao WHERE id_funcionario = @Id";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@StatusFuncionario", funcionario.StatusFuncionario),
                    new SqlParameter("@Nome", funcionario.Nome),
                    new SqlParameter("@Apelido", funcionario.Apelido),
                    new SqlParameter("@Sexo", funcionario.Sexo),
                    new SqlParameter("@RG", funcionario.RG),
                    new SqlParameter("@CPF", funcionario.CPF),
                    new SqlParameter("@Email", funcionario.Email),
                    new SqlParameter("@Telefone", funcionario.Telefone),
                    new SqlParameter("@Celular", funcionario.Celular),
                    new SqlParameter("@CEP", funcionario.CEP),
                    new SqlParameter("@Endereco", funcionario.Endereco),
                    new SqlParameter("@Numero", funcionario.Numero),
                    new SqlParameter("@Complemento", funcionario.Complemento),
                    new SqlParameter("@Bairro", funcionario.Bairro),
                    new SqlParameter("@IdCargo", funcionario.Cargo.ID),
                    new SqlParameter("@IdCidade", funcionario.Cidade.ID),
                    new SqlParameter("@DataNasc", funcionario.DataNascimento),
                    new SqlParameter("@DataUltimaAlteracao", funcionario.DataUltimaAlteracao),
                    new SqlParameter("@Id", funcionario.ID)
                };
                banco.ExecutarComando(sql, parametros);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool ExcluirFuncionario(int funcionarioId)
        {
            try
            {
                string sql = "DELETE FROM tb_funcionarios WHERE id_funcionario = @Id";
                SqlParameter parametro = new SqlParameter("@Id", funcionarioId);
                banco.ExecutarComando(sql, new[] { parametro });
                return true;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir funcionário", ex);
                return false;
            }
        }

        public Funcionarios BuscarFuncionarioPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_funcionarios WHERE id_funcionario = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateFuncionarioFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar funcionário por ID", ex);
                return null;
            }
        }

        public List<Funcionarios> ListarFuncionarios(string status)
        {
            try
            {
                string sql = "SELECT * FROM tb_funcionarios";
                List<SqlParameter> parametros = new List<SqlParameter>();

                // Verifica se o parâmetro de status foi fornecido e adiciona a cláusula WHERE, se necessário
                if (!string.IsNullOrEmpty(status))
                {
                    sql += " WHERE status_funcionario = @Status";
                    parametros.Add(new SqlParameter("@Status", status));
                }

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateFuncionariosListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar funcionários", ex);
                return new List<Funcionarios>();
            }
        }


        private Funcionarios CreateFuncionarioFromDataRow(DataRow row)
        {
            return new Funcionarios
            {
                ID = Convert.ToInt32(row["id_funcionario"]),
                StatusFuncionario = row["status_funcionario"].ToString(),
                Nome = row["nome"].ToString(),
                Apelido = row["apelido"].ToString(),
                Sexo = row["sexo"].ToString(),
                RG = row["rg"].ToString(),
                CPF = row["cpf"].ToString(),
                Email = row["email"].ToString(),
                Senha = row["senha"].ToString(),
                Telefone = row["telefone"].ToString(),
                Celular = row["celular"].ToString(),
                CEP = row["cep"].ToString(),
                Endereco = row["endereco"].ToString(),
                Numero = Convert.ToInt32(row["numero"]),
                Complemento = row["complemento"].ToString(),
                Bairro = row["bairro"].ToString(),
                Cargo = aCTLCargo.BuscarCargoPorId(Convert.ToInt32(row["id_cargo"])),
                Cidade = aCTLCidade.BuscarCidadePorId(Convert.ToInt32(row["id_cidade"])),
                DataNascimento = Convert.ToDateTime(row["data_nasc"]),
                DataCriacao = Convert.ToDateTime(row["data_criacao"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ult_alteracao"])
            };
        }

        private List<Funcionarios> CreateFuncionariosListFromDataTable(DataTable dataTable)
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            foreach (DataRow row in dataTable.Rows)
            {
                funcionarios.Add(CreateFuncionarioFromDataRow(row));
            }
            return funcionarios;
        }
        public List<Funcionarios> PesquisarFuncionariosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Funcionarios> funcionariosEncontrados = new List<Funcionarios>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");

                // Verificando o critério de pesquisa
                if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE id_funcionario LIKE @ValorPesquisa";
                }
                else if (criterio == "NOME")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE nome LIKE @ValorPesquisa";
                }
                else if (criterio == "STATUS")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE status_funcionario = @Status AND nome LIKE @ValorPesquisa";
                }
                else if (criterio == "SEXO")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE sexo LIKE @ValorPesquisa";
                }
                else if (criterio == "RG")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE rg LIKE @ValorPesquisa";
                }
                else if (criterio == "CPF")
                {
                    query = "SELECT * FROM tb_funcionarios WHERE cpf LIKE @ValorPesquisa";
                }
                else if (criterio == "CIDADE")
                {
                    // Aqui precisamos pesquisar pelo nome da cidade
                    query = "SELECT f.* FROM tb_funcionarios f JOIN tb_cidades cid ON f.id_cidade = cid.id_cidade WHERE cid.nome LIKE @ValorPesquisa";
                }

                // Adicionar filtro de status, se fornecido
                if (!string.IsNullOrEmpty(status))
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        query += " AND status_funcionario = @Status";
                    }
                    else
                    {
                        query = "SELECT * FROM tb_funcionarios WHERE status_funcionario = @Status AND nome LIKE @ValorPesquisa";
                    }
                }

                // Executar a consulta e preencher a lista de funcionários encontrados
                DataTable dataTable;
                if (!string.IsNullOrEmpty(query))
                {
                    dataTable = banco.ExecutarConsulta(query, new[] { parametro, new SqlParameter("@Status", status) });
                }
                else
                {
                    dataTable = banco.ExecutarConsulta("SELECT * FROM tb_funcionarios WHERE nome LIKE @ValorPesquisa", new[] { parametro });
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Funcionarios funcionario = CreateFuncionarioFromDataRow(row);
                    funcionariosEncontrados.Add(funcionario);
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar funcionários", ex);
                return null;
            }

            return funcionariosEncontrados;
        }

        public Funcionarios ValidarLogin(string emailOuApelido, string senha)
        {
            try
            {
                if (string.IsNullOrEmpty(emailOuApelido) || string.IsNullOrEmpty(senha))
                {
                    return null;
                }

                string sql = "SELECT * FROM tb_funcionarios WHERE (email = @EmailOuApelido OR apelido = @EmailOuApelido) AND senha = @Senha";
                SqlParameter[] parametros =
                {
                    new SqlParameter("@EmailOuApelido", emailOuApelido),
                    new SqlParameter("@Senha", senha) 
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateFuncionarioFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao validar login", ex);
                return null;
            }
        }

        public string CriptografarDadosSHA256(string dados)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(dados));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Funcionarios BuscarPorEmailOuApelido(string func)
        {
            try
            {
                string sql = "SELECT * FROM tb_funcionarios WHERE email = @emailOuApelido OR apelido = @emailOuApelido";
                List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter("@emailOuApelido", func)
                };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());

                // Verifica se a consulta retornou algum resultado
                if (dataTable.Rows.Count > 0)
                {
                    // Cria um objeto Funcionarios a partir da primeira linha da DataTable
                    return CreateFuncionarioFromDataRow(dataTable.Rows[0]);
                }
                else
                {
                    return null; // Retorna null se nenhum resultado for encontrado
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar funcionário por email ou apelido", ex);
                return null;
            }
        }


    }
}

