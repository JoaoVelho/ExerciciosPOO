using System;
using System.Collections.Generic;

namespace exerc3
{
    public class Mago : Personagem
    {

        public List<string> magia { get; private set; }

        public Mago(string nome) : base(nome) {
            magia = new List<string>() { "Attack" };
            vida = 3;
            mana = 5;
            inteligencia = 5;
            forca = 3;
        }

        public override void lvlUp() {
            vida++;
            mana += 2;
            inteligencia += 2;
            forca++;
            level++;
            Console.WriteLine(nome + " upou para o level " + level);
            Console.WriteLine("Seus atributos aumentaram:");
            Console.WriteLine("Vida: " + vida);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Inteligência: " + inteligencia);
            Console.WriteLine("Força: " + forca);
        }

        public override void attack() {
            Random r = new Random();
            int dano = (inteligencia * level) + r.Next(0, 300);
            Console.WriteLine("{0} causou {1} de dano", nome, dano);
        }

        public void aprenderMagia(string novaMagia) {
            magia.Add(novaMagia);
            Console.WriteLine(nome + " aprendeu a magia: " + novaMagia);
        }
    }
}