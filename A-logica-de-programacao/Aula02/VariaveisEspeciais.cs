﻿﻿﻿using System;

namespace A_logica_de_programacao.Aula02
{
    public class VariaveisEspeciais
    {
        public static void Executar()
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
    }
}