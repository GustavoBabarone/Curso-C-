using System;

namespace D_memoria_arrays_listas.Aula06
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            /* parametros -> ref precisa ser iniciada #1#
            int a = 10;

            Triplicar(a);
            
            Console.WriteLine("Valor de a = " + a);

            TriplicarUsandoRef(ref a);
            
            Console.WriteLine("Valor de ref a = " + a);

            /* parametros -> out não precisa ser iniciada #1#
            int x = 10;
            int triplo;
            
            TriplicarUsandoOut(x, out triplo);
            
            Console.WriteLine("Valor out triplo = " + triplo);
        }*/

        public static void Triplicar(int x)
        {
            x *= 3;
        }
        
        public static void TriplicarUsandoRef(ref int x)
        {
            x *= 3;
        }
        
        public static void TriplicarUsandoOut(int origem,  out int resultado)
        {
            resultado = origem * 3;
        }
    }
}