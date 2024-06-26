namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaFornecedor
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
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRazao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clInscE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clInscM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCelular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLogr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clComp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataFund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCriacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.clCondicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.clNome,
            this.clRazao,
            this.clInscE,
            this.clInscM,
            this.clCNPJ,
            this.clRG,
            this.clEmail,
            this.clTelefone,
            this.clCelular,
            this.clCep,
            this.clCidade,
            this.clBairro,
            this.clLogr,
            this.clComp,
            this.clNumero,
            this.clDataFund,
            this.clDataCriacao,
            this.clDataUltAlt,
            this.clStatus,
            this.clCondicao,
            this.clTipo});
            this.listView1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbCNPJ);
            this.pnTop.Controls.Add(this.rbStatus);
            this.pnTop.Controls.Add(this.rbCidade);
            this.pnTop.Controls.Add(this.rbNome);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbNome, 0);
            this.pnTop.Controls.SetChildIndex(this.rbCidade, 0);
            this.pnTop.Controls.SetChildIndex(this.rbStatus, 0);
            this.pnTop.Controls.SetChildIndex(this.rbCNPJ, 0);
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
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbStatus.ForeColor = System.Drawing.Color.White;
            this.rbStatus.Location = new System.Drawing.Point(319, 0);
            this.rbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(79, 34);
            this.rbStatus.TabIndex = 7;
            this.rbStatus.Text = "Status";
            this.rbStatus.UseVisualStyleBackColor = true;
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCidade.ForeColor = System.Drawing.Color.White;
            this.rbCidade.Location = new System.Drawing.Point(234, 0);
            this.rbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(85, 34);
            this.rbCidade.TabIndex = 6;
            this.rbCidade.Text = "Cidade";
            this.rbCidade.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNome.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(85, 0);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(149, 34);
            this.rbNome.TabIndex = 5;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome Fantasia";
            this.rbNome.UseVisualStyleBackColor = true;
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
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCNPJ.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCNPJ.ForeColor = System.Drawing.Color.White;
            this.rbCNPJ.Location = new System.Drawing.Point(398, 0);
            this.rbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(75, 34);
            this.rbCNPJ.TabIndex = 8;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // clNome
            // 
            this.clNome.Text = "Nome Fantasia";
            this.clNome.Width = 200;
            // 
            // clRazao
            // 
            this.clRazao.Text = "Razão Social";
            this.clRazao.Width = 200;
            // 
            // clInscE
            // 
            this.clInscE.Text = "Inscrição Estadual";
            this.clInscE.Width = 130;
            // 
            // clInscM
            // 
            this.clInscM.Text = "Inscrição Municipal";
            this.clInscM.Width = 130;
            // 
            // clCNPJ
            // 
            this.clCNPJ.Text = "CNPJ";
            this.clCNPJ.Width = 130;
            // 
            // clEmail
            // 
            this.clEmail.Text = "E-mail";
            this.clEmail.Width = 200;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 120;
            // 
            // clCelular
            // 
            this.clCelular.Text = "Celular";
            this.clCelular.Width = 120;
            // 
            // clCep
            // 
            this.clCep.Text = "CEP";
            this.clCep.Width = 80;
            // 
            // clCidade
            // 
            this.clCidade.Text = "Cidade";
            this.clCidade.Width = 150;
            // 
            // clBairro
            // 
            this.clBairro.Text = "Bairro";
            this.clBairro.Width = 150;
            // 
            // clLogr
            // 
            this.clLogr.Text = "Logradouro";
            this.clLogr.Width = 250;
            // 
            // clComp
            // 
            this.clComp.Text = "Complemento";
            this.clComp.Width = 120;
            // 
            // clNumero
            // 
            this.clNumero.Text = "Número";
            this.clNumero.Width = 80;
            // 
            // clDataFund
            // 
            this.clDataFund.Text = "Data Fundação";
            this.clDataFund.Width = 130;
            // 
            // clDataCriacao
            // 
            this.clDataCriacao.Text = "Data Cadastro";
            this.clDataCriacao.Width = 130;
            // 
            // clDataUltAlt
            // 
            this.clDataUltAlt.Text = "Ultima Alteração";
            this.clDataUltAlt.Width = 130;
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
            this.cbInativos.Location = new System.Drawing.Point(473, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 9;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // clCondicao
            // 
            this.clCondicao.Text = "Condição Pagamento";
            this.clCondicao.Width = 300;
            // 
            // clRG
            // 
            this.clRG.Text = "RG";
            this.clRG.Width = 130;
            // 
            // clTipo
            // 
            this.clTipo.Text = "Tipo Fornecedor";
            this.clTipo.Width = 130;
            // 
            // FrmConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmConsultaFornecedor";
            this.Text = "Consultar fornecedores";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clRazao;
        private System.Windows.Forms.ColumnHeader clInscE;
        private System.Windows.Forms.ColumnHeader clInscM;
        private System.Windows.Forms.ColumnHeader clCNPJ;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clCelular;
        private System.Windows.Forms.ColumnHeader clCep;
        private System.Windows.Forms.ColumnHeader clCidade;
        private System.Windows.Forms.ColumnHeader clBairro;
        private System.Windows.Forms.ColumnHeader clLogr;
        private System.Windows.Forms.ColumnHeader clComp;
        private System.Windows.Forms.ColumnHeader clNumero;
        private System.Windows.Forms.ColumnHeader clDataFund;
        private System.Windows.Forms.ColumnHeader clDataCriacao;
        private System.Windows.Forms.ColumnHeader clDataUltAlt;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
        private System.Windows.Forms.ColumnHeader clCondicao;
        private System.Windows.Forms.ColumnHeader clRG;
        private System.Windows.Forms.ColumnHeader clTipo;
    }
}
