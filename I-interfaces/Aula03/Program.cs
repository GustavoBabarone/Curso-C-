using System;
using I_interfaces.Aula03.Entities;

namespace I_interfaces.Aula03
{
    public class Program
    {
        static void Teste()
        {
            DispositivoCombo combo = new DispositivoCombo { Numero = 123};
            combo.ProcessarDocumento("Curso.txt");
            Console.WriteLine(combo.Print());
            Console.WriteLine(combo.Scan());
        }
        
        /*static void Main(string[] args)
        {
            Teste();
        }*/
    }
}