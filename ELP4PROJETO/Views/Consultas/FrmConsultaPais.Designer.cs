namespace ELP4PROJETO.Consultas
{
    partial class FrmConsultaPais
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
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCriacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbDDI = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbSigla = new System.Windows.Forms.RadioButton();
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 474);
            this.btnBuscar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(786, 475);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(689, 474);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(594, 474);
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.sigla,
            this.ddi,
            this.dataCriacao,
            this.dataUltAlt,
            this.clStatus});
            this.listView1.Size = new System.Drawing.Size(949, 370);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbSigla);
            this.pnTop.Controls.Add(this.rbDDI);
            this.pnTop.Controls.Add(this.rbPais);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Size = new System.Drawing.Size(948, 34);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbPais, 0);
            this.pnTop.Controls.SetChildIndex(this.rbDDI, 0);
            this.pnTop.Controls.SetChildIndex(this.rbSigla, 0);
            this.pnTop.Controls.SetChildIndex(this.cbInativos, 0);
            this.pnTop.Controls.SetChildIndex(this.btnDiminuirFonte, 0);
            this.pnTop.Controls.SetChildIndex(this.btnAumentarFonte, 0);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(877, 27);
            this.toolTip1.SetToolTip(this.btnAtualizar, "Atualizar página");
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
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCodigo.Size = new System.Drawing.Size(860, 22);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(882, 475);
            this.btnSair.Size = new System.Drawing.Size(83, 24);
            // 
            // nome
            // 
            this.nome.Text = "País";
            this.nome.Width = 200;
            // 
            // sigla
            // 
            this.sigla.Text = "Sigla";
            this.sigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ddi
            // 
            this.ddi.Text = "DDI";
            this.ddi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataCriacao
            // 
            this.dataCriacao.Text = "Data Cadastro";
            this.dataCriacao.Width = 130;
            // 
            // dataUltAlt
            // 
            this.dataUltAlt.Text = "Ultima Alteração";
            this.dataUltAlt.Width = 130;
            // 
            // rbDDI
            // 
            this.rbDDI.AutoSize = true;
            this.rbDDI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDDI.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDDI.ForeColor = System.Drawing.Color.White;
            this.rbDDI.Location = new System.Drawing.Point(148, 0);
            this.rbDDI.Margin = new System.Windows.Forms.Padding(4);
            this.rbDDI.Name = "rbDDI";
            this.rbDDI.Size = new System.Drawing.Size(58, 34);
            this.rbDDI.TabIndex = 6;
            this.rbDDI.Text = "DDI";
            this.rbDDI.UseVisualStyleBackColor = true;
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Checked = true;
            this.rbPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPais.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbPais.ForeColor = System.Drawing.Color.White;
            this.rbPais.Location = new System.Drawing.Point(85, 0);
            this.rbPais.Margin = new System.Windows.Forms.Padding(4);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(63, 34);
            this.rbPais.TabIndex = 5;
            this.rbPais.TabStop = true;
            this.rbPais.Text = "País";
            this.rbPais.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCodigo.ForeColor = System.Drawing.Color.White;
            this.rbCodigo.Location = new System.Drawing.Point(0, 0);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(85, 34);
            this.rbCodigo.TabIndex = 4;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbSigla
            // 
            this.rbSigla.AutoSize = true;
            this.rbSigla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSigla.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbSigla.ForeColor = System.Drawing.Color.White;
            this.rbSigla.Location = new System.Drawing.Point(206, 0);
            this.rbSigla.Margin = new System.Windows.Forms.Padding(4);
            this.rbSigla.Name = "rbSigla";
            this.rbSigla.Size = new System.Drawing.Size(68, 34);
            this.rbSigla.TabIndex = 7;
            this.rbSigla.Text = "Sigla";
            this.rbSigla.UseVisualStyleBackColor = true;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clStatus.Width = 80;
            // 
            // cbInativos
            // 
            this.cbInativos.AutoSize = true;
            this.cbInativos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbInativos.ForeColor = System.Drawing.Color.White;
            this.cbInativos.Location = new System.Drawing.Point(274, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 8;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmConsultaPais";
            this.Text = "Consultar países";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader sigla;
        private System.Windows.Forms.ColumnHeader ddi;
        private System.Windows.Forms.ColumnHeader dataCriacao;
        private System.Windows.Forms.ColumnHeader dataUltAlt;
        private System.Windows.Forms.RadioButton rbDDI;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbSigla;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
