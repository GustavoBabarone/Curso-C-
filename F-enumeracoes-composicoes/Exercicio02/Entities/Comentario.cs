namespace F_enumeracoes_composicoes.Exercicio02.Entities
{
    public class Comentario
    {
        public string Texto { get; set; }

        public Comentario()
        {
        }

        public Comentario(string texto)
        {
            Texto = texto;
        }
    }
}