namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaReceita
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
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDoutor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clClinica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clReceb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataCad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbDoutor = new System.Windows.Forms.RadioButton();
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 476);
            this.btnBuscar.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCliente,
            this.clDoutor,
            this.clClinica,
            this.clReceb,
            this.clDataCad,
            this.clUltAlt});
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.rbLab);
            this.pnTop.Controls.Add(this.rbDoutor);
            this.pnTop.Controls.Add(this.rbCliente);
            this.pnTop.Controls.Add(this.rbCodigo);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(866, 26);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(845, 22);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCliente.ForeColor = System.Drawing.Color.White;
            this.rbCliente.Location = new System.Drawing.Point(85, 0);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(84, 34);
            this.rbCliente.TabIndex = 7;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
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
            this.rbCodigo.TabIndex = 6;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clCliente
            // 
            this.clCliente.Text = "Cliente";
            this.clCliente.Width = 200;
            // 
            // clDoutor
            // 
            this.clDoutor.Text = "Doutor";
            this.clDoutor.Width = 200;
            // 
            // clClinica
            // 
            this.clClinica.Text = "Laboratório";
            this.clClinica.Width = 200;
            // 
            // clReceb
            // 
            this.clReceb.Text = "Recebido EM";
            this.clReceb.Width = 130;
            // 
            // clDataCad
            // 
            this.clDataCad.Text = "Data Cadastro";
            this.clDataCad.Width = 130;
            // 
            // clUltAlt
            // 
            this.clUltAlt.Text = "Ultima Alteração";
            this.clUltAlt.Width = 130;
            // 
            // rbDoutor
            // 
            this.rbDoutor.AutoSize = true;
            this.rbDoutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDoutor.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDoutor.ForeColor = System.Drawing.Color.White;
            this.rbDoutor.Location = new System.Drawing.Point(169, 0);
            this.rbDoutor.Margin = new System.Windows.Forms.Padding(4);
            this.rbDoutor.Name = "rbDoutor";
            this.rbDoutor.Size = new System.Drawing.Size(82, 34);
            this.rbDoutor.TabIndex = 9;
            this.rbDoutor.Text = "Doutor";
            this.rbDoutor.UseVisualStyleBackColor = true;
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbLab.ForeColor = System.Drawing.Color.White;
            this.rbLab.Location = new System.Drawing.Point(251, 0);
            this.rbLab.Margin = new System.Windows.Forms.Padding(4);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(119, 34);
            this.rbLab.TabIndex = 10;
            this.rbLab.Text = "Laboratório";
            this.rbLab.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Name = "FrmConsultaReceita";
            this.Text = "Consultar Receitas";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clCliente;
        private System.Windows.Forms.ColumnHeader clDoutor;
        private System.Windows.Forms.ColumnHeader clClinica;
        private System.Windows.Forms.ColumnHeader clReceb;
        private System.Windows.Forms.ColumnHeader clDataCad;
        private System.Windows.Forms.ColumnHeader clUltAlt;
        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.RadioButton rbDoutor;
    }
}
