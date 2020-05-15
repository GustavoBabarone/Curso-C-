﻿﻿using System;
using System.Globalization;

namespace Curso.Exercicio01
{
    public class Exercicio01
    {
        public void MetodoExercicio01()
        {
            
            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            p.Nome = Console.ReadLine();
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p.ExibirMensagem());
            
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(adicionar);

            Console.WriteLine("Dados atualizados: " + p.ExibirMensagem());
            
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());

            p.RemoverProdutos(remover);

            Console.WriteLine("Dados atualizados: " + p.ExibirMensagem());
        }
    }
}