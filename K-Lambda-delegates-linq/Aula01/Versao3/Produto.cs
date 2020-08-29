using System.Globalization;

namespace K_Lambda_delegates_linq.Aula01.Versao3
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}