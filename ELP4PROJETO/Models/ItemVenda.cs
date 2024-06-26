using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELP4PROJETO.Models
{
    public class ItemVenda
    {
        private int _numNfv;
        private int _modeloNfv;
        private int _serieNfv;
        private Clientes _cliente;
        private int _idItem;
        private string _tipoItem; 
        private int _qtdItem; 
        private decimal _precoUnitario;
        private decimal _totalItem;
        private decimal? _desconto;
        private DateTime _dataCriacao;

        public ItemVenda()
        {
            _numNfv = 0;
            _modeloNfv = 0;
            _serieNfv = 0;
            _cliente = new Clientes();
            _idItem = 0;
            _tipoItem = "";
            _qtdItem = 1; // Por padrão, considerando quantidade 1 para serviços
            _precoUnitario = 0.0m;
            _totalItem = 0.0m;
            _desconto = null;
            _dataCriacao = DateTime.MinValue;
        }

        public ItemVenda(int numNfv, int modeloNfv, int serieNfv, Clientes cliente, int idItem, string tipoItem,
                         int qtdItem, decimal precoUnitario, decimal totalItem, decimal? desconto, DateTime dataCriacao)
        {
            NumNfv = numNfv;
            ModeloNfv = modeloNfv;
            SerieNfv = serieNfv;
            Cliente = cliente;
            IdItem = idItem;
            TipoItem = tipoItem;
            QtdItem = qtdItem;
            PrecoUnitario = precoUnitario;
            TotalItem = totalItem;
            Desconto = desconto;
            DataCriacao = dataCriacao;
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

        public int IdItem
        {
            get => _idItem;
            set => _idItem = value;
        }

        public string TipoItem
        {
            get => _tipoItem;
            set => _tipoItem = value;
        }

        public int QtdItem
        {
            get => _qtdItem;
            set => _qtdItem = value;
        }

        public decimal PrecoUnitario
        {
            get => _precoUnitario;
            set => _precoUnitario = value;
        }

        public decimal TotalItem
        {
            get => _totalItem;
            set => _totalItem = value;
        }

        public decimal? Desconto
        {
            get => _desconto;
            set => _desconto = value;
        }

        public DateTime DataCriacao
        {
            get => _dataCriacao;
            set => _dataCriacao = value;
        }
    }
}