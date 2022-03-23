using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    public class Produs : ProdusAbstract
    {
        
        private String Producator;

        
        public string Producator1 { get => Producator; set => Producator = value; }

        public Produs(long Id, String Nume,String unCodIntern, String producator): base(Id, Nume, unCodIntern)
        {
            this.Producator1 = producator;
        }
        public override void Descriere()
        {
            Console.WriteLine( "Produsul [" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] "+ " Producator: [" + Producator1 + "]");
           
        }
        public override void AltaDescriere()
        {
            Console.WriteLine("[" + Id1 + "]: " + Nume1 + " cod intern :[" + CodIntern1 + "] " + " Producator: [" + Producator1 + "]");
        }





    }
}
