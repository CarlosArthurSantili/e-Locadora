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
using e_Locadora.Dominio.VeiculosModule;

namespace e_Locadora.WindowsApp.Features.Veiculo
{
    public partial class TelaVeiculoForm : Form
    {
        string imgLocation = "";
        public TelaVeiculoForm()
        {
            InitializeComponent();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxVeiculo.ImageLocation = imgLocation;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Código para obter imagem
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            string placa = txtPlaca.Text;
            string chassi = txtChassi.Text;
            string cor = txtCor.Text;
            string fabricante = txtFabricante.Text;
            int capacidadeTanque = Convert.ToInt32(txtCapacidadeTanque.Text);
            int qtdPortas = Convert.ToInt32(txtQtdPortas.Text);
            int ano = Convert.ToInt32(txtAno.Text);
            int capacidadePessoas = Convert.ToInt32(txtCapacidadePessoas.Text);
            string tipoGasolina = comboBoxGasolina.Text;
            string tamanhoPortaMalas = comboBoxPortaMalas.Text;

            //veiculo = new Veiculo();

            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
