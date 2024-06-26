using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
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

namespace ELP4PROJETO.Views.Cadastros
{
    public partial class FrmCadastroCategoria : ELP4PROJETO.Cadastros.FrmCadastros
    {
        CTLCategoria aCTLCategoria;
        Categoria aCategoria;
        public string caminhoFoto = "";
        private Form fotoForm;
        public FrmCadastroCategoria()
        {
            InitializeComponent();
            aCategoria = new Categoria();
            aCTLCategoria = new CTLCategoria();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            if (obj is Categoria Produto)
            {
                aCategoria = Produto;
                CarregarCampos();
            }
        }
        public override void BloquearCampos()
        {
            base.BloquearCampos();
            txtCodigo.Enabled = false;
            txtProduto.Enabled = false;
            btnFoto.Enabled = false;
        }
        public override void DesbloquearCampos()
        {
            base.DesbloquearCampos();
            txtCodigo.Enabled = true;
            txtProduto.Enabled = true;
            btnFoto.Enabled = true;
        }
        public override void CarregarCampos()
        {
            base.CarregarCampos();
            txtCodigo.Text = aCategoria.ID.ToString();
            txtCodigo.Text = aCategoria.ID.ToString();
            txtProduto.Text = aCategoria.Nome;

            if (aCategoria.Foto != null && aCategoria.Foto.Length > 0)
            {
                pbFoto.BackgroundImage = null;
                using (MemoryStream ms = new MemoryStream(aCategoria.Foto))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }
            }
        }


        public override void Verificar()
        {
            if (btnSalvar.Text == "SALVAR" || btnSalvar.Text == "ALTERAR")
            {
                Salvar();
            }
            else if (btnSalvar.Text == "EXCLUIR")
            {
                ConfirmarExclusaaCategoria();
            }
        }

        protected override void Salvar()
        {
            if (string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                MessageBox.Show("Campo Produto não pode estar vazio.");
                txtProduto.Focus();
                return;
            }

            try
            {
                if (pbFoto.Image != null)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbFoto.Image.Save(ms, pbFoto.Image.RawFormat);
                            aCategoria.Foto = ms.ToArray();
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("erro gdi+");
                    }
                
                }
                else
                {
                    aCategoria.Foto = null;
                }

                aCategoria.Nome = txtProduto.Text;

                if (aCategoria.ID == 0) // Produto de patrimônios
                {
                    aCTLCategoria.AdicionarCategoria(aCategoria);
                }
                else
                {
                    aCTLCategoria.AtualizarCategoria(aCategoria);
                }

                Close();
            }
            catch (System.Runtime.InteropServices.ExternalException ex)
            {
                MessageBox.Show("Erro de GDI+: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ConfirmarExclusaaCategoria()
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta Produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ExcluirProduto();
            }
        }


        private void ExcluirProduto()
        {
            if (aCategoria != null)
            {
                try
                {
                    CTLCategoria aCTLCategoria = new CTLCategoria();
                    aCTLCategoria.ExcluirCategoria(aCategoria.ID);
                    Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Não é possível excluir a Produto devido a outros registros estarem vinculados a esta Produto.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir a Produto. Detalhes: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. Detalhes: " + ex.Message);
                }
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "arquivos de imagens jpg e png |*.jpeg; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
            {
                pbFoto.Load(caminhoFoto);
                pbFoto.BackgroundImage = null;
            }
        }

        private void pbFoto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (fotoForm == null || fotoForm.IsDisposed)
                {
                    fotoForm = Operacao.CriarFormFoto(pbFoto.Image);
                    fotoForm.Show();
                }
                else
                {
                    fotoForm.BringToFront();
                }
            }
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operacao.ValidarNomes(sender, e);
        }


        // Buttons

    }
}