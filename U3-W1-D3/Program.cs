using System;
using Bank;

namespace Bank
{  
    class Program
    {
       
        static void Main(string[] args)
        {
            ContoCorrente conto1 = new ContoCorrente("Giangiggi", 1000);

            conto1.Versamento(importo: 1000);
            conto1.Prelievo(importo: 750);
            conto1.Archivia(new Dictionary<string, object>() { { "giacenza", 1200 }, { "titolo_di_credito", "Credit" } });

            Console.WriteLine(conto1.GetName());
            Console.WriteLine(conto1.GetSaldo());
            Console.WriteLine(conto1.GetProperties().Count);
        }
       
    }


}