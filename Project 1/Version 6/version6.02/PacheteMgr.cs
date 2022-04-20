using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        public class PacheteMgr : ProduseAbstractMgr
        {

            public void ReadPachet()
            {

            Pachet pachet = new Pachet(1, "Pachet Sarbatori", "1234", 0, "");
            List<IPackageble> produse;
            
            ProduseMgr produseMgr = new ProduseMgr();
            produse= produseMgr.InitListafromXML();
            
            foreach(IPackageble prod in produse)
            {
                pachet.AddElement(prod);

            }
            
            


            elemente.Add(pachet);

        }

        }
    }

