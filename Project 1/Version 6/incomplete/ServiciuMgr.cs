using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class ServiciuMgr : ProduseAbstractMgr
    {
        private Serviciu[] servicii = new Serviciu[100];
        private int nrServicii = 0;
        public int NrServicii { get => nrServicii; set => nrServicii = value; }
        public Serviciu[] Servicii { get => servicii; set => servicii = value; }

        public ServiciuMgr()
        {

        }
        public ServiciuMgr(Serviciu[] servicii, int nrServicii)
        {
            this.Servicii = servicii;
            this.NrServicii = nrServicii;
        }


        /* public Serviciu ReadServicii()
         {
             Console.WriteLine("Introdu un element");
             Console.Write("Numele:");
             String nume = Console.ReadLine();
             Console.Write("Codul intern:");
             String CodIntern = Console.ReadLine();
             Serviciu serviciu = new Serviciu(nrServicii, nume, CodIntern);
             return serviciu;
         }*/


        public void WriteServicii(Serviciu[] servicii)
        {
            for (int i = 0; i < servicii.Length; i++)
            {
                if (servicii[i] == null)
                {
                    continue;
                }
                // Console.WriteLine(servicii[i].Descriere());
                Console.WriteLine("Id " + servicii[i].Id1 + "Nume: " + servicii[i].Nume1 + " Cod Intern: " + servicii[i].CodIntern1);

            }


        }
        public void ReadServiciu()
        {

        }
    }
}