using System;

namespace D_memoria_arrays_listas.Aula05
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            int soma1 = Somar(new int[] {2, 3, 5});
            int soma2 = SomarParams(2, 3, 5);
            
            Console.WriteLine("Soma default: " +  soma1);
            Console.WriteLine("Soma params: " +  soma2);
        }*/

        public static int Somar(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
        
        public static int SomarParams(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}