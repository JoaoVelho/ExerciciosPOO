using System;
using exerc3;

namespace Tests
{
    public class FakeGuerreiro : Personagem
    {
        public FakeGuerreiro(string nome) : base(nome)
        {
            vida = 5;
            mana = 3;
            inteligencia = 3;
            forca = 5;
        }

        public override void attack() {
            int dano = (forca * level) + 100;
            Console.WriteLine("{0} causou {1} de dano", nome, dano);
        }

        public override void lvlUp()
        {
        }
    }
}