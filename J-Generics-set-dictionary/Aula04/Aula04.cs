using System;
using System.Collections.Generic;

namespace J_Generics_set_dictionary.Aula04
{
    public class Aula04
    {
        public static void Executar()
        {
              var hash = new HashSet<string>();
              hash.Add("string1");
              hash.Add("string2");
              hash.Add("string3");

              Console.WriteLine(hash.Contains("string1"));
              Console.WriteLine(hash.Contains("string4"));

              Console.WriteLine();
              foreach (var set in hash)
              {
                  Console.WriteLine(set);
              }

              Console.WriteLine();
              hash.Remove("string2");
              
              foreach (var set in hash)
              {
                  Console.WriteLine(set);
              }
              
              hash.Clear();

              Console.WriteLine($"\nQuantidade de itens: {hash.Count}");
        }
    }
}