using System;
using System.Collections.Generic;

namespace J_Generics_set_dictionary.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            SortedSet<int> colecao1 = new SortedSet<int> { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> colacao2 = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };
            
            // União de conjuntos
            SortedSet<int> uniao = new SortedSet<int>(colecao1);
            uniao.UnionWith(colacao2);
            PrintColecao(uniao);

            Console.WriteLine();
            
            // Intersecção de conjuntos
            SortedSet<int> interseccao = new SortedSet<int>(colecao1);
            interseccao.IntersectWith(colacao2);
            PrintColecao(interseccao);
            
            Console.WriteLine();
            
            // Diferença de conjuntos
            SortedSet<int> diferenca = new SortedSet<int>(colecao1);
            diferenca.ExceptWith(colacao2);
            PrintColecao(diferenca);
        }

        static void PrintColecao<T>(IEnumerable<T> colecao)
        {
            foreach (var obj in colecao)
            {
                Console.Write($"{obj} - ");
            }
        }
    }
}