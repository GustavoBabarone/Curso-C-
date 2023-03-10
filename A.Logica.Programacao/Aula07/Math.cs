using System;

namespace A.Logica.Programacao.Aula07
{
    public class Math
    {
        public static void Executar()
        {
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = System.Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Delta = " + delta);
            Console.WriteLine("X1 = " + x1);
        }
    }
}