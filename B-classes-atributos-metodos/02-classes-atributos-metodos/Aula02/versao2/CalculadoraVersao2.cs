﻿﻿using System;

namespace Curso.Aula02.versao2
{
    public class CalculadoraVersao2
    {
        public double Pi = 3.14;
        
        public double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}