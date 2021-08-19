using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.FuncionarioModule;
using e_Locadora.Controladores.LocacaoModule;
using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.Dominio.FuncionarioModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.Dominio.TaxasServicosModule;
using e_Locadora.Dominio.VeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorFuncionario controladorFuncionario = new ControladorFuncionario();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();
        ControladorLocacaoTaxasServicos controladorLocacaoTaxasServicos = new ControladorLocacaoTaxasServicos();

        private Locacao locacao;

        public TelaLocacaoForm()
        {
            InitializeComponent();
            CarregarCliente();
            CarregarFuncionario();
            CarregarGrupoVeiculos();
            CarregarTaxasServicos();
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
                cboxFuncionario.SelectedItem = locacao.funcionario;


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

                maskedTextBoxLocacao.Text = locacao.dataLocacao.ToString();
                maskedTextBoxDevolucao.Text = locacao.dataDevolucao.ToString();

                //CLIENTE
                cboxCliente.SelectedItem = locacao.cliente.Nome;

                //CONDUTOR
                cboxCondutor.SelectedItem = locacao.condutor.Nome;

                //VEIUCLO
                cboxGrupoVeiculo.SelectedItem = locacao.grupoVeiculo.categoria;
                cboxVeiculo.SelectedItem = locacao.veiculo.Modelo;
                txtQuilometragemDevolucao.Text = locacao.quilometragemDevolucao.ToString();

                //TAXAS E SERVICOS
                foreach (TaxasServicos taxaServico in controladorLocacaoTaxasServicos.)
                //cListBoxTaxasServicos.Items = Convert.ToBoolean(locacao.taxasServicos);

            }
        }

        public string ValidarCampos()
        {
            if(cboxPlano.SelectedItem == null)
            {
                return "Plano é obrigatorio";
            }

            if(cboxFuncionario.SelectedItem == null)
            {
                return "Funcionario é obrigatório";
            }

            if(!ValidarTipoInt(txtSeguroCliente.Text))
            {
                return "Digite um valor Valido para Seguro Cliente";
            }
            if(!ValidarTipoInt(txtSeguroTerceiro.Text))
            {
                return "Digite um valor Valido para Seguro Terceiro";
            }
            if(maskedTextBoxLocacao.Text == "")
            {
                return "Digite uma data valida para Data de Locação";
            }
            if(maskedTextBoxDevolucao.Text == "")
            {
                return "Digite uma data valida para Data de Devolução";
            }
            if(cboxCliente.SelectedItem == null)
            {
                return "Cliente é obrigatótio";
            }
            if(cboxCondutor.SelectedItem == null)
            {
                return "Condutor é obrigatório";
            }
            if(cboxGrupoVeiculo.SelectedItem == null)
            {
                return "Categoria de Veiculo é obrigatória";
            }
            if(cboxVeiculo.SelectedItem == null)
            {
                return "Veiculo é obrigatoria";
            }
            if(!ValidarTipoInt(txtQuilometragemDevolucao.Text))
            {
                return "Valor Quilometragem Devolução inválido";
            }
            if(Convert.ToDouble(txtQuilometragemDevolucao.Text) <0)
            {
                return "Valor Quilometragem nao pode ser menos que ZERO!";
            }

            return "CAMPOS_VALIDOS";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string validacaoCampos = ValidarCampos();

            if (ValidarCampos().Equals("VALIDO"))
            {
                Funcionario funcionario = (Funcionario)cboxFuncionario.SelectedItem;
                DateTime dataLocacao = Convert.ToDateTime(maskedTextBoxLocacao);
                DateTime dataDevolucao = Convert.ToDateTime(maskedTextBoxDevolucao);
                double quilometragemDevolucao = Convert.ToDouble(txtQuilometragemDevolucao);
                string plano = cboxPlano.SelectedItem.ToString();
                double seguroCliente = Convert.ToDouble(txtSeguroCliente.Text);
                double seguroTerceiro = Convert.ToDouble(txtSeguroTerceiro.Text);
                GrupoVeiculo grupoVeiculo = (GrupoVeiculo)cboxGrupoVeiculo.SelectedItem;
                Veiculo veiculo = (Veiculo)cboxVeiculo.SelectedItem;
                Clientes cliente = (Clientes)cboxCliente.SelectedItem;
                Condutor condutor = (Condutor)cboxCondutor.SelectedItem;
                bool emAberto = true;

                locacao = new Locacao(funcionario, dataLocacao, dataDevolucao, quilometragemDevolucao, plano, seguroCliente, seguroTerceiro, grupoVeiculo, veiculo, cliente, condutor, emAberto);

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
        private void CarregarVeiculo()
        {
            cboxVeiculo.Items.Clear();

            List<Veiculo> veiculos = controladorVeiculo.SelecionarTodos();

            foreach (var veiculo in veiculos)
            {
                if (veiculo.GrupoVeiculo.Equals((GrupoVeiculo)cboxGrupoVeiculo.SelectedItem))
                    cboxVeiculo.Items.Add(veiculo);
            }
        }
        private void CarregarGrupoVeiculos()
        {
            cboxGrupoVeiculo.Items.Clear();

            List<GrupoVeiculo> grupoVeiculos = controladorGrupoVeiculo.SelecionarTodos();

            foreach (var grupoVeiculo in grupoVeiculos)
            {
                cboxGrupoVeiculo.Items.Add(grupoVeiculo);
            }
        }
        private void CarregarCondutor()
        {
            cboxCondutor.Items.Clear();
            List<Condutor> condutores = controladorCondutor.SelecionarTodos();

            foreach (var condutor in condutores)
            {
                if (condutor.Cliente.Equals((Clientes)cboxCliente.SelectedItem))
                    cboxCondutor.Items.Add(condutor);
            }
        }

        private void CarregarFuncionario()
        {
            cboxFuncionario.Items.Clear();

            List<Funcionario> funcionarios = controladorFuncionario.SelecionarTodos();

            foreach (var funcionario in funcionarios)
            {
                cboxFuncionario.Items.Add(funcionario);
            }
        }

        private void CarregarTaxasServicos()
        {
            cListBoxTaxasServicos.Items.Clear();

            List<TaxasServicos> taxasServicos = controladorTaxasServicos.SelecionarTodos();

            foreach (var taxaServico in taxasServicos)
            {
                cListBoxTaxasServicos.Items.Add(taxaServico);
            }
        }



        private bool ValidarTipoInt(string texto)
        {
            try
            {
                double numeroConvertido = Convert.ToInt32(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCliente.Checked == true)
            {
                txtSeguroCliente.Enabled = true;
            }
                
            else
            {
                txtSeguroCliente.Enabled = false;
                txtSeguroCliente.Text = "0";
            }
        }

        private void checkBoxSeguroTerceiro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeguroTerceiro.Checked == true)
            {
                txtSeguroTerceiro.Enabled = true;
            }

            else
            {
                txtSeguroTerceiro.Enabled = false;
                txtSeguroTerceiro.Text = "0";
            }
        }

        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCondutor();
        }

        private void cboxGrupoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarVeiculo();
        }
    }
}

