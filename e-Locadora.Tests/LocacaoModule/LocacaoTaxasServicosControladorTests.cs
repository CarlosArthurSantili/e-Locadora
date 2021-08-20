
using e_Locadora.Controladores;
using e_Locadora.Controladores.ClientesModule;
using e_Locadora.Controladores.CondutorModule;
using e_Locadora.Controladores.FuncionarioModule;
using e_Locadora.Controladores.LocacaoModule;
using e_Locadora.Controladores.LocacaoTaxasServicosModule;
using e_Locadora.Controladores.TaxasServicoModule;
using e_Locadora.Controladores.VeiculoModule;
using e_Locadora.Dominio;
using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using e_Locadora.Dominio.FuncionarioModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.Dominio.TaxasServicosModule;
using e_Locadora.Dominio.VeiculosModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Locadora.Tests.LocacaoModule
{
    [TestClass]
    public class LocacaoTaxasServicosControladorTests
    {
        ControladorFuncionario controladorFuncionario = null;
        ControladorGrupoVeiculo controladorGrupoVeiculo = null;
        ControladorVeiculos controladorVeiculo = null;
        ControladorClientes controladorCliente = null;
        ControladorCondutor controladorCondutor = null;
        ControladorTaxasServicos controladorTaxasServicos = null;
        ControladorLocacao controladorLocacao = null;
        ControladorLocacaoTaxasServicos controladorLocacaoTaxasServicos = null;

        public LocacaoTaxasServicosControladorTests()
        {
            LimparTabelas();
            controladorFuncionario = new ControladorFuncionario();
            controladorGrupoVeiculo = new ControladorGrupoVeiculo();
            controladorVeiculo = new ControladorVeiculos();
            controladorCliente = new ControladorClientes();
            controladorCondutor = new ControladorCondutor();
            controladorTaxasServicos = new ControladorTaxasServicos();
            controladorLocacao = new ControladorLocacao();
            controladorLocacaoTaxasServicos = new ControladorLocacaoTaxasServicos();
        }

        [TestCleanup()]
        public void LimparTabelas()
        {
            Db.Update("DELETE FROM TBLOCACAO_TBTAXASSERVICOS");
            Db.Update("DELETE FROM TBLOCACAO");
            Db.Update("DELETE FROM TBTAXASSERVICOS");
            Db.Update("DELETE FROM TBCONDUTOR");
            Db.Update("DELETE FROM TBCLIENTES");
            Db.Update("DELETE FROM TBFUNCIONARIO");
            Db.Update("DELETE FROM TBVEICULOS");
            Db.Update("DELETE FROM CATEGORIAS");

        }

        [TestMethod]
        public void DeveInserir_LocacaoTaxasServicos()
        {
            //arrange
            var funcionario = new Funcionario("nome", "460162200", "usuario", "senha", DateTime.Now.Date, 600.0);
            var grupoVeiculo = new GrupoVeiculo("Economico", 1, 2, 3, 4, 5, 6);
            var imagem = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 };
            var veiculo = new Veiculo("placa", "modelo", "fabricante", 400.0, 50, 4, "123456", "azul", 4, 1996, "Grande", "Gasolina", grupoVeiculo, imagem);
            var cliente = new Clientes("Joao", "rua souza", "9524282242", "853242", "20220220222", "1239232");
            var condutor = new Condutor("Joao", "Rua dos Joao", "9522185224", "5222522", "20202020222", "522542", new DateTime(2022, 05, 26), cliente);
            var taxaServico1 = new TaxasServicos("descricao", 200, 0);
            var taxaServico2 = new TaxasServicos("descricao2", 200, 0);
            var locacao = new Locacao(funcionario, DateTime.Now.Date, DateTime.Now.Date, 200, "Livre", 200, 0, grupoVeiculo, veiculo, cliente, condutor, true);
            var locacaoTaxasServicos1 = new LocacaoTaxasServicos(locacao, taxaServico1);
            var locacaoTaxasServicos2 = new LocacaoTaxasServicos(locacao, taxaServico2);

            //action
            controladorFuncionario.InserirNovo(funcionario);
            controladorGrupoVeiculo.InserirNovo(grupoVeiculo);
            controladorVeiculo.InserirNovo(veiculo);
            controladorCliente.InserirNovo(cliente);
            controladorCondutor.InserirNovo(condutor);
            controladorTaxasServicos.InserirNovo(taxaServico1);
            controladorTaxasServicos.InserirNovo(taxaServico2);
            controladorLocacao.InserirNovo(locacao);
            controladorLocacaoTaxasServicos.InserirNovo(locacaoTaxasServicos1);
            controladorLocacaoTaxasServicos.InserirNovo(locacaoTaxasServicos2);


            //assert
            var locacaoTaxasServicosEncontrado1 = controladorLocacaoTaxasServicos.SelecionarPorId(locacaoTaxasServicos1.Id);
            locacaoTaxasServicosEncontrado1.Should().Be(locacaoTaxasServicos1);
            locacaoTaxasServicosEncontrado1.locacao.Should().Be(locacao);
            locacaoTaxasServicosEncontrado1.taxasServicos.Should().Be(taxaServico1);

            var locacaoTaxasServicosEncontrado2 = controladorLocacaoTaxasServicos.SelecionarPorId(locacaoTaxasServicos2.Id);
            locacaoTaxasServicosEncontrado2.Should().Be(locacaoTaxasServicos2);
            locacaoTaxasServicosEncontrado2.locacao.Should().Be(locacao);
            locacaoTaxasServicosEncontrado2.taxasServicos.Should().Be(taxaServico2);
        }
    }
}
