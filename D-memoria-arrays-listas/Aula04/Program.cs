using System;
using System.Globalization;

namespace D_memoria_arrays_listas.Aula04
{
    public class Program
    {
        static void ExecutarAula()
        {
            Console.Write("Quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];
            double soma = 0.0;
            
            for (int  i = 0;  i < n;  i++)
            {
                Console.WriteLine($"Posição {i}: ");
                Produto p = new Produto();
                
                Console.Write($"Nome: ");
                p.Nome = Console.ReadLine();
                
                Console.Write($"Preço: ");
                p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = p;
                soma += produtos[i].Preco;
            }

            double media = soma / n;
            
            Console.WriteLine();
            Console.WriteLine("Soma total: " + soma);
            Console.WriteLine("Media final: " + media);    
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}