namespace exerc7
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, float salario) : base(nome, idade, salario) {}

        public override float bonificacao() {
            return base.bonificacao() + 5000;
        }
    }
}