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
            sb.AppendLine($"Vencimentos");
            sb.AppendLine(Fatura.ToString());
            return sb.ToString();
        }
    }
}
