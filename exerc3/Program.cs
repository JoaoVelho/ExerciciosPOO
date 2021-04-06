using System;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new Mago("Gandalf");
            Guerreiro guer1 = new Guerreiro("Kratos");

            mago1.lvlUp();
            Console.WriteLine();
            guer1.lvlUp();
            Console.WriteLine();

            mago1.attack();
            guer1.attack();
            Console.WriteLine();

            mago1.aprenderMagia("SuperNova");
            guer1.aprenderHabilidade("Heavy Attack");
            Console.WriteLine();

            mago1.lvlUp();
            Console.WriteLine();

            Mago mago2 = new Mago("abc");
            Mago mago3 = new Mago("def");
            Guerreiro guer2 = new Guerreiro("ghi");
            Guerreiro guer3 = new Guerreiro("jkl");

            Console.WriteLine("Total de personagens criados: " + Personagem.totalPersonagens);
        }
    }
}
