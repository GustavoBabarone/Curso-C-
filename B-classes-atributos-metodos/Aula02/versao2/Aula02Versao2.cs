﻿﻿using System;
using System.Globalization;

namespace B_classes_atributos_metodos.Aula02.versao2
{
    public class Aula02Versao2
    {
        /* VERSÃO 2 ->  Métodos em uma classe separada */
        public static void Executar()
        {
            Calculadora calc = new Calculadora();
            
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circunferencia = calc.CalcularCircunferencia(raio);
            double volume = calc.CalcularVolume(raio);
            
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}