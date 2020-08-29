using System;

namespace K_Lambda_delegates_linq.Aula03
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