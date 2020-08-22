using System;
using System.Collections.Generic;

namespace J_Generics_set_dictionary.Aula02
{
    public class CalculadoraService
    {
        public T CalcularMaiorValor<T>(List<T> lista) where T : IComparable
        {
            if (lista.Count == 0)
            {
                throw new ArgumentException("Erro! A lista não pode ser vazia.");
            }

            T max = lista[0];
            foreach (var elemento in lista)
            {
                if (elemento.CompareTo(max) > 0)
                {
                    max = elemento;
                }
            }
            return max;
        }
    }
}