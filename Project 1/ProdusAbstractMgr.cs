using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    public abstract class ProduseAbstractMgr
    {
        //private static ProdusAbstract[] elemente = new ProdusAbstract[100];
        //private static int nrElemente = 0;
        protected static List<ProdusAbstract> elemente = new List<ProdusAbstract>();

        //public static ProdusAbstract[] Elemente { get => elemente; set => elemente = value; }
        // public static int NrElemente { get => nrElemente; set => nrElemente = value; }

        public void Write2Console()
        {
            foreach (ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
        public List<IPackageble> InitListafromXML(int i)
        {
            List<IPackageble> produseAbs = new List<IPackageble>();
            //initializare lista dintr-un fisier XML
            XmlDocument doc = new XmlDocument();
            //incarca fisierul
            // doc.Load("C:\\Users\\Daiana\\source\\repos\\ConsoleApp3\\Produse.xml"); //calea spre fisier
            doc.Load("C:\\Users\\cti20c117\\source\\repos\\ConsoleApp1\\Pachet"+i+".xml");
            List<Produs> produse = new List<Produs>();

            //selecteaza nodurile
            //XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            //XmlNodeList lista_noduri2 = doc.SelectNodes("/produse/Serviciu");
            XmlNodeList lista_noduri = doc.SelectNodes("/pachet/Produs");
            XmlNodeList lista_noduri2 = doc.SelectNodes("/pachet/Serviciu");
            foreach (XmlNode nod in lista_noduri)
            {
                //itereaza si selecteaza simpurile fiecarui nod si 
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                string producator = nod["Producator"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                //adauga in lista produse
                /* produse.Add(new Produs
                 (elemente.Count + 1, nume, codIntern, producator, pret, categorie));
                 elemente.Add(new Produs
                 (elemente.Count + 1, nume, codIntern, producator, pret, categorie));*/

                produseAbs.Add(new Produs
                   (produseAbs.Count + 1, nume, codIntern, producator, pret, categorie));
            }
            foreach (XmlNode nod in lista_noduri2)
            {
                //itereaza si selecteaza simpurile fiecarui nod si 
                //informatia continuta in cadrul proprietatii InnerText
                string nume = nod["Nume"].InnerText;
                string codIntern = nod["CodIntern"].InnerText;
                int pret = int.Parse(nod["Pret"].InnerText);
                string categorie = nod["Categorie"].InnerText;

                //adauga in lista produse
                /* elemente.Add(new Serviciu
                 (elemente.Count + 1, nume, codIntern, pret, categorie));*/
                produseAbs.Add(new Serviciu
                (produseAbs.Count + 1, nume, codIntern, pret, categorie));
            }

            return produseAbs;
        }



        
        public void LinqList()
        {
            var interogare = from prod in elemente
                             where prod.Pret1 > 4000
                             select prod;

            Console.WriteLine("Elementele cu pret peste 4000");
            foreach (var p in interogare)
            {
                Console.WriteLine(p.Descriere());
            }
        }



    }
}
