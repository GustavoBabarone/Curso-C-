using System;

namespace C_construtores_sobrecarga_encapsulamento.Aula07
{
    public class Program
    {
        static void ExecutarAula()
        {
            Produto p = new Produto("TV", 900.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";
            
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}