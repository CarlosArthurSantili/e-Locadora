using e_Locadora.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.CupomModule
{
    [TestClass]
    public class CupomDominioTest
    {
        [TestMethod]
        public void Deve_Validar_Cupons()
        {
            Cupons cupons = new Cupons("Deco-5630", 0, 120,(new DateTime(2021,08,27)), "Deko");
            Assert.AreEqual("ESTA_VALIDO", cupons.Validar());        
        }

        [TestMethod]
        public void Nao_Deve_Validar_Nome()
        {
            Cupons cupons = new Cupons("", 0, 120, (new DateTime(2021, 08, 27)), "Deko");
            Assert.AreEqual("O campo nome é obrigatório e não pode ser vazio.", cupons.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Valor_Percentual()
        {
            Cupons cupons = new Cupons("Deco-5630", -1, 0, (new DateTime(2021, 08, 27)), "Deko");
            Assert.AreEqual("Valor Percentual não pode ser menor que Zero.", cupons.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Valor_Fixo()
        {
            Cupons cupons = new Cupons("Deco-5630", 0, -1, (new DateTime(2021, 08, 27)), "Deko");
            Assert.AreEqual("Valor Fixo não pode ser Menor que Zero.", cupons.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Data()
        {
            Cupons cupons = new Cupons("Deco-5630", 0, 20, DateTime.MinValue, "Deko");
            Assert.AreEqual("A data Invalida, Insira uma data valida", cupons.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Parceiro()
        {
            Cupons cupons = new Cupons("Deco-5630", 0, 20, new DateTime(2021, 08, 27), "");
            Assert.AreEqual("O campo Parceiro é obrigatório e não pode ser vazio.", cupons.Validar());
        }
    }
}
