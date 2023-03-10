using System;
using System.Globalization;

namespace B.Classes.Atributos.Metodos.Exercicio01
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Console.WriteLine("Entre os dados do produto:");

            Produto p = new Produto();
            p.Nome = Console.ReadLine();
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p.ExibirMensagem());

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(adicionar);

            Console.WriteLine("Dados atualizados: " + p.ExibirMensagem());

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());

            p.RemoverProdutos(remover);

            Console.WriteLine("Dados atualizados: " + p.ExibirMensagem());
        }
    }
}