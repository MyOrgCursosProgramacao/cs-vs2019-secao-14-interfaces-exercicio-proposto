using System;
using System.Globalization;

namespace src.Entities
{
    class Contrato
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public DateTime Data { get; private set; }
        public double Valor { get; private set; }
        public Fatura Fatura { get; private set; }

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
            return Id
                + ", "
                + Titulo
                + ", "
                + Data.ToString("dd/MissingMemberException/yyyy")
                + ", "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
