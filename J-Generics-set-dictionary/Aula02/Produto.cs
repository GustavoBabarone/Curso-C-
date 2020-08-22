using System;
using System.Globalization;

namespace J_Generics_set_dictionary.Aula02
{
    public class Produto : IComparable
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
            return $"Nome: {Nome} e Preço: {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Argumento inserido inválido!");
            }

            var outroProduto = obj as Produto;
            return Preco.CompareTo(outroProduto.Preco);
        }
    }
}