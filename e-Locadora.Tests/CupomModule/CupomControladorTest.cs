using e_Locadora.Controladores;
using e_Locadora.Controladores.CupomModule;
using e_Locadora.Dominio.CupomModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace e_Locadora.Tests.CupomModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class CupomControladorTest
    {
        ControladorCupons controlador = null;

        public CupomControladorTest()
        {
            controlador = new ControladorCupons();
            LimparTelas();
        }

        private void LimparTelas()
        {
            Db.Update("DELETE FROM TBCUPONS");
        }

        [TestMethod]
        public void Deve_Inserir_Novo_Cupom()
        {
            var cupom = new Cupons("Deko-1236", 250, 0, new DateTime(2021,08,26), "Desconto do Deko");

            //action
            controlador.InserirNovo(cupom);

            //assert
            var parceiroEncontrado = controlador.SelecionarPorId(cupom.Id);
            parceiroEncontrado.Should().Be(cupom);
        }

        [TestMethod]
        public void Deve_Atualizar_Cupom()
        {
            //arrange
            var cupom = new Cupons("Deko-1236", 250, 0, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom);
            var cupomAtualizado = new Cupons("Deko-5946", 150, 0, new DateTime(2021, 08, 26), "Desconto do Deko");

            //action
            controlador.Editar(cupom.Id, cupomAtualizado);

            //assert
            Cupons cuponsEditado = controlador.SelecionarPorId(cupom.Id);
            cuponsEditado.Should().Be(cupomAtualizado);
        }

        [TestMethod]
        public void Deve_SelecionarPorId_Cupons_ValorPercentual()
        {
            //arrange
            var cupom = new Cupons("Deko-1236", 250, 0, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom);
            //action
            Cupons cupomEncontrado = controlador.SelecionarPorId(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_SelecionarPorId_Cupons_ValorFixo()
        {
            //arrange
            var cupom = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom);
            //action
            Cupons cupomEncontrado = controlador.SelecionarPorId(cupom.Id);

            //assert
            cupomEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void Deve_Excluir_TaxasServicos()
        {
            //arrange
            var cupom = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom);
            //action
            controlador.Excluir(cupom.Id);

            //assert
            var cupomEncrontrado = controlador.SelecionarPorId(cupom.Id);
            cupomEncrontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCupons()
        {
            //arrange
            var cupom1 = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom1);

            var cupom2 = new Cupons("Deko-1656", 150, 0, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom2);


            var cupom3 = new Cupons("Deko-2015", 25, 0, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom3);

            //action
            var taxasServicos = controlador.SelecionarTodos();

            //assert
            taxasServicos.Should().HaveCount(3);
            taxasServicos[0].Nome.Should().Be("Deko-1236");
            taxasServicos[1].Nome.Should().Be("Deko-1656");
            taxasServicos[2].Nome.Should().Be("Deko-2015");
        }

        [TestMethod]
        public void Nao_Deve_Cadastrar_Cupons_Iguais()
        {
            var cupom1 = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom1);

            var cupom2 = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom1);

            string resultado = controlador.InserirNovo(cupom2);

            resultado.Should().Be("Cupom já cadastrada, tente novamente.");
            List<Cupons> taxasServicos = controlador.SelecionarTodos();

            taxasServicos.Should().HaveCount(1);

        }

        [TestMethod]
        public void Nao_Deve_Editar_Cupons_Iguais()
        {
            var cupom1 = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");
            controlador.InserirNovo(cupom1);


            var cupomAtualizar = new Cupons("Deko-1236", 0, 250, new DateTime(2021, 08, 26), "Desconto do Deko");  

            string resultado = controlador.Editar(cupomAtualizar.Id, cupomAtualizar);

            resultado.Should().Be("Cupom já cadastrada, tente novamente.");
            List<Cupons> taxasServicos = controlador.SelecionarTodos();

            taxasServicos.Should().HaveCount(1);

        }

    }
    
}
