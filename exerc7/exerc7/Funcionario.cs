namespace exerc7
{
    public class Funcionario
    {

        public string nome { get; private set; }
        public int idade { get; private set; }
        public float salario { get; private set; }

        public Funcionario(string nome, int idade, float salario) {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
        }

        public virtual float bonificacao() {
            return salario;
        }
    }
}