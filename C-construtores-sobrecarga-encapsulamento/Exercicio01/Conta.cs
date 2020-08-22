using System.Globalization;

namespace C_construtores_sobrecarga_encapsulamento.Exercicio01
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        private double _taxa = 5.00;

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            AdicionarDeposito(saldo);
        }

        public void AdicionarDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void RecolherSaque(double saque)
        {
            Saldo = Saldo - saque - _taxa;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, " +
                   $"Titular: {Titular}, " +
                   $"Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}