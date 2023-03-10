using System.Globalization;

namespace C.Construtores.Sobrecarga.Encapsulamento.Aula04
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double CalcularValorTotal()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public string ExibirMensagem()
        {
            return $"{Nome}, "
                   + $"$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, "
                   + $"{Quantidade} unidades, "
                   + $"Total: $ {(CalcularValorTotal()).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}