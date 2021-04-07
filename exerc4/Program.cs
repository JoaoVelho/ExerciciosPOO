using System;
using System.Collections.Generic;

namespace exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>() {
                new Pessoa("João", 15),
                new Pessoa("Leandro", 21),
                new Pessoa("Paulo", 17),
                new Pessoa("Jessica", 18)
            };

            Pessoa maisVelho = new Pessoa("velho", 0);
            
            pessoas.ForEach(pessoa => {
                if (pessoa.idade > maisVelho.idade) {
                    maisVelho = pessoa;
                }
            });

            Console.WriteLine("EXERCÍCIO 4:");
            Console.WriteLine(maisVelho.nome + " é o mais velho");
            Console.WriteLine();

            // EXERCÍCIO 5
            Console.WriteLine("EXERCÍCIO 5:");
            Console.WriteLine(pessoas.Count + " pessoas na lista");
            Console.WriteLine();

            List<Pessoa> menores = pessoas.FindAll(pessoa => pessoa.idade < 18);
            menores.ForEach(menor => pessoas.Remove(menor));

            pessoas.ForEach(pessoa => Console.WriteLine(pessoa.nome));
            Console.WriteLine(pessoas.Count + " pessoas maiores de idade na lista");
            Console.WriteLine();

            // EXERCÍCIO 6
            Pessoa jessica = pessoas.Find(pessoa => pessoa.nome == "Jessica");
            Console.WriteLine("EXERCÍCIO 6:");
            if (jessica is null) {
                Console.WriteLine("Jessica não existe na lista");
            } else {
                Console.WriteLine("Jessica tem {0} anos", jessica.idade);
            }
        }
    }
}
