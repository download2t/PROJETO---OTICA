namespace ELP4PROJETO.Consultas
{
    partial class FrmConsultaEstado
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
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCriacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbUF = new System.Windows.Forms.RadioButton();
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(498, 477);
            this.btnBuscar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(783, 475);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(689, 475);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(594, 475);
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.estado,
            this.uf,
            this.pais,
            this.dataCriacao,
            this.dataUltAlt,
            this.clStatus});
            this.listView1.Size = new System.Drawing.Size(949, 369);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbUF);
            this.pnTop.Controls.Add(this.rbPais);
            this.pnTop.Controls.Add(this.rbEstado);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Size = new System.Drawing.Size(948, 34);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbEstado, 0);
            this.pnTop.Controls.SetChildIndex(this.rbPais, 0);
            this.pnTop.Controls.SetChildIndex(this.rbUF, 0);
            this.pnTop.Controls.SetChildIndex(this.cbInativos, 0);
            this.pnTop.Controls.SetChildIndex(this.btnDiminuirFonte, 0);
            this.pnTop.Controls.SetChildIndex(this.btnAumentarFonte, 0);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(875, 27);
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
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigo.Size = new System.Drawing.Size(857, 22);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(878, 475);
            // 
            // estado
            // 
            this.estado.Text = "Estado";
            this.estado.Width = 200;
            // 
            // uf
            // 
            this.uf.Text = "UF";
            this.uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pais
            // 
            this.pais.Text = "Pais";
            this.pais.Width = 180;
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
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPais.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbPais.ForeColor = System.Drawing.Color.White;
            this.rbPais.Location = new System.Drawing.Point(169, 0);
            this.rbPais.Margin = new System.Windows.Forms.Padding(4);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(63, 34);
            this.rbPais.TabIndex = 6;
            this.rbPais.Text = "País";
            this.rbPais.UseVisualStyleBackColor = true;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Checked = true;
            this.rbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbEstado.ForeColor = System.Drawing.Color.White;
            this.rbEstado.Location = new System.Drawing.Point(85, 0);
            this.rbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(84, 34);
            this.rbEstado.TabIndex = 5;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
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
            // rbUF
            // 
            this.rbUF.AutoSize = true;
            this.rbUF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUF.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbUF.ForeColor = System.Drawing.Color.White;
            this.rbUF.Location = new System.Drawing.Point(232, 0);
            this.rbUF.Margin = new System.Windows.Forms.Padding(4);
            this.rbUF.Name = "rbUF";
            this.rbUF.Size = new System.Drawing.Size(52, 34);
            this.rbUF.TabIndex = 7;
            this.rbUF.Text = "UF";
            this.rbUF.UseVisualStyleBackColor = true;
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
            this.cbInativos.Location = new System.Drawing.Point(284, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 9;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmConsultaEstado";
            this.Text = "Consultar estados";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader uf;
        private System.Windows.Forms.ColumnHeader pais;
        private System.Windows.Forms.ColumnHeader dataCriacao;
        private System.Windows.Forms.ColumnHeader dataUltAlt;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbUF;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
