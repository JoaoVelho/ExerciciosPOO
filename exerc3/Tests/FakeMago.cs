using System;
using exerc3;

namespace Tests
{
    public class FakeMago : Personagem
    {
        public FakeMago(string nome) : base(nome)
        {
            vida = 3;
            mana = 5;
            inteligencia = 5;
            forca = 3;
        }

        public override void attack()
        {
            int dano = (inteligencia * level) + 100;
            Console.WriteLine("{0} causou {1} de dano", nome, dano);
        }

        public override void lvlUp()
        {
        }
    }
}