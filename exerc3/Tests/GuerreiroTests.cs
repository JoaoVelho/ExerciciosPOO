using exerc3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class GuerreiroTests
    {
        [TestMethod]
        public void DeveSerCriadoOGuerreiroJaCom5EmVidaEForcaE3EmManaEInteligenciaELevel1()
        {
            Guerreiro guerreiro = new Guerreiro("Guerreiro");

            Assert.AreEqual(guerreiro.level, 1);
            Assert.AreEqual(guerreiro.vida, 5);
            Assert.AreEqual(guerreiro.forca, 5);
            Assert.AreEqual(guerreiro.mana, 3);
            Assert.AreEqual(guerreiro.inteligencia, 3);
        }

        [TestMethod]
        public void DeveAumentar2EmVidaEForcaE1EmManaEInteligenciaQuandoUpar()
        {
            Guerreiro guerreiro = new Guerreiro("Guerreiro");
            guerreiro.lvlUp();

            Assert.AreEqual(guerreiro.level, 2);
            Assert.AreEqual(guerreiro.vida, 7);
            Assert.AreEqual(guerreiro.forca, 7);
            Assert.AreEqual(guerreiro.mana, 4);
            Assert.AreEqual(guerreiro.inteligencia, 4);
        }

        [TestMethod]
        public void DeveAdicionarHabilidadeAListaQuandoAprender()
        {
            Guerreiro guerreiro = new Guerreiro("Guerreiro");
            guerreiro.aprenderHabilidade("Chute");

            Assert.AreEqual(guerreiro.habilidade.Contains("Chute"), true);
        }
    }
}
