﻿using e_Locadora.Controladores.LocacaoModule;
using e_Locadora.Controladores.LocacaoTaxasServicosModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.Dominio.TaxasServicosModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    public class OperacoesLocacao : ICadastravel
    {
        private ControladorLocacao controladorLocacao = null;
        private ControladorLocacaoTaxasServicos controladorLocacaoTaxasServicos = null;
        private TabelaLocacaoControl tabelaLocacao = null;

        public OperacoesLocacao(ControladorLocacao controladorLocacao)
        {
            this.controladorLocacao = controladorLocacao;
            tabelaLocacao = new TabelaLocacaoControl();
        }
        public void InserirNovoRegistro()
        {
            TelaLocacaoForm tela = new TelaLocacaoForm();
            tela.ShowDialog();
            if (tela.DialogResult == DialogResult.OK && controladorLocacao.ValidarLocacao(tela.Locacao) == "ESTA_VALIDO")
            {
                controladorLocacao.InserirNovo(tela.Locacao);

                foreach (LocacaoTaxasServicos taxaServicoIndividual in tela.LocacaoTaxasServicos)
                    controladorLocacaoTaxasServicos.InserirNovo(taxaServicoIndividual);
                tabelaLocacao.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação do veículo: [{tela.Locacao.veiculo.Modelo}] para o Cliente: [{tela.Locacao.cliente.Nome}] foi efetuada com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Locação para poder editar!", "Edição de Locacao",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionado = controladorLocacao.SelecionarPorId(id);

            TelaLocacaoForm tela = new TelaLocacaoForm();

            tela.Locacao = locacaoSelecionado;
            tela.ShowDialog();
            if (tela.DialogResult == DialogResult.OK && controladorLocacao.ValidarLocacao(tela.Locacao, id) == "ESTA_VALIDO")
            {
                List<TaxasServicos> taxasServicosSelecionados = controladorLocacaoTaxasServicos.SelecionarTaxasServicosPorLocacaoId(locacaoSelecionado.Id);

                foreach (TaxasServicos taxaServicoIndividual in taxasServicosSelecionados)
                    controladorLocacaoTaxasServicos.ExcluirPorIdLocacaoEIdTaxa(locacaoSelecionado.Id,taxaServicoIndividual.Id);

                controladorLocacao.Editar(id, tela.Locacao);

                foreach (LocacaoTaxasServicos locacaoTaxaServicoIndividual in tela.LocacaoTaxasServicos)
                {
                    controladorLocacaoTaxasServicos.InserirNovo(locacaoTaxaServicoIndividual);
                }
                
                tabelaLocacao.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação do veículo: [{tela.Locacao.veiculo.Modelo}] para o Cliente: [{tela.Locacao.cliente.Nome}] foi editada com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Locação para poder excluir!", "Exclusão de Locacao",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionado = controladorLocacao.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir a Locação do veículo: [{locacaoSelecionado.veiculo.Modelo}] para o Cliente: [{locacaoSelecionado.cliente.Nome}]?",
                "Exclusão de Locação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<TaxasServicos> taxasServicosSelecionados = controladorLocacaoTaxasServicos.SelecionarTaxasServicosPorLocacaoId(locacaoSelecionado.Id);
                foreach (TaxasServicos taxaServicoIndividual in taxasServicosSelecionados)
                    controladorLocacaoTaxasServicos.ExcluirPorIdLocacaoEIdTaxa(locacaoSelecionado.Id, taxaServicoIndividual.Id);
                controladorLocacao.Excluir(id);

                tabelaLocacao.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação do veículo: [{locacaoSelecionado.veiculo.Modelo}] para o Cliente: [{locacaoSelecionado.cliente.Nome}] foi removida com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            tabelaLocacao.AtualizarRegistros();

            return tabelaLocacao;
        }


        public void FiltrarRegistros()
        {
            TelaFiltroLocacaoForm tela = new TelaFiltroLocacaoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<Locacao> locacoes = new List<Locacao>();

                string chegadasPendentes = "";

                switch (tela.TipoFiltro)
                {
                    case FlitroLocacoesEnum.TodasLocacoes:
                        locacoes = controladorLocacao.SelecionarTodos();
                        break;

                    case FlitroLocacoesEnum.LocacoesChegadaPendente:
                        {
                            locacoes = controladorLocacao.SelecionarLocacoesPendentes(true, DateTime.Now);
                            chegadasPendentes = "Pendentes";
                            break;
                        }

                    default:
                        break;
                }
                tabelaLocacao.CarregarTabela(locacoes);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {locacoes.Count} chegadas {chegadasPendentes}");
            }
        }

        public void RegistrarDevolucao()
        {
            int id = tabelaLocacao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione uma Locação para registrar sua devolução!", "Registro de Devolução",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionado = controladorLocacao.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja registrar a devolução do veículo: [{locacaoSelecionado.veiculo.Modelo}] do Cliente: [{locacaoSelecionado.cliente.Nome}]?",
                "Registro de Devolução", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                controladorLocacao.Editar(id, locacaoSelecionado);

                tabelaLocacao.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Locação do veículo: [{locacaoSelecionado.veiculo.Modelo}] para o Cliente: [{locacaoSelecionado.cliente.Nome}] foi removida com sucesso");
            }
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
