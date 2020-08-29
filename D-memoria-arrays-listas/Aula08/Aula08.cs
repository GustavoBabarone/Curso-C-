using System;
using System.Collections.Generic;

namespace D_memoria_arrays_listas.Aula08
{
    public class Aula08
    {
        private static void Listar(List<string> lista)
        {
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Executar()
        {
            List<string> lista = new List<string>();
            
            /* adiciona no final da lista */
            lista.Add("Gustavo");
            lista.Add("Maria");
            lista.Add("Felipe");
            lista.Add("Fulano");

            /* adiciona em qualquer posição da lista */
            lista.Insert(2, "Bob");
            
            Console.WriteLine("Elementos da lista: ");
            Listar(lista);
            
            Console.WriteLine();    
            Console.WriteLine("List Count = " + lista.Count);

            /* EXPLICANDO A SINTAXE LAMBDA NO FIND -> eu quero um string 'x' tal que a primeira letra do nome seja 'A' */
            string s1 = lista.Find(x => x[0] == 'F');
            Console.WriteLine("Primeiro com letra 'F' = " + s1);
            
            string s2 = lista.FindLast(x => x[0] == 'F');
            Console.WriteLine("Último com letra 'F' = " + s2);
            
            int pos1 = lista.FindIndex(x => x[0] == 'F');
            Console.WriteLine("Posição do primeiro com letra 'F' = " + pos1);
            
            int pos2 = lista.FindLastIndex(x => x[0] == 'F');
            Console.WriteLine("Posição do último com letra 'F' = " + pos2);

            Console.WriteLine();
            Console.WriteLine("Listar todos com 6 letras: ");
            
            List<string> lista2 = lista.FindAll(x => x.Length == 6);
            Listar(lista2);

            Console.WriteLine();
            Console.WriteLine("Removendo string com letra 'M': ");
            
            lista.Remove("Maria");
            Listar(lista);
            
            Console.WriteLine();
            Console.WriteLine("Removendo todos string com letra 'F':");

            lista.RemoveAll(x => x[0] == 'F');
            Listar(lista);
            
            Console.WriteLine();
            Console.WriteLine("Removendo por index 2: ");
            
            lista.RemoveAt(1);
            Listar(lista);
            
            lista.Add("Carlos");
            lista.Add("Maas");
            lista.Add("Adrian");
            lista.Add("Pedro");
            lista.Add("Mira");
            
            Console.WriteLine();
            Console.WriteLine("Lista completa: ");
            Listar(lista);
            
            Console.WriteLine();
            Console.WriteLine("Remover a partir do index '2', 3 elementos: ");
            
            lista.RemoveRange(2, 3);
            Listar(lista);
        }
    }
}