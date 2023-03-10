using System;

namespace D.Memoria.Arrays.Listas.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            /* dados tipo VALOR (structs) podem receber NULL se usado '?' */
            double? x = null;
            double? y = 10.0;

            Console.WriteLine("Valor default do double: " + x.GetValueOrDefault());
            Console.WriteLine("valor atribuido do double: " + y.GetValueOrDefault());
            Console.WriteLine();
            Console.WriteLine("Valor default do double: " + x.HasValue);
            Console.WriteLine("valor atribuido do double: " + y.HasValue);

            Console.WriteLine("-------------------------------");

            double? a = null;
            double b = a ?? 50.0;

            Console.WriteLine("Valor de a = " + a);
            Console.WriteLine("Valor de b = " + b);
        }
    }
}