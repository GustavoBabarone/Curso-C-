using System;
using System.Collections.Generic;

namespace D.Memoria.Arrays.Listas.Exercicio04
{
    public class Exercicio04
    {
        private static HashSet<int> CadastrarAlunosCursos(string nomeCurso, HashSet<int> curso)
        {
            Console.Write($"\nO curso {nomeCurso} possui quantos alunos? ");
            int nA = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite os códigos dos alunos do curso {nomeCurso}:");

            for (int a = 0; a < nA; a++)
            {
                Console.Write($"#{a + 1}: ");
                int codigo = int.Parse(Console.ReadLine());
                curso.Add(codigo);
            }

            return curso;
        }

        public static void Executar()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            A = CadastrarAlunosCursos("A", A);
            B = CadastrarAlunosCursos("B", B);
            C = CadastrarAlunosCursos("C", C);

            HashSet<int> totalAlunos = new HashSet<int>();
            totalAlunos.UnionWith(A);
            totalAlunos.UnionWith(B);
            totalAlunos.UnionWith(C);

            Console.WriteLine($"\nTotal de alunos cadastrados: {totalAlunos.Count}");
        }
    }
}