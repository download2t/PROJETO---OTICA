namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaFormaPagamento
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
            this.rbForma = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clForma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 476);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3);
            this.btnBuscar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(5);
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clForma,
            this.clData,
            this.clUltAlt,
            this.clStatus});
            this.listView1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbForma);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbForma, 0);
            this.pnTop.Controls.SetChildIndex(this.cbInativos, 0);
            this.pnTop.Controls.SetChildIndex(this.btnDiminuirFonte, 0);
            this.pnTop.Controls.SetChildIndex(this.btnAumentarFonte, 0);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(866, 26);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3);
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
            this.txtCodigo.Size = new System.Drawing.Size(843, 22);
            // 
            // btnSair
            // 
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            // 
            // rbForma
            // 
            this.rbForma.AutoSize = true;
            this.rbForma.Checked = true;
            this.rbForma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbForma.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbForma.ForeColor = System.Drawing.Color.White;
            this.rbForma.Location = new System.Drawing.Point(85, 0);
            this.rbForma.Margin = new System.Windows.Forms.Padding(4);
            this.rbForma.Name = "rbForma";
            this.rbForma.Size = new System.Drawing.Size(110, 34);
            this.rbForma.TabIndex = 5;
            this.rbForma.TabStop = true;
            this.rbForma.Text = "Forma PG";
            this.rbForma.UseVisualStyleBackColor = true;
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
            // clForma
            // 
            this.clForma.Text = "Forma de Pagamento";
            this.clForma.Width = 300;
            // 
            // clData
            // 
            this.clData.Text = "Data Cadastro";
            this.clData.Width = 130;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clStatus.Width = 80;
            // 
            // clUltAlt
            // 
            this.clUltAlt.Text = "Ultima Alteração";
            this.clUltAlt.Width = 130;
            // 
            // cbInativos
            // 
            this.cbInativos.AutoSize = true;
            this.cbInativos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cbInativos.ForeColor = System.Drawing.Color.White;
            this.cbInativos.Location = new System.Drawing.Point(195, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 10;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmConsultaFormaPagamento";
            this.Text = "Consultar forma de pagamento";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbForma;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clForma;
        private System.Windows.Forms.ColumnHeader clData;
        private System.Windows.Forms.ColumnHeader clUltAlt;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
