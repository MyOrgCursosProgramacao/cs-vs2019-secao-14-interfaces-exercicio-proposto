using System;
using System.Globalization;

namespace src.Entities
{
    public class Vencimento
    {
        public DateTime Data { get; private set; }
        public double ValorDoServico { get; private set; }
        public double Tarifa { get; private set; }
        public double Juros { get; private set; }

        public Vencimento(DateTime data, double valorDoServico, double tarifa, double juros)
        {
            Data = data;
            ValorDoServico = valorDoServico;
            Tarifa = tarifa;
            Juros = juros;
        }

        public double Total
        {
            get { return ValorDoServico + Tarifa + Juros; }
        }

        public override string ToString()
        {
            return $"Vencimento: {Data.ToString("dd/MM/yyyy")}"
                + Environment.NewLine
                + $"Valor do serviço: R$ {ValorDoServico.ToString("F2", CultureInfo.InvariantCulture)}"
                + Environment.NewLine
                + $"Tarifa: R$ {Tarifa.ToString("F2", CultureInfo.InvariantCulture)}"
                + Environment.NewLine
                + $"Juros: R$ {Juros.ToString("F2", CultureInfo.InvariantCulture)}"
                + Environment.NewLine
                + $"Total: R$ {Total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}