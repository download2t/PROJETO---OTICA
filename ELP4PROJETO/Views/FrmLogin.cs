using ELP4PROJETO.Models;
using System;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views
{
    public partial class FrmLogin : Form
    {
        CTLFuncionarios aCTLFunc;
        public FrmLogin()
        {
            InitializeComponent();
            aCTLFunc = new CTLFuncionarios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string emailOuApelido = txtUsuario.Text;
            string senha = txtSenha.Text;

            Funcionarios funcionario = aCTLFunc.ValidarLogin(emailOuApelido, senha);

            if (funcionario != null)
            {
                // Armazena os dados do usuário logado
                UsuarioLogado.Login(funcionario);

                this.Hide();
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                // Credenciais inválidas
                MessageBox.Show("Email/Apelido ou senha incorretos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
