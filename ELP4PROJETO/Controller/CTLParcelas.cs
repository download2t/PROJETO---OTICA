using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;

namespace test.Controllers
{
    public class CTLParcelas
    {
        private Parcela Parcelas = new Parcela();
        private DALParcelas parcelasDAL = new DALParcelas();

        public string AdicionarParcela(Parcela parcela)
        {
            return parcelasDAL.AdicionarParcela(parcela);
        }

        public bool AtualizarParcela(Parcela parcela)
        {
            return parcelasDAL.AtualizarParcela(parcela);
        }

        public bool ExcluirParcela(int idCondicao, int numParcela, int idForma)
        {
            return parcelasDAL.ExcluirParcela(idCondicao, numParcela, idForma);
        }

        public List<Parcela> ListarParcelas()
        {
            return parcelasDAL.ListarParcelas();
        }
        public Parcela BuscarParcelaPorId(int idCondicao, int numParcela, int idForma)
        {
            return parcelasDAL.BuscarParcelaPorId(idCondicao, numParcela, idForma);
        }
        public bool SalvarParcelas(Parcela parcelas)
        {
            Parcelas = parcelas;
            return parcelasDAL.SalvarParcelas(parcelas);
        }
        public List<Parcela> BuscarParcelasPorIDCondicao(int idCondicao)
        {
            return parcelasDAL.BuscarParcelasPorIDCondicao(idCondicao);
        }



    }
}
