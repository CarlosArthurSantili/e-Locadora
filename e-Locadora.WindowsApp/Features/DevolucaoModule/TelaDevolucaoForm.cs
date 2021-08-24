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

namespace e_Locadora.WindowsApp.Features.DevolucaoModule
{
    public partial class TelaDevolucaoForm : Form
    {
        private Locacao devolucao;

        ControladorClientes controladorCliente = new ControladorClientes();
        ControladorCondutor controladorCondutor = new ControladorCondutor();
        ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
        ControladorVeiculos controladorVeiculo = new ControladorVeiculos();
        ControladorLocacao controladorLocacao = new ControladorLocacao();
        ControladorFuncionario controladorFuncionario = new ControladorFuncionario();
        ControladorTaxasServicos controladorTaxasServicos = new ControladorTaxasServicos();

        public TelaDevolucaoForm()
        {
            InitializeComponent();
            CarregarTaxasServicos();
        }


        public Locacao Locacao
        {
            get
            {
                return devolucao;
            } 
            set
            {
                devolucao = value;

                //LOCAÇÃO
                txtIdLocacao.Text = devolucao.Id.ToString();
                txtFuncionario.Text = TelaPrincipalForm.Instancia.funcionario.ToString();
                txtPlano.Text = devolucao.plano;
                txtCategoria.Text = devolucao.veiculo.GrupoVeiculo.ToString();
                txtVeiculo.Text = devolucao.veiculo.ToString();
                txtCliente.Text = devolucao.cliente.ToString();
                txtCondutor.Text = devolucao.condutor.ToString();
                maskedTextBoxDataLocacao.Text = devolucao.dataLocacao.ToString();
                maskedTextBoxDataRetornoPrevisto.Text = devolucao.dataDevolucao.ToString();
                maskedTextBoxDataRetornoAtual.Text = Convert.ToDateTime(DateTime.Now).ToString();
                txtTipoCombustivel.Text = devolucao.veiculo.Combustivel.ToString();
                txtQuilometragemInicial.Text = devolucao.veiculo.Quilometragem.ToString();

                if (devolucao.seguroCliente != 0)
                {
                    checkBoxSeguroCliente.Checked = true;
                    txtSeguroCliente.Text = devolucao.seguroCliente.ToString();
                }

                if (devolucao.seguroTerceiro != 0)
                {
                    checkBoxSeguroTerceiro.Checked = true;
                    txtSeguroTerceiro.Text = devolucao.seguroTerceiro.ToString();
                }

            }
        }

        public string ValidarCampos()
        {
            if(maskedTextBoxDataRetornoAtual.Text.Length != 10)
            {
                return "Data de Retorno Atual inválido";
            }
            if (Convert.ToDateTime(maskedTextBoxDataRetornoAtual.Text) <= Convert.ToDateTime(maskedTextBoxDataLocacao.Text))
            {
                return "Data de Retorno Atual não pode ser menor ou igual a data da Locação!";
            }
            if (!ValidarTipoInt(txtQuilometragemAtual.Text))
            {
                return "Quilometragem Atual inválido";
            }
            if (Convert.ToDouble(txtQuilometragemAtual.Text) < Convert.ToDouble(txtQuilometragemInicial.Text))
            {
                return "Quilometragem Atual não pode ser menor que a quilometragem inicial!";
            }
            if(!ValidarTipoInt(txtQtdCombustivelRetorno.Text))
            {
                return "Quantidade de Combustível Inválida";
            }
            if (Convert.ToDouble(txtQtdCombustivelRetorno.Text) < 0)
            {
                return "Quantidade de Combustível não pode ser menor que ZERO!";
            }

            return "ESTA_VALIDO";
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

        private bool ValidarTipoDouble(string texto)
        {
            try
            {
                double numeroConvertido = Convert.ToDouble(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //MostrarResumoFinanceiro();
            string validacaoCampos = ValidarCampos();

            if (ValidarCampos().Equals("ESTA_VALIDO"))
            {
                DialogResult = DialogResult.OK;

                devolucao.emAberto = false;
                devolucao.funcionario = TelaPrincipalForm.Instancia.funcionario;
                devolucao.dataDevolucao = Convert.ToDateTime(maskedTextBoxDataRetornoAtual.Text);
                devolucao.quilometragemDevolucao = Convert.ToDouble(txtQuilometragemAtual.Text);
                devolucao.veiculo.Quilometragem = devolucao.quilometragemDevolucao;
                devolucao.valorTotal = Convert.ToDouble(labelVariavelValorTotal.Text);

                int id = Convert.ToInt32(txtIdLocacao.Text);
                string resultadoValidacaoDominio = devolucao.Validar();

                string resultadoValidacaoControlador = controladorLocacao.ValidarLocacao(devolucao, id);

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

        private void CarregarTaxasServicos()
        {
            cListBoxTaxasServicos.Items.Clear();

            List<TaxasServicos> taxasServicos = controladorTaxasServicos.SelecionarTodos();

            foreach (var taxaServico in taxasServicos)
            {
                cListBoxTaxasServicos.Items.Add(taxaServico);
            }
        }

        private void TelaDevolucaoForm_Load(object sender, EventArgs e)
        {
            if (devolucao != null)
                for (int i = 0; i <= (cListBoxTaxasServicos.Items.Count - 1); i++)
                {
                    foreach (TaxasServicos taxaServicoLocacao in controladorLocacao.SelecionarTaxasServicosPorLocacaoId(devolucao.Id))
                    {
                        if (taxaServicoLocacao.Equals((TaxasServicos)cListBoxTaxasServicos.Items[i]))
                            cListBoxTaxasServicos.SetItemChecked(i, true);
                    }
                }

            MostrarResumoFinanceiro();
        }

        private void MostrarResumoFinanceiro()
        {
            MostrarDiasPrevistos();
            MostrarValorPlano();
            MostrarValorTaxasServicos();
            MostrarValorSeguros();
            MostrarValorTotal();
        }

        private void MostrarDiasPrevistos()
        {
            try
            {
                DateTime dataLocacao = Convert.ToDateTime(maskedTextBoxDataLocacao.Text);
                DateTime dataDevolucao = Convert.ToDateTime(maskedTextBoxDataRetornoAtual.Text);
                double numeroDias = (dataDevolucao - dataLocacao).TotalDays;
                if (numeroDias > 0)
                    labelVariavelDiasPrevistos.Text = numeroDias.ToString();
                else
                    labelVariavelDiasPrevistos.Text = "0";
                
            }
            catch { }
        }

        private void MostrarValorPlano()
        {
            try
            {
                double custoPlanoLocacao = 0;
                GrupoVeiculo grupoVeiculoSelecionado = devolucao.grupoVeiculo;
                string planoSelecionado = devolucao.plano;

                if (grupoVeiculoSelecionado != null && planoSelecionado != "")
                {
                    if (planoSelecionado == "Diário")
                    {
                        double valorDiario = grupoVeiculoSelecionado.planoDiarioValorDiario * Convert.ToDouble(labelVariavelDiasPrevistos.Text);
                        double valorKm = grupoVeiculoSelecionado.planoDiarioValorKm * (Convert.ToDouble(txtQuilometragemAtual.Text) - Convert.ToDouble(txtQuilometragemInicial.Text));
                        custoPlanoLocacao = valorDiario + valorKm;
                        labelVariavelCustosPlano.Text = custoPlanoLocacao.ToString();
                    }
                    else if (planoSelecionado == "Km Controlado")
                    {
                        double valorDiario = grupoVeiculoSelecionado.planoKmControladoValorDiario * Convert.ToDouble(labelVariavelDiasPrevistos.Text);
                        double valorKm = 0;
                        if (Convert.ToDouble(txtQuilometragemAtual.Text) - Convert.ToDouble(txtQuilometragemInicial.Text) > grupoVeiculoSelecionado.planoKmControladoQuantidadeKm)
                             valorKm = grupoVeiculoSelecionado.planoKmControladoValorKm * (Convert.ToDouble(txtQuilometragemAtual.Text) - Convert.ToDouble(txtQuilometragemInicial.Text) - grupoVeiculoSelecionado.planoKmControladoQuantidadeKm);
                        
                        custoPlanoLocacao = valorDiario + valorKm;
                        labelVariavelCustosPlano.Text = custoPlanoLocacao.ToString();
                    }
                    else if (planoSelecionado == "Km Livre")
                    {
                        double valorDiario = grupoVeiculoSelecionado.planoKmLivreValorDiario * Convert.ToDouble(labelVariavelDiasPrevistos.Text);
                        custoPlanoLocacao = valorDiario;
                        labelVariavelCustosPlano.Text = custoPlanoLocacao.ToString();
                    }

                    if (custoPlanoLocacao < 0)
                        labelVariavelCustosPlano.Text = "0";
                }
            }
            catch
            {
                labelVariavelCustosPlano.Text = "0";
            }
        }

        private void MostrarValorTaxasServicos()
        {
            try
            {
                List<TaxasServicos> taxasServicosSelecionadas = new List<TaxasServicos>();
                double valorTaxasServicos = 0;

                foreach (object itemChecked in cListBoxTaxasServicos.CheckedItems)
                {
                    TaxasServicos taxaServico = (TaxasServicos)itemChecked;
                    valorTaxasServicos += (taxaServico.TaxaDiaria * Convert.ToDouble(labelVariavelDiasPrevistos.Text)) + taxaServico.TaxaFixa;
                }

                labelVariavelCustosTaxasServicos.Text = valorTaxasServicos.ToString();
              
            }
            catch
            {
                labelVariavelCustosTaxasServicos.Text = "0";
            }
        }

        private void MostrarValorSeguros()
        {
            try
            {
                double valorSeguros = 0;
                valorSeguros += Convert.ToDouble(txtSeguroCliente.Text) + Convert.ToDouble(txtSeguroTerceiro.Text);
                labelVariavelSeguros.Text = valorSeguros.ToString();
            }
            catch
            {
                labelVariavelSeguros.Text = "0";
            }
        }

        private void MostrarValorTotal()
        {
            try
            {
                double valorTotal = Convert.ToDouble(labelVariavelCustosPlano.Text) + Convert.ToDouble(labelVariavelCombustivel.Text) + Convert.ToDouble(labelVariavelCustosTaxasServicos.Text) + Convert.ToDouble(labelVariavelSeguros.Text);
                labelVariavelValorTotal.Text = valorTotal.ToString();
            }
            catch { }

        }

        private void txtQuilometragemAtual_TextChanged(object sender, EventArgs e)
        {
            MostrarResumoFinanceiro();
        }

        private void txtQtdCombustivelRetorno_TextChanged(object sender, EventArgs e)
        {
            MostrarResumoFinanceiro();
        }

        private void maskedTextBoxDataRetornoAtual_TextChanged(object sender, EventArgs e)
        {
            MostrarResumoFinanceiro();
        }
    }
}
