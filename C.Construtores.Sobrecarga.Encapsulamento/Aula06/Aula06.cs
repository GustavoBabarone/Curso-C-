using System;

namespace C.Construtores.Sobrecarga.Encapsulamento.Aula06
{
    public class Aula06
    {
        public static void Executar()
        {
            Produto p = new Produto("TV", 900.00, 10);

            Console.WriteLine(p.Nome);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}