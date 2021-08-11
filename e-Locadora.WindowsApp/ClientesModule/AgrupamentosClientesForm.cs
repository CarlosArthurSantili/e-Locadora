using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.ClientesModule
{
    public partial class AgrupamentosClientesForm : Form
    {
        public AgrupamentosClientesForm()
        {
            InitializeComponent();
        }
        public AgrupamentoClientesEnum TipoAgrupamento
        {
            get
            {
                if (rbCpf.Checked)
                    return AgrupamentoClientesEnum.ClientesAgrupadoPorCPF;

                else if (rbCnpj.Checked)
                    return AgrupamentoClientesEnum.ClientesAgrupadosPorCNPJ;

                else
                    return AgrupamentoClientesEnum.TodosClientes;
            }
        }
    }
}
