using e_Locadora.Dominio;
using e_Locadora.Dominio.VeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoDominioTest
    {
        [TestMethod]
        public void Deve_Validar_Veiculo()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("ESTA_VALIDO", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_ValidarPlaca()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("O campo Placa é obrigatório", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Fabricante()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("O campo Fabricante é obrigatório", veiculo.Validar());
        }

       [TestMethod]
        public void Nao_Deve_Validar_Tanque()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("O campo Quantidade De Litros do Tanque de Combustivel é obrigatório", veiculo.Validar());
        }

       [TestMethod]
        public void Nao_Deve_Validar_Chassi()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("O campo Numero do Chassi é obrigatório", veiculo.Validar());
        }

       [TestMethod]
        public void Nao_Deve_Validar_Cor()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);
            Assert.AreEqual("O campo Cor do Veiculo é obrigatório", veiculo.Validar());
        }

        [TestMethod]

        public void Nao_Deve_Validar_Capacidade_Ocupantes_menor_Ocupantes()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);

            Assert.AreEqual("O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)", veiculo.Validar());

        }

        [TestMethod]

        public void Nao_Deve_Validar_Capacidade_Ocupantes_Maior_Ocupantes()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);

            Assert.AreEqual("O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)", veiculo.Validar());

        }

        [TestMethod]

        public void Nao_Deve_Validar_Ano_De_Fabricacao()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "grande", "etanol", grupoVeiculo, null);

            Assert.AreEqual("O campo Ano de Fabricação do Veiculo nao pode Ser Nullo", veiculo.Validar());

        }
        [TestMethod]
        public void Nao_Deve_Validar_Portamalas()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            var veiculo = new Veiculo("1234", "Modelo", "Fabricante", 0, 4, 4, "4", "azul", 4, 1994, "", "etanol", grupoVeiculo, null);

            Assert.AreEqual("O campo Tamanho do Porta Malas é obrigatório", veiculo.Validar());

        }

        /*[TestMethod]
        public void Nao_Deve_Validar_Imagem()
        {
            var grupoVeiculo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 4, 2010, "grande", "Etanol", grupo, null);

            Assert.AreEqual("O campo Imagem é obrigatório", veiculo.Validar());

        }*/
    }
}
