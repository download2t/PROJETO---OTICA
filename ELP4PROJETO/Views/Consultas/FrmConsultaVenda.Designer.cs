namespace ELP4PROJETO.Views.Consultas
{
    partial class FrmConsultaVenda
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
            ((System.ComponentModel.ISupportInitialize)(this.txtForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtData2
            // 
            this.toolTip1.SetToolTip(this.dtData2, "Data final do período de busca");
            // 
            // dtData1
            // 
            this.toolTip1.SetToolTip(this.dtData1, "Data inicial do período de busca");
            // 
            // cbDatas
            // 
            this.cbDatas.Size = new System.Drawing.Size(146, 22);
            // 
            // btnBuscar
            // 
            this.toolTip1.SetToolTip(this.btnBuscar, "Busca com base nos filtros");
            // 
            // btnExcluir
            // 
            this.btnExcluir.Text = "Cancelar Venda";
            this.toolTip1.SetToolTip(this.btnExcluir, "Selecione um item da lista para excluir");
            // 
            // btnAlterar
            // 
            this.toolTip1.SetToolTip(this.btnAlterar, "Selecione um item da lista para alterar");
            // 
            // btnIncluir
            // 
            this.btnIncluir.Text = "Nova Venda";
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir novo");
            // 
            // btnAtualizar
            // 
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
            // FrmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1319, 620);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaVenda";
            this.Text = "Consultar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.txtForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
