using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELP4PROJETO.DATA
{
    internal class Banco
    {
        private static string connectionString = @"Data Source=172.16.10.200\SQLEXPRESS;Initial Catalog=db_otica;Persist Security Info=True;User ID=sa;Password=macaco21";
        //private static string connectionString = @"Data Source=BARROSNOTE\SQLEXPRESS;Initial Catalog=db_otica;Persist Security Info=True;User ID=sa;Password=c10437bf";

        public SqlConnection Abrir()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                return cnn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro SQL ao abrir a conexão. Detalhes: " + ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao abrir a conexão. Detalhes: " + ex.Message);
                return null;
            }
        }

        public void Fechar(SqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro SQL ao fechar a conexão. Detalhes: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao fechar a conexão. Detalhes: " + ex.Message);
            }
        }
        // Método para executar o comando dentro de uma transação
    
        public void ExecutarComando(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (SqlException ex) when (ex.Number == 547) // Código de erro para violação de chave estrangeira
                {
                    MessageBox.Show("Não é possível excluir este registo porque está vinculado a outros serviços.",
                                    "Erro de Exclusão",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
      

        public object ExecutarComandoScalar(string sql, SqlParameter[] parameters)
        {
            object result = null;

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        result = command.ExecuteScalar();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar o comando no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }



        public DataTable ExecutarConsulta(string sql, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = Abrir())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection, transaction))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocorreu um erro ao executar a consulta no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }
    }
}