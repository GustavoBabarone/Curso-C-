using System;

namespace D_memoria_arrays_listas.Aula07
{
    public class Program
    {
        static void ExecutarAula()
        {
            string[] pessoas = new string[] {"Gustavo", "Maria", "Felipe"};

            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}