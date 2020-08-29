﻿﻿using System;
using System.Globalization;

namespace B_classes_atributos_metodos.Aula02.versao3
{
    public class Aula02Versao3
    {
        /* VERSÃO 3 ->  Atributos e métodos static */
        public static void Executar()
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = Calculadora.CalcularCircunferencia(raio);
            double volume = Calculadora.CalcularVolume(raio);
            
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}