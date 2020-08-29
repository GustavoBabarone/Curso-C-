using System;

namespace K_Lambda_delegates_linq.Aula02
{
    delegate double OperacoesBinariasNumericas(double n1, double n2);
    
    public class Aula02
    {
        public static void Executar()
        {
            double a = 10;
            double b = 12;

            OperacoesBinariasNumericas operacao1 = Calculadora.ObterMaiorValor;
            double resultado1 = operacao1(a, b);
            Console.WriteLine(resultado1);
            
            OperacoesBinariasNumericas operacao2 = Calculadora.Somar;
            double resultado2 = operacao2.Invoke(a, b); // Sintaxe alternativa
            Console.WriteLine(resultado2);
            
            /* Erro de compilacao por nao respeitar a declaracao 'OperacoesBinariasNumericas' */
            // OperacoesBinariasNumericas operacao3 = Calculadora.ElevarAoQuadrado;
            // double resultado3 = operacao3(a, b);
            // Console.WriteLine(resultado3);
        }
    }
}