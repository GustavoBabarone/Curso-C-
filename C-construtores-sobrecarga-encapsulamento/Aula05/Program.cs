using System;

namespace C_construtores_sobrecarga_encapsulamento.Aula05
{
    public class Program
    {
        static void ExecutarAula()
        {
            Produto p = new Produto("TV", 900.00, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");
            
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
        
        /*static void Main(string[] args)
        {
            ExecutarAula();
        }*/
    }
}