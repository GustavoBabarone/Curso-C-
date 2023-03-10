using System;
using B.Classes.Atributos.Metodos.Aula02.versao1;
using B.Classes.Atributos.Metodos.Aula02.versao2;
using B.Classes.Atributos.Metodos.Aula02.versao3;

namespace B.Classes.Atributos.Metodos
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            Aula01.Aula01.Executar();

            Console.WriteLine("\n----- Aula02 Versão 1 -----");
            Aula02Versao1.Executar();

            Console.WriteLine("\n----- Aula02 Versão 2 -----");
            Aula02Versao2.Executar();

            Console.WriteLine("\n----- Aula02 Versão 3 -----");
            Aula02Versao3.Executar();

            Console.WriteLine("\n----- Exercicio01 -----");
            Exercicio01.Exercicio01.Executar();

            Console.WriteLine("\n----- Exercicio02 -----");
            Exercicio02.Exercicio02.Executar();

            Console.WriteLine("\n----- Exercicio03 -----");
            Exercicio03.Exercicio03.Executar();

            Console.WriteLine("\n----- Exercicio04 -----");
            Exercicio04.Exercicio04.Executar();
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nSegunda Parte do Curso de C#!");
        }
    }
}