using e_Locadora.Controladores.ClientesModule;
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
    public partial class TabelaClientesControl : UserControl
    {
        private readonly ControladorClientes controladorContato;

        private Subro.Controls.DataGridViewGrouper gridClientesAgrupados;
        private AgrupamentoClientesEnum tipoAgrupamento;
        public TabelaClientesControl()
        {
            InitializeComponent();
        }
    }
}
