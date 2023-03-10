namespace G.Heranca.Polimorfismo.Aula02.Entities
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}