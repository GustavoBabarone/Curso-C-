using System;

namespace E.Topicos.Especiais.Parte01
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

            Console.WriteLine("\n----- Aula07 -----");
            Aula07.Aula07.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nQuinta Parte do Curso de C#!");
        }
    }
}