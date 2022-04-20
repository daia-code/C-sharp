using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Pachet : ProdusAbstract,IPackageble
    {
        //List<ProdusAbstract> elem_pachet=new List<ProdusAbstract>();

        private List<IPackageble> elem_pachet = new List<IPackageble>();
        public Pachet(List<IPackageble>elem_pachet, long id, string nume, string codIntern, double pret, string categorie) : base(id, nume, codIntern, pret, categorie)
        {
            this.elem_pachet = elem_pachet; 
           
           
        }

      
       public void AddElement(IPackageble elem)
        {
            if (elem.canAddToPackage(this))
            {
                elem_pachet.Add(elem);
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
