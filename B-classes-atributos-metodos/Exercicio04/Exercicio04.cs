﻿﻿using System;
using System.Globalization;

namespace B_classes_atributos_metodos.Exercicio04
{
    public class Exercicio04
    {
        public static void Executar()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string valor = ConversorDeMoeda.CalcularValorFinal(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"O valor a ser pago em reais será = {valor}");
        }
    }
}