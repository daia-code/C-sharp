using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProduseMgr : ProduseAbstractMgr
    {
        //private Produs[] produse = new Produs[100];
        //private int nrProduse = 0;

        //public int NrProduse { get => nrProduse; set => nrProduse = value; }
        //public Produs[] Produse { get => produse; set => produse = value; }

        
        public Produs ReadProdus()
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            String nume = Console.ReadLine();
            Console.Write("Codul intern:");
            String CodIntern = Console.ReadLine();
            Console.Write("Producator :");
            String producator = Console.ReadLine();
            Produs produs = new Produs(NrElemente, nume, CodIntern, producator);
            return produs;
        }


        public void WriteProduse()
        {
            for (int i = 0; i < NrElemente; i++)
            {
                if !(Elemente[i] == null)           
                    {
                    continue;
                }
               Console.WriteLine(Elemente[i].Descriere());

               // Console.WriteLine("Id "+produse[i].Id1+" Nume: "+produse[i].Nume1+" Cod Intern: "+produse[i].CodIntern1+" Producator: "+produse[i].Producator1);



            }


        }

    }
}
