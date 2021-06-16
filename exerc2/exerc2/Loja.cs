using System;
using System.Collections.Generic;

namespace exerc2
{
    public class Loja
    {
        public string nome { get; set; }

        public string cnpj { get; set; }

        public List<Livro> livros { get; set; }

        public List<VideoGame> videoGames { get; set; }

        public Loja() {}

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames) {
            this.nome = nome;
            this.cnpj = cnpj;
            this.livros = livros;
            this.videoGames = videoGames;
        }

        public void listaLivros() {
            if (livros.Count == 0) {
                Console.WriteLine("A loja não tem livros no seu estoque.");
                return;
            }
            Console.WriteLine("A loja {0} possui estes livros para venda:", nome);
            foreach (Livro livro in livros) {
                Console.WriteLine("Título: {0} , preço: {1} , quantidade: {2} em estoque.", livro.nome, livro.preco.ToString("N2"), livro.qtd);
            }
        }

        public void listaVideoGames() {
            if (videoGames.Count == 0) {
                Console.WriteLine("A loja não tem video-games no seu estoque.");
                return;
            }
            Console.WriteLine("A loja {0} possui estes video-games para venda:", nome);
            foreach (VideoGame videoGame in videoGames) {
                Console.WriteLine("Video-game: {0} , preço: {1} , quantidade: {2} em estoque.", videoGame.modelo, videoGame.preco.ToString("N2"), videoGame.qtd);
            }
        }

        public void calculaPatrimonio() {
            double total = 0;
            foreach (Livro livro in livros) {
                total += livro.preco * livro.qtd;
            }
            foreach (VideoGame videoGame in videoGames) {
                total += videoGame.preco * videoGame.qtd;
            }
            Console.WriteLine("O patrimônio da loja: {0} é de R$ {1}", nome, total.ToString("N2"));
        }
    }
}