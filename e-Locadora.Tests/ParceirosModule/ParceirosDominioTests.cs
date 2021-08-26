using e_Locadora.Dominio.ParceirosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.ParceirosModule
{
    [TestClass]
    [TestCategory("Dominio")]
    public class ParceirosDominioTests
    {
        [TestMethod]
        public void DeveValidaParceiro()
        {
            string parceiro = "Desconto do Deko";

            Parceiro novoparceiro = new Parceiro(parceiro);

            Assert.AreEqual("ESTA_VALIDO", novoparceiro.Validar());
        }
        [TestMethod]
        public void DeveValidaParceiroNome()
        {
            string parceiro = "";

            Parceiro novoparceiro = new Parceiro(parceiro);

            Assert.AreEqual("O Nome do Parceiro é obrigatório .", novoparceiro.Validar());
        }
    }
}
