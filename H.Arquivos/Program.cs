using System;

namespace H.Arquivos
{
    class Program
    {
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

            Console.WriteLine("\n----- Aula05 -----");
            Aula05.Aula05.Executar();

            Console.WriteLine("\n----- Aula06 -----");
            Aula06.Aula06.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nOitava Parte do Curso de C#!");
        }
    }
}