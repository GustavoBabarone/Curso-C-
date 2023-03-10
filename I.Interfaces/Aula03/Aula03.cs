using System;
using I.Interfaces.Aula03.Entities;

namespace I.Interfaces.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            DispositivoCombo combo = new DispositivoCombo { Numero = 123 };
            combo.ProcessarDocumento("Curso.txt");
            Console.WriteLine(combo.Print());
            Console.WriteLine(combo.Scan());
        }
    }
}