using System;
using System.Collections.Generic;
using System.IO;
using exerc2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class LojaTests
    {
        private StringWriter _output;
        private List<Livro> _livros;
        private List<VideoGame> _games;

        public LojaTests() 
        {
            _output = new StringWriter();
            Console.SetOut(_output);
            _livros = new List<Livro>();
            _games = new List<VideoGame>();
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeNaoHouverLivrosNaLoja()
        {
            Loja loja = new Loja("Loja", "12345678", _livros, _games);

            loja.listaLivros();
            Assert.AreEqual(_output.ToString(), "A loja não tem livros no seu estoque." + Environment.NewLine);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleOsLivrosDaLoja()
        {
            Livro livro = new Livro("Livro", 40, 50, "Autor", "educativo", 300);
            _livros.Add(livro);

            Loja loja = new Loja("Loja", "12345678", _livros, _games);

            loja.listaLivros();
            Assert.AreEqual(
                _output.ToString(), 
                "A loja Loja possui estes livros para venda:" +
                Environment.NewLine +
                $"Título: Livro , preço: {40.ToString("N2")} , quantidade: 50 em estoque." + 
                Environment.NewLine
            );
        }

        [TestMethod]
        public void DeveEscreverNoConsoleSeNaoHouverVideoGamesNaLoja()
        {
            Loja loja = new Loja("Loja", "12345678", _livros, _games);

            loja.listaVideoGames();
            Assert.AreEqual(_output.ToString(), "A loja não tem video-games no seu estoque." + Environment.NewLine);
        }

        [TestMethod]
        public void DeveEscreverNoConsoleOsVideoGamesDaLoja()
        {
            VideoGame game = new VideoGame("Game", 1800, 100, "Sony", "Slim", false);
            _games.Add(game);

            Loja loja = new Loja("Loja", "12345678", _livros, _games);

            loja.listaVideoGames();
            Assert.AreEqual(
                _output.ToString(), 
                "A loja Loja possui estes video-games para venda:" +
                Environment.NewLine +
                $"Video-game: Slim , preço: {1800.ToString("N2")} , quantidade: 100 em estoque." + 
                Environment.NewLine
            );
        }

        [TestMethod]
        public void DeveEscreverNoConsoleOPatrimonioTotalDaLojaDe182000()
        {
            Livro livro = new Livro("Livro", 40, 50, "Autor", "educativo", 300);
            _livros.Add(livro);

            VideoGame game = new VideoGame("Game", 1800, 100, "Sony", "Slim", false);
            _games.Add(game);

            Loja loja = new Loja("Loja", "12345678", _livros, _games);

            loja.calculaPatrimonio();
            Assert.AreEqual(_output.ToString(), $"O patrimônio da loja: Loja é de R$ {182000.ToString("N2")}" + Environment.NewLine);
        }
    }
}