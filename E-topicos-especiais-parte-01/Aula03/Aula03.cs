using System;

namespace E_topicos_especiais_parte_01.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            /* CONDICIONAL TERNÁRIA */
            int valor = 10;
            string resposta;

            resposta = (valor > 5) ? "Sim" : "Não";
            
            Console.WriteLine("Resposta: " + resposta);
            
            resposta = (valor < 5) ? "Sim" : "Não";
            
            Console.WriteLine("Resposta: " + resposta);
        }
    }
}