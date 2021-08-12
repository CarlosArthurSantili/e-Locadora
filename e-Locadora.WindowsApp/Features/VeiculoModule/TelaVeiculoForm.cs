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
                comboBoxCombustivel.SelectedItem = veiculo.Combustivel.ToString();
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
            if (ValidarCampos())
            {
                DialogResult = DialogResult.OK;
                //Código para obter imagem
                byte[] imagem = null;
                if (pictureBoxVeiculo.Image == null)
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    imagem = brs.ReadBytes((int)stream.Length);
                }
                else
                {
                    imagem = ConvertImageToBinary(pictureBoxVeiculo.Image);
                }
                string placa = txtPlaca.Text;
                string chassi = txtChassi.Text;
                string cor = txtCor.Text;
                string fabricante = txtFabricante.Text;
                int capacidadeTanque = Convert.ToInt32(txtCapacidadeTanque.Text);
                int qtdPortas = Convert.ToInt32(txtQtdPortas.Text);
                int ano = Convert.ToInt32(txtAno.Text);
                int capacidadePessoas = Convert.ToInt32(txtCapacidadePessoas.Text);
                string tipoGasolina = comboBoxCombustivel.SelectedItem.ToString();
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
            else { 
            
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
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

        public bool ValidarCampos() 
        {
            if(string.IsNullOrEmpty(txtPlaca.Text)) {
                labelPlaca.ForeColor = Color.Red;
                //labelPlaca.Text = "Placa é obrigatório";
                return false;
            }

            if(string.IsNullOrEmpty(txtChassi.Text)) {
                labelChassi.ForeColor = Color.Red;
                //labelChassi.Text = "Chassi é obrigatório";
                return false;
            }

            if(txtCor.Text.Equals("")) {
                labelCor.ForeColor = Color.Red;
                //labelCor.Text = "Cor é obrigatório";
                return false;
            }

            if(string.IsNullOrEmpty(txtFabricante.Text)) {
                labelFabricante.ForeColor = Color.Red;
                //labelFabricante.Text = "Fabricante é obrigatório";
                return false;
            }

            if(string.IsNullOrEmpty(txtCapacidadeTanque.Text)) {
                labelCapacidadeTanque.ForeColor = Color.Red;
                //labelCapacidadeTanque.Text = "Capacidade Tanque é obrigatório";
                return false;
            }

            if(string.IsNullOrEmpty(txtQtdPortas.Text)) {
                labelQtdPortas.ForeColor = Color.Red;
                //labelQtdPortas.Text = "Quantidade de Portas é obrigatório";
                return false;
            }

            if(string.IsNullOrEmpty(txtAno.Text)) {
                labelAno.ForeColor = Color.Red;
                //labelAno.Text = "Ano de Fabricação é obrigatório";
                return false;
            }

            if (string.IsNullOrEmpty(txtCapacidadePessoas.Text))
            {
                labelCapacidadePessoas.ForeColor = Color.Red;
                //labelCapacidadePessoas.Text = "Capacidade de Pessoas é obrigatório";
                return false;
            }

            if(comboBoxCombustivel.SelectedItem == null) 
            {
                labelCombustivel.ForeColor = Color.Red;
                //comboBoxCombustivel.ForeColor = Color.Red;
                //labelCombustivel.Text = "Tipo de combustível é obrigatório";
                return false;
            }

            if(comboBoxGrupoVeiculo.SelectedItem == null) 
            {
                labelGrupoVeiculo.ForeColor = Color.Red;
                //comboBoxGrupoVeiculo.ForeColor = Color.Red;
                //labelGrupoVeiculo.Text = "Grupo do veículo é obrigatório";
                return false;
            }

            if (comboBoxPortaMalas.SelectedItem == null) {
                labelPortaMalas.ForeColor = Color.Red;
                //comboBoxPortaMalas.ForeColor = Color.Red;
                //labelPortaMalas.Text = "Tamanho do porta malas é obrigatório";
                return false;
            }

            if (pictureBoxVeiculo.Image == null)
            {
                groupBoxImagemVeiculo.ForeColor = Color.Red;
                //labelPortaMalas.Text = "Imagem do veículo é obrigatório";
                return false;
            }

            return true;
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
