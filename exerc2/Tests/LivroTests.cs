using System;
using System.IO;
using exerc2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LivroTests
    {
        private StringWriter _output;

        public LivroTests() 
        {
            _output = new StringWriter();
            Console.SetOut(_output);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleQueNaoHaImpostoParaLivroEducativo()
        {
            Livro livro = new Livro("Livro", 40, 50, "Autor", "educativo", 300);

            livro.calculaImposto();

            Assert.AreEqual(_output.ToString(), "Livro educativo não tem imposto: Livro" + Environment.NewLine);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleOImpostoDe4ReaisParaLivroNaoEducativoComPrecoDe40()
        {
            Livro livro = new Livro("Livro", 40, 50, "Autor", "fantasia", 300);

            livro.calculaImposto();
            var imposto = 4;

            Assert.AreEqual(_output.ToString(), $"R$ {imposto.ToString("N2")} de impostos sobre o livro Livro." + Environment.NewLine);
        }
    }
}
