using System;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Toyota", "Corolla", "ABCDEFG", 125.5f, 210000);

            Console.WriteLine("Marca: " + veiculo.Marca);
            Console.WriteLine("Modelo: " + veiculo.Modelo);
            Console.WriteLine("Placa: " + veiculo.Placa);
            Console.WriteLine("Km: " + veiculo.Km);
            Console.WriteLine("Preço: " + veiculo.Preco);
            Console.WriteLine();

            bool loop = true;
            while (loop) {
                Console.WriteLine("1 - Ligar; 2 - Desligar; 3 - Acelerar; 4 - Frear; 5 - Abastecer; 6 - Pintar; 0 - Terminar");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 0:
                        loop = false;
                        break;
                    case 1:
                        veiculo.ligar();
                        Console.WriteLine("Ligado: " + veiculo.isLigado);
                        break;
                    case 2:
                        veiculo.desligar();
                        Console.WriteLine("Ligado: " + veiculo.isLigado);
                        break;
                    case 3:
                        veiculo.acelerar();
                        Console.WriteLine("Velocidade: " + veiculo.Velocidade);
                        break;
                    case 4:
                        veiculo.frear();
                        Console.WriteLine("Velocidade: " + veiculo.Velocidade);
                        break;
                    case 5:
                        Console.WriteLine("Insira quantos litros você quer abastecer: ");
                        int litros = int.Parse(Console.ReadLine());
                        veiculo.abastecer(litros);
                        Console.WriteLine("Litros: " + veiculo.litrosCombustivel);
                        break;
                    case 6:
                        Console.WriteLine("Insira a cor que você quer pintar: ");
                        string cor = Console.ReadLine();
                        veiculo.pintar(cor);
                        Console.WriteLine("Cor: " + veiculo.Cor);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }
            }
        }
    }
}
