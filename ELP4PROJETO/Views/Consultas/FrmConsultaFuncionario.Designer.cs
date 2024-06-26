namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaFuncionario
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
            this.rbCidade = new System.Windows.Forms.RadioButton();
            this.rbSexo = new System.Windows.Forms.RadioButton();
            this.rbRg = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clRG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clApelido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataNasc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCelular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clLogradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clComplemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbInativos = new System.Windows.Forms.CheckBox();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(484, 478);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3);
            this.btnBuscar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(675, 475);
            this.btnAlterar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(579, 476);
            this.btnIncluir.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNome,
            this.clSexo,
            this.clRG,
            this.clCPF,
            this.clCargo,
            this.clApelido,
            this.clDataNasc,
            this.clEmail,
            this.clTelefone,
            this.clCelular,
            this.clCep,
            this.clCidade,
            this.clBairro,
            this.clLogradouro,
            this.clComplemento,
            this.clNumero,
            this.clDataCria,
            this.clDataUltAlt,
            this.clStatus});
            this.listView1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.cbInativos);
            this.pnTop.Controls.Add(this.rbCidade);
            this.pnTop.Controls.Add(this.rbSexo);
            this.pnTop.Controls.Add(this.rbRg);
            this.pnTop.Controls.Add(this.rbCPF);
            this.pnTop.Controls.Add(this.rbNome);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3);
            this.pnTop.Controls.SetChildIndex(this.rbCodigo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbNome, 0);
            this.pnTop.Controls.SetChildIndex(this.rbCPF, 0);
            this.pnTop.Controls.SetChildIndex(this.rbRg, 0);
            this.pnTop.Controls.SetChildIndex(this.rbSexo, 0);
            this.pnTop.Controls.SetChildIndex(this.rbCidade, 0);
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
            this.txtCodigo.Size = new System.Drawing.Size(845, 22);
            // 
            // btnSair
            // 
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            this.btnSair.TabIndex = 23;
            // 
            // rbCidade
            // 
            this.rbCidade.AutoSize = true;
            this.rbCidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCidade.ForeColor = System.Drawing.Color.White;
            this.rbCidade.Location = new System.Drawing.Point(348, 0);
            this.rbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.rbCidade.Name = "rbCidade";
            this.rbCidade.Size = new System.Drawing.Size(85, 34);
            this.rbCidade.TabIndex = 9;
            this.rbCidade.Text = "Cidade";
            this.rbCidade.UseVisualStyleBackColor = true;
            // 
            // rbSexo
            // 
            this.rbSexo.AutoSize = true;
            this.rbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSexo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbSexo.ForeColor = System.Drawing.Color.White;
            this.rbSexo.Location = new System.Drawing.Point(279, 0);
            this.rbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.rbSexo.Name = "rbSexo";
            this.rbSexo.Size = new System.Drawing.Size(69, 34);
            this.rbSexo.TabIndex = 8;
            this.rbSexo.Text = "Sexo";
            this.rbSexo.UseVisualStyleBackColor = true;
            // 
            // rbRg
            // 
            this.rbRg.AutoSize = true;
            this.rbRg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRg.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbRg.ForeColor = System.Drawing.Color.White;
            this.rbRg.Location = new System.Drawing.Point(224, 0);
            this.rbRg.Margin = new System.Windows.Forms.Padding(4);
            this.rbRg.Name = "rbRg";
            this.rbRg.Size = new System.Drawing.Size(55, 34);
            this.rbRg.TabIndex = 7;
            this.rbRg.Text = "RG";
            this.rbRg.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCPF.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(160, 0);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(64, 34);
            this.rbCPF.TabIndex = 6;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
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
            this.rbNome.Size = new System.Drawing.Size(75, 34);
            this.rbNome.TabIndex = 5;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
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
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 200;
            // 
            // clSexo
            // 
            this.clSexo.Text = "Sexo";
            this.clSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clSexo.Width = 80;
            // 
            // clRG
            // 
            this.clRG.Text = "RG";
            this.clRG.Width = 120;
            // 
            // clCPF
            // 
            this.clCPF.Text = "CPF";
            this.clCPF.Width = 120;
            // 
            // clCargo
            // 
            this.clCargo.Text = "Cargo";
            this.clCargo.Width = 150;
            // 
            // clApelido
            // 
            this.clApelido.Text = "Apelido";
            this.clApelido.Width = 150;
            // 
            // clDataNasc
            // 
            this.clDataNasc.Text = "Data Nascimento";
            this.clDataNasc.Width = 130;
            // 
            // clEmail
            // 
            this.clEmail.Text = "E-mail";
            this.clEmail.Width = 200;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 130;
            // 
            // clCelular
            // 
            this.clCelular.Text = "Celular";
            this.clCelular.Width = 130;
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
            this.clBairro.Width = 120;
            // 
            // clLogradouro
            // 
            this.clLogradouro.Text = "Logradouro";
            this.clLogradouro.Width = 150;
            // 
            // clComplemento
            // 
            this.clComplemento.Text = "Complemento";
            this.clComplemento.Width = 80;
            // 
            // clNumero
            // 
            this.clNumero.Text = "Número";
            this.clNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clDataCria
            // 
            this.clDataCria.Text = "Data Cadastro";
            this.clDataCria.Width = 130;
            // 
            // clDataUltAlt
            // 
            this.clDataUltAlt.Text = "UltimaAlteração";
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
            this.cbInativos.Location = new System.Drawing.Point(433, 0);
            this.cbInativos.Name = "cbInativos";
            this.cbInativos.Size = new System.Drawing.Size(155, 34);
            this.cbInativos.TabIndex = 10;
            this.cbInativos.Text = "Mostrar Inativos";
            this.toolTip1.SetToolTip(this.cbInativos, "Caso esteja marcado mostra apenas itens inativados.");
            this.cbInativos.UseVisualStyleBackColor = true;
            this.cbInativos.CheckedChanged += new System.EventHandler(this.cbInativos_CheckedChanged);
            // 
            // FrmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmConsultaFuncionario";
            this.Text = "Consultar funcionarios";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCidade;
        private System.Windows.Forms.RadioButton rbSexo;
        private System.Windows.Forms.RadioButton rbRg;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.ColumnHeader clSexo;
        private System.Windows.Forms.ColumnHeader clRG;
        private System.Windows.Forms.ColumnHeader clCPF;
        private System.Windows.Forms.ColumnHeader clCargo;
        private System.Windows.Forms.ColumnHeader clApelido;
        private System.Windows.Forms.ColumnHeader clDataNasc;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clCelular;
        private System.Windows.Forms.ColumnHeader clCep;
        private System.Windows.Forms.ColumnHeader clCidade;
        private System.Windows.Forms.ColumnHeader clBairro;
        private System.Windows.Forms.ColumnHeader clLogradouro;
        private System.Windows.Forms.ColumnHeader clComplemento;
        private System.Windows.Forms.ColumnHeader clNumero;
        private System.Windows.Forms.ColumnHeader clDataCria;
        private System.Windows.Forms.ColumnHeader clDataUltAlt;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.CheckBox cbInativos;
    }
}
