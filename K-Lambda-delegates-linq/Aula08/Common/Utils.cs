using System;
using System.Collections.Generic;

namespace K_Lambda_delegates_linq.Aula08.Common
{
    public class Utils
    {
        public static List<Produto> CriarListaProdutos()
        {
            var c1 = new Categoria { Id = 1, Nome = "Ferramentas", Classificacao = 2 };
            var c2 = new Categoria { Id = 2, Nome = "Computadores", Classificacao = 1 };
            var c3 = new Categoria { Id = 3, Nome = "Eletronicos", Classificacao = 1 };

            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Computador", Preco = 1100.0, Categoria = c2},
                new Produto { Id = 2, Nome = "Martelo", Preco = 90.0, Categoria = c1},
                new Produto { Id = 3, Nome = "TV", Preco = 1700.0, Categoria = c3},
                new Produto { Id = 4, Nome = "Notebook", Preco = 1300.0, Categoria = c2},
                new Produto { Id = 5, Nome = "Serra", Preco = 80.0, Categoria = c1},
                new Produto { Id = 6, Nome = "Tablet", Preco = 700.0, Categoria = c2},
                new Produto { Id = 7, Nome = "Camera", Preco = 700.0, Categoria = c3},
                new Produto { Id = 8, Nome = "Impressora", Preco = 350.0, Categoria = c3},
                new Produto { Id = 9, Nome = "MacBook", Preco = 1800.0, Categoria = c2},
                new Produto { Id = 10, Nome = "Caixa de som", Preco = 700.0, Categoria = c3},
                new Produto { Id = 11, Nome = "Nivelador", Preco = 70.0, Categoria = c1},
            };

            return produtos;
        }
        
        public static void ImprimirColecao<T>(string mensagem, IEnumerable<T> colecao)
        {
            Console.WriteLine($"\n{mensagem}");
            foreach (var elemento in colecao)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}