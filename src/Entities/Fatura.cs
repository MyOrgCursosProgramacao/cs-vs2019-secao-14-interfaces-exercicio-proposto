using System.Collections.Generic;
using System.Text;

namespace src.Entities
{
    class Fatura
    {
        public int Parcelas { get; private set; }
        public double ValorDoServico { get; private set; }
        public List<Vencimento> Vencimentos { get; private set; }

        public Fatura(int parcelas, double valorDoServico, List<Vencimento> vencimentos)
        {
            Parcelas = parcelas;
            ValorDoServico = valorDoServico;
            Vencimentos = vencimentos;
        }

        public double Tarifas
        {
            get
            {
                double tarifa = 0.0;
                foreach (Vencimento vencimento in Vencimentos)
                {
                    tarifa += vencimento.Tarifa;
                }
                return tarifa;
            }
        }

        public double Juros
        {
            get
            {
                double juros = 0.0;
                foreach (Vencimento vencimento in Vencimentos)
                {
                    juros += vencimento.Juros;
                }
                return juros;
            }
        }

        public double Total
        {
            get { return ValorDoServico + Tarifas + Juros; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int parcela = 1;
            foreach (Vencimento vencimento in Vencimentos)
            {
                if (Parcelas > 0)
                {
                    sb.AppendLine($"Parcela #{parcela}");
                }
                else
                {
                    sb.AppendLine($"Pagamento");
                }
                sb.AppendLine(vencimento.ToString());
                sb.AppendLine();
                parcela++;
            }

            return sb.ToString();
        }
    }
}
