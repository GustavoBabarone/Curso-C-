﻿﻿using System;
using System.Globalization;

namespace A_logica_de_programacao.Aula04
{
    public class Globalization
    {
        public static void Executar()
        {
            double saldo = 10.35784;
            
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}