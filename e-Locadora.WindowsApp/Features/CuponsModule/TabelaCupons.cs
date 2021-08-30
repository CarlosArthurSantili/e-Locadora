using e_Locadora.Controladores.CupomModule;
using e_Locadora.Dominio.CupomModule;
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

namespace e_Locadora.WindowsApp.Features.CuponsModule
{
    public partial class TabelaCupons : UserControl
    {
        private readonly ControladorCupons  controladorCupons;
        public TabelaCupons(ControladorCupons ctrlCupons)
        {
            InitializeComponent();
            gridCupons.ConfigurarGridZebrado();
            gridCupons.ConfigurarGridSomenteLeitura();
            gridCupons.Columns.AddRange(ObterColunas());
            this.controladorCupons = ctrlCupons;
        }

        private DataGridViewColumn[] ObterColunas()
        {
           var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorPercentual", HeaderText = "Valor Percentual"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorFixo", HeaderText = "Valor Fixo R$"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataValidade", HeaderText = "Data de Validade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Parceiro", HeaderText = "Parceiro"}

           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridCupons.SelecionarId<int>();
        }
        public void AtualizarRegistros()
        {

            var cupons = controladorCupons.SelecionarTodos();

            CarregarTbela(cupons);

        }
        private void CarregarTbela(List<Cupons> cupons)
        {
            gridCupons.DataSource = cupons;
        }
    }
}
