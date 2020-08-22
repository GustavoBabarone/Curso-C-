﻿﻿namespace B_classes_atributos_metodos.Exercicio04
{
    public class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double CalcularValorFinal(double cotacao, double quantidade)
        {
            return cotacao * quantidade + (cotacao * quantidade * IOF);
        }
    }
}