using System;

namespace D_memoria_arrays_listas.Aula07
{
    public class Aula07
    {
        public static void Executar()
        {
            string[] pessoas = new string[] {"Gustavo", "Maria", "Felipe"};

            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}