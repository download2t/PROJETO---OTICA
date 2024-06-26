using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLReceita
    {
        private DALReceita receitaDAL = new DALReceita();

        public string  AdicionarReceita(Receita receita)
        {
            return receitaDAL.AdicionarReceita(receita);
        }

        public string AtualizarReceita(Receita receita)
        {
            return receitaDAL.AtualizarReceita(receita);
        }

        public bool ExcluirReceita(int receitaId)
        {
            return receitaDAL.ExcluirReceita(receitaId);
        }

        public Receita BuscarReceitaPorId(int id)
        {
            return receitaDAL.BuscarReceitaPorId(id);
        }

        public List<Receita> ListarReceitas()
        {
            return receitaDAL.ListarReceitas();
        }

        public List<Receita> PesquisarReceitasPorCriterio(string criterio, string nomeLaboratorioOuFornecedor)
        {
            return receitaDAL.PesquisarReceitasPorCriterio(criterio, nomeLaboratorioOuFornecedor);
        }

        public void Incluir()
        {
            // Implementação do método para abrir a tela de cadastro de receita para inclusão
            FrmCadastroReceita frmCadastroReceita = new FrmCadastroReceita();
            frmCadastroReceita.Text = "Incluir Receita";
            frmCadastroReceita.toolTip1.SetToolTip(frmCadastroReceita.btnSalvar, "Salvar dados.");
            frmCadastroReceita.ShowDialog();
        }

        public void Alterar(Receita receita)
        {
            // Implementação do método para abrir a tela de cadastro de receita para alteração
            FrmCadastroReceita frmCadastroReceita = new FrmCadastroReceita();
            frmCadastroReceita.ConhecaObj(receita);
            frmCadastroReceita.Text = "Alterar Receita";
            frmCadastroReceita.btnSalvar.Text = "ALTERAR";
            frmCadastroReceita.btnSalvar.BackColor = Color.BurlyWood;
            frmCadastroReceita.CarregarCampos();
            frmCadastroReceita.toolTip1.SetToolTip(frmCadastroReceita.btnSalvar, "Alterar dados.");
            frmCadastroReceita.ShowDialog();
        }

        public void Excluir(Receita receita)
        {
            // Implementação do método para abrir a tela de cadastro de receita para exclusão
            FrmCadastroReceita frmCadastroReceita = new FrmCadastroReceita();
            frmCadastroReceita.ConhecaObj(receita);
            frmCadastroReceita.Text = "Excluir Receita";
            frmCadastroReceita.btnSalvar.Text = "EXCLUIR";
            frmCadastroReceita.toolTip1.SetToolTip(frmCadastroReceita.btnSalvar, "Excluir receita.");
            frmCadastroReceita.btnSalvar.ForeColor = Color.White;
            frmCadastroReceita.btnSalvar.BackColor = Color.DarkRed;
            frmCadastroReceita.CarregarCampos();
            frmCadastroReceita.BloquearCampos();
            frmCadastroReceita.ShowDialog();
        }

        public void Visualizar(Receita receita)
        {
            // Implementação do método para abrir a tela de cadastro de receita para visualização
            FrmCadastroReceita frmCadastroReceita = new FrmCadastroReceita();
            frmCadastroReceita.ConhecaObj(receita);
            frmCadastroReceita.Text = "Visualizar Receita";
            frmCadastroReceita.CarregarCampos();
            frmCadastroReceita.BloquearCampos();
            frmCadastroReceita.btnSalvar.Enabled = false;
            frmCadastroReceita.ShowDialog();
        }
    }
}
