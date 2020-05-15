using System;

namespace E_topicos_especiais_parte_01.Aula07
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            TesteFormatacoes();
            TesteConversao();
            TesteOperacoes();
        }*/
        
        static void TesteFormatacoes()
        {
            Console.WriteLine("\n--- Formatações ---");
            
            DateTime d = new DateTime(2020, 05, 07, 08, 02, 45, 275);
            
            Console.WriteLine("DateTime Exemplo: " + d);
            Console.WriteLine("Date: " + d.Date);
            Console.WriteLine("Day: " + d.Day);
            Console.WriteLine("DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("DayOfYear: " + d.DayOfYear);
            Console.WriteLine("Hour: " + d.Hour);
            Console.WriteLine("Kind: " + d.Kind);
            Console.WriteLine("Millisecond: " + d.Millisecond);
            Console.WriteLine("Minute: " + d.Minute);
            Console.WriteLine("Month: " + d.Month);
            Console.WriteLine("Second: " + d.Second);
            Console.WriteLine("Ticks: " + d.Ticks);
            Console.WriteLine("TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("Year: " + d.Year);
        }

        static void TesteConversao()
        {
            Console.WriteLine("\n--- Conversões ---");
            
            DateTime d1 = new DateTime(2020, 05, 07, 08, 02, 45);
            
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        } 

        static void TesteOperacoes()
        {
            Console.WriteLine("\n--- Operações ---");
            
            DateTime d1 = new DateTime(2020, 05, 07, 08, 02, 45, 275);
            
            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(15);
            DateTime d4 = d1.AddDays(7);
            
            Console.WriteLine("Default: " + d1);
            Console.WriteLine("AddHours: " + d2);
            Console.WriteLine("AddMinutes: " + d3);
            Console.WriteLine("AddDays: " + d4);
        }
    }
}