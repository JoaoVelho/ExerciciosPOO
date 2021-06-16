using exerc7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class VendedorTests
    {
        [TestMethod]
        public void DeveRetornarOSalarioMais3000PelaBonificacao()
        {
            Vendedor vendedor = new Vendedor("Vendedor", 53, 8000);

            Assert.AreEqual(vendedor.bonificacao(), 11000);
        }
    }
}
