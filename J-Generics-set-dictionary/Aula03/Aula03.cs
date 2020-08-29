using System;

namespace J_Generics_set_dictionary.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            var c1 = new Cliente("Gustavo", "email.igual@gmail.com");
            var c2 = new Cliente("Maria", "email.igual@gmail.com");

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}