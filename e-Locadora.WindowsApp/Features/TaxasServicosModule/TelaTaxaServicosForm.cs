using e_Locadora.Dominio.TaxasServicosModule;
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

namespace e_Locadora.WindowsApp.Features.TaxasServicosModule
{
    public partial class TelaTaxaServicosForm : Form
    {
        private TaxasServicos taxasServicos;
        public TelaTaxaServicosForm()
        {
            InitializeComponent();
        }

        public TaxasServicos TaxasServicos
        {
            get { return taxasServicos; }

            set
            {
                taxasServicos = value;

                txtId.Text = taxasServicos.Id.ToString();
                txtDescricao.Text = taxasServicos.Descricao;
                textTaxaFixa.Text = taxasServicos.TaxaFixa.ToString();
                textTaxaDiaria.Text = taxasServicos.TaxaDiaria.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double taxaFixa = Convert.ToDouble(textTaxaFixa.Text);
            double taxaDiaria = Convert.ToDouble(textTaxaDiaria.Text);

            taxasServicos = new TaxasServicos(descricao, taxaFixa, taxaDiaria);

            string resultadoValidacao = taxasServicos.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void taxaFixa_CheckedChanged(object sender, EventArgs e)
        {
            if(taxaFixa.Checked == true )
            {
                textTaxaDiaria.Enabled = false;
                textTaxaDiaria.Text = "0";
            }
        }

        private void taxaDiaria_CheckedChanged(object sender, EventArgs e)
        {
            if(taxaDiaria.Checked == true)
            {
                textTaxaFixa.Enabled = false;
                textTaxaFixa.Text = "0";
            }
        }

        private void TelaTaxaServicosForm_Load(object sender, EventArgs e)
        {
            taxaFixa.Checked = true;
            taxaDiaria.Checked = false;
        }


    }
}
