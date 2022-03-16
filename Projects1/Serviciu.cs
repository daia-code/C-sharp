using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Serviciu
    {

        private String codIntern;// codul Intern
        private long id;// identificator
        private String nume;// numele serviciului

        public string CodIntern { get => codIntern; set => codIntern = value; }
        public long Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public Serviciu createServiciu()
        {
            Serviciu serviciu = new Serviciu();
            Console.WriteLine("Introdu un serviciu");
            Console.Write("Numele:");
            serviciu.Nume = Console.ReadLine();
            Console.Write("Codul intern:");
            serviciu.CodIntern = Console.ReadLine();
           
            return serviciu;
        }
        public void afisServiciu(Serviciu[] serviciu)
        {
            for (int cnt = 0; cnt < serviciu.Length; cnt++)
            {
                Serviciu serv = serviciu[cnt];
                Console.WriteLine("Produs: " +
                serv.Nume + "[" +
                serv.CodIntern +
                "] " );
            }
        }
    }
}
