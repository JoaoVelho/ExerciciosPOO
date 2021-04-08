using System;

namespace exerc1
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo(string Marca, string Modelo, string Placa, float Km, double Preco) {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Km = Km;
            this.Preco = Preco;
        }

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

        public void pintar(string cor) {
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