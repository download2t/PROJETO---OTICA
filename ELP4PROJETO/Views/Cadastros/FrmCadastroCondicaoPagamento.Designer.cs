namespace ELP4PROJETO.Views.Cadastros
{
    partial class frm
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatUltAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatCad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBuscarForma = new System.Windows.Forms.Button();
            this.DgCondicao = new System.Windows.Forms.DataGridView();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_totais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idForma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPercentualTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtForma = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodForma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCondicao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgCondicao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(475, 409);
            this.btnSalvar.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(695, 9);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(39, 44);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(41, 62);
            this.txtCodigo.Size = new System.Drawing.Size(79, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(569, 408);
            this.btnSair.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 208;
            this.label3.Text = "Data Ult. Alt";
            // 
            // txtDatUltAlt
            // 
            this.txtDatUltAlt.Enabled = false;
            this.txtDatUltAlt.Location = new System.Drawing.Point(158, 411);
            this.txtDatUltAlt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatUltAlt.Name = "txtDatUltAlt";
            this.txtDatUltAlt.Size = new System.Drawing.Size(112, 22);
            this.txtDatUltAlt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 206;
            this.label2.Text = "Data Cad.";
            // 
            // txtDatCad
            // 
            this.txtDatCad.Enabled = false;
            this.txtDatCad.Location = new System.Drawing.Point(42, 411);
            this.txtDatCad.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatCad.Name = "txtDatCad";
            this.txtDatCad.Size = new System.Drawing.Size(112, 22);
            this.txtDatCad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 14);
            this.label6.TabIndex = 204;
            this.label6.Text = "Taxa";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(561, 63);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 24);
            this.btnAdicionar.TabIndex = 203;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBuscarForma
            // 
            this.btnBuscarForma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarForma.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBuscarForma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarForma.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarForma.ForeColor = System.Drawing.Color.White;
            this.btnBuscarForma.Location = new System.Drawing.Point(569, 112);
            this.btnBuscarForma.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarForma.Name = "btnBuscarForma";
            this.btnBuscarForma.Size = new System.Drawing.Size(88, 24);
            this.btnBuscarForma.TabIndex = 12;
            this.btnBuscarForma.Text = "BUSCAR";
            this.btnBuscarForma.UseVisualStyleBackColor = false;
            this.btnBuscarForma.Click += new System.EventHandler(this.btnBuscarForma_Click);
            // 
            // DgCondicao
            // 
            this.DgCondicao.AllowUserToAddRows = false;
            this.DgCondicao.AllowUserToDeleteRows = false;
            this.DgCondicao.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgCondicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCondicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_parcela,
            this.dias_totais,
            this.idForma,
            this.forma_pagamento,
            this.percentual});
            this.DgCondicao.Location = new System.Drawing.Point(41, 143);
            this.DgCondicao.Margin = new System.Windows.Forms.Padding(2);
            this.DgCondicao.Name = "DgCondicao";
            this.DgCondicao.ReadOnly = true;
            this.DgCondicao.RowHeadersWidth = 51;
            this.DgCondicao.RowTemplate.Height = 24;
            this.DgCondicao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCondicao.Size = new System.Drawing.Size(615, 248);
            this.DgCondicao.TabIndex = 201;
            // 
            // num_parcela
            // 
            this.num_parcela.HeaderText = "N° Parcela";
            this.num_parcela.MinimumWidth = 6;
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.ReadOnly = true;
            this.num_parcela.Width = 125;
            // 
            // dias_totais
            // 
            this.dias_totais.HeaderText = "Dias";
            this.dias_totais.MinimumWidth = 6;
            this.dias_totais.Name = "dias_totais";
            this.dias_totais.ReadOnly = true;
            this.dias_totais.Width = 125;
            // 
            // idForma
            // 
            this.idForma.HeaderText = "Cód Forma";
            this.idForma.MinimumWidth = 6;
            this.idForma.Name = "idForma";
            this.idForma.ReadOnly = true;
            this.idForma.Width = 125;
            // 
            // forma_pagamento
            // 
            this.forma_pagamento.HeaderText = "Forma de Pagamento";
            this.forma_pagamento.MinimumWidth = 6;
            this.forma_pagamento.Name = "forma_pagamento";
            this.forma_pagamento.ReadOnly = true;
            this.forma_pagamento.Width = 150;
            // 
            // percentual
            // 
            this.percentual.HeaderText = "% Sub Total";
            this.percentual.MinimumWidth = 6;
            this.percentual.Name = "percentual";
            this.percentual.ReadOnly = true;
            this.percentual.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 14);
            this.label13.TabIndex = 200;
            this.label13.Text = "% Total";
            // 
            // txtPercentualTotal
            // 
            this.txtPercentualTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPercentualTotal.Enabled = false;
            this.txtPercentualTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentualTotal.Location = new System.Drawing.Point(493, 62);
            this.txtPercentualTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentualTotal.Name = "txtPercentualTotal";
            this.txtPercentualTotal.ReadOnly = true;
            this.txtPercentualTotal.Size = new System.Drawing.Size(60, 27);
            this.txtPercentualTotal.TabIndex = 6;
            this.txtPercentualTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 94);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 14);
            this.label12.TabIndex = 198;
            this.label12.Text = "Código";
            // 
            // txtForma
            // 
            this.txtForma.Enabled = false;
            this.txtForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForma.Location = new System.Drawing.Point(391, 111);
            this.txtForma.Margin = new System.Windows.Forms.Padding(2);
            this.txtForma.Name = "txtForma";
            this.txtForma.ReadOnly = true;
            this.txtForma.Size = new System.Drawing.Size(173, 27);
            this.txtForma.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 14);
            this.label11.TabIndex = 196;
            this.label11.Text = "Forma de Pagamento";
            // 
            // txtCodForma
            // 
            this.txtCodForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodForma.Location = new System.Drawing.Point(307, 111);
            this.txtCodForma.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodForma.Name = "txtCodForma";
            this.txtCodForma.Size = new System.Drawing.Size(77, 27);
            this.txtCodForma.TabIndex = 10;
            this.txtCodForma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodForma.Enter += new System.EventHandler(this.tbIdForma_Enter);
            this.txtCodForma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcelas_KeyPress);
            this.txtCodForma.Leave += new System.EventHandler(this.txtCodForma_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 14);
            this.label10.TabIndex = 194;
            this.label10.Text = "%";
            // 
            // txtPercentual
            // 
            this.txtPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentual.Location = new System.Drawing.Point(452, 62);
            this.txtPercentual.Margin = new System.Windows.Forms.Padding(2);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(33, 27);
            this.txtPercentual.TabIndex = 5;
            this.txtPercentual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentual_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 14);
            this.label9.TabIndex = 192;
            this.label9.Text = "Dias";
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(411, 62);
            this.txtDias.Margin = new System.Windows.Forms.Padding(2);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(33, 27);
            this.txtDias.TabIndex = 4;
            this.txtDias.Text = "30";
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcelas_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 14);
            this.label8.TabIndex = 190;
            this.label8.Text = "Desconto";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(219, 111);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(79, 27);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentual_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 188;
            this.label7.Text = "Multa";
            // 
            // txtMulta
            // 
            this.txtMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.Location = new System.Drawing.Point(130, 111);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(2);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(82, 27);
            this.txtMulta.TabIndex = 8;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentual_KeyPress);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxa.Location = new System.Drawing.Point(41, 111);
            this.txtTaxa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(79, 27);
            this.txtTaxa.TabIndex = 7;
            this.txtTaxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentual_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 185;
            this.label5.Text = "Parcela";
            // 
            // txtParcelas
            // 
            this.txtParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParcelas.Location = new System.Drawing.Point(352, 62);
            this.txtParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(52, 27);
            this.txtParcelas.TabIndex = 3;
            this.txtParcelas.Text = "1";
            this.txtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcelas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 183;
            this.label4.Text = "Condição";
            // 
            // txtCondicao
            // 
            this.txtCondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCondicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicao.Location = new System.Drawing.Point(130, 62);
            this.txtCondicao.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondicao.Name = "txtCondicao";
            this.txtCondicao.Size = new System.Drawing.Size(216, 27);
            this.txtCondicao.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(382, 409);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 24);
            this.btnExcluir.TabIndex = 211;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.Sienna;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(287, 409);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 24);
            this.btnLimpar.TabIndex = 212;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 444);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatUltAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatCad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnBuscarForma);
            this.Controls.Add(this.DgCondicao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPercentualTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodForma);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCondicao);
            this.Name = "frm";
            this.Text = "Condição de pagamento";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtCondicao, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtParcelas, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtTaxa, 0);
            this.Controls.SetChildIndex(this.txtMulta, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtDesconto, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtDias, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtPercentual, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtCodForma, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtForma, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.txtPercentualTotal, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.DgCondicao, 0);
            this.Controls.SetChildIndex(this.btnBuscarForma, 0);
            this.Controls.SetChildIndex(this.btnAdicionar, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDatUltAlt, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnLimpar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgCondicao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDatUltAlt;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDatCad;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnAdicionar;
        protected System.Windows.Forms.Button btnBuscarForma;
        private System.Windows.Forms.DataGridView DgCondicao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPercentualTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtForma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodForma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCondicao;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_totais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idForma;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentual;
    }
}