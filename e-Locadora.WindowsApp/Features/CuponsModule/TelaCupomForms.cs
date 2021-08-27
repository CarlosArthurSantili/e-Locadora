using e_Locadora.Controladores.CupomModule;
using e_Locadora.Dominio.CupomModule;
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

namespace e_Locadora.WindowsApp.Features.CuponsModule
{
    public partial class TelaCupomForms : Form
    {
        private Cupons cupons;
        ControladorCupons controladorCupons = new ControladorCupons();

        public TelaCupomForms()
        {
            InitializeComponent();
        }

        public Cupons Cupons
        {
            get { return cupons; }


            set
            {
                cupons = value;
                txtId.Text = cupons.Id.ToString();
                txtNome.Text = cupons.Nome.ToString();
                if (cupons.ValorPercentual != 0)
                {
                    valorPercentual.Checked = true;
                    valorPercentual.Text = cupons.ValorPercentual.ToString();
                }
                if (cupons.ValorFixo != 0)
                {
                    valorFixo.Checked = true;
                    valorFixo.Text = cupons.ValorFixo.ToString();
                }
                maskedTextBoxDataValidade.Text = cupons.DataValidade.ToString();
                txtParceiro.Text = cupons.Parceiro.ToString();
            }
        }

        public string ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
                return "Nome Inválida, tente novamente";

            if (valorPercentual.Checked == true && !ValidarTipoInt(txtValorPercentual.Text))
                return "Valor Percentual está inválido, tente novamente";

            if (valorFixo.Checked == true && !ValidarTipoDouble(txtValorFixo.Text))
                return "Valor Fixo está inválido, tente novamente";

            if (string.IsNullOrEmpty(maskedTextBoxDataValidade.Text))
                return "Data de Validade invalida, tente novamente";

            if (string.IsNullOrEmpty(txtParceiro.Text))
                return "Parceiro Inválida, tente novamente";

            return "CAMPOS_VALIDOS";
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string resultadoValidacao = ValidarCampos();
            if (resultadoValidacao.Equals("CAMPOS_VALIDOS"))
            {
                DialogResult = DialogResult.OK;
                string nome = txtNome.Text;
                int valorPercentual = Convert.ToInt32(txtValorPercentual.Text);
                double valorFixo = Convert.ToDouble(txtValorFixo.Text);
                DateTime dataValidade = Convert.ToDateTime(maskedTextBoxDataValidade.Text);
                string parceiro = txtParceiro.Text;


                cupons = new Cupons(nome, valorPercentual, valorFixo, dataValidade, parceiro);

                int id = Convert.ToInt32(txtId.Text);
                resultadoValidacao = cupons.Validar();
                string resultadoValidacaoControlador = controladorCupons.ValidarCupons(Cupons, id);

                if (resultadoValidacao != "ESTA_VALIDO")
                {
                    string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

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
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void valorPercentual_CheckedChanged(object sender, EventArgs e)
        {
            if (valorPercentual.Checked == true)
            {
                txtValorFixo.Enabled = false;
                txtValorPercentual.Enabled = true;
                txtValorFixo.Text = "0";
            }
        }

        private void valorFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (valorFixo.Checked == true)
            {
                txtValorPercentual.Enabled = false;
                txtValorFixo.Enabled = true;
                txtValorPercentual.Text = "0";
            }
        }
    }
}
