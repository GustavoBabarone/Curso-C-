using System;
using System.Collections.Generic;

namespace J.Generics.Set.Dictionary.Aula07
{
    public class Aula07
    {
        public static void Executar()
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["nome"] = "Gustavo";
            cookies["email"] = "email@gmail.com";
            cookies["telefone"] = "999887766";
            cookies["telefone"] = "999776655";

            Console.WriteLine();
            Console.WriteLine($"Email: {cookies["email"]}");
            Console.WriteLine($"Telefone: {cookies["telefone"]}");

            cookies.Remove("email");

            // Console.WriteLine($"Email com KeyNotFoundException: {cookies["email"]}");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine($"Email: {cookies["email"]}");
            }
            else
            {
                Console.WriteLine("Key 'email' não está presente do dicionario");
            }

            Console.WriteLine($"Tamanho do dicionario: {cookies.Count}");

            Console.WriteLine("\nPrint de todo o dicionario:");
            // foreach (var par in cookies) -> código menos 'verboso'
            foreach (KeyValuePair<string, string> par in cookies)
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }
        }
    }
}