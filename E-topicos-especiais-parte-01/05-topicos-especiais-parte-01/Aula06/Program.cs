using System;

namespace E_topicos_especiais_parte_01.Aula06
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();
        }*/

        static void Teste()
        {
            
            TimeSpan t1 = new TimeSpan();
            Console.WriteLine("TimeSpan: " + t1);
            
            TimeSpan t2 = new TimeSpan(0, 1, 30);
            Console.WriteLine("TimeSpan: " + t2);
            Console.WriteLine("TimeSpan (Ticks): " + t2.Ticks);
            
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine("TimeSpan: " + t3);
            
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine("TimeSpan: " + t4);
            
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine("TimeSpan: " + t5);

            TimeSpan t6 = TimeSpan.FromDays(1.5);
            Console.WriteLine("TimeSpan: " + t6);
            
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            Console.WriteLine("TimeSpan: " + t7);
            
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine("TimeSpan: " + t8);
            
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine("TimeSpan: " + t9);
            
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine("TimeSpan: " + t10);
            
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine("TimeSpan: " + t11);
        }
    }
}