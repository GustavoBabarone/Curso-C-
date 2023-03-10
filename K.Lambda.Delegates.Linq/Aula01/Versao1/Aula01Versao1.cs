using System;
using System.Collections.Generic;

namespace K.Lambda.Delegates.Linq.Aula01.Versao1
{
    public class Aula01Versao1
    {
        public static void Executar()
        {
            /* Violando o conceito 'Open-Close' do SOLID */
            var list = new List<Produto>();
            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Notebook", 1200.00));
            list.Add(new Produto("Tablet", 450.00));

            list.Sort();

            foreach (var produto in list)
            {
                Console.WriteLine(produto);
            }
        }
    }
}