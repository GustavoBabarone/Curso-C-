namespace K_Lambda_delegates_linq.Aula03
{
    public class Aula03
    {
        delegate void OperacoesBinariasNumericas(double n1, double n2);
        
        public static void Executar()
        {
            double a = 10;
            double b = 12;

            OperacoesBinariasNumericas operacao = Calculadora.MostrarMaiorValor;
            operacao += Calculadora.MostrarSoma;
            
            operacao.Invoke(a, b);
        }
    }
}