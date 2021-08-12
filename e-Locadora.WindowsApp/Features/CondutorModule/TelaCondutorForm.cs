using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
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

namespace e_Locadora.WindowsApp.Features.CondutorModule
{
    public partial class TelaCondutorForm : Form
    {
        private Condutor condutor;
        private ControladorClientes controladorCliente = new ControladorClientes();
        public TelaCondutorForm()
        {
            InitializeComponent();
            InicializarComboBoxClientes();
        }

        public Condutor Condutor
        {
            get { return condutor; }

            set
            {
                condutor = value;

                txtId.Text = condutor.Id.ToString();
                txtNome.Text = condutor.Nome;
                txtEndereco.Text = condutor.Endereco;

                TxtTelefone.Text = condutor.Telefone;
                txtRG.Text = condutor.Rg;
                txtCPF.Text = condutor.Cpf;
                txtCnh.Text = condutor.NumeroCNH;
                dateValidade.Value = condutor.ValidadeCNH;
                cbCliente.SelectedItem = condutor.Cliente;
                
            }
        }

        private void InicializarComboBoxClientes()
        {
            cbCliente.Items.Clear();

            List<Clientes> contatos = controladorCliente.SelecionarTodos();

            foreach (var contato in contatos)
            {
                cbCliente.Items.Add(contato);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string endereco = txtEndereco.Text;
            string telefone = TxtTelefone.Text;
            string rg = txtRG.Text;
            string cpf = txtCPF.Text;
            string cnh = txtCnh.Text;
            DateTime validade = dateValidade.Value;
            Clientes cliente = (Clientes)cbCliente.SelectedItem;

            condutor = new Condutor(nome, endereco, telefone, rg, cpf, cnh, validade, cliente);

            string resultadoValidacao = condutor.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCondutorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
