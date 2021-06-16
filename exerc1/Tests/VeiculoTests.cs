using System;
using System.IO;
using exerc1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class VeiculoTests
    {
        private Veiculo _veiculo;

        public VeiculoTests() 
        {
            _veiculo = new Veiculo("Toyota", "Corolla", "ABCDEFG", 125.5f, 210000);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarLigarComOVeiculoJaLigado()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.ligar();
            _veiculo.ligar();
            Assert.AreEqual(output.ToString(), "O veículo já está ligado!" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveSetarIsLigadoParaTrueQuandoLigarOVeiculoDesligado()
        {
            _veiculo.ligar();
            Assert.AreEqual(_veiculo.isLigado, true);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarAcelerarComOVeiculoDesligado()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.acelerar();
            Assert.AreEqual(output.ToString(), "O veículo está desligado!" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveAumentarAVelocidadeEm20QuandoAcelerarOVeiculoLigado()
        {
            _veiculo.ligar();
            _veiculo.acelerar();
            Assert.AreEqual(_veiculo.Velocidade, 20);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarFrearComOVeiculoParado()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.ligar();
            _veiculo.frear();
            Assert.AreEqual(output.ToString(), "O veículo já está parado!" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveDiminuirAVelocidadeEm20QuandoFrearOVeiculoEmMovimento()
        {
            _veiculo.ligar();
            _veiculo.acelerar();
            _veiculo.frear();
            Assert.AreEqual(_veiculo.Velocidade, 0);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarDesligarComOVeiculoJaDesligado()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.desligar();
            Assert.AreEqual(output.ToString(), "O veículo já está desligado!" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarDesligarComOVeiculoEmMovimento()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.ligar();
            _veiculo.acelerar();
            _veiculo.desligar();
            Assert.AreEqual(output.ToString(), "O veículo está em movimento!" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveSetarIsLigadoParaFalseQuandoDesligarOVeiculoLigado()
        {
            _veiculo.ligar();
            _veiculo.desligar();
            Assert.AreEqual(_veiculo.isLigado, false);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeTentarAbastecerMaisDe60LitrosESetarLitrosCombustivelEm60()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            _veiculo.abastecer(100);
            Assert.AreEqual(output.ToString(), "O limite do tanque é 60 litros!" + Environment.NewLine);
            Assert.AreEqual(_veiculo.litrosCombustivel, 60);
        }

        [TestMethod]
        public void DeveSetarLitrosCombustivelComOValorPassadoQuandoAbastecer()
        {
            _veiculo.abastecer(40);
            Assert.AreEqual(_veiculo.litrosCombustivel, 40);
        }

        [TestMethod]
        public void DeveSetarACorPassadaQuandoPintar()
        {
            _veiculo.pintar("Verde");
            Assert.AreEqual(_veiculo.Cor, "Verde");
        }
    }
}
