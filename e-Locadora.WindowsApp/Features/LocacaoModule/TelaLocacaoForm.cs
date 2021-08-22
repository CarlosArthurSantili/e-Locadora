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

                //txtDataLocacao.Value = Convert.ToDateTime(locacao.dataLocacao);
                //txtDataDevolucao.Value = Convert.ToDateTime(locacao.dataDevolucao);

                //CLIENTE
                //txtIdCliente.Text = locacao.cliente.Id.ToString();
                cboxCliente.SelectedItem = locacao.cliente;

                //CONDUTOR
                //txtIdCondutor.Text = locacao.condutor.Id.ToString();
                cboxCondutor.SelectedItem = locacao.condutor;

                //VEICULO
                cboxGrupoVeiculo.SelectedItem = locacao.grupoVeiculo.categoria;
                cboxVeiculo.SelectedItem = locacao.veiculo.Modelo;
                txtQuilometragemDevolucao.Text = locacao.quilometragemDevolucao.ToString();

                //TAXAS E SERVICOS
                //txtIdTaxasServicos.Text = locacao.Id.ToString();
                //cListBoxTaxasServicos.Items = Convert.ToBoolean(locacao.taxasServicos);

            }
        }

        public string ValidarCampos()
        {
            return "CAMPOS_VALIDOS";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string validacaoCampos = ValidarCampos();

            if (ValidarCampos().Equals("ESTA_VALIDO"))
            {
                DialogResult = DialogResult.OK;
                Funcionario funcionario = (Funcionario)cboxFuncionario.SelectedItem;
                DateTime dataLocacao = Convert.ToDateTime(maskedTextBoxLocacao.Text);
                DateTime dataDevolucao = Convert.ToDateTime(maskedTextBoxDevolucao.Text);
                double quilometragemDevolucao = Convert.ToDouble(txtQuilometragemDevolucao.Text);
                string plano = cboxPlano.SelectedItem.ToString();
                double seguroCliente = Convert.ToDouble(txtSeguroCliente.Text);
                double seguroTerceiro = Convert.ToDouble(txtSeguroTerceiro.Text);
                GrupoVeiculo grupoVeiculo = (GrupoVeiculo)cboxGrupoVeiculo.SelectedItem;
                Veiculo veiculo = (Veiculo)cboxVeiculo.SelectedItem;
                Clientes cliente = (Clientes)cboxCliente.SelectedItem;
                Condutor condutor = (Condutor)cboxCondutor.SelectedItem;
                bool emAberto = true;


                locacao = new Locacao(funcionario, dataLocacao, dataDevolucao, quilometragemDevolucao, plano, seguroCliente, seguroTerceiro, grupoVeiculo, veiculo, cliente, condutor, emAberto);


                locacao.taxasServicos.Clear();

                for (int i = 0; i <= (cListBoxTaxasServicos.Items.Count - 1); i++)
                {
                    if (cListBoxTaxasServicos.GetItemChecked(i))
                    {
                        TaxasServicos taxaServico = (TaxasServicos)cListBoxTaxasServicos.Items[i];
                        locacao.taxasServicos.Add(taxaServico);
                    }
                }

                int id = Convert.ToInt32(txtIdLocacao.Text);
                string resultadoValidacaoDominio = veiculo.Validar();

                string resultadoValidacaoControlador = controladorLocacao.ValidarLocacao(locacao, id);

                if (resultadoValidacaoDominio != "ESTA_VALIDO")
                {
                    string primeiroErroDominio = new StringReader(resultadoValidacaoDominio).ReadLine();

                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErroDominio);

                    DialogResult = DialogResult.None;
                }
                else if (resultadoValidacaoControlador != "ESTA_VALIDO")
                {
                    string primeiroErroControlador = new StringReader(resultadoValidacaoControlador).ReadLine();

                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErroControlador);

                    DialogResult = DialogResult.None;
                }
                
            }
            else
            {
                string primeiroErro = new StringReader(validacaoCampos).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
            }
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
