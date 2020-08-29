﻿﻿using System;
using System.Globalization;

namespace B_classes_atributos_metodos.Aula02.versao1
{
    public class Aula02Versao1
    {
        /* VERSÃO 1 -> Métodos na própria classe */
        static double Pi = 3.14;
        
        static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }

        public static void Executar()
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = CalcularCircunferencia(raio);
            double volume = CalcularVolume(raio);
            
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}