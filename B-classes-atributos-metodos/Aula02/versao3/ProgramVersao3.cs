﻿﻿using System;
using System.Globalization;

namespace B_classes_atributos_metodos.Aula02.versao3
{
    public class ProgramVersao3
    {
        /* VERSÃO 3 ->  Atributos e métodos static */
        static void ExecutarAula()
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = CalculadoraVersao3.CalcularCircunferencia(raio);
            double volume = CalculadoraVersao3.CalcularVolume(raio);
            
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + CalculadoraVersao3.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}