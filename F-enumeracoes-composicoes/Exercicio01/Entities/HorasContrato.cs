using System;

namespace F_enumeracoes_composicoes.Exercicio01.Entities
{
    public class HorasContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HorasContrato()
        {
        }

        public HorasContrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double CalcularValorTotal()
        {
            return Horas * ValorPorHora;
        }
    }
}