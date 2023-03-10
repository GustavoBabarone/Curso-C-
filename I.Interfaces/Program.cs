using System;

namespace I.Interfaces
{
    class Program
    {
        // TODO - Traduzir aulas para o portugues
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            Aula01.Aula01.Executar();

            Console.WriteLine("\n----- Aula02 -----");
            Aula02.Aula02.Executar();

            Console.WriteLine("\n----- Aula03 -----");
            Aula03.Aula03.Executar();

            Console.WriteLine("\n----- Aula04 -----");
            Aula04.Aula04.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nNona Parte do Curso de C#!");
        }
    }
}