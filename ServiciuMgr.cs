using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L3;

namespace app1
{
    class ServiciuMgr
    {
        private Serviciu[] servicii;
        private int nrServicii;

        public ServiciuMgr()
        {
            this.servicii = new Serviciu[100];
            this.nrServicii = 0;
        }
        public ServiciuMgr(Serviciu[] servicii, int nrServicii)
        {
            this.servicii = servicii;
            this.nrServicii = nrServicii;
        }
        public void  ReadServicii(int nrServicii)
        {

            for (int i = 0; i < nrServicii; i++)
            {
                Console.WriteLine("Introdu un serviciu");
                Console.Write("Numele:");
                String nume = Console.ReadLine();
                Console.Write("Codul intern:");
                String CodIntern = Console.ReadLine();
                servicii[i] = new Serviciu(i, nume, CodIntern);
            }
            
         

        }
        public void WriteServicii()
        {
            for (int i = 0; i < nrServicii; i++)
            {
                servicii[i].Descriere();
                    
               //Console.WriteLine("Id " + servicii[i].Id1 + "Nume: " + servicii[i].Nume1 + " Cod Intern: " + servicii[i].CodIntern1);

            }


        }
    }
}
