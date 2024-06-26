using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;

namespace test.Controllers
{
    public class CTLCompras
    {
        private DALCompras comprasDAL = new DALCompras();


        public bool AdicionarCompra(Compra compra)
        {
            return comprasDAL.AdicionarCompra(compra);
        }
        public bool CancelarCompra(Compra aCompra)
        {
            return comprasDAL.CancelarCompra(aCompra);
        }
        public Compra BuscarCompraPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            return comprasDAL.BuscarCompraPorChave(numNFC, modeloNFC, serieNFC, idFornecedor);
        }
        public bool VerificarSeCompraExiste(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            try
            {
                return comprasDAL.ExisteCompraPorChave(numNFC, modeloNFC, serieNFC, idFornecedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public List<Compra> BuscarListaCompraPorChave(int numNFC, int modeloNFC, int serieNFC, int idFornecedor)
        {
            return comprasDAL.BuscarListaComprasPorChave(numNFC, modeloNFC, serieNFC, idFornecedor);
        }
        public List<Compra> ListarCompras(bool? statusCancelada)
        {
            return comprasDAL.ListarCompras(statusCancelada);
        }
        public List<Compra> ListarCompras(DateTime? dataInicio, DateTime? dataFim,bool? Cancelada, string Fornecedor, string cbDatas)
        {
            return comprasDAL.ListarCompras(dataInicio,dataFim,Cancelada,Fornecedor, cbDatas);
        }
        public void Incluir()
        {
            FrmCadastroCompra frmCadastroCompra = new FrmCadastroCompra();
            frmCadastroCompra.Text = "Incluir Compra";
            frmCadastroCompra.ShowDialog();
        }

        public void Visualizar(Compra compra)
        {
            if (compra != null)
            {
                FrmCadastroCompra frmCadastroCompra = new FrmCadastroCompra();
                frmCadastroCompra.ConhecaObj(compra);
                frmCadastroCompra.Text = "Consultar Compra";
                frmCadastroCompra.GbChave.Enabled = false;
                frmCadastroCompra.Popular(compra);
                frmCadastroCompra.BloquearCampos();
                frmCadastroCompra.btnSalvar.Enabled = false;
                frmCadastroCompra.ShowDialog();
            }
        }
        public void CancelarNota(Compra compra)
        {
            if (compra != null)
            {
                FrmCadastroCompra frm = new FrmCadastroCompra();
                frm.ConhecaObj(compra);
                frm.Text = "Cancelar Nota";

                if (compra.DataCancelamento != null)
                    frm.btnSalvar.Text = "CANCELAR";
                frm.GbChave.Enabled = false;
                frm.btnSalvar.BackColor = Color.DarkRed;
                frm.btnSalvar.ForeColor = Color.White;
                frm.dtCancelada.Visible = true;
                frm.lblDataCacelamento.Visible = true;
                frm.Popular(compra);
                frm.BloquearCampos();
                frm.ShowDialog();
            }
        }
    }
}
