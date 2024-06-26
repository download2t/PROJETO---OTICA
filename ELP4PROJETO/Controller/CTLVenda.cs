using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Models;
using ELP4PROJETO.Models.Others;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLVenda
    {
        private DALVenda vendasDAL = new DALVenda();

        public bool AdicionarVenda(Venda venda)
        {
            return vendasDAL.AdicionarVenda(venda);
        }

        public bool CancelarVenda(Venda venda)
        {
            return vendasDAL.CancelarVenda(venda);
        }

        public Venda BuscarVendaPorChave(int numNF, int modeloNF, int serieNF, int idCliente)
        {
            return vendasDAL.BuscarVendaPorChave(numNF, modeloNF, serieNF, idCliente);
        }

        public bool VerificarSeVendaExiste(int numNF, int modeloNF, int serieNF, int idCliente)
        {
            try
            {
                return vendasDAL.ExisteVendaPorChave(numNF, modeloNF, serieNF, idCliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<Venda> BuscarListaVendaPorChave(int numNF, int modeloNF, int serieNF, int idCliente)
        {
            return vendasDAL.BuscarListaVendasPorChave(numNF, modeloNF, serieNF, idCliente);
        }

        public List<Venda> ListarVendas(bool? statusCancelada)
        {
            return vendasDAL.ListarVendas(statusCancelada);
        }

        public List<Venda> ListarVendas(DateTime? dataInicio, DateTime? dataFim, bool? cancelada, string nomeCliente, string tipoData)
        {
            return vendasDAL.ListarVendas(dataInicio, dataFim, cancelada, nomeCliente, tipoData);
        }

        public void Incluir()
        {
            FrmCadastroVenda frmCadastroVenda = new FrmCadastroVenda();
            frmCadastroVenda.Text = "Realizar nova venda";
            frmCadastroVenda.ShowDialog();
        }

        public void Visualizar(Venda venda)
        {
            if (venda != null)
            {
                FrmCadastroVenda frmCadastroVenda = new FrmCadastroVenda();
              //  frmCadastroVenda.ConhecaObj(venda);
                frmCadastroVenda.Text = "Consultar uma Venda";
              //  frmCadastroVenda.GbChave.Enabled = false;
              //  frmCadastroVenda.Popular(venda);
              //  frmCadastroVenda.BloquearCampos();
              //  frmCadastroVenda.btnSalvar.Enabled = false;
                frmCadastroVenda.ShowDialog();
            }
        }

        public void CancelarNota(Venda venda)
        {
            if (venda != null)
            {
                FrmCadastroVenda frm = new FrmCadastroVenda();
             //   frm.ConhecaObj(venda);
                frm.Text = "Cancelar Nota";

                if (venda.DataCancelamento != null)
              //      frm.btnSalvar.Text = "CANCELAR";
           //     frm.GbChave.Enabled = false;
              //  frm.btnSalvar.BackColor = Color.DarkRed;
             //   frm.btnSalvar.ForeColor = Color.White;
            //    frm.dtCancelada.Visible = true;
             //   frm.lblDataCacelamento.Visible = true;
            //    frm.Popular(venda);
            //    frm.BloquearCampos();
                frm.ShowDialog();
            }
        }
    }
}
