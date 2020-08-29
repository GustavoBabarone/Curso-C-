using System;
using System.Collections.Generic;
using System.Globalization;

namespace D_memoria_arrays_listas.Exercicio02
{
    public class Exercicio02
    {
        public static void Executar()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            
            Console.Write("Quantos funcionários serão registrados? ");
            int quantia = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantia; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionário #{i+1}: ");
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                funcionarios.Add(new Funcionario(id, nome, salario));
            }
            
            Console.WriteLine();
            Console.Write("Insira o id do funcionário que receberá aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarios.Find(x => x.Id == idFuncionario);
            if (funcionario == null)
            {
                Console.WriteLine("Esse Id não existe!");
            }
            else
            {
                Console.Write("Insira a porcentagem (%) do aumento: ");
                double porentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porentagem);
            }
            
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}