using e_Locadora.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.GrupoVeiculos
{
    [TestClass]
    public class GrupoVeiculosDominioTest
    {
        [TestMethod]
        public void NaoDeveValidarCategoria()
        {
            string categoria = "";
            double planoDiarioValorKm = 1000;
            double planoDiarioValorDiario = 2000;
            double planoKmControladoValorKm = 3000;
            double planoKmControladoValorDiario = 5000;
            double planoKmLivreValorDiario = 6000;

            GrupoVeiculo grupoVeiculo = new GrupoVeiculo(categoria, planoDiarioValorKm, planoDiarioValorDiario, planoKmControladoValorKm, planoKmControladoValorDiario, planoKmLivreValorDiario);
            Assert.AreEqual("O atributo categoria é obrigatório e não pode ser vazio.", grupoVeiculo.Validar());
        }
    }
}
