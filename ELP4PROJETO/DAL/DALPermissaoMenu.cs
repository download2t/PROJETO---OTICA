using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DATA;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using test.Controllers;

namespace ELP4PROJETO.Data
{
    public class DALPermissaoMenu
    {
        private Banco banco = new Banco();
        Operacao operacao = new Operacao();

        public static bool OpcaoLiberada(string opcao, List<PermissaoMenu> usuarioAcessos, Func<PermissaoMenu, bool> propriedade)
        {
            foreach (var item in usuarioAcessos)
            {
                if (item.Opcao.Nome == opcao)
                {
                    return propriedade(item);
                }
            }
            return false;
        }

        // Métodos específicos chamando o método genérico para verificar diferentes propriedades booleanas
        public bool OpcaoLiberadaAdicionar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeAdicionar);
        }

        public bool OpcaoLiberadaAlterar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeAlterar);
        }

        public bool OpcaoLiberadaExcluir(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeExcluir);
        }

        public bool OpcaoLiberadaConsultar(string opcao, List<PermissaoMenu> usuarioAcessos)
        {
            return OpcaoLiberada(opcao, usuarioAcessos, x => x.PodeConsultar);
        }

        public void AdicionarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            try
            {
                string sql = "INSERT INTO tb_PermissaoMenu (FuncionarioId, MenuOpcaoId, PodeAdicionar, PodeAlterar, PodeExcluir, PodeConsultar) " +
                             "VALUES (@FuncionarioId, @MenuOpcaoId, @PodeAdicionar, @PodeAlterar, @PodeExcluir, @PodeConsultar)";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@FuncionarioId", permissaoMenu.Funcionario.ID),
                    new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.ID),
                    new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                    new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                    new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                    new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao adicionar permissão de menu", ex);
            }
        }

        public void AtualizarPermissaoMenu(PermissaoMenu permissaoMenu)
        {
            try
            {
                string sql = "UPDATE tb_PermissaoMenu " +
                             "SET PodeAdicionar = @PodeAdicionar, PodeAlterar = @PodeAlterar, " +
                             "PodeExcluir = @PodeExcluir, PodeConsultar = @PodeConsultar " +
                             "WHERE FuncionarioId = @FuncionarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@FuncionarioId", permissaoMenu.Funcionario.ID),
                    new SqlParameter("@MenuOpcaoId", permissaoMenu.Opcao.ID),
                    new SqlParameter("@PodeAdicionar", permissaoMenu.PodeAdicionar),
                    new SqlParameter("@PodeAlterar", permissaoMenu.PodeAlterar),
                    new SqlParameter("@PodeExcluir", permissaoMenu.PodeExcluir),
                    new SqlParameter("@PodeConsultar", permissaoMenu.PodeConsultar)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao atualizar permissão de menu", ex);
            }
        }

        public void RemoverPermissaoMenu(int funcionarioId, int menuOpcaoId)
        {
            try
            {
                string sql = "DELETE FROM tb_PermissaoMenu WHERE FuncionarioId = @FuncionarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
                    new SqlParameter("@FuncionarioId", funcionarioId),
                    new SqlParameter("@MenuOpcaoId", menuOpcaoId)
                };

                banco.ExecutarComando(sql, parametros);
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao remover permissão de menu", ex);
            }
        }

        public PermissaoMenu ObterPermissaoMenu(int funcionarioId, int menuOpcaoId)
        {
            try
            {
                string sql = "SELECT * FROM tb_PermissaoMenu WHERE FuncionarioId = @FuncionarioId AND MenuOpcaoId = @MenuOpcaoId";

                SqlParameter[] parametros =
                {
            new SqlParameter("@FuncionarioId", funcionarioId),
            new SqlParameter("@MenuOpcaoId", menuOpcaoId)
        };

                DataTable dataTable = banco.ExecutarConsulta(sql, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return CreatePermissaoMenuFromDataRow(row);
                }

                return null;
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter permissão de menu", ex);
                return null;
            }
        }


        public List<PermissaoMenu> ObterPermissoesPorUsuario(int funcionarioId)
        {
            List<PermissaoMenu> listaPermissoes = new List<PermissaoMenu>();

            try
            {
                string sql = @"SELECT mo.Id_menu AS id, mo.Nome AS nomeOpcao, mo.Descricao AS descricaoOpcao, mo.Nivel, 
                       pm.PodeAdicionar, pm.PodeAlterar, pm.PodeExcluir, pm.PodeConsultar
                       FROM tb_MenuOpcoes mo
                       LEFT JOIN tb_PermissaoMenu pm ON mo.Id_menu = pm.MenuOpcaoId AND pm.FuncionarioId = @FuncionarioId";

                SqlParameter parametro = new SqlParameter("@FuncionarioId", funcionarioId);

                DataTable dataTable = banco.ExecutarConsulta(sql, new[] { parametro });

                foreach (DataRow row in dataTable.Rows)
                {
                    listaPermissoes.Add(CreatePermissaoMenuFromDataRow(row));
                }
            }
            catch (Exception ex)
            {
                operacao.HandleException("Erro ao obter permissões do usuário", ex);
            }

            return listaPermissoes;
        }

        private PermissaoMenu CreatePermissaoMenuFromDataRow(DataRow row)
        {
            CTLOpcoes aCTLOpcoes = new CTLOpcoes();
            Opcoes opcao = aCTLOpcoes.BuscarOpcaoPorID((int)row["MenuOpcaoId"]);

            return new PermissaoMenu
            {
                Funcionario = new Funcionarios { ID = Convert.ToInt32(row["FuncionarioId"]) },
                Opcao = opcao,
                PodeAdicionar = Convert.ToBoolean(row["PodeAdicionar"]),
                PodeAlterar = Convert.ToBoolean(row["PodeAlterar"]),
                PodeExcluir = Convert.ToBoolean(row["PodeExcluir"]),
                PodeConsultar = Convert.ToBoolean(row["PodeConsultar"])
            };
        }
        private List<PermissaoMenu> CreatePermissaoMenuListFromDataTable(DataTable dataTable)
        {
            List<PermissaoMenu> permissoes = new List<PermissaoMenu>();
            foreach (DataRow row in dataTable.Rows)
            {
                permissoes.Add(CreatePermissaoMenuFromDataRow(row));
            }
            return permissoes;
        }


    }
}
