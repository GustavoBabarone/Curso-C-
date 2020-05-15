﻿﻿using System;
using System.Globalization;

namespace Curso.Exercicio03
{
    public class Exercicio03
    {
        public void MetodoExercicio03()
        {
            Aluno a = new Aluno();
            
            Console.WriteLine("Entre com os dados do aluno:");
            a.Nome = Console.ReadLine();
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Nota final = " + a.CalcularMediaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.CalcularMediaFinal() >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "+ a.CalcularPontosFaltantes().ToString("F2", CultureInfo.InvariantCulture) + "pontos");
            }
        }
    }
}