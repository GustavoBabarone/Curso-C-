using System;
using System.Linq;
using K_Lambda_delegates_linq.Aula08.Common;

namespace K_Lambda_delegates_linq.Aula08.Parte2
{
    public class Aula08Parte2
    {
        public static void Executar()
        {
            var produtos = Utils.CriarListaProdutos();

            var resultado1 = produtos.Max(p => p.Preco);
            Console.WriteLine($"Maior preço: {resultado1}");
            
            var resultado2 = produtos.Min(p => p.Preco);
            Console.WriteLine($"Menor preço: {resultado2}");

            var resultado3 = produtos
                .Where(p => p.Categoria.Id == 1)
                .Sum(p => p.Preco);
            Console.WriteLine($"Soma dos preços da categoria 1: {resultado3}");
            
            var resultado4 = produtos
                .Where(p => p.Categoria.Id == 1)
                .Average(p => p.Preco);
            Console.WriteLine($"Média dos preços da categoria 1: {resultado4}");
            
            /* Caso ocorra um cenário em que não há categoria -> o programa tentará dividir por 0, ocasionando uma exception */
            /* Para que não ocorre uma exception -> DefaultIfEmpty() */
            var resultado5 = produtos
                .Where(p => p.Categoria.Id == 99)
                .Select(p => p.Preco)
                .DefaultIfEmpty(0.0)
                .Average();
            Console.WriteLine($"Média dos preços da categoria 99: {resultado5}");
            
            var resultado6 = produtos
                .Where(p => p.Categoria.Id == 1)
                .Select(p => p.Preco)
                .Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Soma dos preços da categoria 1 usando Aggregate(): {resultado6}");

            var resultado7 = produtos.GroupBy(p => p.Categoria);
            Console.WriteLine("\n---Agrupando por categoria usando GroupBy()---");
            foreach (IGrouping<Categoria, Produto> grupo in resultado7)
            {
                Console.WriteLine($"Categoria '{grupo.Key.Nome}':");
                foreach (var produto in grupo)
                {
                    Console.WriteLine($"{produto.Id}, {produto.Nome}, {produto.Preco}, {produto.Categoria.Nome}");
                }
                Console.WriteLine();
            }
        }
    }
}