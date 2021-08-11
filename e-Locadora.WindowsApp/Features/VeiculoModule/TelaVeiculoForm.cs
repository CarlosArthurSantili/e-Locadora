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
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
using e_Locadora.Dominio.VeiculosModule;

namespace e_Locadora.WindowsApp.Features.VeiculoModule
{
    public partial class TelaVeiculoForm : Form
    {
        private ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();
        private Veiculo veiculo;

        string imgLocation = "";

        public TelaVeiculoForm()
        {
            InitializeComponent();
        }

        public Veiculo Veiculo
        {
            get { return veiculo; }

            set
            {
                veiculo = value;

                txtId.Text = veiculo.Id.ToString();
                txtPlaca.Text = veiculo.Placa;
                txtChassi.Text = veiculo.NumeroChassi;
                txtCor.Text = veiculo.Cor;
                txtFabricante.Text = veiculo.Fabricante;
                txtCapacidadeTanque.Text = veiculo.QtdLitrosTanque.ToString();
                txtQtdPortas.Text = veiculo.QtdPortas.ToString();
                txtAno.Text = veiculo.AnoFabricacao.ToString();
                txtCapacidadePessoas.Text = veiculo.CapacidadeOcupantes.ToString();
                comboBoxGasolina.SelectedItem = veiculo.Combustivel.ToString();
                comboBoxPortaMalas.SelectedItem = veiculo.TamanhoPortaMalas.ToString();
                comboBoxGrupoVeiculo.SelectedItem = veiculo.GrupoVeiculo;
                pictureBoxVeiculo.Image = ConvertBinaryToImage(veiculo.Imagem);
                
            }
        }

        //Convert binary to image
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
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
            byte[] imagem = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            imagem = brs.ReadBytes((int)stream.Length);

            string placa = txtPlaca.Text;
            string chassi = txtChassi.Text;
            string cor = txtCor.Text;
            string fabricante = txtFabricante.Text;
            int capacidadeTanque = Convert.ToInt32(txtCapacidadeTanque.Text);
            int qtdPortas = Convert.ToInt32(txtQtdPortas.Text);
            int ano = Convert.ToInt32(txtAno.Text);
            int capacidadePessoas = Convert.ToInt32(txtCapacidadePessoas.Text);
            string tipoGasolina = comboBoxGasolina.SelectedItem.ToString();
            string tamanhoPortaMalas = comboBoxPortaMalas.SelectedItem.ToString();
            GrupoVeiculo grupoVeiculo = (GrupoVeiculo)comboBoxGrupoVeiculo.SelectedItem;

            veiculo = new Veiculo(placa, fabricante, capacidadeTanque, qtdPortas, chassi, cor, capacidadePessoas, ano, tamanhoPortaMalas, tipoGasolina, grupoVeiculo, imagem);

            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaVeiculoForm_Load(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void CarregarContatos()
        {
            foreach (GrupoVeiculo grupoVeiculo in controladorGrupoVeiculo.SelecionarTodos())
                comboBoxGrupoVeiculo.Items.Add(grupoVeiculo);
        }

        #region Eventos não utilizados
        private void comboBoxPortaMalas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPortaMalas_Click(object sender, EventArgs e)
        {

        }

        private void labelGasolina_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGasolina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPlaca_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
