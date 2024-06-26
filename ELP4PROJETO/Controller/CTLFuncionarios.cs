using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLFuncionarios
    {
        private DALFuncionarios funcionariosDAL = new DALFuncionarios();

        public string AdicionarFuncionario(Funcionarios funcionario)
        {
            return funcionariosDAL.AdicionarFuncionario(funcionario);
        }

        public string AtualizarFuncionarioComSenha(Funcionarios funcionario)
        {
            return funcionariosDAL.AtualizarFuncionarioComSenha(funcionario);
        }
        public string AtualizarFuncionarioSemSenha(Funcionarios funcionario)
        {
            return funcionariosDAL.AtualizarFuncionarioSemSenha(funcionario);
        }
        public Funcionarios AtualizarSenha(Funcionarios funcionario)
        {
            return funcionariosDAL.AtualizarSenha(funcionario);
        }
        public bool ExcluirFuncionario(int funcionarioId)
        {
            return funcionariosDAL.ExcluirFuncionario(funcionarioId);
        }

        public Funcionarios BuscarFuncionarioPorId(int id)
        {
            return funcionariosDAL.BuscarFuncionarioPorId(id);
        }

        public Funcionarios BuscarEmailOuApelido(string func)
        {
            return funcionariosDAL.BuscarPorEmailOuApelido(func);
        }

        public List<Funcionarios> ListarFuncionarios(string status)
        {
            return funcionariosDAL.ListarFuncionarios(status);
        }

        public List<Funcionarios> PesquisarFuncionariosPorCriterio(string criterio, string valorPesquisa, string status)
        {
            return funcionariosDAL.PesquisarFuncionariosPorCriterio(criterio, valorPesquisa, status);
        }
        public string CriptografarDados(string dados)
        {
            return funcionariosDAL.CriptografarDadosSHA256(dados);
        }
        public Funcionarios ValidarLogin(string emailOuApelido, string senha)
        {
            string SenhaCriptografada = CriptografarDados(senha);
            return funcionariosDAL.ValidarLogin(emailOuApelido, SenhaCriptografada);
        }


        public void Incluir()
        {
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
            frmCadastroFuncionario.Text = "Incluir Funcionário";
            frmCadastroFuncionario.cmbStatus.Text = "ATIVO";
            frmCadastroFuncionario.cmbStatus.Enabled = false;
            frmCadastroFuncionario.toolTip1.SetToolTip(frmCadastroFuncionario.btnSalvar, "Salvar dados.");
            frmCadastroFuncionario.ShowDialog();
        }

        public void Alterar(Funcionarios funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
                frmCadastroFuncionario.ConhecaObj(funcionario);
                frmCadastroFuncionario.Text = "Alterar Funcionário";
                frmCadastroFuncionario.btnSalvar.Text = "ALTERAR";
                frmCadastroFuncionario.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroFuncionario.CarregarCampos();
                frmCadastroFuncionario.toolTip1.SetToolTip(frmCadastroFuncionario.btnSalvar, "Alterar dados.");
                frmCadastroFuncionario.ShowDialog();
            }
        }

        public void Excluir(Funcionarios funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
                frmCadastroFuncionario.ConhecaObj(funcionario);
                frmCadastroFuncionario.Text = "Excluir Funcionário";
                frmCadastroFuncionario.btnSalvar.Text = "EXCLUIR";
                frmCadastroFuncionario.toolTip1.SetToolTip(frmCadastroFuncionario.btnSalvar, "Excluir funcionário.");
                frmCadastroFuncionario.btnSalvar.ForeColor = Color.White;
                frmCadastroFuncionario.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroFuncionario.CarregarCampos();
                frmCadastroFuncionario.BloquearCampos();
                frmCadastroFuncionario.ShowDialog();
            }
        }

        public void Visualizar(Funcionarios funcionario)
        {
            if (funcionario != null)
            {
                FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();
                frmCadastroFuncionario.ConhecaObj(funcionario);
                frmCadastroFuncionario.Text = "Consultar Funcionário";
                frmCadastroFuncionario.CarregarCampos();
                frmCadastroFuncionario.BloquearCampos();
                frmCadastroFuncionario.btnSalvar.Enabled = false;
                frmCadastroFuncionario.ShowDialog();
            }
        }
    }
}
