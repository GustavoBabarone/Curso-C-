using System;

namespace K.Lambda.Delegates.Linq.Aula03
{
    public class Calculadora
    {
        public static void MostrarMaiorValor(double x, double y)
        {
            Console.WriteLine(x > y ? x : y);
        }

        public static void MostrarSoma(double x, double y)
        {
            Console.WriteLine(x + y);
        }
    }
}