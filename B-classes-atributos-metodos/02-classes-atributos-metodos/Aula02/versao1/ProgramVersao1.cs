﻿﻿using System;
using System.Globalization;

namespace Curso.Aula02.versao1
{
    public class ProgramVersao1
    {
        /* VERSÃO 1 -> MÉTODOS NA PRÓPRIA CLASSE 'PROGRAM' */
        static double Pi = 3.14;
        
        /*static void Main(string[] args)
        {
            
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = CalcularCircunferencia(raio);
            double volume = CalcularVolume(raio);
            
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }*/

        static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}