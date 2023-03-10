using System;

namespace E.Topicos.Especiais.Parte01.Aula03
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