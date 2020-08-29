namespace K_Lambda_delegates_linq.Aula02
{
    public class Calculadora
    {
        public static double ObterMaiorValor(double x, double y)
        {
            return (x > y) ? x : y;
        }
        
        public static double Somar(double x, double y)
        {
            return x + y;
        }
        
        public static double ElevarAoQuadrado(double x)
        {
            return x * x;
        }
    }
}