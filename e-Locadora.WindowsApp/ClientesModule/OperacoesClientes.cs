using e_Locadora.Controladores.ClientesModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.ClientesModule
{
    public class OperacoesClientes : ICadastravel
    {
        private ControladorClientes controlador = null;
        private TabelaClientesControl tabelaClientes = null;

        public OperacoesClientes(ControladorClientes controlador)
        {
            this.controlador = controlador;
            tabelaClientes = new TabelaClientesControl();
        }

        public void AgruparRegistros()
        {
            TelaClientesForm tela = new TelaClientesForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.c);

                tabelaClientes.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"GrupoVeiculo: [{tela.GrupoVeiculo.categoria}] inserido com sucesso");
            }
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
