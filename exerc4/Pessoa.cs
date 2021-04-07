namespace exerc4
{
    public class Pessoa
    {
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }
    }
}