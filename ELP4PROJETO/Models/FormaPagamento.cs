using System;

namespace ELP4PROJETO.Classes
{
    public class FormaPagamento : Pai
    {
        private string _statusForma;
        private string _forma;

        public FormaPagamento() : base()
        {
            _statusForma = "";
            _forma = "";
        }

        public FormaPagamento(int id, string statusForma, string forma, DateTime dataCriacao, DateTime dataUltAlteracao) : base(id, dataCriacao, dataUltAlteracao)
        {
            StatusForma = statusForma;
            Forma = forma;
        }

        public string StatusForma
        {
            get => _statusForma;
            set => _statusForma = value;
        }

        public string Forma
        {
            get => _forma;
            set => _forma = value;
        }
    }
}
