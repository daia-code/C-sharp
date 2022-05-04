using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pachet : ProdusAbstract, IPackageble
    {
        //List<ProdusAbstract> elem_pachet=new List<ProdusAbstract>();

        private List<IPackageble> elem_pachet;
        public Pachet( long id, string nume, string codIntern, double pret, string categorie) : base(id, nume, codIntern, pret, categorie)
        {
            //Elem_pachet1 = new List<IPackageble>();

        }

     

        public List<IPackageble> Elem_pachet { get => Elem_pachet; set => Elem_pachet = value; }
        

        public void AddElement(IPackageble elem)
        {
            if (elem.canAddToPackage(this))
            {
                Elem_pachet.Add(elem);
            }

        }
        public bool canAddToPackage(Pachet pachet)
        {
            return false;
        }

        public override string Descriere()
        {
           
                return "Id [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Pret:" + Pret1 + " Categorie:" + Categorie1;
            
           
        }
    }
}
