using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bank
{
    class ContoCorrente
{
        private string Name { get; set; }
        private int Giacenza { get; set; }
        private int Saldo { get; set; }
        public Dictionary<string, object> Properties { get; set; }

        public ContoCorrente(string name, int giacenza)
    {
        this.Name = name;
        this.Giacenza = giacenza;
        this.Saldo = giacenza; 
        this.Properties = new Dictionary<string, object>();
    }


        // METODO VERSAMENT
        public void Versamento(int importo)
    {
        this.Saldo += importo;
    }
        // METODO PRELIEVO
    
    public void Prelievo(int importo)
    {
        if (this.Saldo < importo)
        {
            Console.WriteLine("Insufficienza fondi per prelievo");
        }
        else
        {
            this.Saldo -= importo;
        }


    }
       

        // MEDOTO ARCHIVIA PROPRIETA ACCOUNT

        public void Archivia(Dictionary<string, object> properties)
    {
        this.Properties = properties;
    }
        //GET NAME
    public string GetName()
    {
        return Name;
    }
        //GET SALDO
    public int GetSaldo()
    {
        return Saldo;
    }
        // PROPRIETA

    public Dictionary<string, object> GetProperties()
    {
        return Properties;
    }
}


}

