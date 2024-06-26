namespace ELP4PROJETO
{
    partial class FrmTeste
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.consEstados = new System.Windows.Forms.ToolStripMenuItem();
            this.consCidades = new System.Windows.Forms.ToolStripMenuItem();
            this.conClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.conFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.forn = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosForn = new System.Windows.Forms.ToolStripMenuItem();
            this.conFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.conCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.conFormaDePagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.conCondicaoDePagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.Marca = new System.Windows.Forms.ToolStripMenuItem();
            this.Doutores = new System.Windows.Forms.ToolStripMenuItem();
            this.Laboratorios = new System.Windows.Forms.ToolStripMenuItem();
            this.Receitas = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFCeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 0;
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consPaises,
            this.consEstados,
            this.consCidades,
            this.conClientes,
            this.conFornecedores,
            this.conFuncionarios,
            this.conCargos,
            this.conFormaDePagamento,
            this.conCondicaoDePagamento,
            this.categoriaToolStripMenuItem,
            this.conProdutos,
            this.Marca,
            this.Doutores,
            this.Laboratorios,
            this.Receitas,
            this.compraToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.consultarToolStripMenuItem.Text = "Cadastros";
            // 
            // consPaises
            // 
            this.consPaises.Name = "consPaises";
            this.consPaises.Size = new System.Drawing.Size(236, 24);
            this.consPaises.Text = "Paises ✔️";
            this.consPaises.Click += new System.EventHandler(this.consPaises_Click);
            // 
            // consEstados
            // 
            this.consEstados.Name = "consEstados";
            this.consEstados.Size = new System.Drawing.Size(236, 24);
            this.consEstados.Text = "Estados ✔️";
            this.consEstados.Click += new System.EventHandler(this.consEstados_Click);
            // 
            // consCidades
            // 
            this.consCidades.Name = "consCidades";
            this.consCidades.Size = new System.Drawing.Size(236, 24);
            this.consCidades.Text = "Cidades ✔️";
            this.consCidades.Click += new System.EventHandler(this.consCidades_Click);
            // 
            // conClientes
            // 
            this.conClientes.Name = "conClientes";
            this.conClientes.Size = new System.Drawing.Size(236, 24);
            this.conClientes.Text = "Clientes ✔️";
            this.conClientes.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // conFornecedores
            // 
            this.conFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forn,
            this.produtosForn});
            this.conFornecedores.Name = "conFornecedores";
            this.conFornecedores.Size = new System.Drawing.Size(236, 24);
            this.conFornecedores.Text = "Fornecedores ✔️";
            this.conFornecedores.Click += new System.EventHandler(this.conFornecedores_Click);
            // 
            // forn
            // 
            this.forn.Enabled = false;
            this.forn.Name = "forn";
            this.forn.Size = new System.Drawing.Size(250, 24);
            this.forn.Text = "Fornecedores ✔️";
            this.forn.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosForn
            // 
            this.produtosForn.Enabled = false;
            this.produtosForn.Name = "produtosForn";
            this.produtosForn.Size = new System.Drawing.Size(250, 24);
            this.produtosForn.Text = "Produtos do Fornecedor ✔️";
            this.produtosForn.Click += new System.EventHandler(this.produtosForn_Click);
            // 
            // conFuncionarios
            // 
            this.conFuncionarios.Name = "conFuncionarios";
            this.conFuncionarios.Size = new System.Drawing.Size(236, 24);
            this.conFuncionarios.Text = "Funcionários ✔️";
            this.conFuncionarios.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // conCargos
            // 
            this.conCargos.Name = "conCargos";
            this.conCargos.Size = new System.Drawing.Size(236, 24);
            this.conCargos.Text = "Cargos ✔️";
            this.conCargos.Click += new System.EventHandler(this.cargosToolStripMenuItem1_Click);
            // 
            // conFormaDePagamento
            // 
            this.conFormaDePagamento.Name = "conFormaDePagamento";
            this.conFormaDePagamento.Size = new System.Drawing.Size(236, 24);
            this.conFormaDePagamento.Text = "Forma de Pagamento ✔️";
            this.conFormaDePagamento.Click += new System.EventHandler(this.formaDePagamentoToolStripMenuItem_Click);
            // 
            // conCondicaoDePagamento
            // 
            this.conCondicaoDePagamento.Name = "conCondicaoDePagamento";
            this.conCondicaoDePagamento.Size = new System.Drawing.Size(236, 24);
            this.conCondicaoDePagamento.Text = "Condição de Pamento ✔️";
            this.conCondicaoDePagamento.Click += new System.EventHandler(this.conCondicaoDePagamento_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria ✔️";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // conProdutos
            // 
            this.conProdutos.Name = "conProdutos";
            this.conProdutos.Size = new System.Drawing.Size(236, 24);
            this.conProdutos.Text = "Produtos ✔️";
            this.conProdutos.Click += new System.EventHandler(this.conProdutos_Click);
            // 
            // Marca
            // 
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(236, 24);
            this.Marca.Text = "Marcas✔️";
            this.Marca.Click += new System.EventHandler(this.Marca_Click);
            // 
            // Doutores
            // 
            this.Doutores.Name = "Doutores";
            this.Doutores.Size = new System.Drawing.Size(236, 24);
            this.Doutores.Text = "Doutores ✔️";
            this.Doutores.Click += new System.EventHandler(this.Doutores_Click);
            // 
            // Laboratorios
            // 
            this.Laboratorios.Name = "Laboratorios";
            this.Laboratorios.Size = new System.Drawing.Size(236, 24);
            this.Laboratorios.Text = "Laboratórios ✔️";
            this.Laboratorios.Click += new System.EventHandler(this.Laboratorios_Click);
            // 
            // Receitas
            // 
            this.Receitas.Name = "Receitas";
            this.Receitas.Size = new System.Drawing.Size(236, 24);
            this.Receitas.Text = "Receitas ✔️";
            this.Receitas.Click += new System.EventHandler(this.Receitas_Click);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.compraToolStripMenuItem.Text = "Compras";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPreçoToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.nFCeToolStripMenuItem});
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // consultarPreçoToolStripMenuItem
            // 
            this.consultarPreçoToolStripMenuItem.Enabled = false;
            this.consultarPreçoToolStripMenuItem.Name = "consultarPreçoToolStripMenuItem";
            this.consultarPreçoToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.consultarPreçoToolStripMenuItem.Text = "Consultar Preço";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.Enabled = false;
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Enabled = false;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Enabled = false;
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // nFCeToolStripMenuItem
            // 
            this.nFCeToolStripMenuItem.Enabled = false;
            this.nFCeToolStripMenuItem.Name = "nFCeToolStripMenuItem";
            this.nFCeToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.nFCeToolStripMenuItem.Text = "NFC-e";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem,
            this.fluxoDeCaixaToolStripMenuItem,
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Enabled = false;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.Enabled = false;
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de caixa";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Enabled = false;
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.contasAPagarToolStripMenuItem.Text = "Contas a pagar";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Enabled = false;
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.contasAReceberToolStripMenuItem.Text = "Contas a receber";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consPaises;
        private System.Windows.Forms.ToolStripMenuItem consEstados;
        private System.Windows.Forms.ToolStripMenuItem consCidades;
        private System.Windows.Forms.ToolStripMenuItem conClientes;
        private System.Windows.Forms.ToolStripMenuItem conFornecedores;
        private System.Windows.Forms.ToolStripMenuItem conProdutos;
        private System.Windows.Forms.ToolStripMenuItem conFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFCeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conCargos;
        private System.Windows.Forms.ToolStripMenuItem conFormaDePagamento;
        private System.Windows.Forms.ToolStripMenuItem conCondicaoDePagamento;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forn;
        private System.Windows.Forms.ToolStripMenuItem produtosForn;
        private System.Windows.Forms.ToolStripMenuItem Marca;
        private System.Windows.Forms.ToolStripMenuItem Doutores;
        private System.Windows.Forms.ToolStripMenuItem Laboratorios;
        private System.Windows.Forms.ToolStripMenuItem Receitas;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

