namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaCategoria
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
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.clCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // 
            // btnAlterar
            // 
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(5);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCategoria});
            this.listView1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.rbCategoria);
            this.pnTop.Controls.Add(this.rbCodigo);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3);
            this.pnTop.Size = new System.Drawing.Size(939, 34);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(866, 27);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Size = new System.Drawing.Size(843, 22);
            // 
            // btnSair
            // 
            this.btnSair.Margin = new System.Windows.Forms.Padding(5);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Checked = true;
            this.rbCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCategoria.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rbCategoria.ForeColor = System.Drawing.Color.White;
            this.rbCategoria.Location = new System.Drawing.Point(85, 0);
            this.rbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(106, 34);
            this.rbCategoria.TabIndex = 5;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
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
            // clCategoria
            // 
            this.clCategoria.Text = "Categoria";
            this.clCategoria.Width = 500;
            // 
            // FrmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(976, 508);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConsultaCategoria";
            this.Text = "Consultar Categorias";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clCategoria;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}
