using System.Globalization;

namespace K_Lambda_delegates_linq.Aula08
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"Id: {Id.ToString().PadRight(3)}| " +
                   $"Nome: {Nome.PadRight(14)}| " +
                   $"Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture).PadRight(8)}| " +
                   $"Categoria: {Categoria.Nome.PadRight(14)}| " +
                   $"Classificacao: {Categoria.Classificacao}";
        }
    }
}