using System;
using System.Reflection;
using F_enumeracoes_composicoes.Exercicio02.Entities;

namespace F_enumeracoes_composicoes.Exercicio02
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Teste();   
        }*/

        static void Teste()
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            
            Post p1 = new Post(
                DateTime.Parse("07/05/2020 12:20:45"),
                "Traveling to New Zeland!",
                "I am going to visit this wonderful country!",
                12
            );
            
            p1.AddComent(c1);
            p1.AddComent(c2);
            
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Comment c5 = new Comment("Be careful with nightmares");
            
            Post p2 = new Post(
                DateTime.Parse("23/08/2018 15:30:17"),
                "Good night guys",
                "See you tomorrow",
                12
            );
            
            p2.AddComent(c3);
            p2.AddComent(c4);
            p2.AddComent(c5);
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}