namespace ELP4PROJETO.Views.Cadastros
{
    partial class FrmCadastroVenda
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTotalNota = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DgItensVenda = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnReceberF1 = new System.Windows.Forms.Button();
            this.btnNovoF2 = new System.Windows.Forms.Button();
            this.btnEditarF3 = new System.Windows.Forms.Button();
            this.btnFinalizarF4 = new System.Windows.Forms.Button();
            this.btnCancearF5 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clForn = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCPFeCNPJ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lbSexo = new System.Windows.Forms.Label();
            this.cmbProdServ = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(314, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 85);
            this.panel2.TabIndex = 553;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 557;
            this.label2.Text = "Ótica Cristal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 85);
            this.panel1.TabIndex = 554;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 556;
            this.label1.Text = "PDV";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(0, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 511);
            this.panel4.TabIndex = 555;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.lbSexo);
            this.panel5.Controls.Add(this.cmbProdServ);
            this.panel5.Controls.Add(this.btnBuscarCliente);
            this.panel5.Controls.Add(this.clForn);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txtCliente);
            this.panel5.Controls.Add(this.pbFoto);
            this.panel5.Controls.Add(this.btnBuscarProduto);
            this.panel5.Controls.Add(this.txtCPFeCNPJ);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtQtd);
            this.panel5.Controls.Add(this.txtCodProduto);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 505);
            this.panel5.TabIndex = 555;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.panel6.Controls.Add(this.txtTotalNota);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(771, 485);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 63);
            this.panel6.TabIndex = 558;
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.AutoSize = true;
            this.txtTotalNota.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNota.ForeColor = System.Drawing.Color.White;
            this.txtTotalNota.Location = new System.Drawing.Point(213, 16);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(96, 29);
            this.txtTotalNota.TabIndex = 557;
            this.txtTotalNota.Text = "000,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 29);
            this.label3.TabIndex = 556;
            this.label3.Text = "R$";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(0, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(314, 511);
            this.panel7.TabIndex = 555;
            // 
            // DgItensVenda
            // 
            this.DgItensVenda.AllowUserToAddRows = false;
            this.DgItensVenda.AllowUserToDeleteRows = false;
            this.DgItensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgItensVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.codigo,
            this.produto,
            this.qtd,
            this.valor_unitario,
            this.sub_total});
            this.DgItensVenda.Location = new System.Drawing.Point(330, 118);
            this.DgItensVenda.Margin = new System.Windows.Forms.Padding(2);
            this.DgItensVenda.MultiSelect = false;
            this.DgItensVenda.Name = "DgItensVenda";
            this.DgItensVenda.ReadOnly = true;
            this.DgItensVenda.RowHeadersWidth = 51;
            this.DgItensVenda.RowTemplate.Height = 24;
            this.DgItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgItensVenda.Size = new System.Drawing.Size(755, 362);
            this.DgItensVenda.TabIndex = 559;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.MinimumWidth = 6;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 40;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 60;
            // 
            // produto
            // 
            this.produto.HeaderText = "Produto";
            this.produto.MinimumWidth = 6;
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 300;
            // 
            // qtd
            // 
            this.qtd.HeaderText = "Qtda";
            this.qtd.MinimumWidth = 6;
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 50;
            // 
            // valor_unitario
            // 
            this.valor_unitario.HeaderText = "Valor Unit.";
            this.valor_unitario.MinimumWidth = 6;
            this.valor_unitario.Name = "valor_unitario";
            this.valor_unitario.ReadOnly = true;
            this.valor_unitario.Width = 125;
            // 
            // sub_total
            // 
            this.sub_total.HeaderText = "Sub Total";
            this.sub_total.MinimumWidth = 6;
            this.sub_total.Name = "sub_total";
            this.sub_total.ReadOnly = true;
            this.sub_total.Width = 125;
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFoto.Image = global::ELP4PROJETO.Properties.Resources.sem_foto;
            this.pbFoto.Location = new System.Drawing.Point(12, 219);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(291, 232);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 539;
            this.pbFoto.TabStop = false;
            // 
            // btnReceberF1
            // 
            this.btnReceberF1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceberF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnReceberF1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceberF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceberF1.ForeColor = System.Drawing.Color.White;
            this.btnReceberF1.Location = new System.Drawing.Point(467, 555);
            this.btnReceberF1.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceberF1.Name = "btnReceberF1";
            this.btnReceberF1.Size = new System.Drawing.Size(118, 47);
            this.btnReceberF1.TabIndex = 560;
            this.btnReceberF1.Text = "F1 - RECEBER";
            this.btnReceberF1.UseVisualStyleBackColor = false;
            // 
            // btnNovoF2
            // 
            this.btnNovoF2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnNovoF2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoF2.ForeColor = System.Drawing.Color.White;
            this.btnNovoF2.Location = new System.Drawing.Point(593, 555);
            this.btnNovoF2.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoF2.Name = "btnNovoF2";
            this.btnNovoF2.Size = new System.Drawing.Size(118, 47);
            this.btnNovoF2.TabIndex = 561;
            this.btnNovoF2.Text = "F2- NOVO";
            this.btnNovoF2.UseVisualStyleBackColor = false;
            // 
            // btnEditarF3
            // 
            this.btnEditarF3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnEditarF3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarF3.ForeColor = System.Drawing.Color.White;
            this.btnEditarF3.Location = new System.Drawing.Point(719, 555);
            this.btnEditarF3.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarF3.Name = "btnEditarF3";
            this.btnEditarF3.Size = new System.Drawing.Size(118, 47);
            this.btnEditarF3.TabIndex = 563;
            this.btnEditarF3.Text = "F3-EDITAR";
            this.btnEditarF3.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarF4
            // 
            this.btnFinalizarF4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnFinalizarF4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarF4.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarF4.Location = new System.Drawing.Point(845, 555);
            this.btnFinalizarF4.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarF4.Name = "btnFinalizarF4";
            this.btnFinalizarF4.Size = new System.Drawing.Size(118, 47);
            this.btnFinalizarF4.TabIndex = 562;
            this.btnFinalizarF4.Text = "F4-FINALIZAR";
            this.btnFinalizarF4.UseVisualStyleBackColor = false;
            // 
            // btnCancearF5
            // 
            this.btnCancearF5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancearF5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnCancearF5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancearF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancearF5.ForeColor = System.Drawing.Color.White;
            this.btnCancearF5.Location = new System.Drawing.Point(971, 555);
            this.btnCancearF5.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancearF5.Name = "btnCancearF5";
            this.btnCancearF5.Size = new System.Drawing.Size(118, 47);
            this.btnCancearF5.TabIndex = 564;
            this.btnCancearF5.Text = "F5-CANCELAR";
            this.btnCancearF5.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 546;
            this.label16.Text = "Qtd";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtQtd.Location = new System.Drawing.Point(12, 79);
            this.txtQtd.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(92, 27);
            this.txtQtd.TabIndex = 543;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnBuscarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduto.Location = new System.Drawing.Point(215, 79);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarProduto.TabIndex = 542;
            this.btnBuscarProduto.Text = "BUSCAR";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(110, 79);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProduto.MaxLength = 100;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(97, 27);
            this.txtCodProduto.TabIndex = 540;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 545;
            this.label5.Text = "Cód Produto";
            // 
            // clForn
            // 
            this.clForn.AutoSize = true;
            this.clForn.Location = new System.Drawing.Point(9, 166);
            this.clForn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clForn.Name = "clForn";
            this.clForn.Size = new System.Drawing.Size(39, 13);
            this.clForn.TabIndex = 568;
            this.clForn.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(12, 185);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.MaxLength = 100;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(291, 27);
            this.txtCliente.TabIndex = 565;
            // 
            // txtCPFeCNPJ
            // 
            this.txtCPFeCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFeCNPJ.Location = new System.Drawing.Point(12, 131);
            this.txtCPFeCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPFeCNPJ.MaxLength = 100;
            this.txtCPFeCNPJ.Name = "txtCPFeCNPJ";
            this.txtCPFeCNPJ.Size = new System.Drawing.Size(195, 27);
            this.txtCPFeCNPJ.TabIndex = 567;
            this.txtCPFeCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 569;
            this.label6.Text = "CPF / CNPJ";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(93)))));
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(215, 131);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarCliente.TabIndex = 570;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.ForeColor = System.Drawing.Color.Black;
            this.lbSexo.Location = new System.Drawing.Point(10, 4);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(117, 17);
            this.lbSexo.TabIndex = 606;
            this.lbSexo.Text = "Produto / Serviço";
            // 
            // cmbProdServ
            // 
            this.cmbProdServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProdServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProdServ.FormattingEnabled = true;
            this.cmbProdServ.Items.AddRange(new object[] {
            "Produtos",
            "Serviços"});
            this.cmbProdServ.Location = new System.Drawing.Point(12, 25);
            this.cmbProdServ.Name = "cmbProdServ";
            this.cmbProdServ.Size = new System.Drawing.Size(195, 28);
            this.cmbProdServ.TabIndex = 605;
            // 
            // FrmCadastroVenda
            // 
            this.ClientSize = new System.Drawing.Size(1102, 608);
            this.Controls.Add(this.btnCancearF5);
            this.Controls.Add(this.btnEditarF3);
            this.Controls.Add(this.btnFinalizarF4);
            this.Controls.Add(this.btnNovoF2);
            this.Controls.Add(this.btnReceberF1);
            this.Controls.Add(this.DgItensVenda);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Name = "FrmCadastroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - Ótica Cristal";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.DataGridView DgItensVenda;
        private System.Windows.Forms.Label txtTotalNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_total;
        private System.Windows.Forms.PictureBox pbFoto;
        protected System.Windows.Forms.Button btnReceberF1;
        protected System.Windows.Forms.Button btnNovoF2;
        protected System.Windows.Forms.Button btnEditarF3;
        protected System.Windows.Forms.Button btnFinalizarF4;
        protected System.Windows.Forms.Button btnCancearF5;
        protected System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Button btnBuscarProduto;
        protected System.Windows.Forms.TextBox txtQtd;
        protected System.Windows.Forms.TextBox txtCodProduto;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnBuscarCliente;
        protected System.Windows.Forms.Label clForn;
        protected System.Windows.Forms.TextBox txtCliente;
        protected System.Windows.Forms.TextBox txtCPFeCNPJ;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.ComboBox cmbProdServ;
    }
}
