using System;
using System.Collections.Generic;

namespace J.Generics.Set.Dictionary.Aula06
{
    public class Aula06
    {
        public static void Executar()
        {
            HashSet<Produto> produtos = new HashSet<Produto>();
            produtos.Add(new Produto("TV", 600.00));
            produtos.Add(new Produto("Notebook", 1350.00));

            HashSet<Ponto> pontos = new HashSet<Ponto>();
            pontos.Add(new Ponto(3, 4));
            pontos.Add(new Ponto(5, 10));

            // Sem impl do método GetHashCode e Equals -> Resultado == False POIS Endereço de memória diferente
            // Com impl do método GetHashCode e Equals -> Resultado == True POIS Conteúdo dos obj são iguais
            Produto produto = new Produto("Notebook", 1350.00);
            Console.WriteLine(produtos.Contains(produto));

            // Sem impl do método GetHashCode e Equals -> Resultado == True POIS Tipo struct
            Ponto ponto = new Ponto(5, 10);
            Console.WriteLine(pontos.Contains(ponto));
        }
    }
}