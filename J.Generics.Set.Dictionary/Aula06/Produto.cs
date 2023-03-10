using System;

namespace J.Generics.Set.Dictionary.Aula06
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

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Argumento inválido!");
            }

            Produto outro = obj as Produto;
            return Nome.Equals(outro.Nome) && Preco.Equals(outro.Preco);
        }
    }
}