using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Dominio.ClientesModule;
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

namespace e_Locadora.WindowsApp.ClientesModule
{
    public partial class TabelaClientesControl : UserControl
    {
        private readonly ControladorClientes controladorClientes;

        private Subro.Controls.DataGridViewGrouper gridClientesAgrupados;
        private AgrupamentoClientesEnum tipoAgrupamento;

        public AgrupamentoClientesEnum TipoAgrupamento
        {
            get { return tipoAgrupamento; }
        }

        public TabelaClientesControl(ControladorClientes controladorClientes)
        {
            InitializeComponent();
            gridClientes.ConfigurarGridZebrado();
            gridClientes.ConfigurarGridSomenteLeitura();
            gridClientes.Columns.AddRange(ObterColunas());
            this.controladorClientes = controladorClientes;

            tipoAgrupamento = AgrupamentoClientesEnum.TodosClientes;
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "RG", HeaderText = "Numero RG"},

                new DataGridViewTextBoxColumn {DataPropertyName = "CPF", HeaderText = "Numero CPF"},

                 new DataGridViewTextBoxColumn {DataPropertyName = "CNPJ", HeaderText = "Numero CNPJ"}
            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridClientes.SelecionarId<int>();
        }
        public void AgruparClientes(AgrupamentoClientesEnum tipoAgrupamento)
        {
            this.tipoAgrupamento = tipoAgrupamento;

            AgruparClientes();
        }
        public void AtualizarRegistros()
        {
            DesagruparClientes();

            var clientes = controladorClientes.SelecionarTodos();

            CarregarTbela(clientes);

            AgruparClientes();
        }
   
        public void DesagruparClientes()
        {
            if (gridClientesAgrupados == null)
                return;

            var campos = new string[] { "Cargo", "Empresa" };

            gridClientesAgrupados.RemoveGrouping();
            gridClientes.RowHeadersVisible = true;

            foreach (var campo in campos)
                foreach (DataGridViewColumn item in gridClientes.Columns)
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
        }
        public void AgruparClientesPor(string campo)
        {
            if (gridClientesAgrupados == null)
                return;
            gridClientesAgrupados.RemoveGrouping();
            gridClientesAgrupados.SetGroupOn(campo);
            gridClientesAgrupados.Options.ShowGroupName = false;
            gridClientesAgrupados.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in gridClientes.Columns)
                if (item.DataPropertyName == campo)
                    item.Visible = false;
            gridClientes.RowHeadersVisible = false;
            gridClientes.ClearSelection();

        }
        private void AgruparClientes()
        {
            switch (TipoAgrupamento)
            {
                case AgrupamentoClientesEnum.TodosClientes:
                    DesagruparClientes();
                    break;

                case AgrupamentoClientesEnum.ClientesAgrupadoPorCPF:
                    AgruparClientesPor("CPF");
                    break;

                case AgrupamentoClientesEnum.ClientesAgrupadosPorCNPJ:
                    AgruparClientesPor("CNPJ");
                    break;

                default:
                    break;
            }
        }
        private void CarregarTbela(List<Clientes> clientes)
        {
            gridClientes.DataSource = clientes;

            gridClientesAgrupados = new Subro.Controls.DataGridViewGrouper(gridClientes);
        }

    }
}
