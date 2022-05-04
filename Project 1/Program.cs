using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
       
         class Program
    {
        static void Main(string[] args)
        {
            /*ProduseMgr produseMgr = new ProduseMgr();
            ServiciuMgr serviciuMgr = new ServiciuMgr();
            int op, nrP = 0, nrS = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Introduceti un produs");
                Console.WriteLine("2.Introduceti un serviciu");
                Console.WriteLine("3.Vizualizati produsele");
                Console.WriteLine("4.Vizualizati serviciile");
                Console.WriteLine("0.Exit");
                Console.Write("Introduceti optiunea:");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        {
                            ProduseAbstractMgr.NrElemente = nrP;
                            ProduseAbstractMgr.Elemente[nrP] = produseMgr.ReadProdus();
                            nrP++;
                            break;
                        }
                    case 2:
                        {
                            serviciuMgr.NrServicii = nrS;
                            serviciuMgr.Servicii[nrS] = serviciuMgr.ReadServicii();
                            break;
                        }
                    case 3:
                        {
                            produseMgr.WriteProduse(produseMgr.Produse);
                            break;
                        }
                    case 4:
                        {
                            serviciuMgr.WriteServicii(serviciuMgr.Servicii);
                            break;
                        }
                }
                Console.WriteLine();
            } while (op != 0);*/

            /*
            ProduseMgr produseMgr = new ProduseMgr();
            produseMgr.InitListafromXML();
            produseMgr.Write2Console();
            Console.WriteLine();
            produseMgr.LinqList();
            Console.ReadKey();
            */
            List<PacheteMgr> pacheteMgr = new List<PacheteMgr>();
            Console.WriteLine("Introduceti nr de pachete:");
            int nrPachete = int.Parse(Console.ReadLine());
            for (int i = 0; i < nrPachete; i++)
            {
                pacheteMgr[i].ReadPachet(i,nrPachete);
            }
        
          





        }









    }
}

