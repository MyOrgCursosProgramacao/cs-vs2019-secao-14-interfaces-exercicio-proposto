using src.Entities;
using System;
using System.Collections.Generic;

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
            List<Vencimento> vencimentos = new List<Vencimento>();
            Console.WriteLine("Sistema de pagamento: " + _sistemaDePagamento.Sistema());

            if (Parcelas > 0)
            {
                for (int i = 0; i < Parcelas; i++)
                {
                    DateTime vencimento = contrato.Data.AddMonths(i + 1);
                    double valorDoServico = contrato.Valor / Parcelas;
                    double juros = _sistemaDePagamento.Juros(valorDoServico) * (i + 1);
                    double tarifa = _sistemaDePagamento.Tarifa(valorDoServico + juros);

                    vencimentos.Add(new Vencimento(vencimento, valorDoServico, tarifa, juros));
                }
            }
            else
            {
                vencimentos.Add(new Vencimento(contrato.Data, contrato.Valor, _sistemaDePagamento.Tarifa(contrato.Valor), 0.0));
            }

            contrato.Fatura = new Fatura(Parcelas, contrato.Valor, vencimentos);
        }
    }
}
