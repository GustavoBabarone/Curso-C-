using System;

namespace C.Construtores.Sobrecarga.Encapsulamento.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            Produto p = new Produto("TV", 900.00, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}