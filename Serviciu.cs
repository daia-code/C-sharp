using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public class Serviciu : ProdusAbstract
    {
      
        public Serviciu(long unId, String unNume, String unCodIntern) : base(unId, unNume, unCodIntern)
        {
            
        }
        public override void Descriere()
        {
            Console.WriteLine( "Produsul [" + Id1 + "]: " + Nume1+ " cod intern :[" + CodIntern1 + "] ");
            
        }
        public override void AltaDescriere()
        {
            Console.WriteLine( "[" + Id1 + "]: " + Nume1  + " cod intern :[" + CodIntern1 + "] ");
        }

    }
}
