using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Produs
    {
        private long id;// identificator
        private String nume;// numele produsului
        private String codIntern;// codul Intern
        private String producator;// producator

        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string CodIntern { get => codIntern; set => codIntern = value; }
        public string Producator { get => producator; set => producator = value; }

        public Produs createProdus()
        {
            Produs prod = new Produs();
            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            prod.Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            prod.CodIntern = Console.ReadLine();
            Console.Write("Producator:");
            prod.Producator = Console.ReadLine();
            return prod;
        }
        public void afisProdus(Produs[] prod)
        {
            for (int cnt = 0; cnt < prod.Length; cnt++)
            {
                Produs produs = prod[cnt];
                Console.WriteLine("Produs: " +produs.Nume + "[" +produs.CodIntern +"] " + produs.Producator);
            }
        }
    }
}
