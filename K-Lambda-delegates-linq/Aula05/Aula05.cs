using System;
using System.Collections.Generic;

namespace K_Lambda_delegates_linq.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            var produtos = new List<Produto>();
            
            produtos.Add(new Produto("Tv", 900.00));
            produtos.Add(new Produto("Mouse", 50.00));
            produtos.Add(new Produto("Tablet", 350.50));
            produtos.Add(new Produto("HD Case", 80.90));

            /* Funciona usando 'lambda' */
            // Action<Produto> action = p => { p.Preco += p.Preco * 0.1; };
            // produtos.ForEach(action);

            /* Funciona usando 'Action' */
            produtos.ForEach(AtualizarProduto);

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        private static void AtualizarProduto(Produto p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }
}