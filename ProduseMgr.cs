using L3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class ProduseMgr
    {
        private Produs[] produse;
        private int nrProduse ;

        public ProduseMgr()
        {
            this.produse = new Produs[100];
            this.nrProduse = 0;
        }
        public ProduseMgr(Produs[] produse, int nrProduse)
        {
            this.produse = produse;
            this.nrProduse = nrProduse;
        }

      
        public void ReadProduse( int nrProduse)
        {
            
            for(int i = 0; i < nrProduse; i++)
            {
                Console.WriteLine("Introdu un produs");
                Console.Write("Numele:");
                String nume = Console.ReadLine();
                Console.Write("Codul intern:");
                String CodIntern = Console.ReadLine();
                Console.Write("Producator :");
                String producator = Console.ReadLine();
                produse[i] = new Produs(i, nume, CodIntern, producator);
            }
           
       
        }
       public void WriteProduse()
        {
            for (int i = 0; i < nrProduse; i++)
            {
                //Console.WriteLine("Id "+produse[i].Id1+" Nume: "+produse[i].Nume1+" Cod Intern: "+produse[i].CodIntern1+" Producator: "+produse[i].Producator1);
                produse[i].AltaDescriere();
            }
          

        }

    }
     
    }
