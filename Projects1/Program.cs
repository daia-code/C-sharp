using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ok = 0;
            Console.Write("Nr. produse:");
            int nrProduse =
            int.Parse(Console.ReadLine());
            // array de produse
            Produs[] produse = new Produs[100];
            for (int cnt = 0; cnt < nrProduse; cnt++)
            {
                // instantierea unui Produs
                Produs prod = new Produs();
                prod = prod.createProdus();
               /* for(int i = 0; i < produse.Length; i++)
                {
                    if (prod.CodIntern == produse[i].CodIntern)
                    {
                        ok++;
                    }
                }*/
                if (ok == 0)
                {
                    produse[cnt] = prod;
                }
                ok = 0;
               
               
            }
            // afisam produsele
            Console.WriteLine("Produsele sunt:");
            Produs p = new Produs();
            p.afisProdus(produse);
            Console.Write("Nr. servicii:");
            int nrServicii =int.Parse(Console.ReadLine());
            Serviciu[] servicii = new Serviciu[100];
            for (int cnt = 0; cnt < nrProduse; cnt++)
            {
                // instantierea unui Produs
                Serviciu serv = new Serviciu();
                serv = serv.createServiciu();
                /* for (int i = 0; i < servicii.Length; i++)
                 {
                     if (serv.CodIntern == servicii[i].CodIntern)
                     {
                         ok++;
                     }
                 }
                 if (ok == 0)
                 {
                     servicii[cnt] = serv;
                 }
                 ok = 0;*/
                Console.WriteLine("Serviciile sunt:");
                Serviciu s= new Serviciu();
                s.afisServiciu(servicii);

            }
        }
    }
    }

