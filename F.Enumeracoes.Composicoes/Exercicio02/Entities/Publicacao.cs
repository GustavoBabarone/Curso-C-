using System;
using System.Collections.Generic;
using System.Text;

namespace F.Enumeracoes.Composicoes.Exercicio02.Entities
{
    public class Publicacao
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Publicacao()
        {
        }

        public Publicacao(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("Comentários:");
            foreach (Comentario comentario in Comentarios)
            {
                sb.AppendLine(comentario.Texto);
            }

            return sb.ToString();
        }
    }
}