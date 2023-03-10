namespace I.Interfaces.Aula02.Entities
{
    public abstract class Forma : IForma
    {
        public Cor Cor { get; set; }

        public abstract double CalcularArea();
    }
}