using System;
using System.Collections.Generic;

namespace D_memoria_arrays_listas.Aula10
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            /* CONJUNTOS */
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);
            
            B.Add(3);
            B.Add(4);
            B.Add(5);

            B.Add(4); /* <- Não adiciona, pois conjunto não aceita repeticao */

            foreach (var a in A)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine();
            Console.Write("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            if (B.Contains(valor))
            {
                Console.WriteLine($"O valor {valor} pertence ao conjunto 'B'!");
            }
            else
            {
                Console.WriteLine($"O valor {valor} não pertence ao conjunto 'B'!");
            }

            Console.WriteLine();
            Console.WriteLine("Removendo '4' do conjunto 'B'");
            B.Remove(4);
            
            Console.WriteLine();
            Console.WriteLine("Excluido do conjunto 'A' os valor do conjunto 'B':");
            A.ExceptWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine();
            Console.WriteLine("Unindo os valores de 'B' ao conjunto 'A':");
            A.UnionWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
            
            Console.WriteLine();
            Console.WriteLine("Intersecção entre 'B' e 'A':");
            A.IntersectWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
        }
    }
}