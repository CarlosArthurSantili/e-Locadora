using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Dominio.ClientesModule;
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

namespace e_Locadora.WindowsApp.ClientesModule
{
    public partial class TelaClientesForm : Form
    {
        private Clientes cliente;
        ControladorClientes controladorCliente = new ControladorClientes();
        public TelaClientesForm()
        {
            InitializeComponent();
        }
        public Clientes Cliente
        {
            get { return cliente; }

            set
            {
                cliente = value;

                txtId.Text = cliente.Id.ToString();
                txtNome.Text = cliente.Nome;
                txtEndereco.Text = cliente.Endereco;

                TxtTelefone.Text = cliente.Telefone;
                if (!cliente.CNPJ.Equals(""))
                {
                    rbCNPJ.Checked = true;
                    txtCnpj.Text = cliente.CNPJ;
                }
                else
                {
                    rbCPF.Checked = true;
                    txtRG.Text = cliente.RG;
                    txtCPF.Text = cliente.CPF;
                }
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = TxtTelefone.Text;
            string rg = txtRG.Text;
            string cpf = txtCPF.Text;
            string cnpj = txtCnpj.Text;

            cpf = RemoverPontosETracos(cpf);
            cnpj = RemoverPontosETracos(cnpj);


            cliente = new Clientes(nome, endereco, telefone, rg, cpf, cnpj);

            int id = Convert.ToInt32(txtId.Text);

            string resultadoValidacaoDominio = cliente.Validar();
            string resultadoValidacaoControlador = controladorCliente.ValidarClientes(cliente, id);

            if (resultadoValidacaoDominio != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacaoDominio).ReadLine();

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
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                txtCnpj.Enabled = false;
                txtCnpj.Text = "";
                txtCPF.Enabled = true;
                txtRG.Enabled = true;
            }
        }

        private void rbCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCNPJ.Checked)
            {
                txtCnpj.Enabled = true;
                txtCPF.Enabled = false;
                txtCPF.Text = "";
                txtRG.Enabled = false;
                txtRG.Text = "";
            }
        }

        private void TelaClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaClientesForm_Load(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                rbCPF.Checked = true;
                //.Enabled = false;
            }
            
        }

        private string RemoverPontosETracos(string palavra) {
            palavra = palavra.Replace(".", "");
            palavra = palavra.Replace(",", "");
            palavra = palavra.Replace("-", "");
            palavra = palavra.Replace("/", "");
            palavra = palavra.Trim();
            return palavra;
        }
    }
}
