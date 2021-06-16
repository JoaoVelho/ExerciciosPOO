namespace exerc7
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, float salario) : base(nome, idade, salario) {}

        public override float bonificacao() {
            return base.bonificacao() + 10000;
        }
    }
}