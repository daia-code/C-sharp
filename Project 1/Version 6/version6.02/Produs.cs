using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Produs : ProdusAbstract, IPackageble
    {

        private String Producator;


        public string Producator1 { get => Producator; set => Producator = value; }

        public Produs(long Id, String Nume, String unCodIntern, String producator, double unPret, String oCategorie) : base(Id, Nume, unCodIntern, unPret, oCategorie)
        {
            this.Producator1 = producator;
        }
        public override String Descriere()
        {

            return "Id [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Producator: [" + Producator1 + "]" + " Pret:" + Pret1 + " Categorie:" + Categorie1;


        }
        public override String AltaDescriere()
        {
            return ("Produs[" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Producator: [" + Producator1 + "]");
        }

        public bool canAddToPackage(Pachet pachet)
        {
            return true;
        }
    }
}
