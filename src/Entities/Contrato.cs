using System;
using System.Globalization;
using System.Text;

namespace src.Entities
{
    class Contrato
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public DateTime Data { get; private set; }
        public double Valor { get; private set; }
        public Fatura Fatura { get; set; }

        public Contrato(int id, string titulo, DateTime data, double valor)
        {
            Id = id;
            Titulo = titulo;
            Data = data;
            Valor = valor;
            Fatura = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"id: {Id}");
            sb.AppendLine($"Titulo: {Titulo}");
            sb.AppendLine($"Data: {Data.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Valor: R$ {Valor}");
            sb.AppendLine();
            if(Fatura.Parcelas > 0)
            {
                sb.AppendLine($"Número de parcelas: {Fatura.Parcelas}");
            }
            else
            {
                sb.AppendLine("Pagamento à vista");
            }
            sb.AppendLine($"Tarifas totais: R$ {Fatura.Tarifas.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Juros totais: R$ {Fatura.Juros.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Pagamento total: R$ {Fatura.Total.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine();
            sb.AppendLine($"Vencimentos");
            sb.AppendLine(Fatura.ToString());
            return sb.ToString();
        }
    }
}
