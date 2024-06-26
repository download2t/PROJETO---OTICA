using System;

namespace ELP4PROJETO.Classes
{
    public class Categoria : Pai
    {
        private string _nome;
        private string _descricao;
        private byte[] _foto;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public Categoria() : base()
        {
            ID = 0;
            _nome = "";
            _descricao = "";
            _foto = null;
        }

        public Categoria(int id, string nome, string descricao, byte[] foto) : base(id)
        {
            ID = id;
            _nome = nome;
            _descricao = descricao;
            _foto = foto;
        }
    }
}
