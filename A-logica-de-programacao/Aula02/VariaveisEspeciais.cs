﻿﻿using System;

namespace A_logica_de_programacao.Aula02
{
    public class VariaveisEspeciais
    {
        static void ExecutarAula()
        {
            char letra = '\u0041';
            string nome = "Gustavo";
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;
            
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);    
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}