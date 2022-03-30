using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Serviciu : ProdusAbstract
    {

        public Serviciu(long unId, String unNume, String unCodIntern) : base(unId, unNume, unCodIntern)
        {

        }
        public override String Descriere()
        {
            return "Produsul [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] ";

        }
        public override String AltaDescriere()
        {
            return "[" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] ";
        }

    }
}
