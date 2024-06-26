namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaDoutores
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
            this.rbDoutor = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clDr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 474);
            this.btnBuscar.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clDr,
            this.clDt,
            this.clUltAlt});
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.rbDoutor);
            this.pnTop.Controls.Add(this.rbCodigo);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(866, 25);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(841, 22);
            // 
            // rbDoutor
            // 
            this.rbDoutor.AutoSize = true;
            this.rbDoutor.Checked = true;
            this.rbDoutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDoutor.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbDoutor.ForeColor = System.Drawing.Color.White;
            this.rbDoutor.Location = new System.Drawing.Point(85, 0);
            this.rbDoutor.Margin = new System.Windows.Forms.Padding(4);
            this.rbDoutor.Name = "rbDoutor";
            this.rbDoutor.Size = new System.Drawing.Size(82, 34);
            this.rbDoutor.TabIndex = 17;
            this.rbDoutor.TabStop = true;
            this.rbDoutor.Text = "Doutor";
            this.rbDoutor.UseVisualStyleBackColor = true;
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
            this.rbCodigo.TabIndex = 16;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clDr
            // 
            this.clDr.Text = "Doutor";
            this.clDr.Width = 400;
            // 
            // clDt
            // 
            this.clDt.Text = "Data Criação";
            this.clDt.Width = 130;
            // 
            // clUltAlt
            // 
            this.clUltAlt.Text = "Ultima Alteração";
            this.clUltAlt.Width = 130;
            // 
            // FrmConsultaDoutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Name = "FrmConsultaDoutores";
            this.Text = "Consultar Doutores";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDoutor;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clDr;
        private System.Windows.Forms.ColumnHeader clDt;
        private System.Windows.Forms.ColumnHeader clUltAlt;
    }
}
