using System;
using K_Lambda_delegates_linq.Aula01.Versao1;
using K_Lambda_delegates_linq.Aula01.Versao2;
using K_Lambda_delegates_linq.Aula01.Versao3;
using K_Lambda_delegates_linq.Aula08.Parte1;
using K_Lambda_delegates_linq.Aula08.Parte2;

namespace K_Lambda_delegates_linq
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 Versão 1 -----");
            Aula01Versao1.Executar();
            
            Console.WriteLine("\n----- Aula01 Versão 2 -----");
            Aula01Versao2.Executar();
            
            Console.WriteLine("\n----- Aula01 Versão 3 -----");
            Aula01Versao3.Executar();
            
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
            
            Console.WriteLine("\n----- Aula08 Parte 1 -----");
            Aula08Parte1.Executar();
            
            Console.WriteLine("\n----- Aula08 Parte 2 -----");
            Aula08Parte2.Executar();
        }
        
        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nDécima Primeira Parte do Curso de C#!");
        }
    }
}