using e_Locadora.Dominio;
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

namespace e_Locadora.WindowsApp.GrupoVeiculoModule
{
    public partial class TelaGrupoVeiculoForm : Form
    {
        private GrupoVeiculo grupoVeiculo;

        public TelaGrupoVeiculoForm()
        {
            InitializeComponent();
        }

        public GrupoVeiculo GrupoVeiculo
        {
            get { return grupoVeiculo; }

            set
            {
                grupoVeiculo = value;

                txtId.Text = grupoVeiculo.Id.ToString();
                txtCategoria.Text = grupoVeiculo.categoria;
                txtPlanoDiarioValorDiario.Text = grupoVeiculo.planoDiarioValorDiario.ToString();
                txtPlanoDiarioValorKm.Text = grupoVeiculo.planoDiarioValorKm.ToString();
                txtPlanoControladoValorDiario.Text = grupoVeiculo.planoKmControladoValorDiario.ToString();
                txtPlanoControladoValorKm.Text = grupoVeiculo.planoKmControladoValorKm.ToString();
                txtPlanoLivreValorDiario.Text = grupoVeiculo.planoKmLivreValorDiario.ToString();
            }
        }


        public string ValidarCampos() 
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
                return "Categoria Invalido, tente novamente";

            if (!ValidarTipoDouble(txtPlanoDiarioValorDiario.Text))
                return "Valor Plano Diario inválido, tente novamente";

            if (!ValidarTipoDouble(txtPlanoDiarioValorKm.Text))
                return "Valor Plano Diario Valor KM inválido, tente novamente";

            if (!ValidarTipoDouble(txtPlanoControladoValorDiario.Text))
                return "Valor Plano Controlado Valor Diario inválido, tente novamente";

            if (!ValidarTipoDouble(txtPlanoControladoValorKm.Text))
                return "Valor Plano Controlado Valor Km inválido, tente novamente";

            if (!ValidarTipoDouble(txtPlanoControladoValorKm.Text))
                return "Valor Plano Livre Valor Diario inválido, tente novamente";

            return "CAMPOS_VALIDIS";
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
            string resultadoValidacao = ValidarCampos();
            if (resultadoValidacao.Equals("CAMPOS_VALIDOS"))
            {
                DialogResult = DialogResult.OK;
                string categoria = txtCategoria.Text;
                double planoDiarioValorDiario = Convert.ToDouble(txtPlanoDiarioValorDiario.Text);
                double planoDiarioValorKm = Convert.ToDouble(txtPlanoDiarioValorKm.Text);
                double planoControladoValorDiario = Convert.ToDouble(txtPlanoControladoValorDiario.Text);
                double planoControladoValorKm = Convert.ToDouble(txtPlanoControladoValorKm.Text);
                double planoLivreValorDiario = Convert.ToDouble(txtPlanoLivreValorDiario.Text);

                grupoVeiculo = new GrupoVeiculo(categoria, planoDiarioValorDiario, planoDiarioValorKm, planoControladoValorDiario, planoControladoValorKm, planoLivreValorDiario);

                resultadoValidacao = grupoVeiculo.Validar();

                if (resultadoValidacao != "ESTA_VALIDO")
                {
                    string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                    DialogResult = DialogResult.None;
                }
                
            }
            else
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
            }
        }
    }
}
