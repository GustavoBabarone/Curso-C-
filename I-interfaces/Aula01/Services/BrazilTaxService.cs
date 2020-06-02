namespace I_interfaces.Aula01.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }

            return amount * 0.15;
        }
    }
}