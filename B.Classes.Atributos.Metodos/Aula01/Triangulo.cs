using System;

namespace B.Classes.Atributos.Metodos.Aula01
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}