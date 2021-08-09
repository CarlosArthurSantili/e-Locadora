using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
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

namespace e_Locadora.WindowsApp.GrupoVeiculoModule
{
    public partial class TabelaGrupoVeiculoControl : UserControl
    {
        public ControladorGrupoVeiculo controladorGrupoVeiculo = new ControladorGrupoVeiculo();

        public TabelaGrupoVeiculoControl()
        {
            InitializeComponent();
            gridGrupoVeiculo.ConfigurarGridZebrado();
            gridGrupoVeiculo.ConfigurarGridSomenteLeitura();
            gridGrupoVeiculo.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorDiario", HeaderText = "PlanoDiarioValorDiario"},

                new DataGridViewTextBoxColumn { DataPropertyName = "valorDiarioKM", HeaderText = "PlanoDiarioValorKm"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorControladoDiarioKm", HeaderText = "PlanoControladoValorDiario"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorControladoDiario", HeaderText = "PlanoControladoValorKm"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ValorLivre", HeaderText = "PlanoLivreValorDiario"}
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridGrupoVeiculo.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            var grupoVeiculos = controladorGrupoVeiculo.SelecionarTodos();

            CarregarTabela(grupoVeiculos);
        }

        public void CarregarTabela(List<GrupoVeiculo> grupoVeiculos)
        {
            gridGrupoVeiculo.DataSource = grupoVeiculos;
        }
    }
}
