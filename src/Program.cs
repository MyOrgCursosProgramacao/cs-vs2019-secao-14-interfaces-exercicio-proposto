using src.Entities;
using src.Services;
using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====  Seção 14: Exercício proposto de interfaces  ====");
            Console.WriteLine();

            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Número do contrato: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Título do contrato: ");
            string titulo = Console.ReadLine();
            Console.Write("Data do contrato (dd/mm/aaaa): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine().Trim(), "dd/MM/yyyy", null);
            Console.Write("Valor do contrato: R$ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contrato contrato = new Contrato(id, titulo, data, valor);

            Console.Write("Número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            ServicoContrato servicoContrato = new ServicoContrato(parcelas, new PayPal());
            servicoContrato.ProcesarFatura(contrato);

            Console.WriteLine();
            Console.WriteLine("-- Resumo do contrato --");
            Console.WriteLine(contrato);
        }
    }
}
