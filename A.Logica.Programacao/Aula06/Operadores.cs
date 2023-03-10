using System;

namespace A.Logica.Programacao.Aula06
{
    public class Operadores
    {
        public static void Executar()
        {
            int numero1 = 10;
            int numero2 = 2;
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            Console.WriteLine($"{numero1} % {numero2} = {numero1 % numero2}");

            double resultado = (double)10 / 8;
            Console.WriteLine(resultado);
        }
    }
}