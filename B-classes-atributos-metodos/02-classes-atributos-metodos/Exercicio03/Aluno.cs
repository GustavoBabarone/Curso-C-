﻿﻿namespace Curso.Exercicio03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMediaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public double CalcularPontosFaltantes()
        {
            return 60.00 - CalcularMediaFinal();
        }
    }
}