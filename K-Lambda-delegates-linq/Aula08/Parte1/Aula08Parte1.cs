using System;
using System.Collections.Generic;
using System.Linq;
using K_Lambda_delegates_linq.Aula08.Common;

namespace K_Lambda_delegates_linq.Aula08.Parte1
{
    public class Aula08Parte1
    {
        public static void Executar()
        {
            var produtos = Utils.CriarListaProdutos();

            var resultado1 = produtos
                .Where(p => p.Categoria.Classificacao == 1 && p.Preco > 900.0);
            
            Utils.ImprimirColecao("--- Todos com classificação 1 e preço > 900 ---", resultado1);
            
            var resultado2 = produtos
                .Where(p => p.Categoria.Nome == "Ferramentas")
                .Select(p => p.Nome);
            
            Utils.ImprimirColecao("--- Nomes dos produtos da categoria 'Ferramentas' ---", resultado2);
            
            var resultado3 = produtos
                .Where(p => p.Nome[0] == 'C')
                .Select(p => new
                {
                    NomeProduto = p.Nome,
                    p.Preco,
                    NomeCategoria = p.Categoria.Nome
                }); // Objeto anônimo
            
            Utils.ImprimirColecao("--- Produtos que começam com a letra 'C' ---", resultado3);
            
            var resultado4 = produtos
                .Where(p => p.Categoria.Classificacao == 1)
                .OrderBy(p => p.Preco) // Ordenação por preço
                .ThenBy(p => p.Nome); // Ordenação por nome depois de ordenar por preço
            
            Utils.ImprimirColecao("--- Classificação 1 ordenado por preço e depois por nome ---", resultado4);

            var resultado5 = resultado4
                .Skip(2) // Não obter os dois primeiros
                .Take(4); // Obter somente 4
            
            Utils.ImprimirColecao("--- Classificação 1 ordenado por preço e depois por nome com Skip 2 e Take 4 ---", resultado5);

            Console.WriteLine();
            
            var resultado6 = produtos.First();
            Console.WriteLine($"First: {resultado6}");
            
            /* Exception -> não há produtos com preço maior que 3000.0 */
            // var resultado7 = produtos.First(p => p.Preco > 3000.0);
            // Console.WriteLine($"First: {resultado7}");

            var resultado8 = produtos.FirstOrDefault(p => p.Preco > 3000.0);
            Console.WriteLine($"FirstOrDefault: {resultado8} (sem resultado para a pesquisa)");
            
            var resultado9 = produtos.SingleOrDefault(p => p.Id == 3);
            Console.WriteLine($"SingleOrDefault: {resultado9}");
            
            var resultado10 = produtos.SingleOrDefault(p => p.Id == 99);
            Console.WriteLine($"SingleOrDefault: {resultado10} (sem resultado para a pesquisa)");
        }
    }
}