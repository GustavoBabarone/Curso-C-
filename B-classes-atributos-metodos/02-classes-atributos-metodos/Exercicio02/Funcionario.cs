﻿﻿namespace Curso.Exercicio02
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto = 1000;

        public double ObterSalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalarioBruto(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem) / 100;
        }
    }
}