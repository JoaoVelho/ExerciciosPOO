using System;

namespace exerc2
{
    public class VideoGame : Produto, IImposto
    {
        public string marca { get; set; }

        public string modelo { get; set; }

        public bool isUsado { get; set; }

        public VideoGame() {}

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd) {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public void calculaImposto() {
            double imposto;
            string usado = "";
            if (isUsado) {
                imposto = 0.25 * preco;
                usado = " usado";
            } else {
                imposto = 0.45 * preco;
            }
            Console.WriteLine("Imposto {0} {1}{2}, R$ {3}", nome, modelo, usado, imposto.ToString("N2"));
        }
    }
}