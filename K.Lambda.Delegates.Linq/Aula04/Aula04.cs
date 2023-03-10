using System;
using System.Collections.Generic;

namespace K.Lambda.Delegates.Linq.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
            var produtos = new List<Produto>();

            produtos.Add(new Produto("Tv", 900.00));
            produtos.Add(new Produto("Mouse", 50.00));
            produtos.Add(new Produto("Tablet", 350.50));
            produtos.Add(new Produto("HD Case", 80.90));

            /* Funciona usando 'lambda' */
            // Predicate<Produto> predicate = p => p.Preco >= 100.0;
            // produtos.RemoveAll(predicate);

            /* Funciona usando 'Predicate' */
            produtos.RemoveAll(ValidarProduto);

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        private static bool ValidarProduto(Produto p)
        {
            return p.Preco >= 100.00;
        }
    }
}