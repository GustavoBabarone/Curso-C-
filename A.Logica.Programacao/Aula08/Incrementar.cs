using System;

namespace A.Logica.Programacao.Aula08
{
    public class Incrementar
    {
        public static void Executar()
        {
            int contador = 1;
            contador++;
            Console.WriteLine(contador);

            int variavel1 = contador++;
            Console.WriteLine(variavel1);

            int variavel2 = ++contador;
            Console.WriteLine(variavel2);
        }
    }
}