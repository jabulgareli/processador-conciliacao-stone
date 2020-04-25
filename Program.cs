using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProcessadorXmlConciliacaoStone
{

    class Program
    {
        static void Main(string[] args)
        {
            var totalAmount = 0m;
            var files = Directory.GetFiles(Environment.CurrentDirectory, "*.xml");
            var lastNegativeAmount = 0m;
            var paymentEvents = 0;
            var atkFileName = Environment.CurrentDirectory + @"\" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".txt";

            foreach (var file in files)
            {
                Console.WriteLine($"Arquivo: {Path.GetFileName(file)}");
                var content = File.ReadAllText(file);

                using(var reader = new StringReader(content))
                {
                    var serializer = new XmlSerializer(typeof(Conciliation), new XmlRootAttribute("Conciliation"));
                    var conciliation = (Conciliation)serializer.Deserialize(reader);

                    foreach(var p in conciliation.Payments)
                    {
                        totalAmount += p.TotalFinancialAccountsAmount;
                        lastNegativeAmount += p.LastNegativeAmount;

                        Console.WriteLine($"Encontrado: {p.TotalFinancialAccountsAmount}");
                    }

                    foreach(var fta in conciliation.FinancialTransactionsAccounts)
                    {
                        if (fta.Events.Payments > 0)
                        {
                            paymentEvents++;

                            File.AppendAllText(atkFileName, fta.AcquirerTransactionKey.ToString() + Environment.NewLine);
                        }

                    }
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("******************************************************");
            Console.WriteLine($"Soma dos pagamentos nos arquivos    : R$ {totalAmount}");
            Console.WriteLine($"Soma LastNegativeAmount nos arquivos: R$ {lastNegativeAmount}");
            Console.WriteLine($"Arquivos processados                : {files.Length}");
            Console.WriteLine("******************************************************");

            Console.ReadKey();
        }
    }
}
