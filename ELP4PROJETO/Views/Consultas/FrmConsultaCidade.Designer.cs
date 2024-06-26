namespace ELP4PROJETO.Consultas
{
    partial class FrmConsultaCidade
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
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCriacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbDDD = new System.Windows.Forms.RadioButton();
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(500, 476);
            this.btnBuscar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(785, 474);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(691, 474);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(596, 474);
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cidade,
            this.ddd,
            this.estado,
            this.dataCriacao,
            this.dataUltAlt,
            this.clStatus});
            this.listView1.Size = new System.Drawing.Size(951, 370);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbDDD);
            this.pnTop.Controls.Add(this.rbPais);
            this.pnTop.Controls.Add(this.rbEstado);
            this.pnTop.Controls.Add(this.rbCidade);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Size = new System.Drawing.Size(950, 34);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbCidade, 0);
            this.pnTop.Controls.SetChildIndex(this.rbEstado, 0);
            this.pnTop.Controls.SetChildIndex(this.rbPais, 0);
            this.pnTop.Controls.SetChildIndex(this.rbDDD, 0);
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
            this.txtCodigo.Size = new System.Drawing.Size(859, 22);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(880, 474);
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 200;
            // 
            // ddd
            // 
            this.ddd.Text = "DDD";
            this.ddd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 180;
            // 
            // dataCriacao
            // 
            this.dataCriacao.Text = "Data Cadastro";
            this.dataCriacao.Width = 130;
            // 
            // dataUltAlt
            // 
            this.dataUltAlt.Text = "Ultima Alteração";
            this.dataUltAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataUltAlt.Width = 130;
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.Checked = true;
            this.rbCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCidade.ForeColor = System.Drawing.Color.White;
            this.rbCidade.Location = new System.Drawing.Point(85, 0);
            this.rbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(85, 34);
            this.rbCidade.TabIndex = 6;
            this.rbCidade.TabStop = true;
            this.rbCidade.Text = "Cidade";
            this.rbCidade.UseVisualStyleBackColor = true;
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
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbEstado.ForeColor = System.Drawing.Color.White;
            this.rbEstado.Location = new System.Drawing.Point(170, 0);
            this.rbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(84, 34);
            this.rbEstado.TabIndex = 7;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPais.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbPais.ForeColor = System.Drawing.Color.White;
            this.rbPais.Location = new System.Drawing.Point(254, 0);
            this.rbPais.Margin = new System.Windows.Forms.Padding(4);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(63, 34);
            this.rbPais.TabIndex = 8;
            this.rbPais.Text = "País";
            this.rbPais.UseVisualStyleBackColor = true;
            // 
            // rbDDD
            // 
            this.rbDDD.AutoSize = true;
            this.rbDDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDDD.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDDD.ForeColor = System.Drawing.Color.White;
            this.rbDDD.Location = new System.Drawing.Point(317, 0);
            this.rbDDD.Margin = new System.Windows.Forms.Padding(4);
            this.rbDDD.Name = "rbDDD";
            this.rbDDD.Size = new System.Drawing.Size(67, 34);
            this.rbDDD.TabIndex = 9;
            this.rbDDD.Text = "DDD";
            this.rbDDD.UseVisualStyleBackColor = true;
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
            this.cbInativos.Location = new System.Drawing.Point(384, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 10;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmConsultaCidade";
            this.Text = "Consultar cidades";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader ddd;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader dataCriacao;
        private System.Windows.Forms.ColumnHeader dataUltAlt;
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbDDD;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
