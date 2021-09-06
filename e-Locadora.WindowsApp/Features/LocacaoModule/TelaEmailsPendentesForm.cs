using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    public partial class TelaEmailsPendentesForm : Form
    {
        private OperacoesLocacao operacaoLocacao;
        public TelaEmailsPendentesForm()
        {
            InitializeComponent();

            ConfigurarPainelRegistros();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacaoLocacao.ObterTabelaEmailsPendentes();
            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }
    }
}
