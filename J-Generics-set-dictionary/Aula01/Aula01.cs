using System;

namespace J_Generics_set_dictionary.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            PrintService<string> printService = new PrintService<string>();
            
            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("Primeiro: " + printService.First());
        }
    }
}