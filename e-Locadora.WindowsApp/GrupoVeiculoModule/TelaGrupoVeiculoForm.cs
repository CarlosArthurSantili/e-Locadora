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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string categoria = txtCategoria.Text;
                double planoDiarioValorDiario = Convert.ToDouble(txtPlanoDiarioValorDiario.Text);
                double planoDiarioValorKm = Convert.ToDouble(txtPlanoDiarioValorKm.Text);
                double planoControladoValorDiario = Convert.ToDouble(txtPlanoControladoValorDiario.Text);
                double planoControladoValorKm = Convert.ToDouble(txtPlanoControladoValorKm.Text);
                double planoLivreValorDiario = Convert.ToDouble(txtPlanoLivreValorDiario.Text);
            

                grupoVeiculo = new GrupoVeiculo(categoria, planoDiarioValorDiario, planoDiarioValorKm, planoControladoValorDiario, planoControladoValorKm, planoLivreValorDiario);

                string resultadoValidacao = grupoVeiculo.Validar();

                if (resultadoValidacao != "ESTA_VALIDO")
                {
                    string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                    DialogResult = DialogResult.None;
                }
                this.Close();
            }
            catch (Exception e)
            {
                
            }
        }

    }
}
