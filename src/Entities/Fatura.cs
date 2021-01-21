using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace src.Entities
{
    class Fatura
    {
        public double ValorDoServico { get; private set; }
        public double Tarifas { get; private set; }

        public Fatura(double valorDoServico, double tarifas)
        {
            ValorDoServico = valorDoServico;
            Tarifas = tarifas;
        }

        public double Total
        {
            get { return ValorDoServico + Tarifas; }
        }

        public override string ToString()
        {
            return "Valor do serviço: R$ "
                + ValorDoServico.ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Tarifas: R$ "
                + Tarifas.ToString("F2", CultureInfo.InvariantCulture)
                + Environment.NewLine
                + "Total: R$ "
                + Total.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
