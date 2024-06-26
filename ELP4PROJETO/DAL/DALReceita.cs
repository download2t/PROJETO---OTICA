using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Controllers;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALReceita
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();
        public string AdicionarReceita(Receita receita)
        {
            string sqlInsertReceita = @"INSERT INTO tb_Receitas 
                    (id_cliente, id_laboratorio, id_doutor, data_recebimento, data_cadastro, data_ultima_alteracao, 
                    od_esf_longe, od_cil_longe, od_eixo_longe, od_dnp_longe, od_adicao_longe, od_altura_longe, 
                    ed_esf_longe, ed_cil_longe, ed_eixo_longe, ed_dnp_longe, ed_edadicao_longe, ed_altura_longe, 
                    od_esf_perto, od_cil_perto, od_eixo_perto, od_dnp_perto, oe_esf_perto, oe_cil_perto, oe_eixo_perto, oe_dnp_perto) 
                    VALUES 
                    (@IdCliente, @IdLaboratorio, @IdDoutor, @DataRecebimento, @DataCadastro, @DataUltimaAlteracao, 
                    @OdEsfLonge, @OdCilLonge, @OdEixoLonge, @OdDnpLonge, @OdAdicaoLonge, @OdAlturaLonge, 
                    @EdEsfLonge, @EdCilLonge, @EdEixoLonge, @EdDnpLonge, @EdAdicaoLonge, @EdAlturaLonge, 
                    @OdEsfPerto, @OdCilPerto, @OdEixoPerto, @OdDnpPerto, @OeEsfPerto, @OeCilPerto, @OeEixoPerto, @OeDnpPerto);
                    SELECT SCOPE_IDENTITY();"; // Retorna o último ID inserido na mesma sessão de conexão

            try
            {
                // Parâmetros da query
                List<SqlParameter> parametros = new List<SqlParameter>()
                {
                    new SqlParameter("@IdCliente", receita.Cliente.ID),
                    new SqlParameter("@IdLaboratorio", receita.Laboratorio.ID),
                    new SqlParameter("@IdDoutor", receita.Doutor.ID),
                    new SqlParameter("@DataRecebimento", receita.DataRecebimento),
                    new SqlParameter("@DataCadastro", DateTime.Now),
                    new SqlParameter("@DataUltimaAlteracao", DateTime.Now),
                    new SqlParameter("@OdEsfLonge", receita.OdEsfLonge),
                    new SqlParameter("@OdCilLonge", receita.OdCilLonge),
                    new SqlParameter("@OdEixoLonge", receita.OdEixoLonge),
                    new SqlParameter("@OdDnpLonge", receita.OdDnpLonge),
                    new SqlParameter("@OdAdicaoLonge", receita.OdAdicaoLonge),
                    new SqlParameter("@OdAlturaLonge", receita.OdAlturaLonge),
                    new SqlParameter("@EdEsfLonge", receita.EdEsfLonge),
                    new SqlParameter("@EdCilLonge", receita.EdCilLonge),
                    new SqlParameter("@EdEixoLonge", receita.EdEixoLonge),
                    new SqlParameter("@EdDnpLonge", receita.EdDnpLonge),
                    new SqlParameter("@EdAdicaoLonge", receita.EdAdicaoLonge),
                    new SqlParameter("@EdAlturaLonge", receita.EdAlturaLonge),
                    new SqlParameter("@OdEsfPerto", receita.OdEsfPerto),
                    new SqlParameter("@OdCilPerto", receita.OdCilPerto),
                    new SqlParameter("@OdEixoPerto", receita.OdEixoPerto),
                    new SqlParameter("@OdDnpPerto", receita.OdDnpPerto),
                    new SqlParameter("@OeEsfPerto", receita.OeEsfPerto),
                    new SqlParameter("@OeCilPerto", receita.OeCilPerto),
                    new SqlParameter("@OeEixoPerto", receita.OeEixoPerto),
                    new SqlParameter("@OeDnpPerto", receita.OeDnpPerto)
                };

                Banco banco = new Banco();
                using (SqlConnection connection = banco.Abrir())
                {
                    using (SqlCommand command = new SqlCommand(sqlInsertReceita, connection))
                    {
                        command.Parameters.AddRange(parametros.ToArray());
                        int ultimoID = Convert.ToInt32(command.ExecuteScalar());

                        // Agora, insira o registro em ReceitaClientes
                        ReceitaClientes receitaCliente = new ReceitaClientes();
                        CTLReceitaClientes ctlReceitaClientes = new CTLReceitaClientes();

                        receitaCliente.Cliente.ID = receita.Cliente.ID;
                        receitaCliente.Receita.ID = ultimoID;

                        ctlReceitaClientes.AdicionarReceitaCliente(receitaCliente);
                        return "OK";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                return "ERRO" + ex.Message;
            }

        }



      /*  public string AdicionarReceita(Receita receita) // funcional, apenas para receita sem receitaClientes.
        {
            try
            {
                string query = @"INSERT INTO tb_Receitas 
                         (id_cliente, id_laboratorio, id_doutor, data_recebimento, data_cadastro, data_ultima_alteracao, 
                         od_esf_longe, od_cil_longe, od_eixo_longe, od_dnp_longe, od_adicao_longe, od_altura_longe, 
                         ed_esf_longe, ed_cil_longe, ed_eixo_longe, ed_dnp_longe, ed_edadicao_longe, ed_altura_longe, 
                         od_esf_perto, od_cil_perto, od_eixo_perto, od_dnp_perto, oe_esf_perto, oe_cil_perto, oe_eixo_perto, oe_dnp_perto) 
                         VALUES 
                         (@IdCliente, @IdLaboratorio, @IdDoutor, @DataRecebimento, @DataCadastro, @DataUltimaAlteracao, 
                         @OdEsfLonge, @OdCilLonge, @OdEixoLonge, @OdDnpLonge, @OdAdicaoLonge, @OdAlturaLonge, 
                         @EdEsfLonge, @EdCilLonge, @EdEixoLonge, @EdDnpLonge, @EdAdicaoLonge, @EdAlturaLonge, 
                         @OdEsfPerto, @OdCilPerto, @OdEixoPerto, @OdDnpPerto, @OeEsfPerto, @OeCilPerto, @OeEixoPerto, @OeDnpPerto)";

                List<SqlParameter> parametros = new List<SqlParameter>()
                 {
                     new SqlParameter("@IdCliente", receita.Cliente.ID),
                     new SqlParameter("@IdLaboratorio", receita.Laboratorio.ID),
                     new SqlParameter("@IdDoutor", receita.Doutor.ID),
                   //  new SqlParameter("@Pedido", receita.Pedido  ),
                     new SqlParameter("@DataRecebimento", receita.DataRecebimento  ),
                     new SqlParameter("@DataCadastro", DateTime.Now),
                     new SqlParameter("@DataUltimaAlteracao", DateTime.Now),
                     new SqlParameter("@OdEsfLonge", receita.OdEsfLonge  ),
                     new SqlParameter("@OdCilLonge", receita.OdCilLonge  ),
                     new SqlParameter("@OdEixoLonge", receita.OdEixoLonge  ),
                     new SqlParameter("@OdDnpLonge", receita.OdDnpLonge  ),
                     new SqlParameter("@OdAdicaoLonge", receita.OdAdicaoLonge  ),
                     new SqlParameter("@OdAlturaLonge", receita.OdAlturaLonge  ),
                     new SqlParameter("@EdEsfLonge", receita.EdEsfLonge  ),
                     new SqlParameter("@EdCilLonge", receita.EdCilLonge  ),
                     new SqlParameter("@EdEixoLonge", receita.EdEixoLonge  ),
                     new SqlParameter("@EdDnpLonge", receita.EdDnpLonge  ),
                     new SqlParameter("@EdAdicaoLonge", receita.EdAdicaoLonge  ),
                     new SqlParameter("@EdAlturaLonge", receita.EdAlturaLonge  ),
                     new SqlParameter("@OdEsfPerto", receita.OdEsfPerto  ),
                     new SqlParameter("@OdCilPerto", receita.OdCilPerto  ),
                     new SqlParameter("@OdEixoPerto", receita.OdEixoPerto  ),
                     new SqlParameter("@OdDnpPerto", receita.OdDnpPerto  ),
                     new SqlParameter("@OeEsfPerto", receita.OeEsfPerto  ),
                     new SqlParameter("@OeCilPerto", receita.OeCilPerto  ),
                     new SqlParameter("@OeEixoPerto", receita.OeEixoPerto  ),
                     new SqlParameter("@OeDnpPerto", receita.OeDnpPerto  )
                 };

                Banco banco = new Banco(); // Instanciando a classe do banco
                banco.ExecutarComando(query, parametros.ToArray()); // Executando o comando SQL com a classe do banco

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }*/

        public string AtualizarReceita(Receita receita)
        {
            try
            {
                string query = @"UPDATE tb_Receitas SET 
                        id_cliente = @IdCliente,
                        id_laboratorio = @IdLaboratorio,
                        id_doutor = @IdDoutor,
                        data_recebimento = @DataRecebimento,
                        data_ultima_alteracao = @DataUltimaAlteracao,
                        od_esf_longe = @OdEsfLonge,
                        od_cil_longe = @OdCilLonge,
                        od_eixo_longe = @OdEixoLonge,
                        od_dnp_longe = @OdDnpLonge,
                        od_adicao_longe = @OdAdicaoLonge,
                        od_altura_longe = @OdAlturaLonge,
                        ed_esf_longe = @EdEsfLonge,
                        ed_cil_longe = @EdCilLonge,
                        ed_eixo_longe = @EdEixoLonge,
                        ed_dnp_longe = @EdDnpLonge,
                        ed_edadicao_longe = @EdAdicaoLonge,
                        ed_altura_longe = @EdAlturaLonge,
                        od_esf_perto = @OdEsfPerto,
                        od_cil_perto = @OdCilPerto,
                        od_eixo_perto = @OdEixoPerto,
                        od_dnp_perto = @OdDnpPerto,
                        oe_esf_perto = @OeEsfPerto,
                        oe_cil_perto = @OeCilPerto,
                        oe_eixo_perto = @OeEixoPerto,
                        oe_dnp_perto = @OeDnpPerto
                        WHERE id_receita = @IdReceita";

                List<SqlParameter> parametros = new List<SqlParameter>()
                {
                    new SqlParameter("@IdCliente", receita.Cliente.ID),
                    new SqlParameter("@IdLaboratorio", receita.Laboratorio.ID),
                    new SqlParameter("@IdDoutor", receita.Doutor.ID),
                  //  new SqlParameter("@Pedido", receita.Pedido  ),
                    new SqlParameter("@DataRecebimento", receita.DataRecebimento  ),
                    new SqlParameter("@DataUltimaAlteracao", DateTime.Now),
                    new SqlParameter("@OdEsfLonge", receita.OdEsfLonge),
                    new SqlParameter("@OdCilLonge", receita.OdCilLonge),
                    new SqlParameter("@OdEixoLonge", receita.OdEixoLonge),
                    new SqlParameter("@OdDnpLonge", receita.OdDnpLonge),
                    new SqlParameter("@OdAdicaoLonge", receita.OdAdicaoLonge),
                    new SqlParameter("@OdAlturaLonge", receita.OdAlturaLonge),
                    new SqlParameter("@EdEsfLonge", receita.EdEsfLonge),
                    new SqlParameter("@EdCilLonge", receita.EdCilLonge),
                    new SqlParameter("@EdEixoLonge", receita.EdEixoLonge),
                    new SqlParameter("@EdDnpLonge", receita.EdDnpLonge),
                    new SqlParameter("@EdAdicaoLonge", receita.EdAdicaoLonge),
                    new SqlParameter("@EdAlturaLonge", receita.EdAlturaLonge),
                    new SqlParameter("@OdEsfPerto", receita.OdEsfPerto),
                    new SqlParameter("@OdCilPerto", receita.OdCilPerto),
                    new SqlParameter("@OdEixoPerto", receita.OdEixoPerto),
                    new SqlParameter("@OdDnpPerto", receita.OdDnpPerto),
                    new SqlParameter("@OeEsfPerto", receita.OeEsfPerto),
                    new SqlParameter("@OeCilPerto", receita.OeCilPerto),
                    new SqlParameter("@OeEixoPerto", receita.OeEixoPerto),
                    new SqlParameter("@OeDnpPerto", receita.OeDnpPerto),
                    new SqlParameter("@IdReceita", receita.ID)
                };

                // Executar o comando
                banco.ExecutarComando(query, parametros.ToArray());

                return "OK"; // Retorna OK caso a execução seja bem sucedida
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao atualizar Receita", ex);
                return "Erro ao atualizar Receita: " + ex.Message; // Retorna mensagem de erro em caso de falha
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar Receita", ex);
                return "Erro ao atualizar Receita: " + ex.Message; // Retorna mensagem de erro em caso de falha
            }
        }

        public bool ExcluirReceita(int idReceita)
        {
            try
            {
                string query = "DELETE FROM tb_Receitas WHERE id_receita = @IdReceita";

                List<SqlParameter> parametros = new List<SqlParameter>()
        {
            new SqlParameter("@IdReceita", idReceita)
        };

                // Executar o comando
                banco.ExecutarComando(query, parametros.ToArray());

                return true;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao excluir Receita", ex);
                return false;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao excluir Receita", ex);
                return false;
            }
        }

        public Receita BuscarReceitaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_Receitas WHERE id_receita = @Id";

                List<SqlParameter> parametros = new List<SqlParameter>()
                {
                    new SqlParameter("@Id", id)
                };

                // Executar o comando
                DataTable dataTable = banco.ExecutarConsulta(query, parametros.ToArray());

                // Verificar se a consulta retornou algum resultado
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreateReceitaFromDataRow(row);
                }

                return null;
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao buscar Receita por ID", ex);
                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar Receita por ID", ex);
                return null;
            }
        }
        public List<Receita> ListarReceitas()
        {
            try
            {
                string sql = "SELECT * FROM tb_Receitas";
                List<SqlParameter> parametros = new List<SqlParameter>();

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros.ToArray());
                return CreateReceitasListFromDataTable(dataTable);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar receitas", ex);
                return new List<Receita>();
            }
        }


        private Receita CreateReceitaFromDataRow(DataRow row)
        {
            CTLLaboratorios aCTLLab = new CTLLaboratorios();
            CTLClientes aCTLCliente = new CTLClientes();
            CTLDoutores aCTLDoutor = new CTLDoutores();
            Laboratorio lab = aCTLLab.BuscarLaboratorioPorId(Convert.ToInt32(row["id_laboratorio"]));
            Clientes cli = aCTLCliente.BuscarClientePorId(Convert.ToInt32(row["id_cliente"]));
            Doutor dout = aCTLDoutor.BuscarDoutorPorId(Convert.ToInt32(row["id_doutor"]));

            return new Receita
            {
                ID = Convert.ToInt32(row["id_receita"]),
                Laboratorio = lab,
                Cliente = cli,
                Doutor = dout,
                // Pedido = row["pedido"].ToString(),
                DataRecebimento = row["data_recebimento"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(row["data_recebimento"]),
                DataCriacao = Convert.ToDateTime(row["data_cadastro"]),
                DataUltimaAlteracao = Convert.ToDateTime(row["data_ultima_alteracao"]),
                OdEsfLonge = Convert.ToDecimal(row["od_esf_longe"]),
                OdCilLonge = Convert.ToDecimal(row["od_cil_longe"]),
                OdEixoLonge = Convert.ToDecimal(row["od_eixo_longe"]),
                OdDnpLonge = Convert.ToDecimal(row["od_dnp_longe"]),
                OdAdicaoLonge = Convert.ToDecimal(row["od_adicao_longe"]),
                OdAlturaLonge = Convert.ToDecimal(row["od_altura_longe"]),
                EdEsfLonge = Convert.ToDecimal(row["ed_esf_longe"]),
                EdCilLonge = Convert.ToDecimal(row["ed_cil_longe"]),
                EdEixoLonge = Convert.ToDecimal(row["ed_eixo_longe"]),
                EdDnpLonge = Convert.ToDecimal(row["ed_dnp_longe"]),
                EdAdicaoLonge = Convert.ToDecimal(row["ed_edadicao_longe"]),
                EdAlturaLonge = Convert.ToDecimal(row["ed_altura_longe"]),
                OdEsfPerto = Convert.ToDecimal(row["od_esf_perto"]),
                OdCilPerto = Convert.ToDecimal(row["od_cil_perto"]),
                OdEixoPerto = Convert.ToDecimal(row["od_eixo_perto"]),
                OdDnpPerto = Convert.ToDecimal(row["od_dnp_perto"]),
                OeEsfPerto = Convert.ToDecimal(row["oe_esf_perto"]),
                OeCilPerto = Convert.ToDecimal(row["oe_cil_perto"]),
                OeEixoPerto = Convert.ToDecimal(row["oe_eixo_perto"]),
                OeDnpPerto = Convert.ToDecimal(row["oe_dnp_perto"])
            };
        }

        private List<Receita> CreateReceitasListFromDataTable(DataTable dataTable)
        {
            List<Receita> receitas = new List<Receita>();
            foreach (DataRow row in dataTable.Rows)
            {
                receitas.Add(CreateReceitaFromDataRow(row));
            }
            return receitas;
        }
        public List<Receita> PesquisarReceitasPorCriterio(string criterio, string valorPesquisa)
        {
            List<Receita> receitasEncontradas = new List<Receita>();

            try
            {
                string query = string.Empty;
                SqlParameter parametro = new SqlParameter();

                // Constrói a consulta SQL baseada no critério de pesquisa
                if (criterio == "LABORATORIO")
                {
                    query = "SELECT r.* FROM tb_Receitas r JOIN tb_Laboratorio l ON r.id_laboratorio = l.id_laboratorio WHERE l.nome LIKE @ValorPesquisa";
                    parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                }
                else if (criterio == "CLIENTE")
                {
                    query = "SELECT r.* FROM tb_Receitas r JOIN tb_Clientes c ON r.id_cliente = c.id_cliente WHERE c.nome LIKE @ValorPesquisa";
                    parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                }
                else if (criterio == "DOUTOR")
                {
                    query = "SELECT r.* FROM tb_Receitas r JOIN tb_Doutores d ON r.id_doutor = d.id_doutor WHERE d.nome LIKE @ValorPesquisa";
                    parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                }
                else if (criterio == "ID")
                {
                    query = "SELECT * FROM tb_Receitas WHERE id_receita = @ValorPesquisa";
                    parametro = new SqlParameter("@ValorPesquisa", valorPesquisa);
                }

                // Executa a consulta SQL e preenche a lista de receitas encontradas
                if (!string.IsNullOrEmpty(query))
                {
                    DataTable dataTable = banco.ExecutarConsulta(query, new SqlParameter[] { parametro });

                    foreach (DataRow row in dataTable.Rows)
                    {
                        Receita receita = CreateReceitaFromDataRow(row);
                        receitasEncontradas.Add(receita);
                    }
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar receitas por critério", ex);
                return null;
            }

            return receitasEncontradas;
        }


    }
}
