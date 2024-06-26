using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ELP4PROJETO.Cadastros
{
    public partial class FrmCadastros : Frm
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        //Metodos Virtuais
        public virtual void CarregarCampos()// carregar campos do form.
        {
            this.txtCodigo.Text = txtCodigo.Text.ToString();
        }
        protected virtual void AlterarEdit()
        {

        }
    
        protected virtual void LimparCampos()// limpar campos do form.
        {
            this.txtCodigo.Clear();
        }
        public virtual void DesbloquearCampos()// carregar campos do form.
        {
            this.txtCodigo.Enabled = true;
        }
        public virtual void BloquearCampos()// carregar campos do form.
        {
            this.txtCodigo.Enabled = false;
        }
        protected virtual void Salvar()//Salvar
        {
            Sair();
        }
        public virtual void Verificar()
        {
            Salvar();
        }
   
        //Metodos Privados
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificar();
        }

        // Metodos publicos
        public virtual void ConhecaObj(object obj)
        {

        }
    }
}
