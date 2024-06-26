using ELP4PROJETO.Classes;
using ELP4PROJETO.Controllers;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using System.Collections.Generic;

namespace test.Controllers
{
    public class CTLItemVenda
    {
        private DALItemVenda itensVendaDAL = new DALItemVenda();

        public bool AdicionarItemVenda(ItemVenda itemVenda)
        {
            return itensVendaDAL.AdicionarItemVenda(itemVenda);
        }
        public ItemVenda BuscarItemVendaPorChave(int numNF, int modeloNF, int serieNF, int idCliente, int idProduto, string tipoItem)
        {
            return itensVendaDAL.BuscarItemVendaPorChave(numNF, modeloNF, serieNF, idCliente, idProduto, tipoItem);
        }
        public List<ItemVenda> BuscarItensVendaPorChave2(int numNF, int modeloNF, int serieNF, int idCliente)
        {
            return itensVendaDAL.BuscarItensVendaPorChave2(numNF, modeloNF, serieNF, idCliente);
        }
        public List<ItemVenda> ListarItensVenda()
        {
            return itensVendaDAL.ListarItensVenda();
        }
    }
}
