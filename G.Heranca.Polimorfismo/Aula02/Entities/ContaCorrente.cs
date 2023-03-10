namespace G.Heranca.Polimorfismo.Aula02.Entities
{
    public class ContaCorrente : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaCorrente()
        {
        }

        public ContaCorrente(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
    }
}