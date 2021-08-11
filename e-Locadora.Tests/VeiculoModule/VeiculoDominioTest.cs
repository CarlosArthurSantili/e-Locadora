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
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("ESTA_VALIDO", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_ValidarPlaca()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("", "BMW", 55, 4, "123456789", "AZUL", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("O campo Placa é obrigatório", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Fabricante()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "", 55, 4, "123456789", "AZUL", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("O campo Fabricante é obrigatório", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Tanque()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 0, 4, "123456789", "AZUL", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("O campo Quantidade De Litros do Tanque de Combustivel é obrigatório", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Chassi()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "", "AZUL", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("O campo Numero do Chassi é obrigatório", veiculo.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Cor()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "", 4, 2010, "Pequeno", "Etanol", grupo);
            Assert.AreEqual("O campo Cor do Veiculo é obrigatório", veiculo.Validar());
        }

        [TestMethod]

        public void Nao_Deve_Validar_Capacidade_Ocupantes_menor_Ocupantes()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 1, 2010, "Pequeno", "Etanol", grupo);

            Assert.AreEqual("O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)", veiculo.Validar());

        }

        [TestMethod]

        public void Nao_Deve_Validar_Capacidade_Ocupantes_Maior_Ocupantes()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 10, 2010, "Pequeno", "Etanol", grupo);

            Assert.AreEqual("O campo Capacidade de Ocupantes do Veiculo é obrigatório(Com Minimo 2 Lugares e Maximo 7)", veiculo.Validar());

        }

        [TestMethod]

        public void Nao_Deve_Validar_Ano_De_Fabricacao()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 4, int.MinValue, "Pequeno", "Etanol", grupo);

            Assert.AreEqual("O campo Ano de Fabricação do Veiculo nao pode Ser Nullo", veiculo.Validar());

        }

        [TestMethod]
        public void Nao_Deve_Validar_Portamalas()
        {
            var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

            Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, 4, "123456789", "AZUL", 4, 2010, "", "Etanol", grupo);

            Assert.AreEqual("O campo Tamanho do Porta Malas é obrigatório", veiculo.Validar());

        }

    //    [TestMethod]
    //    public void Nao_Deve_Validar_Grupo()
    //    {
    //        var grupo = new GrupoVeiculo("SUV", 1000, 2000, 3000, 4000, 500);

    //        Veiculo veiculo = new Veiculo("ABC-1234", "BMW", 55, "123456789", "AZUL", 4, 2010, 20, CombustivelEnum.Gasolina, null);

    //        Assert.AreEqual("O Campo Grupo de Veiculo é obrigatório", veiculo.Validar());

    //    }
     }
}
