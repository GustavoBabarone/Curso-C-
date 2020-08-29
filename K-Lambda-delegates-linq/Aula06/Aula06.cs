using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Lambda_delegates_linq.Aula06
{
    public class Aula06
    {
        public static void Executar()
        {
            var produtos = new List<Produto>();
            
            produtos.Add(new Produto("Tv", 900.00));
            produtos.Add(new Produto("Mouse", 50.00));
            produtos.Add(new Produto("Tablet", 350.50));
            produtos.Add(new Produto("HD Case", 80.90));

            /* Funciona usando 'lambda' */
            // Func<Produto, string> func = p => p.Nome.ToUpper();
            // var resultado = produtos.Select(func).ToList();

            /* Funciona usando 'Func' */
            var resultado = produtos.Select(EmCaixaAlta).ToList();

            foreach (var r in resultado)
            {
                Console.WriteLine(r);
            }
        }

        private static string EmCaixaAlta(Produto p)
        {
            return p.Nome.ToUpper();
        }
    }
}