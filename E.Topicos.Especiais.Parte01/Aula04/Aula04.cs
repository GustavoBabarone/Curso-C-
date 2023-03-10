using System;

namespace E.Topicos.Especiais.Parte01.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int s4 = original.IndexOf("bc");
            int s5 = original.LastIndexOf("bc");

            string s6 = original.Substring(3);
            string s7 = original.Substring(3, 5);
            string s8 = original.Replace('a', 'X');

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: -{original}-");
            Console.WriteLine($"ToUpper: -{s1}-");
            Console.WriteLine($"ToLower: -{s2}-");
            Console.WriteLine($"Trim: -{s3}-");

            Console.WriteLine($"IndexOf(bc): -{s4}-");
            Console.WriteLine($"LastIndexOf(bc): -{s5}-");

            Console.WriteLine($"Substring(3): -{s6}-");
            Console.WriteLine($"Substring(3,5): -{s7}-");
            Console.WriteLine($"Replace(a, X): -{s8}-");

            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}