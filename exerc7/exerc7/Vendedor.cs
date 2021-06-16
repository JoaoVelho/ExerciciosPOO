namespace exerc7
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, float salario) : base(nome, idade, salario) {}

        public override float bonificacao() {
            return base.bonificacao() + 3000;
        }
    }
}