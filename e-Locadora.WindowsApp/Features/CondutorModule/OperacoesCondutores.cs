using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.CondutorModule
{
    public class OperacoesCondutores : ICadastravel
    {
        private ControladorCondutor controlador = null;
        private TabelaCondutorControl tabelaCondutor = null;

        public OperacoesCondutores(ControladorCondutor controlador)
        {
            this.controlador = controlador;
            tabelaCondutor = new TabelaCondutorControl(controlador);
        }

        public void InserirNovoRegistro()
        {
            TelaCondutorForm tela = new TelaCondutorForm();


            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Condutor);

                tabelaCondutor.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Condutor: [{tela.Condutor.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaCondutor.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Condutor para poder editar!", "Edição de Condutor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Condutor condutorSelecionado = controlador.SelecionarPorId(id);

            TelaCondutorForm tela = new TelaCondutorForm();

            tela.Condutor = condutorSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Condutor);

                tabelaCondutor.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Condutor: [{tela.Condutor.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaCondutor.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Condutor para poder excluir!", "Exlusão de Condutor",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Condutor condutorSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Condutor: [{condutorSelecionado.Nome}] ?",
             "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                tabelaCondutor.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Condutor: [{condutorSelecionado.Nome}] removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            FiltroCondutoresForm telaFiltro = new FiltroCondutoresForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                List<Condutor> condutores = new List<Condutor>();
                string condutorValidadeCnh = "";
                switch (telaFiltro.TipoFiltro)
                {
                    case FlitroCondutoresEnum.TodosCondutores:
                        condutores = controlador.SelecionarTodos();
                        break;

                    case FlitroCondutoresEnum.CondutoresCnhVencida:
                        {
                            condutores = controlador.SelecionarCondutoresComCnhVencida(DateTime.Now);
                            condutorValidadeCnh = "Vencidas";
                            break;
                        }

                    default:
                        break;
                }
            }
        }

        public UserControl ObterTabela()
        {
            tabelaCondutor.AtualizarRegistros();

            return tabelaCondutor;
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void DesagruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
