using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Serviciu : ProdusAbstract
    {

        public Serviciu(long unId, String unNume, String unCodIntern, double unPret, String oCategorie) : base(unId, unNume, unCodIntern, unPret, oCategorie)
        {

        }
        public override String Descriere()
        {
            return "Id [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Pret:" + Pret1 + " Categorie:" + Categorie1;

        }
        public override String AltaDescriere()
        {
            return "Id [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Pret:" + Pret1 + " Categorie:" + Categorie1;
        }

    }
}
