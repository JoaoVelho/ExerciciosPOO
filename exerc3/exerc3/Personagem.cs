namespace exerc3
{
    public abstract class Personagem
    {
        public string nome { get; protected set; }
        public int vida { get; protected set; }
        public int mana { get; protected set; }
        public float xp { get; protected set; }
        public int inteligencia { get; protected set; }
        public int forca { get; protected set; }
        public int level { get; protected set; }
        public static int totalPersonagens { get; private set; }

        public Personagem(string nome) {
            this.nome = nome;
            xp = 0;
            level = 1;
            totalPersonagens++;
        }
        
        public abstract void lvlUp();

        public abstract void attack();
    }
}