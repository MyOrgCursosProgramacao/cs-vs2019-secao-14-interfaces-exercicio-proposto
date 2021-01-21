namespace src.Services
{
    interface ISistemaDePagamento
    {
        string Sistema();

        double Tarifa(double quantia);

        double Juros(double quantia);
    }
}
