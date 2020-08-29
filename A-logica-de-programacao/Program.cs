﻿using System;
 using A_logica_de_programacao.Aula01;
 using A_logica_de_programacao.Aula02;
 using A_logica_de_programacao.Aula03;
 using A_logica_de_programacao.Aula04;
 using A_logica_de_programacao.Aula05;
 using A_logica_de_programacao.Aula06;
 using Math = A_logica_de_programacao.Aula07.Math;
 using A_logica_de_programacao.Aula08;

 namespace A_logica_de_programacao
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