using System;
using System.Collections.Generic;
using System.Linq;

namespace ELP4PROJETO.Classes
{
    public class Paises:Pai
    {

        protected string _pais;
        protected string _sigla;
        protected string _ddi;
        protected string _statusPais;

        public Paises(): base()
        {
            _pais = "";
            _sigla = "";
            _ddi = "";
        }

        public Paises(int id,string ddi, string pais, string sigla, DateTime dataUltAlteracao, DateTime dataCriacao,string status) : base(id, dataCriacao, dataUltAlteracao)
        {
            Ddi = ddi;
            Pais = pais; 
            Sigla = sigla;
            StatusPais = status;
        }
        public string StatusPais
        {
            get => _statusPais;
            set => _statusPais = value;
        }

        public string Ddi
        {
            get => _ddi;
            set => _ddi = value;
        }

        public string Pais
        {
            get => _pais;
            set => _pais = value;
        }

        public string Sigla
        {
            get => _sigla;
            set => _sigla = value;
        }
      
    }
}
