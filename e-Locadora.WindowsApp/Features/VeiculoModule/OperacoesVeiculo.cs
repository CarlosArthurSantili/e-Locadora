using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio.VeiculosModule;
using e_Locadora.WindowsApp.Features.VeiculoModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.VeiculoModule
{
    public class OperacoesVeiculo : ICadastravel
    {
        private ControladorVeiculos controladorVeiculo = null;
        private TabelaVeiculoControl tabelaVeiculoControl = null;


        public OperacoesVeiculo(ControladorVeiculos ctrlVeiculo)
        {
            controladorVeiculo = ctrlVeiculo;
            tabelaVeiculoControl = new TabelaVeiculoControl();
        }


        public void AgruparRegistros()
        {
        }

        public void DesagruparRegistros()
        {
        }

        public void EditarRegistro()
        {
            int id = tabelaVeiculoControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Veiculo para poder editar!", "Edição de Veiculos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo VeiculoSelecionada = controladorVeiculo.SelecionarPorId(id);

            TelaVeiculoForm tela = new TelaVeiculoForm();

            tela.Veiculo = VeiculoSelecionada;

            tela.ShowDialog();
            if (tela.ValidarCampos() == true)
                if (tela.DialogResult == DialogResult.OK)
                {
                    controladorVeiculo.Editar(id, tela.Veiculo);

                    tabelaVeiculoControl.AtualizarRegistros();

                    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.Placa}] editado com sucesso");
                }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaVeiculoControl.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veiculo para poder excluir!", "Exclusão de Veiculo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo VeiculoSelecionada = controladorVeiculo.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o veiculo: [{VeiculoSelecionada.Placa}] ?",
                "Exclusão de Veiculo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controladorVeiculo.Excluir(id);

                tabelaVeiculoControl.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{VeiculoSelecionada.Placa}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
        }

        public void InserirNovoRegistro()
        {
            TelaVeiculoForm tela = new TelaVeiculoForm();
            tela.ShowDialog();
            if (tela.ValidarCampos() == true)
                if (tela.DialogResult == DialogResult.OK)
                {
                    controladorVeiculo.InserirNovo(tela.Veiculo);

                    tabelaVeiculoControl.AtualizarRegistros();

                    TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.Placa}] inserido com sucesso");
                }
        }

        public UserControl ObterTabela()
        {
            tabelaVeiculoControl.AtualizarRegistros();

            return tabelaVeiculoControl;
        }
    }
}
