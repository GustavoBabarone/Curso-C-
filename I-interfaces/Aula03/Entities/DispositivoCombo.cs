using System;

namespace I_interfaces.Aula03.Entities
{
    public class DispositivoCombo : Dispositivo, IScanner, IPrinter
    {
        public override void ProcessarDocumento(string doc)
        {
            Console.WriteLine($"DispositivoCombo está processando doc: {doc}");
        }

        public string Scan()
        {
            return "DispositivoCombo scan está funcionando!";
        }

        public string Print()
        {
            return "DispositivoCombo print está funcionando!";
        }
    }
}