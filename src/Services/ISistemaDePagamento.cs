namespace src.Services
{
    interface ISistemaDePagamento
    {
        double Tarifa(double quantia);

        double Juros(double quantia);
    }
}
