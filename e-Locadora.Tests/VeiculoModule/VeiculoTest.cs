using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace e_Locadora.Tests.VeiculoModule
{
    [TestClass]
    [TestCategory("Dominio")]

    public class VeiculoTest
    {
        [TestMethod]
        public void DeveValidar__()
        {
            string exemplo = "abc";
            exemplo.Should().Be("abc");
            Assert.AreEqual("abc", exemplo);
        }
    }
}
