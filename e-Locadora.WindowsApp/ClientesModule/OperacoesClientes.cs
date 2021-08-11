using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Dominio.ClientesModule;
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
            tabelaClientes = new TabelaClientesControl(controlador);
        }

        public void InserirNovoRegistro()
        {
            TelaClientesForm tela = new TelaClientesForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Cliente);

                tabelaClientes.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Cliente.Nome}] inserido com sucesso");
            }
        }
   
        public void EditarRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cliente para poder editar!", "Edição de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Clientes clienteSelecionado = controlador.SelecionarPorId(id);

            TelaClientesForm tela = new TelaClientesForm();

            tela.Cliente = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Cliente);

                tabelaClientes.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Cliente.Nome}] editado com sucesso");
            }

        }

        public void ExcluirRegistro()
        {
            int id = tabelaClientes.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cliente para poder excluir!", "Exclusão de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Clientes clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                tabelaClientes.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
         
        }
        public void DesagruparRegistros()
        {
            tabelaClientes.DesagruparClientes();
        }

        public UserControl ObterTabela()
        {
            tabelaClientes.AtualizarRegistros();

            return tabelaClientes;
        }
    }
}
