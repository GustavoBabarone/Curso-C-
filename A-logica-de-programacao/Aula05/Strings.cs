﻿﻿using System;

namespace A_logica_de_programacao.Aula05
{
    public class Strings
    {
        public static void Executar()
        {
            string nome = "Gustavo";
            int idade = 17;
            double saldo = 10.35784;

            // Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");    
        }
    }
}