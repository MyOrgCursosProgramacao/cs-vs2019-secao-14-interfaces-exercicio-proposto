using System;
using System.Globalization;

namespace src.Entities
{
    class Fatura
    {
        public double ValorDoServico { get; private set; }
        public double Tarifas { get; private set; }
        public double Juros { get; private set; }

        public double Total
        {
            get { return ValorDoServico + Tarifas + Juros; }
        }

        public Fatura(double valorDoServico, double tarifas, double juros)
        {
            ValorDoServico = valorDoServico;
            Tarifas = tarifas;
            Juros = juros;
        }

        public override string ToString()
        {
            return "Valor do serviço: R$ "
                + ValorDoServico.ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Tarifas: R$ "
                + Tarifas.ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Juros: R$ "
                + Juros.ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Total: R$ "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
