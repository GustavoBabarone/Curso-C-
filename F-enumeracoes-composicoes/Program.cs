using System;

namespace F_enumeracoes_composicoes
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            Aula01.Aula01.Executar();
            
            Console.WriteLine("\n----- Exercicio01 -----");
            Exercicio01.Exercicio01.Executar();
            
            Console.WriteLine("\n----- Exercicio02 -----");
            Exercicio02.Exercicio02.Executar();
            
            Console.WriteLine("\n----- Exercicio03 -----");
            Exercicio03.Exercicio03.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nSexta Parte do Curso de C#!");
        }
    }
}