using System;
using System.IO;
using exerc3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MagoTests
    {
        [TestMethod]
        public void DeveSerCriadoOMagoJaCom3EmVidaEForcaE5EmManaEInteligenciaELevel1()
        {
            Mago mago = new Mago("Mago");

            Assert.AreEqual(mago.level, 1);
            Assert.AreEqual(mago.vida, 3);
            Assert.AreEqual(mago.forca, 3);
            Assert.AreEqual(mago.mana, 5);
            Assert.AreEqual(mago.inteligencia, 5);
        }

        [TestMethod]
        public void DeveAumentar1EmVidaEForcaE2EmManaEInteligenciaQuandoUpar()
        {
            Mago mago = new Mago("Mago");
            mago.lvlUp();

            Assert.AreEqual(mago.level, 2);
            Assert.AreEqual(mago.vida, 4);
            Assert.AreEqual(mago.forca, 4);
            Assert.AreEqual(mago.mana, 7);
            Assert.AreEqual(mago.inteligencia, 7);
        }

        [TestMethod]
        public void DeveAdicionarMagiaAListaQuandoAprender()
        {
            Mago mago = new Mago("Mago");
            mago.aprenderMagia("Fogo");

            Assert.AreEqual(mago.magia.Contains("Fogo"), true);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleDanoDe105AoAtacar()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            FakeMago mago = new FakeMago("Mago");
            mago.attack();

            Assert.AreEqual(output.ToString(), "Mago causou 105 de dano" + Environment.NewLine);
        }
    }
}