using System;
using System.Collections.Generic;
using System.Globalization;
using F.Enumeracoes.Composicoes.Exercicio01.Entities.Enums;

namespace F.Enumeracoes.Composicoes.Exercicio01.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public ExperienciaFuncionario Experiencia { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();

        public Funcionario()
        {
        }

        public Funcionario(string nome, ExperienciaFuncionario experiencia, double salarioBase,
            Departamento departamento)
        {
            Nome = nome;
            Experiencia = experiencia;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(HorasContrato contract)
        {
            Contratos.Add(contract);
        }

        public void RemoverContrato(HorasContrato contract)
        {
            Contratos.Remove(contract);
        }

        public double CalcularRenda(int ano, int mes)
        {
            double total = SalarioBase;
            foreach (HorasContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    total += contrato.CalcularValorTotal();
                }
            }

            return total;
        }

        public void MostrarDados(string mesAno)
        {
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            string dados = "\nDados do Funcionário:";
            dados += $"\nNome: {Nome}";
            dados += $"\nDepartamento: {Departamento.Nome}";
            dados += $"\nRenda para {mesAno}: {CalcularRenda(ano, mes).ToString("F2", CultureInfo.InvariantCulture)}";

            Console.WriteLine(dados);
        }
    }
}