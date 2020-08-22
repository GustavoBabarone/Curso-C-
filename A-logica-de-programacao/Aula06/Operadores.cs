﻿﻿using System;

namespace A_logica_de_programacao.Aula06
{
    public class Operadores
    {
        static void ExecutarAula()
        {
            int numero1 = 10;
            int numero2 = 2;
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");

            double resultado = (double) 10 / 8;
            Console.WriteLine(resultado);
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}