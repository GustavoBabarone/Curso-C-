using System;

namespace E_topicos_especiais_parte_01.Aula03
{
    public class Program
    {
        static void ExecutarAula()
        {
            /* CONDICIONAL TERNÁRIA */
            int valor = 10;
            string resposta;

            resposta = (valor > 5) ? "Sim" : "Não";
            
            Console.WriteLine("Resposta: " + resposta);
            
            resposta = (valor < 5) ? "Sim" : "Não";
            
            Console.WriteLine("Resposta: " + resposta);
        }

        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}