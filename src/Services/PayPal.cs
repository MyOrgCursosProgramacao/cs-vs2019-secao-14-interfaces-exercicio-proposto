namespace src.Services
{
    class PayPal : ISistemaDePagamento
    {
        public double Tarifa(double quantia)
        {
            return 0.02 * quantia;
        }

        public double Juros(double quantia)
        {
            return 0.01 * quantia;
        }
    }
}
