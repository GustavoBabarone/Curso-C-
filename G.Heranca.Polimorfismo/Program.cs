using System;

namespace G.Heranca.Polimorfismo
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            Console.WriteLine("--- Exemplo de herança com tipos de contas bancárias ---");

            Console.WriteLine("\n----- Aula02 -----");
            Aula02.Aula02.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nSétima Parte do Curso de C#!");
        }
    }
}