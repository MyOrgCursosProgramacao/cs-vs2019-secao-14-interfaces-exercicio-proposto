using src.Entities;
using System;
using System.Globalization;

namespace src.Services
{
    class ServicoContrato
    {
        public int Parcelas { get; private set; }

        private ISistemaDePagamento _sistemaDePagamento;

        public ServicoContrato(int parcelas, ISistemaDePagamento sistemaDePagamento)
        {
            Parcelas = parcelas;
            _sistemaDePagamento = sistemaDePagamento;
        }

        public void ProcesarFatura(Contrato contrato)
        {
            DateTime[] vencimento = new DateTime[Parcelas - 1];
            double[] pagamento = new double[Parcelas - 1];
            double[] tarifa = new double[Parcelas - 1];
            double[] juros = new double[Parcelas - 1];

            for (int i = 0; i < Parcelas; i++)
            {
                vencimento[i] = contrato.Data.AddMonths(i + 1);
                pagamento[i] = contrato.Valor / Parcelas;
                tarifa[i] = _sistemaDePagamento.Tarifa(contrato.Valor);
                juros[i] = _sistemaDePagamento.Juros(contrato.Valor);

                Console.WriteLine($"Parcela #{i}");
                Console.WriteLine($"Vencimento: {vencimento[i].ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Total: R$ {(pagamento[i] + tarifa[i] + juros[i]).ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"\tValor: R$ {pagamento[i].ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"\tTarifa: R$ {tarifa[i].ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"\tJuros: R$ {juros[i].ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
            }
        }
    }
}
