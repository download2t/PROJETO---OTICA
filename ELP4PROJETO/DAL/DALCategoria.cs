using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models.Others;

namespace ELP4PROJETO.Data
{
    public class DALCategoria
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();

        public void AdicionarCategoria(Categoria Categoria)
        {
            try
            {
                string sql = "INSERT INTO tb_categorias (Nome";
                List<string> colunas = new List<string>() { "@Nome" };
                List<object> valores = new List<object>() { Categoria.Nome };

                // Verifica se a foto está presente
                if (Categoria.Foto != null)
                {
                    sql += ", Foto";
                    colunas.Add("@Foto");
                    valores.Add(Categoria.Foto);
                }

                sql += ") VALUES (" + string.Join(", ", colunas) + ")";
                SqlParameter[] parametros = colunas.Zip(valores, (coluna, valor) => new SqlParameter(coluna, valor)).ToArray();
                banco.ExecutarComando(sql, parametros);
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao adicionar Categoria", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar Categoria", ex);
            }
        }

        public void AtualizarCategoria(Categoria Categoria)
        {
            try
            {
                string sql = "UPDATE tb_categorias SET Nome = @Nome";
                List<SqlParameter> parametros = new List<SqlParameter>()
                 {
                     new SqlParameter("@Nome", Categoria.Nome),
                     new SqlParameter("@Id", Categoria.ID)
                 };

                // Verifica se a foto está presente
                if (Categoria.Foto != null)
                {
                    sql += ", Foto = @Foto";
                    parametros.Add(new SqlParameter("@Foto", Categoria.Foto));
                }

                sql += " WHERE Id = @Id";

                banco.ExecutarComando(sql, parametros.ToArray());
            }
            catch (SqlException ex)
            {
                operacao.HandleException("Erro ao atualizar Categoria", ex);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar Categoria", ex);
            }
        }


        public Categoria BuscarCategoriaPorId(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_categorias WHERE Id = @Id";
                SqlParameter parametro = new SqlParameter("@Id", id);
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new Categoria
                    {
                        ID = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString(),
                        Foto = row["Foto"] != DBNull.Value ? (byte[])row["Foto"] : null
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar Categoria por ID", ex);
                return null;
            }
        }
        public List<Categoria> BuscarCategoriaPorNome(string valorPesquisa)
        {
            try
            {
                string query = "SELECT * FROM tb_categorias WHERE Nome LIKE @ValorPesquisa";
                SqlParameter parametro = new SqlParameter("@ValorPesquisa", "%" + valorPesquisa + "%");
                DataTable dataTable = banco.ExecutarConsulta(query, new[] { parametro });

                List<Categoria> Categoria = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Categoria.Add(new Categoria
                    {
                        ID = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString(),
                        Foto = row["Foto"] != DBNull.Value ? (byte[])row["Foto"] : null
                    });
                }

                return Categoria;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao buscar Categoria por nome", ex);
                return new List<Categoria>();
            }
        }
        public List<Categoria> ListarCategoria()
        {
            try
            {
                string sql = "SELECT * FROM tb_categorias ORDER BY Id ASC"; // Ordena os Categoria pelo ID em ordem ascendente
                DataTable dataTable = banco.ExecutarConsulta(sql, null);

                List<Categoria> Categoria = new List<Categoria>();
                foreach (DataRow row in dataTable.Rows)
                {
                    Categoria.Add(new Categoria
                    {
                        ID = Convert.ToInt32(row["Id"]),
                        Nome = row["Nome"].ToString(),
                        Foto = row["Foto"] != DBNull.Value ? (byte[])row["Foto"] : null
                    });
                }

                return Categoria;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao listar Categoria", ex);
                return new List<Categoria>();
            }
        }



        public bool ExcluirCategoria(int CategoriaId)
        {
            try
            {
                string sql = "DELETE FROM tb_categorias WHERE Id = @Id";
                SqlParameter[] parametros = { new SqlParameter("@Id", CategoriaId) };
                banco.ExecutarComando(sql, parametros);
                return true;
            }
            catch (SqlException ex)
            {

                if (operacao.IsForeignKeyViolation(ex))
                {
                    MessageBox.Show("Não foi possível excluir o Categoria selecionado, pois ele está sendo utilizado em outros registros." +
                        " Por favor, remova todas as referências deste Categoria em outros registros antes de tentar excluí-lo novamente.");
                }
                else
                {
                    // Outro tratamento de exceção, se necessário
                    operacao.HandleException("Erro ao excluir Categoria", ex);
                }
                return false;
            }
        }
    }
}
