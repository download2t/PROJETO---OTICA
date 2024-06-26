using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using test.Controllers;

namespace ELP4PROJETO.Consultas
{
    public partial class FrmConsultaPais : ELP4PROJETO.Consultas.FrmConsulta
    {
        FrmCadastroPais frmcadPaises;
        Paises oPais;
        CTLPaises aCTLPaises;
        public int IdSelecionado { get; private set; }
        public string NomeSelecionado { get; private set; }
        private string status = "A";
        public FrmConsultaPais()
        {
            InitializeComponent();
            aCTLPaises = new CTLPaises();

        }

        // sobreescrever metodos Pais

        public override void SetFrmCadastro(object obj)
        {
           if(obj != null)
           {
                frmcadPaises = (FrmCadastroPais)obj;
           }
            
        }
        public override void ConhecaObj(object obj)
        {
            oPais = (Paises)obj;
        }

        protected override void Incluir()
        {
            base.Incluir();
            aCTLPaises.Incluir(); // Alteração de aCTLprodutoss para aCTLProdutos
            CarregaLV();
        }
        protected override void Alterar()
        {
            base.Alterar();
            int idPais = ObterIdSelecionado(); // Alteração de idprodutos para idProduto
            if (idPais > 0)
            {
                Paises pais = aCTLPaises.BuscarPaisPorId(idPais); // Alteração de produtos para Produto, aCTLprodutoss para aCTLProdutos
                if (pais != null)
                {
                    aCTLPaises.Alterar(pais); // Alteração de produtos para Produto, aCTLprodutoss para aCTLProdutos
                    CarregaLV();
                }
            }
        }

        public override void Excluir()
        {
            base.Excluir();
            int idPais = ObterIdSelecionado(); // Alteração de idprodutos para idProduto
            if (idPais > 0)
            {
                Paises pais = aCTLPaises.BuscarPaisPorId(idPais); // Alteração de produtos para Produto, aCTLprodutoss para aCTLProdutos
                if (pais != null)
                {
                    aCTLPaises.Excluir(pais); // Alteração de produtos para Produto, aCTLprodutoss para aCTLProdutos
                    CarregaLV();
                }
            }
        }
        public override void Visualizar()
        {
            if (btnSair.Text == "Selecionar")
            {
                btnSair.PerformClick();
            }
            else if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
               Paises pais = selectedItem.Tag as Paises; // Alteração de produtos para Produto
                if (pais != null)
                {
                    aCTLPaises.Visualizar(pais); // Alteração de produtos para Produto, aCTLprodutoss para aCTLProdutos
                    CarregaLV();
                }
            }
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            List<Paises> dados = aCTLPaises.ListarPaises(status); 
            PreencherListView(dados); 
        }
        private void PreencherListView(IEnumerable<Paises> dados) 
        {
            listView1.Items.Clear();

            foreach (var pais in dados)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pais.ID)); 
                item.SubItems.Add(pais.Pais); 
                item.SubItems.Add(pais.Sigla);
                item.SubItems.Add(pais.Ddi);
                item.SubItems.Add(pais.DataCriacao.ToString());
                item.SubItems.Add(pais.DataUltimaAlteracao.ToString());
                item.SubItems.Add(pais.StatusPais == "I" ? "Inativo" : pais.StatusPais == "A" ? "Ativo" : pais.StatusPais);
                item.Tag = pais; 
                listView1.Items.Add(item);
            }
        }
        private int ObterIdSelecionado()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                return int.Parse(listView1.SelectedItems[0].Text);
            }
            return 0;
        }
        protected override void Sair()
        {
            if (btnSair.Text == "Sair")
            {
                base.Sair();
            }
            else if (btnSair.Text == "Selecionar")
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    IdSelecionado = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    NomeSelecionado = listView1.SelectedItems[0].SubItems[1].Text;
                }
                this.Close();
            }
        }
        private string ObterCritérioPesquisa()
        {
            if (rbCodigo.Checked)
            {
                return "ID";
            }
            else if (rbPais.Checked)
            {
                return "PAIS";
            }
            else if (rbDDI.Checked)
            {
                return "DDI";
            }
            else if (rbSigla.Checked)
            {
                return "SIGLA";
            }

            return string.Empty; 
        }
        protected override void Pesquisar()
        {
            string valorPesquisa = txtCodigo.Text;
            string criterioPesquisa = ObterCritérioPesquisa();

            if (!string.IsNullOrEmpty(valorPesquisa) && !string.IsNullOrEmpty(criterioPesquisa))
            {
                // Execute uma pesquisa na camada de controle com base no critério
                var resultados = aCTLPaises.PesquisarPaisesPorCriterio(criterioPesquisa, valorPesquisa, status);

                // Use o método de preenchimento para atualizar a ListView
                PreencherListView(resultados);
            }
        }

        private void cbInativos_CheckedChanged(object sender, EventArgs e)
        {
            if(cbInativos.Checked)  
                status = "I";
            else
                status = "A";
            CarregaLV();
        }
    }
}
