using exerc7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class GerenteTests
    {
        [TestMethod]
        public void DeveRetornarOSalarioMais10000PelaBonificacao()
        {
            Gerente gerente = new Gerente("Gerente", 53, 8000);

            Assert.AreEqual(gerente.bonificacao(), 18000);
        }
    }
}
