using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class ProdusAbstract
    {
        private long Id;
        private String Nume;
        private String CodIntern;
        private double Pret;
        private String Categorie;

        public ProdusAbstract(long id, string nume, string codIntern, double pret, string categorie)
        {
            Id = id;
            Nume = nume;
            CodIntern = codIntern;
            Pret = pret;
            Categorie = categorie;
        }

        public long Id1 { get => Id; set => Id = value; }
        public string Nume1 { get => Nume; set => Nume = value; }
        public string CodIntern1 { get => CodIntern; set => CodIntern = value; }
        public double Pret1 { get => Pret; set => Pret = value; }
        public string Categorie1 { get => Categorie; set => Categorie = value; }


        public abstract String Descriere();
        public virtual String AltaDescriere()
        {
            return "Id [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Pret:" + Pret1 + " Categorie:" + Categorie1;
        }
    }
}
