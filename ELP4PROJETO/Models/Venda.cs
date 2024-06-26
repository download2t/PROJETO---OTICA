using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class Venda : Pai
    {
        private int _numNfv;
        private int _modeloNfv;
        private int _serieNfv;
        private Clientes _cliente;
        private CondicaoPagamento _condicaoPagamento;
        private decimal _valorTotal;
        private decimal _valorFrete;
        private decimal _valorSeguro;
        private decimal _valorOutrasDespesas;
        private DateTime _dataSaida;
        private DateTime _dataEmissao;
        private DateTime? _dataCancelamento;
        private List<ItemVenda> _itensVenda;

        public Venda() : base()
        {
            _cliente = new Clientes();
            _condicaoPagamento = new CondicaoPagamento();
            _numNfv = 0;
            _modeloNfv = 0;
            _serieNfv = 0;
            _valorTotal = 0.0m;
            _valorFrete = 0.0m;
            _valorSeguro = 0.0m;
            _valorOutrasDespesas = 0.0m;
            _dataSaida = DateTime.MinValue;
            _dataEmissao = DateTime.MinValue;
            _dataCancelamento = null;
            _itensVenda = new List<ItemVenda>();
        }

        public Venda(List<ItemVenda> itensVenda, int numNfv, int modeloNfv, int serieNfv, Clientes cliente, CondicaoPagamento condicaoPagamento,
                     decimal valorTotal, decimal valorFrete, decimal valorSeguro, decimal valorOutrasDespesas,
                     DateTime dataSaida, DateTime dataEmissao, DateTime? dataCancelamento, DateTime dataCriacao, DateTime dataUltAlteracao)
            : base(0, dataCriacao, dataUltAlteracao)
        {
            NumNfv = numNfv;
            ModeloNfv = modeloNfv;
            SerieNfv = serieNfv;
            Cliente = cliente;
            CondicaoPagamento = condicaoPagamento;
            ValorTotal = valorTotal;
            ValorFrete = valorFrete;
            ValorSeguro = valorSeguro;
            ValorOutrasDespesas = valorOutrasDespesas;
            DataSaida = dataSaida;
            DataEmissao = dataEmissao;
            DataCancelamento = dataCancelamento;
            ItensVenda = itensVenda;
        }
        public List<ItemVenda> ItensVenda
        {
            get => _itensVenda;
            set => _itensVenda = value;
        }
        public int NumNfv
        {
            get => _numNfv;
            set => _numNfv = value;
        }

        public int ModeloNfv
        {
            get => _modeloNfv;
            set => _modeloNfv = value;
        }

        public int SerieNfv
        {
            get => _serieNfv;
            set => _serieNfv = value;
        }

        public Clientes Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }

        public CondicaoPagamento CondicaoPagamento
        {
            get => _condicaoPagamento;
            set => _condicaoPagamento = value;
        }

        public decimal ValorTotal
        {
            get => _valorTotal;
            set => _valorTotal = value;
        }

        public decimal ValorFrete
        {
            get => _valorFrete;
            set => _valorFrete = value;
        }

        public decimal ValorSeguro
        {
            get => _valorSeguro;
            set => _valorSeguro = value;
        }

        public decimal ValorOutrasDespesas
        {
            get => _valorOutrasDespesas;
            set => _valorOutrasDespesas = value;
        }

        public DateTime DataSaida
        {
            get => _dataSaida;
            set => _dataSaida = value;
        }

        public DateTime DataEmissao
        {
            get => _dataEmissao;
            set => _dataEmissao = value;
        }

        public DateTime? DataCancelamento
        {
            get => _dataCancelamento;
            set => _dataCancelamento = value;
        }
    }
}