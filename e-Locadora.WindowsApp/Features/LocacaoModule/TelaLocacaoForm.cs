using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.LocacaoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    public partial class TelaLocacaoForm : Form
    {
        ControladorClientes controladorCliente = new ControladorClientes();
        ControladorCondutor controladorCondutor = new ControladorCondutor();
        ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
        ControladorVeiculos controladorVeiculo = new ControladorVeiculos();
        private Locacao locacao;

        public TelaLocacaoForm()
        {
            InitializeComponent();
            CarregarCliente();
        }

        public Locacao Locacao
        {
            get
            {
                return locacao;
            }

            set
            {
                locacao = value;

                //LOCAÇÃO
                txtIdLocacao.Text = locacao.Id.ToString();
                cboxPlano.SelectedItem = locacao.plano;


                if(locacao.seguroCliente != 0) 
                { 
                    checkBoxCliente.Enabled = true;
                    txtSeguroCliente.Text = locacao.seguroCliente.ToString();
                }

                if(locacao.seguroTerceiro != 0)
                {
                    checkBoxSeguroTerceiro.Enabled = true;
                    txtSeguroTerceiro.Text = locacao.seguroTerceiro.ToString();
                }

                dateLocacao.Value = Convert.ToDateTime(locacao.dataLocacao);
                dataDevolucao.Value = Convert.ToDateTime(locacao.dataDevolucao);

                //CLIENTE
                txtIdCliente.Text = locacao.cliente.Id.ToString();
                cboxCliente.SelectedItem = locacao.cliente.Nome;

                //CONDUTOR
                txtIdCondutor.Text = locacao.condutor.Id.ToString();
                cboxCondutor.SelectedItem = locacao.condutor.Nome;

                //VEIUCLO
                txtIdVeiculo.Text = locacao.Id.ToString();
                cboxVeiculo.SelectedItem = locacao.veiculo.Modelo;
                txtQuilometragemDevolucao.Text = locacao.quilometragemDevolucao.ToString();

                //TAXAS E SERVICOS
                txtIdTaxasServicos.Text = locacao.Id.ToString();
                //cListBoxTaxasServicos.Items = Convert.ToBoolean(locacao.taxasServicos);

            }
        }

        public string ValidarCampos()
        {
            return "CAMPOS_VALIDOS";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
        }

        private void CarregarCliente()
        {
            cboxCliente.Items.Clear();

            List<Clientes> contatos = controladorCliente.SelecionarTodos();

            foreach (var contato in contatos)
            {
                cboxCliente.Items.Add(contato);
            }
        }

    }
}
