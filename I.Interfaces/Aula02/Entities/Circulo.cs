using System;
using System.Globalization;

namespace I.Interfaces.Aula02.Entities
{
    public class Circulo : Forma
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return $"Circulo: " +
                   $"Cor = {Cor}, " +
                   $"Raio = {Raio} e " +
                   $"Area = {CalcularArea().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}