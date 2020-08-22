using System.Globalization;

namespace I_interfaces.Aula02.Entities
{
    public class Retangulo : Forma
    {
        public double Comprimento { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Comprimento * Altura;
        }

        public override string ToString()
        {
            return $"Retangulo: " +
                   $"Cor = {Cor}, " +
                   $"Comprimento = {Comprimento}, " +
                   $"Altura = {Altura} e " +
                   $"Area = {CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}