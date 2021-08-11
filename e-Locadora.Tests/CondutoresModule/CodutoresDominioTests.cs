using e_Locadora.Dominio.ClientesModule;
using e_Locadora.Dominio.CondutoresModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.CondutoresModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class CodutoresDominioTests
    {
        [TestMethod]
        public void Deve_Validar_Condutor()
        {
            var cliente = new Clientes("Joao","Rua dos joao","9522185224","5222522","20202020222","");

            Condutor condutor = new Condutor("Joao", "Rua dos joao", "9522185224", "5222522", "20202020222", "522542",
                new DateTime(2022,05,26), cliente);

            var validar = condutor.Validar();

            validar.Should().Be("ESTA_VALIDO");
        }
    }
}
