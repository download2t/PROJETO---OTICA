using ELP4PROJETO.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ELP4PROJETO.Models.Others
{
    public class Opcoes : Pai
    {

        public string _nome;
        public string _descricao;
        public byte _nivel;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public byte Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
        public Opcoes() : base()
        {
            ID = 0;
            Nome = "";
            Descricao = "";
            Nivel = 0;
        }
        public Opcoes(int id, string nome, string descricao, byte nivel):base(id) 
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }
        public Opcoes( string nome, string descricao, byte nivel) : base()
        {
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }
    }
}