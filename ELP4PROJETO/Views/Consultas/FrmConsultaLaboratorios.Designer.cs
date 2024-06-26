namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaLaboratorios
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
            this.rbLab = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clLab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUltAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.rbLab);
            this.pnTop.Controls.Add(this.rbCodigo);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(487, 474);
            this.btnBuscar.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clLab,
            this.clDt,
            this.clUltAlt});
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(866, 26);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(841, 22);
            // 
            // rbLab
            // 
            this.rbLab.AutoSize = true;
            this.rbLab.Checked = true;
            this.rbLab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLab.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbLab.ForeColor = System.Drawing.Color.White;
            this.rbLab.Location = new System.Drawing.Point(85, 0);
            this.rbLab.Margin = new System.Windows.Forms.Padding(4);
            this.rbLab.Name = "rbLab";
            this.rbLab.Size = new System.Drawing.Size(119, 34);
            this.rbLab.TabIndex = 15;
            this.rbLab.TabStop = true;
            this.rbLab.Text = "Laboratório";
            this.rbLab.UseVisualStyleBackColor = true;
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
            this.rbCodigo.TabIndex = 14;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // clLab
            // 
            this.clLab.Text = "Laboratório";
            this.clLab.Width = 400;
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
            // FrmConsultaLaboratorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Name = "FrmConsultaLaboratorios";
            this.Text = "Consultar Laboratório";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLab;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.ColumnHeader clLab;
        private System.Windows.Forms.ColumnHeader clDt;
        private System.Windows.Forms.ColumnHeader clUltAlt;
    }
}
