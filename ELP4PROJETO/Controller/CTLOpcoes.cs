using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.DAL;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test.Controllers
{
    public class CTLOpcoes
    {
        private DALOpcoes opcaoDAL = new DALOpcoes();
        public void SalvarMenu(HashSet<Opcoes> opcoes)
        {
            opcaoDAL.SalvarMenu(opcoes);
        }

        public HashSet<Opcoes> CriarMenu(MenuStrip menu)
        {
            return opcaoDAL.Criar(menu);
        }
        public List<Opcoes> ObterOpcoesDoMenu()
        {
            // Aqui você deve chamar o método da sua DAL para obter as opções do menu
            return opcaoDAL.ObterOpcoesDoMenuDoBanco(); // Método fictício para buscar do banco de dados
        }
        public Opcoes BuscarOpcaoPorID(int idOpcao)
        {
            return opcaoDAL.BuscarOpcaoPorID(idOpcao);
        }
        public HashSet<Opcoes> CriarOpcoesPorTags(List<string> tags)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            foreach (var tag in tags)
            {
                // Aqui você pode criar uma lógica para definir a descrição da opção baseada na tag
                string descricao = $"Opção gerada a partir da tag: {tag}";

                // Cria uma nova opção com base na tag e na descrição
                Opcoes opcao = new Opcoes(tag, descricao, 1);

                // Adiciona a opção ao HashSet
                hashSetOpcoes.Add(opcao);
            }

            return hashSetOpcoes;
        }
    }
}
