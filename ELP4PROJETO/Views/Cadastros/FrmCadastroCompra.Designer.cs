namespace ELP4PROJETO.Views.Cadastros
{
    partial class FrmCadastroCompra
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
            this.lvParcelas = new System.Windows.Forms.ListView();
            this.clParcelas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clForma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPercentTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.gbCondicao = new System.Windows.Forms.GroupBox();
            this.txtTotalNota = new System.Windows.Forms.NumericUpDown();
            this.txtOutras = new System.Windows.Forms.NumericUpDown();
            this.txtSeguro = new System.Windows.Forms.NumericUpDown();
            this.txtFrete = new System.Windows.Forms.NumericUpDown();
            this.lbTotalNota = new System.Windows.Forms.Label();
            this.lbOutras = new System.Windows.Forms.Label();
            this.lbSeguro = new System.Windows.Forms.Label();
            this.lbFrete = new System.Windows.Forms.Label();
            this.lbCondicaoPg = new System.Windows.Forms.Label();
            this.txtCondicao = new System.Windows.Forms.TextBox();
            this.lbCodigoCondicao = new System.Windows.Forms.Label();
            this.txtCodCondicao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.GbChave = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.txtNumNFC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModeloNFC = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerieNFC = new System.Windows.Forms.NumericUpDown();
            this.clForn = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnBuscarFornecedor = new System.Windows.Forms.Button();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.dtCancelada = new System.Windows.Forms.DateTimePicker();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.dtChegada = new System.Windows.Forms.DateTimePicker();
            this.lblDataCacelamento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLinkVideo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTotalItens = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUND = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.DgItensCompra = new System.Windows.Forms.DataGridView();
            this.id_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.und = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo_atual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo_Sugerido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentual_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media_ponderada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDataCad = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCondicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrete)).BeginInit();
            this.GbChave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeloNFC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieNFC)).BeginInit();
            this.gbDatas.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgItensCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(959, 566);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSalvar.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1163, 9);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Enabled = true;
            this.lblCodigo.Location = new System.Drawing.Point(270, 46);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = true;
            this.txtCodigo.Location = new System.Drawing.Point(270, 64);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCodigo.ReadOnly = false;
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(1053, 565);
            this.btnSair.TabIndex = 51;
            // 
            // lvParcelas
            // 
            this.lvParcelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvParcelas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clParcelas,
            this.clDias,
            this.clForma,
            this.clPercentTotal,
            this.clPreco});
            this.lvParcelas.FullRowSelect = true;
            this.lvParcelas.GridLines = true;
            this.lvParcelas.HideSelection = false;
            this.lvParcelas.Location = new System.Drawing.Point(15, 460);
            this.lvParcelas.Margin = new System.Windows.Forms.Padding(4);
            this.lvParcelas.Name = "lvParcelas";
            this.lvParcelas.Size = new System.Drawing.Size(890, 130);
            this.lvParcelas.TabIndex = 85;
            this.lvParcelas.UseCompatibleStateImageBehavior = false;
            this.lvParcelas.View = System.Windows.Forms.View.Details;
            // 
            // clParcelas
            // 
            this.clParcelas.Text = "Nº Parcelas";
            this.clParcelas.Width = 150;
            // 
            // clDias
            // 
            this.clDias.Text = "Dias";
            this.clDias.Width = 100;
            // 
            // clForma
            // 
            this.clForma.Text = "Forma PG";
            this.clForma.Width = 500;
            // 
            // clPercentTotal
            // 
            this.clPercentTotal.Text = "%  sob Total";
            this.clPercentTotal.Width = 120;
            // 
            // clPreco
            // 
            this.clPreco.Text = "Valor da parcela";
            this.clPreco.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-97, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 14);
            this.label9.TabIndex = 82;
            this.label9.Text = "Data Cad.";
            // 
            // gbCondicao
            // 
            this.gbCondicao.Controls.Add(this.txtTotalNota);
            this.gbCondicao.Controls.Add(this.txtOutras);
            this.gbCondicao.Controls.Add(this.txtSeguro);
            this.gbCondicao.Controls.Add(this.txtFrete);
            this.gbCondicao.Controls.Add(this.lbTotalNota);
            this.gbCondicao.Controls.Add(this.lbOutras);
            this.gbCondicao.Controls.Add(this.lbSeguro);
            this.gbCondicao.Controls.Add(this.lbFrete);
            this.gbCondicao.Controls.Add(this.lbCondicaoPg);
            this.gbCondicao.Controls.Add(this.txtCondicao);
            this.gbCondicao.Controls.Add(this.lbCodigoCondicao);
            this.gbCondicao.Controls.Add(this.txtCodCondicao);
            this.gbCondicao.Enabled = false;
            this.gbCondicao.Location = new System.Drawing.Point(15, 382);
            this.gbCondicao.Margin = new System.Windows.Forms.Padding(2);
            this.gbCondicao.Name = "gbCondicao";
            this.gbCondicao.Padding = new System.Windows.Forms.Padding(2);
            this.gbCondicao.Size = new System.Drawing.Size(1124, 73);
            this.gbCondicao.TabIndex = 88;
            this.gbCondicao.TabStop = false;
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.BackColor = System.Drawing.Color.BurlyWood;
            this.txtTotalNota.Enabled = false;
            this.txtTotalNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNota.Location = new System.Drawing.Point(1032, 38);
            this.txtTotalNota.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalNota.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(93, 27);
            this.txtTotalNota.TabIndex = 103;
            this.txtTotalNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOutras
            // 
            this.txtOutras.BackColor = System.Drawing.Color.White;
            this.txtOutras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutras.Location = new System.Drawing.Point(528, 38);
            this.txtOutras.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutras.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtOutras.Name = "txtOutras";
            this.txtOutras.Size = new System.Drawing.Size(93, 27);
            this.txtOutras.TabIndex = 102;
            this.txtOutras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            this.txtOutras.Leave += new System.EventHandler(this.txtFrete_Leave);
            // 
            // txtSeguro
            // 
            this.txtSeguro.BackColor = System.Drawing.Color.White;
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(430, 38);
            this.txtSeguro.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeguro.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(93, 27);
            this.txtSeguro.TabIndex = 101;
            this.txtSeguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            this.txtSeguro.Leave += new System.EventHandler(this.txtFrete_Leave);
            // 
            // txtFrete
            // 
            this.txtFrete.BackColor = System.Drawing.Color.White;
            this.txtFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrete.Location = new System.Drawing.Point(328, 38);
            this.txtFrete.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrete.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(93, 27);
            this.txtFrete.TabIndex = 100;
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            this.txtFrete.Leave += new System.EventHandler(this.txtFrete_Leave);
            // 
            // lbTotalNota
            // 
            this.lbTotalNota.AutoSize = true;
            this.lbTotalNota.Location = new System.Drawing.Point(1027, 19);
            this.lbTotalNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalNota.Name = "lbTotalNota";
            this.lbTotalNota.Size = new System.Drawing.Size(65, 14);
            this.lbTotalNota.TabIndex = 99;
            this.lbTotalNota.Text = "Total Nota";
            // 
            // lbOutras
            // 
            this.lbOutras.AutoSize = true;
            this.lbOutras.Location = new System.Drawing.Point(525, 19);
            this.lbOutras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOutras.Name = "lbOutras";
            this.lbOutras.Size = new System.Drawing.Size(94, 14);
            this.lbOutras.TabIndex = 97;
            this.lbOutras.Text = "Outras Despesas";
            // 
            // lbSeguro
            // 
            this.lbSeguro.AutoSize = true;
            this.lbSeguro.Location = new System.Drawing.Point(428, 19);
            this.lbSeguro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSeguro.Name = "lbSeguro";
            this.lbSeguro.Size = new System.Drawing.Size(80, 14);
            this.lbSeguro.TabIndex = 95;
            this.lbSeguro.Text = "Custo Seguro";
            // 
            // lbFrete
            // 
            this.lbFrete.AutoSize = true;
            this.lbFrete.Location = new System.Drawing.Point(326, 19);
            this.lbFrete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFrete.Name = "lbFrete";
            this.lbFrete.Size = new System.Drawing.Size(69, 14);
            this.lbFrete.TabIndex = 93;
            this.lbFrete.Text = "Custo Frete";
            // 
            // lbCondicaoPg
            // 
            this.lbCondicaoPg.AutoSize = true;
            this.lbCondicaoPg.Location = new System.Drawing.Point(66, 19);
            this.lbCondicaoPg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCondicaoPg.Name = "lbCondicaoPg";
            this.lbCondicaoPg.Size = new System.Drawing.Size(139, 14);
            this.lbCondicaoPg.TabIndex = 90;
            this.lbCondicaoPg.Text = "Condição de Pagamento";
            // 
            // txtCondicao
            // 
            this.txtCondicao.Enabled = false;
            this.txtCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicao.Location = new System.Drawing.Point(68, 38);
            this.txtCondicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondicao.MaxLength = 100;
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.ReadOnly = true;
            this.txtCondicao.Size = new System.Drawing.Size(252, 27);
            this.txtCondicao.TabIndex = 46;
            // 
            // lbCodigoCondicao
            // 
            this.lbCodigoCondicao.AutoSize = true;
            this.lbCodigoCondicao.Location = new System.Drawing.Point(-3, 19);
            this.lbCodigoCondicao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoCondicao.Name = "lbCodigoCondicao";
            this.lbCodigoCondicao.Size = new System.Drawing.Size(48, 14);
            this.lbCodigoCondicao.TabIndex = 88;
            this.lbCodigoCondicao.Text = "Código";
            // 
            // txtCodCondicao
            // 
            this.txtCodCondicao.Enabled = false;
            this.txtCodCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCondicao.Location = new System.Drawing.Point(0, 38);
            this.txtCodCondicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodCondicao.MaxLength = 100;
            this.txtCodCondicao.Name = "txtCodCondicao";
            this.txtCodCondicao.ReadOnly = true;
            this.txtCodCondicao.Size = new System.Drawing.Size(62, 27);
            this.txtCodCondicao.TabIndex = 45;
            this.txtCodCondicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(768, 30);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(101, 24);
            this.btnAdicionar.TabIndex = 36;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // GbChave
            // 
            this.GbChave.Controls.Add(this.btnVerificar);
            this.GbChave.Controls.Add(this.Nome);
            this.GbChave.Controls.Add(this.txtNumNFC);
            this.GbChave.Controls.Add(this.label3);
            this.GbChave.Controls.Add(this.txtModeloNFC);
            this.GbChave.Controls.Add(this.label4);
            this.GbChave.Controls.Add(this.txtSerieNFC);
            this.GbChave.Controls.Add(this.clForn);
            this.GbChave.Controls.Add(this.txtFornecedor);
            this.GbChave.Controls.Add(this.btnBuscarFornecedor);
            this.GbChave.Location = new System.Drawing.Point(15, 29);
            this.GbChave.Margin = new System.Windows.Forms.Padding(2);
            this.GbChave.Name = "GbChave";
            this.GbChave.Padding = new System.Windows.Forms.Padding(2);
            this.GbChave.Size = new System.Drawing.Size(634, 73);
            this.GbChave.TabIndex = 0;
            this.GbChave.TabStop = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(442, 7);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(95, 24);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(1, 16);
            this.Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 14);
            this.Nome.TabIndex = 104;
            this.Nome.Text = "Nº Nota";
            // 
            // txtNumNFC
            // 
            this.txtNumNFC.BackColor = System.Drawing.Color.White;
            this.txtNumNFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumNFC.Location = new System.Drawing.Point(4, 35);
            this.txtNumNFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumNFC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumNFC.Name = "txtNumNFC";
            this.txtNumNFC.Size = new System.Drawing.Size(74, 27);
            this.txtNumNFC.TabIndex = 1;
            this.txtNumNFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumNFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 105;
            this.label3.Text = "Modelo Nota";
            // 
            // txtModeloNFC
            // 
            this.txtModeloNFC.BackColor = System.Drawing.Color.White;
            this.txtModeloNFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloNFC.Location = new System.Drawing.Point(88, 35);
            this.txtModeloNFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtModeloNFC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtModeloNFC.Name = "txtModeloNFC";
            this.txtModeloNFC.Size = new System.Drawing.Size(74, 27);
            this.txtModeloNFC.TabIndex = 2;
            this.txtModeloNFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModeloNFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 106;
            this.label4.Text = "Serie";
            // 
            // txtSerieNFC
            // 
            this.txtSerieNFC.BackColor = System.Drawing.Color.White;
            this.txtSerieNFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieNFC.Location = new System.Drawing.Point(173, 35);
            this.txtSerieNFC.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerieNFC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtSerieNFC.Name = "txtSerieNFC";
            this.txtSerieNFC.Size = new System.Drawing.Size(74, 27);
            this.txtSerieNFC.TabIndex = 3;
            this.txtSerieNFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerieNFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumNFC_KeyPress);
            // 
            // clForn
            // 
            this.clForn.AutoSize = true;
            this.clForn.Location = new System.Drawing.Point(336, 16);
            this.clForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clForn.Name = "clForn";
            this.clForn.Size = new System.Drawing.Size(68, 14);
            this.clForn.TabIndex = 97;
            this.clForn.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(339, 35);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.MaxLength = 100;
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.ReadOnly = true;
            this.txtFornecedor.Size = new System.Drawing.Size(198, 27);
            this.txtFornecedor.TabIndex = 5;
            // 
            // btnBuscarFornecedor
            // 
            this.btnBuscarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarFornecedor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarFornecedor.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFornecedor.Location = new System.Drawing.Point(541, 36);
            this.btnBuscarFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFornecedor.Name = "btnBuscarFornecedor";
            this.btnBuscarFornecedor.Size = new System.Drawing.Size(88, 24);
            this.btnBuscarFornecedor.TabIndex = 7;
            this.btnBuscarFornecedor.Text = "BUSCAR";
            this.btnBuscarFornecedor.UseVisualStyleBackColor = false;
            this.btnBuscarFornecedor.Click += new System.EventHandler(this.btnBuscarFornecedor_Click);
            // 
            // gbDatas
            // 
            this.gbDatas.Controls.Add(this.dtCancelada);
            this.gbDatas.Controls.Add(this.dtEmissao);
            this.gbDatas.Controls.Add(this.dtChegada);
            this.gbDatas.Controls.Add(this.lblDataCacelamento);
            this.gbDatas.Controls.Add(this.label8);
            this.gbDatas.Controls.Add(this.lblLinkVideo);
            this.gbDatas.Controls.Add(this.label7);
            this.gbDatas.Enabled = false;
            this.gbDatas.Location = new System.Drawing.Point(652, 29);
            this.gbDatas.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatas.Size = new System.Drawing.Size(488, 73);
            this.gbDatas.TabIndex = 108;
            this.gbDatas.TabStop = false;
            // 
            // dtCancelada
            // 
            this.dtCancelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCancelada.Location = new System.Drawing.Point(339, 35);
            this.dtCancelada.Name = "dtCancelada";
            this.dtCancelada.Size = new System.Drawing.Size(148, 27);
            this.dtCancelada.TabIndex = 10;
            this.dtCancelada.Visible = false;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEmissao.Location = new System.Drawing.Point(172, 35);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(148, 27);
            this.dtEmissao.TabIndex = 9;
            // 
            // dtChegada
            // 
            this.dtChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtChegada.Location = new System.Drawing.Point(6, 36);
            this.dtChegada.Name = "dtChegada";
            this.dtChegada.Size = new System.Drawing.Size(148, 27);
            this.dtChegada.TabIndex = 8;
            // 
            // lblDataCacelamento
            // 
            this.lblDataCacelamento.AutoSize = true;
            this.lblDataCacelamento.Location = new System.Drawing.Point(336, 16);
            this.lblDataCacelamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCacelamento.Name = "lblDataCacelamento";
            this.lblDataCacelamento.Size = new System.Drawing.Size(113, 14);
            this.lblDataCacelamento.TabIndex = 62;
            this.lblDataCacelamento.Text = "Data Cancelamento";
            this.lblDataCacelamento.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 59;
            this.label8.Text = "Data Chegada";
            // 
            // lblLinkVideo
            // 
            this.lblLinkVideo.AutoSize = true;
            this.lblLinkVideo.Location = new System.Drawing.Point(60, -17);
            this.lblLinkVideo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkVideo.Name = "lblLinkVideo";
            this.lblLinkVideo.Size = new System.Drawing.Size(285, 14);
            this.lblLinkVideo.TabIndex = 112;
            this.lblLinkVideo.Text = "https://www.youtube.com/watch?v=QOneV9GYaJc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 14);
            this.label7.TabIndex = 57;
            this.label7.Text = "Data Emissão";
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.btnAdicionar);
            this.gbProdutos.Controls.Add(this.label21);
            this.gbProdutos.Controls.Add(this.txtTotalItens);
            this.gbProdutos.Controls.Add(this.label20);
            this.gbProdutos.Controls.Add(this.txtUND);
            this.gbProdutos.Controls.Add(this.label18);
            this.gbProdutos.Controls.Add(this.label17);
            this.gbProdutos.Controls.Add(this.label16);
            this.gbProdutos.Controls.Add(this.txtCusto);
            this.gbProdutos.Controls.Add(this.txtDesconto);
            this.gbProdutos.Controls.Add(this.txtQtd);
            this.gbProdutos.Controls.Add(this.btnBuscarProduto);
            this.gbProdutos.Controls.Add(this.txtCodProduto);
            this.gbProdutos.Controls.Add(this.label5);
            this.gbProdutos.Controls.Add(this.label6);
            this.gbProdutos.Controls.Add(this.txtProduto);
            this.gbProdutos.Enabled = false;
            this.gbProdutos.Location = new System.Drawing.Point(15, 102);
            this.gbProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Padding = new System.Windows.Forms.Padding(2);
            this.gbProdutos.Size = new System.Drawing.Size(875, 73);
            this.gbProdutos.TabIndex = 113;
            this.gbProdutos.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(678, 10);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 14);
            this.label21.TabIndex = 125;
            this.label21.Text = "Total";
            // 
            // txtTotalItens
            // 
            this.txtTotalItens.BackColor = System.Drawing.Color.BurlyWood;
            this.txtTotalItens.Enabled = false;
            this.txtTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtTotalItens.Location = new System.Drawing.Point(682, 29);
            this.txtTotalItens.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalItens.Name = "txtTotalItens";
            this.txtTotalItens.ReadOnly = true;
            this.txtTotalItens.Size = new System.Drawing.Size(81, 27);
            this.txtTotalItens.TabIndex = 27;
            this.txtTotalItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(378, 13);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 14);
            this.label20.TabIndex = 123;
            this.label20.Text = "UND E.";
            // 
            // txtUND
            // 
            this.txtUND.Enabled = false;
            this.txtUND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtUND.Location = new System.Drawing.Point(381, 30);
            this.txtUND.Margin = new System.Windows.Forms.Padding(2);
            this.txtUND.Name = "txtUND";
            this.txtUND.Size = new System.Drawing.Size(56, 27);
            this.txtUND.TabIndex = 23;
            this.txtUND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(588, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 14);
            this.label18.TabIndex = 121;
            this.label18.Text = "Desconto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(498, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 14);
            this.label17.TabIndex = 120;
            this.label17.Text = "Custo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(442, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 14);
            this.label16.TabIndex = 119;
            this.label16.Text = "Qtd";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCusto.Location = new System.Drawing.Point(500, 29);
            this.txtCusto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(81, 27);
            this.txtCusto.TabIndex = 25;
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            this.txtCusto.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDesconto.Location = new System.Drawing.Point(591, 29);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(83, 27);
            this.txtDesconto.TabIndex = 26;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtQtd.Location = new System.Drawing.Point(444, 29);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(50, 27);
            this.txtQtd.TabIndex = 24;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProduto.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduto.Location = new System.Drawing.Point(288, 31);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(88, 24);
            this.btnBuscarProduto.TabIndex = 22;
            this.btnBuscarProduto.Text = "BUSCAR";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(1, 30);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProduto.MaxLength = 100;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(80, 27);
            this.txtCodProduto.TabIndex = 20;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProduto.Enter += new System.EventHandler(this.txtCodFornecedor_Enter);
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 113;
            this.label5.Text = "Cód Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 112;
            this.label6.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(88, 30);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduto.MaxLength = 100;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(194, 27);
            this.txtProduto.TabIndex = 21;
            // 
            // DgItensCompra
            // 
            this.DgItensCompra.AllowUserToAddRows = false;
            this.DgItensCompra.AllowUserToDeleteRows = false;
            this.DgItensCompra.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgItensCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgItensCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produto,
            this.produto,
            this.und,
            this.qtd_entrada,
            this.custo_atual,
            this.Custo_Sugerido,
            this.desconto,
            this.percentual_compra,
            this.preco_total,
            this.media_ponderada});
            this.DgItensCompra.Location = new System.Drawing.Point(14, 180);
            this.DgItensCompra.Margin = new System.Windows.Forms.Padding(2);
            this.DgItensCompra.MultiSelect = false;
            this.DgItensCompra.Name = "DgItensCompra";
            this.DgItensCompra.ReadOnly = true;
            this.DgItensCompra.RowHeadersWidth = 51;
            this.DgItensCompra.RowTemplate.Height = 24;
            this.DgItensCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgItensCompra.Size = new System.Drawing.Size(1125, 200);
            this.DgItensCompra.TabIndex = 126;
            // 
            // id_produto
            // 
            this.id_produto.HeaderText = "ID Produto";
            this.id_produto.MinimumWidth = 6;
            this.id_produto.Name = "id_produto";
            this.id_produto.ReadOnly = true;
            this.id_produto.Width = 107;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.MinimumWidth = 6;
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 400;
            // 
            // und
            // 
            this.und.HeaderText = "UND";
            this.und.MinimumWidth = 6;
            this.und.Name = "und";
            this.und.ReadOnly = true;
            this.und.Width = 125;
            // 
            // qtd_entrada
            // 
            this.qtd_entrada.HeaderText = "Qtd Entrada";
            this.qtd_entrada.MinimumWidth = 6;
            this.qtd_entrada.Name = "qtd_entrada";
            this.qtd_entrada.ReadOnly = true;
            this.qtd_entrada.Width = 125;
            // 
            // custo_atual
            // 
            this.custo_atual.HeaderText = "Custo Atual";
            this.custo_atual.MinimumWidth = 6;
            this.custo_atual.Name = "custo_atual";
            this.custo_atual.ReadOnly = true;
            this.custo_atual.Width = 125;
            // 
            // Custo_Sugerido
            // 
            this.Custo_Sugerido.HeaderText = "Preço Compra";
            this.Custo_Sugerido.MinimumWidth = 6;
            this.Custo_Sugerido.Name = "Custo_Sugerido";
            this.Custo_Sugerido.ReadOnly = true;
            this.Custo_Sugerido.Width = 125;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.MinimumWidth = 6;
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            this.desconto.Width = 125;
            // 
            // percentual_compra
            // 
            this.percentual_compra.HeaderText = "% Compra";
            this.percentual_compra.MinimumWidth = 6;
            this.percentual_compra.Name = "percentual_compra";
            this.percentual_compra.ReadOnly = true;
            this.percentual_compra.Width = 125;
            // 
            // preco_total
            // 
            this.preco_total.HeaderText = "Preço Total";
            this.preco_total.MinimumWidth = 6;
            this.preco_total.Name = "preco_total";
            this.preco_total.ReadOnly = true;
            this.preco_total.Width = 125;
            // 
            // media_ponderada
            // 
            this.media_ponderada.HeaderText = "Média Ponderada";
            this.media_ponderada.MinimumWidth = 6;
            this.media_ponderada.Name = "media_ponderada";
            this.media_ponderada.ReadOnly = true;
            this.media_ponderada.Width = 125;
            // 
            // dtDataCad
            // 
            this.dtDataCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtDataCad.Location = new System.Drawing.Point(911, 478);
            this.dtDataCad.Name = "dtDataCad";
            this.dtDataCad.Size = new System.Drawing.Size(230, 22);
            this.dtDataCad.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 87;
            this.label1.Text = "Data Cad.";
            // 
            // FrmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1163, 606);
            this.Controls.Add(this.DgItensCompra);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.gbCondicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDataCad);
            this.Controls.Add(this.lvParcelas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GbChave);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmCadastroCompra";
            this.Text = "Compras";
            this.Controls.SetChildIndex(this.GbChave, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lvParcelas, 0);
            this.Controls.SetChildIndex(this.dtDataCad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.gbCondicao, 0);
            this.Controls.SetChildIndex(this.gbDatas, 0);
            this.Controls.SetChildIndex(this.gbProdutos, 0);
            this.Controls.SetChildIndex(this.DgItensCompra, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.gbCondicao.ResumeLayout(false);
            this.gbCondicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeguro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFrete)).EndInit();
            this.GbChave.ResumeLayout(false);
            this.GbChave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModeloNFC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieNFC)).EndInit();
            this.gbDatas.ResumeLayout(false);
            this.gbDatas.PerformLayout();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgItensCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ListView lvParcelas;
        private System.Windows.Forms.ColumnHeader clParcelas;
        private System.Windows.Forms.ColumnHeader clDias;
        private System.Windows.Forms.ColumnHeader clForma;
        private System.Windows.Forms.ColumnHeader clPercentTotal;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Button btnBuscarFornecedor;
        private System.Windows.Forms.Label lblLinkVideo;
        protected System.Windows.Forms.Button btnBuscarProduto;
        protected System.Windows.Forms.Button btnAdicionar;
        protected System.Windows.Forms.Button btnVerificar;
        public System.Windows.Forms.DateTimePicker dtCancelada;
        public System.Windows.Forms.Label lblDataCacelamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn und;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo_atual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo_Sugerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentual_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn media_ponderada;
        private System.Windows.Forms.ColumnHeader clPreco;
        protected System.Windows.Forms.DateTimePicker dtDataCad;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox gbCondicao;
        protected System.Windows.Forms.GroupBox gbDatas;
        protected System.Windows.Forms.GroupBox gbProdutos;
        protected System.Windows.Forms.DataGridView DgItensCompra;
        public System.Windows.Forms.GroupBox GbChave;
        protected System.Windows.Forms.Label lbCondicaoPg;
        protected System.Windows.Forms.TextBox txtCondicao;
        protected System.Windows.Forms.Label lbCodigoCondicao;
        protected System.Windows.Forms.TextBox txtCodCondicao;
        protected System.Windows.Forms.Label lbTotalNota;
        protected System.Windows.Forms.Label lbOutras;
        protected System.Windows.Forms.Label lbSeguro;
        protected System.Windows.Forms.Label lbFrete;
        protected System.Windows.Forms.Label clForn;
        protected System.Windows.Forms.TextBox txtFornecedor;
        protected System.Windows.Forms.Label Nome;
        protected System.Windows.Forms.NumericUpDown txtNumNFC;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.NumericUpDown txtModeloNFC;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.NumericUpDown txtSerieNFC;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.DateTimePicker dtChegada;
        protected System.Windows.Forms.DateTimePicker dtEmissao;
        protected System.Windows.Forms.NumericUpDown txtFrete;
        protected System.Windows.Forms.NumericUpDown txtOutras;
        protected System.Windows.Forms.NumericUpDown txtSeguro;
        protected System.Windows.Forms.NumericUpDown txtTotalNota;
        protected System.Windows.Forms.TextBox txtCodProduto;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox txtProduto;
        protected System.Windows.Forms.Label label21;
        protected System.Windows.Forms.TextBox txtTotalItens;
        protected System.Windows.Forms.Label label20;
        protected System.Windows.Forms.TextBox txtUND;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.TextBox txtCusto;
        protected System.Windows.Forms.TextBox txtDesconto;
        protected System.Windows.Forms.TextBox txtQtd;
    }
}
