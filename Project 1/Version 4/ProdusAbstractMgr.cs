using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    abstract class ProduseAbstractMgr
    {
        //private static ProdusAbstract[] elemente = new ProdusAbstract[100];
        //private static int nrElemente = 0;
        protected static List<ProdusAbstract> elemente=new List<ProdusAbstract>();

        //public static ProdusAbstract[] Elemente { get => elemente; set => elemente = value; }
       // public static int NrElemente { get => nrElemente; set => nrElemente = value; }

        public void Write2Console()
        {  
           foreach(ProdusAbstract prod in elemente)
            {
                Console.WriteLine(prod.Descriere());
            }
        }
        public void InitListafromXML()
        {
            //initializare lista dintr-un fisier XML
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            //incarca fisierul
            doc.Load("C:\\Users\\cti20c117\\source\\repos\\ConsoleApp1\\Produse.xml"); //calea spre fisier
            doc2.Load("C:\\Users\\cti20c117\\source\\repos\\ConsoleApp1\\Servicii.xml");
                                        //selecteaza nodurile
            XmlNodeList lista_noduri = doc.SelectNodes("/produse/Produs");
            XmlNodeList lista_noduri2 = doc.SelectNodes("/servicii/Serviciu");
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
                elemente.Add(new Produs
                (elemente.Count + 1, nume, codIntern,producator, pret, categorie));
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
                elemente.Add(new Serviciu
                (elemente.Count + 1, nume, codIntern, pret, categorie));
            }
        }
    }
}
