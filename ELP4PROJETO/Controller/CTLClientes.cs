using ELP4PROJETO.Cadastros;
using ELP4PROJETO.Classes;
using ELP4PROJETO.Data;
using ELP4PROJETO.Views.Cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace test.Controllers
{
    public class CTLClientes
    {
        private DALClientes clientesDAL = new DALClientes();

        public string AdicionarCliente(Clientes cliente)
        {
            return clientesDAL.AdicionarCliente(cliente);
        }

        public string AtualizarCliente(Clientes cliente)
        {
            return clientesDAL.AtualizarCliente(cliente);
        }

        public bool ExcluirCliente(int clienteId)
        {
            return clientesDAL.ExcluirCliente(clienteId);
        }

        public Clientes BuscarClientePorId(int id)
        {
            return clientesDAL.BuscarClientePorId(id);
        }
        public string BuscarClientePorDocumento(string nome)
        {
            return clientesDAL.BuscarClientePorCPFouCNPJ(nome);
        }
        public string BuscarClientePorRG(string nome)
        {
            return clientesDAL.BuscarClientePorRG(nome);
        }

        public List<Clientes> ListarClientes(string status)
        {
            return clientesDAL.ListarClientes(status);
        }

        public List<Clientes> PesquisarClientesPorCriterio(string criterio, string valorPesquisa, string status)
        {
            List<Clientes> Encontrados = clientesDAL.PesquisarClientesPorCriterio(criterio, valorPesquisa,status);
            return Encontrados;
        }

        public void Incluir()
        {
            FrmCadastroCliente frmCadastroClientes = new FrmCadastroCliente();
            frmCadastroClientes.Text = "Incluir Cliente";
            frmCadastroClientes.cmbStatus.Text = "ATIVO";
            frmCadastroClientes.VerCampos(false);
            frmCadastroClientes.cmbStatus.Enabled = false;
            frmCadastroClientes.toolTip1.SetToolTip(frmCadastroClientes.btnSalvar, "Salvar dados.");
            frmCadastroClientes.ShowDialog();
        }

        public void Alterar(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroCliente frmCadastroClientes = new FrmCadastroCliente();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.Text = "Alterar Cliente";
                frmCadastroClientes.btnSalvar.Text = "ALTERAR";
                frmCadastroClientes.btnSalvar.BackColor = Color.BurlyWood;
                frmCadastroClientes.cmbTipoCliente.Enabled= false;
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.toolTip1.SetToolTip(frmCadastroClientes.btnSalvar, "Alterar dados.");
                frmCadastroClientes.ShowDialog();
            }
        }

        public void Excluir(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroCliente frmCadastroClientes = new FrmCadastroCliente();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.Text = "Excluir Cliente";
                frmCadastroClientes.btnSalvar.Text = "EXCLUIR";
                frmCadastroClientes.toolTip1.SetToolTip(frmCadastroClientes.btnSalvar, "Excluir cliente.");
                frmCadastroClientes.btnSalvar.ForeColor = Color.White;
                frmCadastroClientes.btnSalvar.BackColor = Color.DarkRed;
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.cmbTipoCliente.Enabled = false;
                frmCadastroClientes.BloquearCampos();  
                frmCadastroClientes.ShowDialog();
            }
        }

        public void Visualizar(Clientes cliente)
        {
            if (cliente != null)
            {
                FrmCadastroCliente frmCadastroClientes = new FrmCadastroCliente();
                frmCadastroClientes.ConhecaObj(cliente);
                frmCadastroClientes.Text = "Consultar Cliente";
                frmCadastroClientes.CarregarCampos();
                frmCadastroClientes.BloquearCampos();
                frmCadastroClientes.cmbTipoCliente.Enabled = false;
                frmCadastroClientes.btnSalvar.Enabled = false;
                frmCadastroClientes.ShowDialog();
            }
        }
    }
}
