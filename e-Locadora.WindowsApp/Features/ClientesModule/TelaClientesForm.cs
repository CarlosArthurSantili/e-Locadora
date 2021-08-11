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
                txtRG.Text = cliente.RG;
                txtCPF.Text = cliente.CPF;
                txtCnpj.Text = cliente.CNPJ;
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

            cliente = new Clientes(nome, endereco, telefone, rg, cpf, cnpj);

            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                txtCnpj.Enabled = false;
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
                txtRG.Enabled = false;
            }
        }

        private void TelaClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaClientesForm_Load(object sender, EventArgs e)
        {
            rbCPF.Checked = true;
            txtCnpj.Enabled = false;
        }
    }
}
