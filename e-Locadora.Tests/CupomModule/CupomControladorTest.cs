using e_Locadora.Controladores;
using e_Locadora.Controladores.CupomModule;
using e_Locadora.Dominio.CupomModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void Deve_Inserir_Novo_cUPOM()
        {

        }
    }
}
