using System;
using System.Globalization;

namespace E.Topicos.Especiais.Parte01.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            /* DateTime -> tipo valor (struct) */
            DateTime d1 = DateTime.Now;
            Console.WriteLine("DateTime 1: " + d1);
            Console.WriteLine("DateTime 1 (Tricks): " + d1.Ticks);

            DateTime d2 = new DateTime(2020, 05, 06);
            Console.WriteLine("DateTime 2: " + d2);

            DateTime d3 = new DateTime(2020, 05, 06, 13, 10, 37);
            Console.WriteLine("DateTime 3: " + d3);

            DateTime d4 = DateTime.Today;
            Console.WriteLine("DateTime 4: " + d4);

            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine("DateTime 5: " + d5);

            DateTime d6 = DateTime.Parse("2020-05-06 13:15:45");
            Console.WriteLine("DateTime 6: " + d6);

            DateTime d7 = DateTime.Parse("06/05/2020 13:15:45");
            Console.WriteLine("DateTime 7: " + d7);

            /* FORMATAÇÃO ESPECIFICA */
            DateTime d8 = DateTime.ParseExact("2020-05-06", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime 8: " + d8);

            DateTime d9 = DateTime.ParseExact("06/05/2020 13:15:45", "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime 9: " + d9);
        }
    }
}