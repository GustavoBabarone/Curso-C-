using System;
using System.Reflection;
using F_enumeracoes_composicoes.Exercicio02.Entities;

namespace F_enumeracoes_composicoes.Exercicio02
{
    public class Exercicio02
    {
        public static void Executar()
        {
            Comentario c1 = new Comentario("Tenha uma ótima viagem!");
            Comentario c2 = new Comentario("Wow que legal!");
            
            Publicacao p1 = new Publicacao(
                DateTime.Parse("07/05/2020 12:20:45"),
                "Viajando para Nova Zelândia!",
                "Eu estou indo visitar esse incrível país!",
                12
            );
            
            p1.AdicionarComentario(c1);
            p1.AdicionarComentario(c2);
            
            Comentario c3 = new Comentario("Boa noite");
            Comentario c4 = new Comentario("May the Force be with you");
            Comentario c5 = new Comentario("Tenha cuidado com os pesadelos");
            
            Publicacao p2 = new Publicacao(
                DateTime.Parse("23/08/2018 15:30:17"),
                "Boa noite pessoal",
                "Vejo vocês amanhã",
                12
            );
            
            p2.AdicionarComentario(c3);
            p2.AdicionarComentario(c4);
            p2.AdicionarComentario(c5);
            
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}