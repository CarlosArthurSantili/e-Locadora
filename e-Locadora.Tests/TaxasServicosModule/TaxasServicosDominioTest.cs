using e_Locadora.Dominio.TaxasServicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.TaxasServicosModule
{
    [TestClass]
    public class TaxasServicosDominioTest
    {
        [TestMethod]
        public void Deve_Validar_Taxas_E_Servicos()
        {
            TaxasServicos taxasServicos = new TaxasServicos("Taxa de Lavação", 1000);
            Assert.AreEqual("ESTA_VALIDO", taxasServicos.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Descricao()
        {
            TaxasServicos taxasServicos = new TaxasServicos("", 1000);
            Assert.AreEqual("O campo descrição é obrigatório e não pode ser vazio.", taxasServicos.Validar());
        }

        [TestMethod]
        public void Nao_Deve_Validar_Valor()
        {
            TaxasServicos taxasServicos = new TaxasServicos("Taxa de Lavação", 0);
            Assert.AreEqual("O campo Valor nao pode Ser Nullo", taxasServicos.Validar());
        }

    }
}
