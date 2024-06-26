using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;

namespace test.Controllers
{
    public class CTLReceitaClientes
    {
        private DALReceitaClientes receitaClientesDAL = new DALReceitaClientes();

        public string AdicionarReceitaCliente(ReceitaClientes receitaCliente)
        {
            return receitaClientesDAL.AdicionarReceitaCliente(receitaCliente);
        }

        public string AtualizarReceitaCliente(ReceitaClientes receitaCliente)
        {
            return receitaClientesDAL.AtualizarReceitaCliente(receitaCliente);
        }

        public bool ExcluirReceitaCliente(int receitaClienteId)
        {
            return receitaClientesDAL.ExcluirReceitaCliente(receitaClienteId);
        }

        public ReceitaClientes BuscarReceitaClientePorId(int id)
        {
            return receitaClientesDAL.BuscarReceitaClientePorId(id);
        }

        public List<ReceitaClientes> ListarReceitasClientes()
        {
            return receitaClientesDAL.ListarReceitasClientes();
        }

        public List<ReceitaClientes> PesquisarReceitasClientesPorCriterio(string criterio, string valorPesquisa)
        {
            return receitaClientesDAL.PesquisarReceitasClientesPorCriterio(criterio, valorPesquisa);
        }

    }
}