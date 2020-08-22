﻿﻿using System;
using System.Globalization;

namespace A_logica_de_programacao.Aula04
{
    public class Globalization
    {
        static void ExecutarAula()
        {
            double saldo = 10.35784;
            
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}