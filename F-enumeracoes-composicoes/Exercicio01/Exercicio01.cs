using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using F_enumeracoes_composicoes.Exercicio01.Entities;
using F_enumeracoes_composicoes.Exercicio01.Entities.Enums;

namespace F_enumeracoes_composicoes.Exercicio01
{
    public class Exercicio01
    {
        public static void Executar()
        {
            Console.Write("Insira o nome do departamento: ");
            string nomeDept = Console.ReadLine();
            
            Console.WriteLine("\nInsira dados do funcionáio: ");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Experiência (Junior/Pleno/Senior): ");
            ExperienciaFuncionario experiencia = Enum.Parse<ExperienciaFuncionario>(Console.ReadLine());
            
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Departamento dept = new Departamento(nomeDept);
            Funcionario funcionario = new Funcionario(nome, experiencia, salarioBase, dept);
            
            Console.Write("\nQuantos contratos para este funcionário? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nInsira os dados do #{i+1} contrato:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                
                HorasContrato contrato = new HorasContrato(data, valorPorHora, horas);
                funcionario.AdicionarContrato(contrato);
            }
            
            Console.Write("\nInsira mes e ano para calcular a renda (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            
            funcionario.MostrarDados(mesAno);
        }
    }
}