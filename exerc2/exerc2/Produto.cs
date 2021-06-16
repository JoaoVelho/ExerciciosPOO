namespace exerc2
{
    public abstract class Produto
    {
        public string nome { get; set; }

        public double preco { get; set; }

        public int qtd { get; set; }

        public Produto() {}
        
        public Produto(string nome, double preco, int qtd) {
            this.nome = nome;
            this.preco = preco;
            this.qtd = qtd;
        }
    }
}