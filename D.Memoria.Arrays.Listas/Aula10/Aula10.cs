using System;
using System.Collections.Generic;

namespace D.Memoria.Arrays.Listas.Aula10
{
    public class Aula10
    {
        private static void ListarConjunto<T>(HashSet<T> lista)
        {
            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }

        public static void Executar()
        {
            /* CONJUNTOS */
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();

            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(9);

            b.Add(3);
            b.Add(4);
            b.Add(5);

            b.Add(4); /* <- Não adiciona, pois conjunto não aceita repeticao */

            ListarConjunto(a);

            Console.Write("\nDigite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            if (b.Contains(valor))
            {
                Console.WriteLine($"O valor {valor} pertence ao conjunto 'B'!");
            }
            else
            {
                Console.WriteLine($"O valor {valor} não pertence ao conjunto 'B'!");
            }

            Console.WriteLine("\nRemovendo '4' do conjunto 'B'");
            b.Remove(4);

            Console.WriteLine("\nExcluido do conjunto 'A' os valor do conjunto 'B':");
            a.ExceptWith(b);

            ListarConjunto(a);

            Console.WriteLine("\nUnindo os valores de 'B' ao conjunto 'A':");
            a.UnionWith(b);

            ListarConjunto(a);

            Console.WriteLine("\nIntersecção entre 'B' e 'A':");
            a.IntersectWith(b);

            ListarConjunto(a);
        }
    }
}