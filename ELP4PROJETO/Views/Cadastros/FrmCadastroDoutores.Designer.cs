namespace ELP4PROJETO.Views.Cadastros
{
    partial class FrmCadastroDoutores
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
            this.lbDr = new System.Windows.Forms.Label();
            this.txtDoutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(302, 104);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(556, 9);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(74, 40);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(74, 58);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(396, 104);
            // 
            // lbDr
            // 
            this.lbDr.AutoSize = true;
            this.lbDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDr.ForeColor = System.Drawing.Color.Black;
            this.lbDr.Location = new System.Drawing.Point(151, 40);
            this.lbDr.Name = "lbDr";
            this.lbDr.Size = new System.Drawing.Size(51, 17);
            this.lbDr.TabIndex = 135;
            this.lbDr.Text = "Doutor";
            // 
            // txtDoutor
            // 
            this.txtDoutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoutor.Location = new System.Drawing.Point(155, 58);
            this.txtDoutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoutor.MaxLength = 150;
            this.txtDoutor.Name = "txtDoutor";
            this.txtDoutor.Size = new System.Drawing.Size(329, 27);
            this.txtDoutor.TabIndex = 134;
            this.txtDoutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoutor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(140, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 136;
            this.label5.Text = "*";
            // 
            // FrmCadastroDoutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(556, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDr);
            this.Controls.Add(this.txtDoutor);
            this.Name = "FrmCadastroDoutores";
            this.Text = "Especialista";
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.txtDoutor, 0);
            this.Controls.SetChildIndex(this.lbDr, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDr;
        private System.Windows.Forms.TextBox txtDoutor;
        private System.Windows.Forms.Label label5;
    }
}
