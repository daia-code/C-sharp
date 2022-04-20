using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PacheteMgr : ProduseAbstractMgr
    {
        
        public void ReadPachet()
        {
            Pachet pachet = new Pachet();
            ProduseMgr produseMgr = new ProduseMgr();
            foreach(ProduseAbstractMgr produse in produseMgr)
            {
                pachet.AddElement(produse);
            }
         
        }
    }
}
