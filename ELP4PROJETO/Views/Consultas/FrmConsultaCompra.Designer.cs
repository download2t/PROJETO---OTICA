namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaCompra
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
            this.dtData2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtData1 = new System.Windows.Forms.DateTimePicker();
            this.clModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSerie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clforn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataEm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCancel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCodF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCond = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFrete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSeguro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLOutras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataChegada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCanceladas = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.cbDatas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.txtSerie = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.NumericUpDown();
            this.txtForn = new System.Windows.Forms.NumericUpDown();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1113, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3);
            this.toolTip1.SetToolTip(this.btnBuscar, "Busca com base nos filtros");
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1067, 587);
            this.btnExcluir.Size = new System.Drawing.Size(134, 24);
            this.btnExcluir.Text = "Cancelar Compra";
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.Location = new System.Drawing.Point(332, 74);
            this.btnAlterar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(926, 587);
            this.btnIncluir.Size = new System.Drawing.Size(134, 24);
            this.btnIncluir.Text = "Nova Compra";
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clModelo,
            this.clSerie,
            this.clCodF,
            this.clforn,
            this.clCond,
            this.clTotal,
            this.clFrete,
            this.clSeguro,
            this.cLOutras,
            this.clDataChegada,
            this.clDataEm,
            this.clDataCancel,
            this.clDataC});
            this.listView1.Location = new System.Drawing.Point(10, 108);
            this.listView1.Margin = new System.Windows.Forms.Padding(3);
            this.listView1.Size = new System.Drawing.Size(1285, 472);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.txtForn);
            this.pnTop.Controls.Add(this.txtModelo);
            this.pnTop.Controls.Add(this.txtSerie);
            this.pnTop.Controls.Add(this.txtNumero);
            this.pnTop.Controls.Add(this.label5);
            this.pnTop.Controls.Add(this.label4);
            this.pnTop.Controls.Add(this.label2);
            this.pnTop.Controls.Add(this.lbM);
            this.pnTop.Location = new System.Drawing.Point(10, 56);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3);
            this.pnTop.Size = new System.Drawing.Size(1284, 46);
            this.pnTop.Controls.SetChildIndex(this.lbM, 0);
            this.pnTop.Controls.SetChildIndex(this.label2, 0);
            this.pnTop.Controls.SetChildIndex(this.label4, 0);
            this.pnTop.Controls.SetChildIndex(this.label5, 0);
            this.pnTop.Controls.SetChildIndex(this.txtNumero, 0);
            this.pnTop.Controls.SetChildIndex(this.txtSerie, 0);
            this.pnTop.Controls.SetChildIndex(this.txtModelo, 0);
            this.pnTop.Controls.SetChildIndex(this.txtForn, 0);
            this.pnTop.Controls.SetChildIndex(this.btnDiminuirFonte, 0);
            this.pnTop.Controls.SetChildIndex(this.btnAumentarFonte, 0);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1208, 28);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualizar página");
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1319, 9);
            // 
            // btnAumentarFonte
            // 
            this.btnAumentarFonte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAumentarFonte.FlatAppearance.BorderSize = 0;
            this.btnAumentarFonte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAumentarFonte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnAumentarFonte, "Aumenta a fonte da lista.");
            // 
            // btnDiminuirFonte
            // 
            this.btnDiminuirFonte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiminuirFonte.FlatAppearance.BorderSize = 0;
            this.btnDiminuirFonte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiminuirFonte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip1.SetToolTip(this.btnDiminuirFonte, "Diminui a fonte da lista");
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(8, 10);
            this.lblCodigo.Size = new System.Drawing.Size(68, 14);
            this.lblCodigo.Text = "Fornecedor";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 29);
            this.txtCodigo.Size = new System.Drawing.Size(270, 22);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1208, 587);
            // 
            // dtData2
            // 
            this.dtData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData2.Location = new System.Drawing.Point(859, 29);
            this.dtData2.Name = "dtData2";
            this.dtData2.Size = new System.Drawing.Size(245, 22);
            this.dtData2.TabIndex = 567;
            this.toolTip1.SetToolTip(this.dtData2, "Data final do período de busca");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(857, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 14);
            this.label1.TabIndex = 569;
            this.label1.Text = "Periodo : Fim da busca";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(607, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 14);
            this.label3.TabIndex = 568;
            this.label3.Text = "Periodo : Inicio de busca";
            // 
            // dtData1
            // 
            this.dtData1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtData1.Location = new System.Drawing.Point(610, 29);
            this.dtData1.Name = "dtData1";
            this.dtData1.Size = new System.Drawing.Size(245, 22);
            this.dtData1.TabIndex = 566;
            this.toolTip1.SetToolTip(this.dtData1, "Data inicial do período de busca");
            // 
            // clModelo
            // 
            this.clModelo.Text = "Modelo";
            // 
            // clSerie
            // 
            this.clSerie.Text = "Série";
            // 
            // clforn
            // 
            this.clforn.Text = "Fornecedor";
            this.clforn.Width = 200;
            // 
            // clDataEm
            // 
            this.clDataEm.Text = "Emissao";
            this.clDataEm.Width = 130;
            // 
            // clDataCancel
            // 
            this.clDataCancel.Text = "Cancelamento";
            this.clDataCancel.Width = 130;
            // 
            // clCodF
            // 
            this.clCodF.Text = "Cód F.";
            // 
            // clCond
            // 
            this.clCond.Text = "Condição";
            this.clCond.Width = 250;
            // 
            // clTotal
            // 
            this.clTotal.Text = "Total";
            this.clTotal.Width = 100;
            // 
            // clFrete
            // 
            this.clFrete.Text = "Frete";
            this.clFrete.Width = 100;
            // 
            // clSeguro
            // 
            this.clSeguro.Text = "Seguro";
            this.clSeguro.Width = 100;
            // 
            // cLOutras
            // 
            this.cLOutras.Text = "Outras";
            this.cLOutras.Width = 100;
            // 
            // clDataChegada
            // 
            this.clDataChegada.Text = "Chegada";
            this.clDataChegada.Width = 130;
            // 
            // clDataC
            // 
            this.clDataC.Text = "Criação";
            this.clDataC.Width = 130;
            // 
            // cbCanceladas
            // 
            this.cbCanceladas.AutoSize = true;
            this.cbCanceladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanceladas.Location = new System.Drawing.Point(286, 27);
            this.cbCanceladas.Name = "cbCanceladas";
            this.cbCanceladas.Size = new System.Drawing.Size(170, 24);
            this.cbCanceladas.TabIndex = 14;
            this.cbCanceladas.Text = "Mostrar Canceladas";
            this.cbCanceladas.UseVisualStyleBackColor = true;
            this.cbCanceladas.CheckedChanged += new System.EventHandler(this.cbCanceladas_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(236, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 14);
            this.label5.TabIndex = 581;
            this.label5.Text = "C. Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 580;
            this.label4.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 579;
            this.label2.Text = "Modelo";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.ForeColor = System.Drawing.Color.White;
            this.lbM.Location = new System.Drawing.Point(156, 2);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(34, 14);
            this.lbM.TabIndex = 578;
            this.lbM.Text = "Série";
            // 
            // cbDatas
            // 
            this.cbDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDatas.FormattingEnabled = true;
            this.cbDatas.Items.AddRange(new object[] {
            "CHEGADA",
            "EMISSAO",
            "CANCELAMENTO"});
            this.cbDatas.Location = new System.Drawing.Point(457, 28);
            this.cbDatas.Name = "cbDatas";
            this.cbDatas.Size = new System.Drawing.Size(146, 22);
            this.cbDatas.TabIndex = 570;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(454, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 14);
            this.label6.TabIndex = 571;
            this.label6.Text = "Tipo de data";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(3, 18);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(74, 27);
            this.txtNumero.TabIndex = 582;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.White;
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(158, 18);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtSerie.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(74, 27);
            this.txtSerie.TabIndex = 583;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.White;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(80, 18);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(74, 27);
            this.txtModelo.TabIndex = 584;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtForn
            // 
            this.txtForn.BackColor = System.Drawing.Color.White;
            this.txtForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForn.Location = new System.Drawing.Point(239, 18);
            this.txtForn.Margin = new System.Windows.Forms.Padding(2);
            this.txtForn.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(74, 27);
            this.txtForn.TabIndex = 585;
            this.txtForn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtForn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // FrmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1319, 620);
            this.Controls.Add(this.cbCanceladas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDatas);
            this.Controls.Add(this.dtData2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmConsultaCompra";
            this.Text = "Consultar Compras";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dtData1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtData2, 0);
            this.Controls.SetChildIndex(this.cbDatas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.cbCanceladas, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnIncluir, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.Controls.SetChildIndex(this.pnTop, 0);
            this.Controls.SetChildIndex(this.btnAtualizar, 0);
            this.Controls.SetChildIndex(this.btnAlterar, 0);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtForn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clModelo;
        private System.Windows.Forms.ColumnHeader clSerie;
        private System.Windows.Forms.ColumnHeader clforn;
        private System.Windows.Forms.ColumnHeader clDataEm;
        private System.Windows.Forms.ColumnHeader clDataCancel;
        private System.Windows.Forms.ColumnHeader clCodF;
        private System.Windows.Forms.ColumnHeader clCond;
        private System.Windows.Forms.ColumnHeader clTotal;
        private System.Windows.Forms.ColumnHeader clFrete;
        private System.Windows.Forms.ColumnHeader clSeguro;
        private System.Windows.Forms.ColumnHeader cLOutras;
        private System.Windows.Forms.ColumnHeader clDataChegada;
        private System.Windows.Forms.ColumnHeader clDataC;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lbM;
        protected System.Windows.Forms.NumericUpDown txtForn;
        protected System.Windows.Forms.NumericUpDown txtModelo;
        protected System.Windows.Forms.NumericUpDown txtSerie;
        protected System.Windows.Forms.NumericUpDown txtNumero;
        protected System.Windows.Forms.DateTimePicker dtData2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.DateTimePicker dtData1;
        protected System.Windows.Forms.CheckBox cbCanceladas;
        protected System.Windows.Forms.ComboBox cbDatas;
        protected System.Windows.Forms.Label label6;
    }
}
