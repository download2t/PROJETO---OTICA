namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaProdutosFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbFornecedor = new System.Windows.Forms.RadioButton();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clIDProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIDForn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clForn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCodProdForn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataUlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(822, 26);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(823, 498);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(716, 498);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(607, 498);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clIDProd,
            this.clProdName,
            this.clIDForn,
            this.clForn,
            this.clCodProdForn,
            this.clDataCad,
            this.clDataUlt});
            this.listView1.Size = new System.Drawing.Size(1016, 377);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbFornecedor);
            this.pnTop.Controls.Add(this.rbProduto);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Size = new System.Drawing.Size(1016, 39);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(932, 26);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(797, 23);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(932, 498);
            // 
            // rbFornecedor
            // 
            this.rbFornecedor.AutoSize = true;
            this.rbFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFornecedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbFornecedor.ForeColor = System.Drawing.Color.Black;
            this.rbFornecedor.Location = new System.Drawing.Point(176, 0);
            this.rbFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.rbFornecedor.Name = "rbFornecedor";
            this.rbFornecedor.Size = new System.Drawing.Size(120, 39);
            this.rbFornecedor.TabIndex = 9;
            this.rbFornecedor.Text = "Fornecedor";
            this.rbFornecedor.UseVisualStyleBackColor = true;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbProduto.ForeColor = System.Drawing.Color.Black;
            this.rbProduto.Location = new System.Drawing.Point(85, 0);
            this.rbProduto.Margin = new System.Windows.Forms.Padding(4);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(91, 39);
            this.rbProduto.TabIndex = 8;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.Black;
            this.rbCodigo.Location = new System.Drawing.Point(0, 0);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 39);
            this.rbCodigo.TabIndex = 7;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clIDProd
            // 
            this.clIDProd.Text = "ID Produto";
            this.clIDProd.Width = 80;
            // 
            // clProdName
            // 
            this.clProdName.Text = "Produto";
            this.clProdName.Width = 200;
            // 
            // clIDForn
            // 
            this.clIDForn.Text = "ID Forn.";
            this.clIDForn.Width = 80;
            // 
            // clForn
            // 
            this.clForn.Text = "Fornecedor";
            this.clForn.Width = 200;
            // 
            // clCodProdForn
            // 
            this.clCodProdForn.Text = "Código";
            this.clCodProdForn.Width = 130;
            // 
            // clDataCad
            // 
            this.clDataCad.Text = "Data Cadastro";
            this.clDataCad.Width = 130;
            // 
            // clDataUlt
            // 
            this.clDataUlt.Text = "Ultima Alteração";
            this.clDataUlt.Width = 130;
            // 
            // cbInativos
            // 
            this.cbInativos.AutoSize = true;
            this.cbInativos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbInativos.Location = new System.Drawing.Point(296, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 39);
            this.cbInativos.TabIndex = 11;
            this.cbInativos.Text = "Mostrar Inativos";
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaProdutosFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1059, 535);
            this.Name = "FrmConsultaProdutosFornecedor";
            this.Text = "Consultar Produtos do Fornecedor";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFornecedor;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clIDProd;
        private System.Windows.Forms.ColumnHeader clProdName;
        private System.Windows.Forms.ColumnHeader clIDForn;
        private System.Windows.Forms.ColumnHeader clForn;
        private System.Windows.Forms.ColumnHeader clCodProdForn;
        private System.Windows.Forms.ColumnHeader clDataCad;
        private System.Windows.Forms.ColumnHeader clDataUlt;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
