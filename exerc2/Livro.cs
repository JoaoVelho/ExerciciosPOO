using System;

namespace exerc2
{
    public class Livro : Produto, IImposto
    {
        public string autor { get; set; }

        public string tema { get; set; }

        public int qtdPag { get; set; }

        public Livro() {}

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd) {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }

        public void calculaImposto() {
            double imposto = 0;
            if (tema == "educativo") {
                Console.WriteLine("Livro educativo não tem imposto: " + nome);
            } else {
                imposto = 0.1 * preco;
                Console.WriteLine("R$ {0} de impostos sobre o livro {1}.", imposto.ToString("N2"), nome);
            }
        }
    }
}