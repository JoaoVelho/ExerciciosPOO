using System;
using System.Collections.Generic;

namespace exerc3
{
    public class Guerreiro : Personagem
    {
        public List<string> habilidade { get; private set; }

        public Guerreiro(string nome) : base(nome) {
            List<string> hab = new List<string>();
            habilidade = hab;
            habilidade.Add("Attack");
            vida = 5;
            mana = 3;
            inteligencia = 3;
            forca = 5;
        }

        public override void lvlUp() {
            vida += 2;
            mana++;
            inteligencia++;
            forca += 2;
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
            int dano = (forca * level) + r.Next(0, 300);
            Console.WriteLine("{0} causou {1} de dano", nome, dano);
        }

        public void aprenderHabilidade(string novaHabilidade) {
            habilidade.Add(novaHabilidade);
            Console.WriteLine(nome + " aprendeu a habilidade: " + novaHabilidade);
        }
    }
}