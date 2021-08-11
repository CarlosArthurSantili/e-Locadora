using e_Locadora.Controladores;
using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Dominio.TaxasServicosModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.TaxasServicosModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class TaxaServicoControladorTest
    {
        ControladorTaxasServicos controlador = null;

        public TaxaServicoControladorTest()
        {
            controlador = new ControladorTaxasServicos();
            LimparTelas();
        }

        private void LimparTelas()
        {
            Db.Update("DELETE FROM TBTAXASSERVICOS");
        }

        [TestMethod]
        public void Deve_Inserir_Novo_Taxas_E_Servicos()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 250, 0);

            //action
            controlador.InserirNovo(taxasServicos);

            //assert
            var grupoVeiculoEncontrado = controlador.SelecionarPorId(taxasServicos.Id);
            grupoVeiculoEncontrado.Should().Be(taxasServicos);
        }

        [TestMethod]
        public void Deve_Inserir_Novo_TaxasEServicos_TaxaVariavel()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 0, 300);

            //action
            controlador.InserirNovo(taxasServicos);

            //assert
            var grupoVeiculoEncontrado = controlador.SelecionarPorId(taxasServicos.Id);
            grupoVeiculoEncontrado.Should().Be(taxasServicos);
        }

        [TestMethod]
        public void Deve_Atualizar_Taxas_E_Servicos()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 0, 300);
            controlador.InserirNovo(taxasServicos);
            var taxaeAtualizado = new TaxasServicos("Taxa de manutenção", 50, 0);

            //action
            controlador.Editar(taxasServicos.Id, taxaeAtualizado);

            //assert
            TaxasServicos tasxaseServicosEditado = controlador.SelecionarPorId(taxasServicos.Id);
            tasxaseServicosEditado.Should().Be(taxaeAtualizado);
        }

        [TestMethod]
        public void Deve_SelecionarPorId_TaxasServicos_TaxaFixa()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 250, 0); 
            controlador.InserirNovo(taxasServicos);
            //action
            TaxasServicos taxaEncontrado = controlador.SelecionarPorId(taxasServicos.Id);

            //assert
            taxaEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_SelecionarPorId_TaxasServicos_TaxaVariavel()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 0, 250);
            controlador.InserirNovo(taxasServicos);
            //action
            TaxasServicos taxaEncontrado = controlador.SelecionarPorId(taxasServicos.Id);

            //assert
            taxaEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_Excluir_TaxasServicos()
        {
            //arrange
            var taxasServicos = new TaxasServicos("Taxa de Lavação", 0, 250);
            controlador.InserirNovo(taxasServicos);
            //action
            controlador.Excluir(taxasServicos.Id);

            //assert
            var taxaEncrontrado = controlador.SelecionarPorId(taxasServicos.Id);
            taxaEncrontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosClientes()
        {
            //arrange
            var taxasServicos1 = new TaxasServicos("Taxa de Lavação", 0, 250);
            controlador.InserirNovo(taxasServicos1);

            var taxasServicos2 = new TaxasServicos("Taxa de Manutenção", 250, 0);
            controlador.InserirNovo(taxasServicos2);


            var taxasServicos3 = new TaxasServicos("Taxa de GPS", 0, 250);
            controlador.InserirNovo(taxasServicos3);


            //action
            var clientes = controlador.SelecionarTodos();

            //assert
            clientes.Should().HaveCount(3);
            clientes[0].Descricao.Should().Be("Taxa de Lavação");
            clientes[1].Descricao.Should().Be("Taxa de Manutenção");
            clientes[2].Descricao.Should().Be("Taxa de GPS");
        }
    }
}
