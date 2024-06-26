using ELP4PROJETO.Classes;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroMarca : ELP4PROJETO.Cadastros.FrmCadastros
    {
        Marca aMarca;
        CTLMarca aCTLMarca;
        public FrmCadastroMarca()
        {
            InitializeComponent();
            aMarca = new Marca();
            aCTLMarca = new CTLMarca();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Marca marca)
            {
                aMarca = marca;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtCodigo.Enabled = false;
            txtMarca.Enabled = false;
            txtDescricao.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtCodigo.Enabled = true;
            txtMarca.Enabled = true;
            txtDescricao.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = aMarca.ID.ToString();
            txtMarca.Text = aMarca.Nome;
            txtDescricao.Text = aMarca.Descricao;
        }

        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "EXCLUIR")
            {
                ConfirmarExclusaoMarca();
            }
        }

        protected override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Campo Marca não pode estar vazio.");
                txtMarca.Focus();
                return;
            }

            try
            {

                aMarca.Nome = txtMarca.Text;
                aMarca.Descricao = txtDescricao.Text;

                if (aMarca.ID == 0) // Produto de patrimônios
                {
                    aMarca.DataCriacao = DateTime.Now;
                    aCTLMarca.AdicionarMarca(aMarca);
                }
                else
                {
                    aMarca.DataUltimaAlteracao = DateTime.Now;
                    aCTLMarca.AtualizarMarca(aMarca);
                }

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConfirmarExclusaoMarca()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta Produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirMarca();
            }
        }


        private void ExcluirMarca()
        {
            if (aMarca != null)
            {
                try
                {

                    aCTLMarca.ExcluirMarca(aMarca.ID);
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a Marca devido a outros registros estarem vinculados a esta Produto.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir a Marca. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }
    }
}
