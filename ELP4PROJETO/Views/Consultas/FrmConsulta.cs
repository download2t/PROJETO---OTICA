using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ELP4PROJETO.Consultas
{
    public partial class FrmConsulta : ELP4PROJETO.Frm
    {
        private const int tamanhoFonteMinimo = 10;
        private const int tamanhoFonteMaximo = 20;
        public FrmConsulta()
        {
            InitializeComponent(); 
        }

        // métodos virtuais
        //Publicos
        public virtual void SetFrmCadastro(object obj)
        {

        }
        public virtual void ConhecaObj(object obj)
        {

        }
        //Protected

        protected virtual void Incluir()
        {

        }
        protected virtual void Alterar()
        {

        }
        public virtual void Excluir()
        {
            // Implemente a lógica de exclusão nas classes derivadas
        }
        public virtual void CarregaLV()
        {
          
        }
        protected virtual void Pesquisar()
        {

        }
        // botões 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           Pesquisar();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        public virtual void Visualizar()
        {
            // Implemente o duplo clique do ListView nas classes derivadas
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visualizar();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            CarregaLV();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaLV();
        }
        protected virtual void Atualizar()
        {
            txtCodigo.Text = "";
            CarregaLV();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Pesquisar();
            if (txtCodigo.Text == "")
                CarregaLV();
        }

        private void btnAumentarFonte_Click(object sender, EventArgs e)
        {
            // Aumenta o tamanho da fonte do ListView se estiver dentro do limite máximo
            if (listView1.Font.Size < tamanhoFonteMaximo)
            {
                listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", listView1.Font.Size + 1);
                AjustarTamanhoColunas();
            }
        }

        private void btnDiminuirFonte_Click(object sender, EventArgs e)
        {
            // Diminui o tamanho da fonte do ListView se estiver dentro do limite mínimo
            if (listView1.Font.Size > tamanhoFonteMinimo)
            {
                listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", listView1.Font.Size - 1);
                AjustarTamanhoColunas();
            }
        }
        private void AjustarTamanhoColunas()
        {
            // Define um fator de escala para ajustar o tamanho da coluna em relação ao tamanho da fonte
            float fatorEscala = 1.5f; // Este é apenas um exemplo, você pode ajustar conforme necessário

            // Calcula a largura das colunas com base no tamanho da fonte
            foreach (ColumnHeader coluna in listView1.Columns)
            {
                // Obtém o tamanho do texto na coluna atual
                Size textSize = TextRenderer.MeasureText(coluna.Text, listView1.Font);

                // Calcula o tamanho ideal da coluna (adiciona uma margem)
                int larguraIdeal = (int)(textSize.Width * fatorEscala);

                // Define a largura mínima da coluna (para evitar que fique muito estreita)
                int larguraMinima = Math.Max(coluna.Width, larguraIdeal);

                // Define a largura da coluna
                coluna.Width = larguraMinima;
            }
        }
    }
}
