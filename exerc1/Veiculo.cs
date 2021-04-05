using System;

namespace exerc1
{
    public class Veiculo
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Placa { get; set; }
        public String Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public Double Preco { get; set; }

        public void acelerar() {
            if (!isLigado) {
                Console.WriteLine("O veículo está desligado!");
                return;
            }
            Velocidade += 20;
        }
        public void abastecer(int combustivel) {
            litrosCombustivel += combustivel;
            if (litrosCombustivel >= 60) {
                litrosCombustivel = 60;
                Console.WriteLine("O limite do tanque é 60 litros!");
            }
        }
        public void frear() {
            if (Velocidade == 0) {
                Console.WriteLine("O veículo já está parado!");
            } else if (Velocidade < 20) {
                Velocidade = 0;
            } else {
                Velocidade -= 20;
            }
        }

        public void pintar(String cor) {
            Cor = cor;
        }

        public void ligar() {
            if (!isLigado) {
                isLigado = true;
            } else {
                Console.WriteLine("O veículo já está ligado!");
            }
        }

        public void desligar() {
            if (!isLigado) {
                Console.WriteLine("O veículo já está desligado!");
            } else if (Velocidade != 0) {
                Console.WriteLine("O veículo está em movimento!");
            } else {
                isLigado = false;
            }
        }
    }
}