using ELP4PROJETO.Models;
using System;

namespace ELP4PROJETO.Classes
{
    public class Receita : Pai
    {
        public Clientes Cliente { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public Doutor Doutor { get; set; }
        public string Pedido { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public decimal OdEsfLonge { get; set; }
        public decimal OdCilLonge { get; set; }
        public decimal OdEixoLonge { get; set; }
        public decimal OdDnpLonge { get; set; }
        public decimal OdAdicaoLonge { get; set; }
        public decimal OdAlturaLonge { get; set; }
        public decimal EdEsfLonge { get; set; }
        public decimal EdCilLonge { get; set; }
        public decimal EdEixoLonge { get; set; }
        public decimal EdDnpLonge { get; set; }
        public decimal EdAdicaoLonge { get; set; }
        public decimal EdAlturaLonge { get; set; }
        public decimal OdEsfPerto { get; set; }
        public decimal OdCilPerto { get; set; }
        public decimal OdEixoPerto { get; set; }
        public decimal OdDnpPerto { get; set; }
        public decimal OeEsfPerto { get; set; }
        public decimal OeCilPerto { get; set; }
        public decimal OeEixoPerto { get; set; }
        public decimal OeDnpPerto { get; set; }

        public Receita() : base()
        {
            Cliente = new Clientes();
            Laboratorio = new Laboratorio();
            Doutor = new Doutor();
            Pedido = "";
            DataRecebimento = DateTime.Now;
            OdEsfLonge = 0;
            OdCilLonge = 0;
            OdEixoLonge = 0;
            OdDnpLonge = 0;
            OdAdicaoLonge = 0;
            OdAlturaLonge = 0;
            EdEsfLonge = 0;
            EdCilLonge = 0;
            EdEixoLonge = 0;
            EdDnpLonge = 0;
            EdAdicaoLonge = 0;
            EdAlturaLonge = 0;
            OdEsfPerto = 0;
            OdCilPerto = 0;
            OdEixoPerto = 0;
            OdDnpPerto = 0;
            OeEsfPerto = 0;
            OeCilPerto = 0;
            OeEixoPerto = 0;
            OeDnpPerto = 0;
        }

        public Receita(decimal odEsfLonge, decimal odCilLonge, decimal odEixoLonge, decimal odDnpLonge, decimal odAdicaoLonge,
           decimal odAlturaLonge, decimal edEsfLonge, decimal edCilLonge, decimal edEixoLonge, decimal edDnpLonge, decimal edAdicaoLonge,
           decimal edAlturaLonge, decimal odEsfPerto, decimal odCilPerto, decimal odEixoPerto, decimal odDnpPerto, decimal oeEsfPerto,
           decimal oeCilPerto, decimal oeEixoPerto, decimal oeDnpPerto, int id, DateTime data_cadastro, DateTime ultima_alteracao) : base(id, data_cadastro, ultima_alteracao)
        {
            OdEixoLonge = odEsfLonge;
            OdCilLonge = odCilLonge;
            OdEixoLonge = odEixoLonge;
            OdDnpLonge = odDnpLonge;
            OdAdicaoLonge = odAdicaoLonge;
            OdAlturaLonge = odAlturaLonge;
            EdEsfLonge = edEsfLonge;
            EdCilLonge = edCilLonge;
            EdEixoLonge = edEixoLonge;
            EdDnpLonge = edDnpLonge;
            EdAdicaoLonge = edAdicaoLonge;
            EdAlturaLonge = edAlturaLonge;
            OdEsfPerto = odEsfPerto;
            OdCilPerto = odCilPerto;
            OdEixoPerto = odEixoPerto;
            OdDnpPerto = odDnpPerto;
            OeEsfPerto = oeEsfPerto;
            OeCilPerto = oeCilPerto;
            OeEixoPerto = oeEixoPerto;
            OeDnpPerto = oeDnpPerto;
        }
    }
}
