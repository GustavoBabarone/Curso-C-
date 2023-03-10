using System;
using System.Collections.Generic;

namespace K.Lambda.Delegates.Linq.Aula01.Versao3
{
    public class Aula01Versao3
    {
        public static void Executar()
        {
            var list = new List<Produto>();
            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Notebook", 1200.00));
            list.Add(new Produto("Tablet", 450.00));

            /* Expressao 'lambda' atribuida a uma variavel 'delegate' */
            /*Comparison<Produto> comparacao = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());*/

            /* Expressao 'lambda' inline */
            list.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

            foreach (var produto in list)
            {
                Console.WriteLine(produto);
            }
        }
    }
}