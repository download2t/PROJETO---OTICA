using System;

namespace ELP4PROJETO.Classes
{
    public class Cargos : Pai
    {
        private string _statusCargo;
        private string _cargo;

        public Cargos() : base()
        {
            _statusCargo = "";
            _cargo = "";
        }

        public Cargos(int id, string statusCargo, string cargo, DateTime dataCriacao, DateTime dataUltAlteracao) : base(id, dataCriacao, dataUltAlteracao)
        {
            StatusCargo = statusCargo;
            Cargo = cargo;
        }

        public string StatusCargo
        {
            get => _statusCargo;
            set => _statusCargo = value;
        }

        public string Cargo
        {
            get => _cargo;
            set => _cargo = value;
        }
    }
}