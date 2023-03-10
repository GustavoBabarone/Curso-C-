namespace G.Heranca.Polimorfismo.Aula01.Entities
{
    public class ContaSalario : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaSalario()
        {
        }

        public ContaSalario(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular,
            saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void RealizarEmprestimo(double quantia)
        {
            if (quantia >= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}