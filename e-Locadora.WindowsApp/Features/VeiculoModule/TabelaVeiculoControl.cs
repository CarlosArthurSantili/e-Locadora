using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio.VeiculosModule;
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

namespace e_Locadora.WindowsApp.VeiculoModule
{
    public partial class TabelaVeiculoControl : UserControl
    {
        public ControladorVeiculos controladorVeiculos = new ControladorVeiculos();
        public TabelaVeiculoControl()
        {
            InitializeComponent();
            gridVeiculo.ConfigurarGridZebrado();
            gridVeiculo.ConfigurarGridSomenteLeitura();
            gridVeiculo.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
          {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Fabricante", HeaderText = "Fabricante"},

                new DataGridViewTextBoxColumn { DataPropertyName = "QtdLitrosTanque", HeaderText = "Quantida de Litros"},

                new DataGridViewTextBoxColumn { DataPropertyName = "NumeroChassi", HeaderText = "Numero do Chassi"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cor", HeaderText = "cor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "CapacidadeOcupantes", HeaderText = "Capacidade de Ocupantes"},

                new DataGridViewTextBoxColumn { DataPropertyName = "AnoFabricacao", HeaderText = "Ano de Fabricação" },

                new DataGridViewTextBoxColumn { DataPropertyName = "TamanhoPortaMalas", HeaderText = "Tamanho Porta Amalas" },

                new DataGridViewTextBoxColumn { DataPropertyName = "Combustivel", HeaderText = "Combustivel" },

                new DataGridViewTextBoxColumn { DataPropertyName = "GrupoVeiculos", HeaderText = "Grupo Veiculos" }

          };
           
            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridVeiculo.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            var veiculo = controladorVeiculos.SelecionarTodos();

            CarregarTabela(veiculo);

        }

        private void CarregarTabela(List<Veiculo> grupoVeiculos)
        {
            gridVeiculo.DataSource = grupoVeiculos;
        }
    }
}
