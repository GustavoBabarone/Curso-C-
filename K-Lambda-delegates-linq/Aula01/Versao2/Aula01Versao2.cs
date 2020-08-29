using System;
using System.Collections.Generic;

namespace K_Lambda_delegates_linq.Aula01.Versao2
{
    public class Aula01Versao2
    {
        static int CompararProdutos(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
        
        public static void Executar()
        {
            /* Sem violar o conceito 'Open-Close' do SOLID */
            /* Usando 'delegate' -> adicionando uma referencia para a funcao 'CompararProdutos' */
            var list = new List<Produto>();
            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Notebook", 1200.00));
            list.Add(new Produto("Tablet", 450.00));

            Comparison<Produto> comparacao = CompararProdutos;
            
            list.Sort(comparacao);

            foreach (var produto in list)
            {
                Console.WriteLine(produto);
            }    
        }
    }
}