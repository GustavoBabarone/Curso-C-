namespace B.Classes.Atributos.Metodos.Exercicio03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public static double Media = 7.00;

        public double CalcularMediaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public double CalcularPontosFaltantes()
        {
            return Media - CalcularMediaFinal();
        }
    }
}