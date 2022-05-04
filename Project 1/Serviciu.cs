using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class Serviciu : ProdusAbstract, IPackageble
    {
        public Serviciu()
        {

        }
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

        public bool canAddToPackage(Pachet pachet)
        {

            return true;


        }
        public void save2XML(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Serviciu));
            StreamWriter sw = new StreamWriter(fileName + ".xml");
            xs.Serialize(sw, this);
            sw.Close();
        }

    }
}
