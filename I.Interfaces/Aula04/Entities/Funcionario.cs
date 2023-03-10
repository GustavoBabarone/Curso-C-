using System;
using System.Globalization;

namespace I.Interfaces.Aula04.Entities
{
    public class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Nome: {Nome.PadRight(15, ' ')} e " +
                   $"Salário: {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Funcionario))
            {
                throw new ArgumentException("Argumento recebido não é um funcionário");
            }

            var outroFuncionario = obj as Funcionario;
            return String.Compare(Nome, outroFuncionario.Nome, StringComparison.Ordinal);
        }
    }
}