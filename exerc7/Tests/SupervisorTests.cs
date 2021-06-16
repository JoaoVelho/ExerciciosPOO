using exerc7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SupervisorTests
    {
        [TestMethod]
        public void DeveRetornarOSalarioMais5000PelaBonificacao()
        {
            Supervisor supervisor = new Supervisor("Supervisor", 53, 8000);

            Assert.AreEqual(supervisor.bonificacao(), 13000);
        }
    }
}
