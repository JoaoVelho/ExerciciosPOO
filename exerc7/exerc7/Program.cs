using System;

namespace exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Jorge", 53, 8000);
            Supervisor supervisor = new Supervisor("Matheus", 40, 6000);
            Vendedor vendedor = new Vendedor("Lucas", 29, 3000);

            Console.WriteLine("Gerente: {0}, {1} anos, bonificação: {2}", gerente.nome, gerente.idade, gerente.bonificacao().ToString("C"));
            Console.WriteLine("Supervisor: {0}, {1} anos, bonificação: {2}", supervisor.nome, supervisor.idade, supervisor.bonificacao().ToString("C"));
            Console.WriteLine("Vendedor: {0}, {1} anos, bonificação: {2}", vendedor.nome, vendedor.idade, vendedor.bonificacao().ToString("C"));
        }
    }
}
