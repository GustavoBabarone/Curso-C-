using System;
using System.Linq;

namespace K.Lambda.Delegates.Linq.Aula07
{
    public class Aula07
    {
        public static void Executar()
        {
            // Especificando os dados de entrada
            int[] numeros = { 2, 3, 4, 5 };

            // Definindo a expressão da consulta
            var resultado = numeros
                .Where(n => n % 2 == 0)
                .Select(n => n * 10);

            foreach (var n in resultado)
            {
                Console.WriteLine(n);
            }
        }
    }
}