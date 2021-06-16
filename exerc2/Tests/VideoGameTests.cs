using System;
using System.IO;
using exerc2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class VideoGameTests
    {
        private StringWriter _output;

        public VideoGameTests() 
        {
            _output = new StringWriter();
            Console.SetOut(_output);
        }
        
        [TestMethod]
        public void DeveEscreverNoConsoleOImpostoDe250SeForUsado() {
            VideoGame game = new VideoGame("Game", 1000, 100, "Sony", "Slim", true);

            game.calculaImposto();
            Assert.AreEqual(_output.ToString(), $"Imposto Game Slim usado, R$ {250.ToString("N2")}" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleOImpostoDe450SeNaoForUsado() {
            VideoGame game = new VideoGame("Game", 1000, 100, "Sony", "Slim", false);

            game.calculaImposto();
            Assert.AreEqual(_output.ToString(), $"Imposto Game Slim, R$ {450.ToString("N2")}" + Environment.NewLine);
        }
    }
}