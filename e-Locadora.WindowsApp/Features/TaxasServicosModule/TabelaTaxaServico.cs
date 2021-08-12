using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Dominio.TaxasServicosModule;
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

namespace e_Locadora.WindowsApp.Features.TaxasServicosModule
{
    public partial class TabelaTaxaServico : UserControl
    {
        private readonly ControladorTaxasServicos controladorTaxasServicos;

        public TabelaTaxaServico(ControladorTaxasServicos ctrlTaxasServicos)
        {
            InitializeComponent();
            gridTaxasServicos.ConfigurarGridZebrado();
            gridTaxasServicos.ConfigurarGridSomenteLeitura();
            gridTaxasServicos.Columns.AddRange(ObterColunas());
            this.controladorTaxasServicos = ctrlTaxasServicos;
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Detalhes", HeaderText = "Detalhes"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaFixa", HeaderText = "Taxa Fixa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaDiaria", HeaderText = "Taxa Diaria"},

            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridTaxasServicos.SelecionarId<int>();
        }
        public void AtualizarRegistros()
        {

            var taxasServicos = controladorTaxasServicos.SelecionarTodos();

            CarregarTbela(taxasServicos);

        }
        private void CarregarTbela(List<TaxasServicos> taxasServicos)
        {
            gridTaxasServicos.DataSource = taxasServicos;
        }
    }
}
