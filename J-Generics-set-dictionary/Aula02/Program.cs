using System;
using System.Collections.Generic;
using System.Globalization;

namespace J_Generics_set_dictionary.Aula02
{
    public class Program
    {
        static void Teste()
        {
            var lista = new List<Produto>();

            Console.Write("Insira o número de itens: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}# Item: ");
                var vetor = Console.ReadLine().Split(',');
                lista.Add(new Produto(vetor[0], int.Parse(vetor[1], CultureInfo.InvariantCulture)));
            }
            
            CalculadoraService calc = new CalculadoraService();;
            Console.WriteLine($"Maior produto = {calc.CalcularMaiorValor(lista)}");
        }
        
        /*static void Main(string[] args)
        {
            Teste();
        }*/
    }
}