using System;

namespace J_Generics_set_dictionary.Aula01
{
    public class Program
    {
        static void Teste()
        {
            PrintService<string> printService = new PrintService<string>();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
        
        /*static void Main(string[] args)
        {
            Teste();
        }*/
    }
}