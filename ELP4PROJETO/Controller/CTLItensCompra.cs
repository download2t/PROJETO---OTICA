using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using System;
using System.Collections.Generic;

namespace test.Controllers
{
    public class CTLItensCompra
    {
        private DALItemCompra itensCompraDAL = new DALItemCompra();
        private ItemCompra item = new ItemCompra();


        public bool AdicionarItemCompra(ItemCompra itemCompra)
        {
            return itensCompraDAL.AdicionarItemCompra(itemCompra);
        }

        public ItemCompra BuscarItemCompraPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor, int idProduto)
        {
            return itensCompraDAL.BuscarItemCompraPorChave(numNFC, modeloNFC, serieNFC, idFornecedor, idProduto);
        }

        public List<ItemCompra> BuscarItemCompraPorChave2(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            return itensCompraDAL.BuscarItemCompraPorChave2(numNFC, modeloNFC, serieNFC, idFornecedor);
        }

        public List<ItemCompra> ListarItensCompra()
        {
            return itensCompraDAL.ListarItensCompra();
        }

    }
}
