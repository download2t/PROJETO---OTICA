using System;
using System.Collections.Generic;
using System.Linq;

namespace ELP4PROJETO.Classes
{
    public class Estados : Pai
    {
        private string _estado;
        private string _uf;
        private Paises oPais;
        private string _statusEstado;

        public Estados() : base()
        {
            _estado = "";
            _uf = "";
            oPais = new Paises();
        }

        public Estados(int id, string estado, string uf, Paises oPais, DateTime dataultAlteracao, DateTime dataCriacao, string status) : base(id, dataCriacao, dataultAlteracao)
        {
            Estado = estado;
            UF = uf;
            OPais = oPais;
            StatusEstado = status;
        }
        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }
        public string StatusEstado
        {
            get => _statusEstado;
            set => _statusEstado = value;
        }
        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }

        public string UF
        {
            get => _uf;
            set => _uf = value;
        }
    }
}
