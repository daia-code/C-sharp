using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class ProduseAbstractMgr
    {
        private static ProdusAbstract[] elemente = new ProdusAbstract[100];
        private static int nrElemente = 0;

        protected static ProdusAbstract[] Elemente { get => elemente; set => elemente = value; }
        protected static int NrElemente { get => nrElemente; set => nrElemente = value; }

        public void Write2Console(ProduseMgr[] produseMgr,ServiciuMgr[] serviciuMgr)
        {
           
            for (int i = 0; i < produseMgr.Length; i++)
            {
               
              

              

            }
        }
    }
}
