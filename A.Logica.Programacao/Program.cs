using System;
using A.Logica.Programacao.Aula01;
using A.Logica.Programacao.Aula02;
using A.Logica.Programacao.Aula03;
using A.Logica.Programacao.Aula04;
using A.Logica.Programacao.Aula05;
using A.Logica.Programacao.Aula06;
using Math = A.Logica.Programacao.Aula07.Math;
using A.Logica.Programacao.Aula08;

namespace A.Logica.Programacao
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            Variaveis.Executar();

            Console.WriteLine("\n----- Aula02 -----");
            VariaveisEspeciais.Executar();

            Console.WriteLine("\n----- Aula03 -----");
            Curiosidades.Executar();

            Console.WriteLine("\n----- Aula04 -----");
            Globalization.Executar();

            Console.WriteLine("\n----- Aula05 -----");
            Strings.Executar();

            Console.WriteLine("\n----- Aula06 -----");
            Operadores.Executar();

            Console.WriteLine("\n----- Aula07 -----");
            Math.Executar();

            Console.WriteLine("\n----- Aula08 -----");
            Incrementar.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nPrimeira Parte do Curso de C#!");
        }
    }
}