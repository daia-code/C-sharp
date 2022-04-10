using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaGen<int> listagenerica = new ListaGen<int>();
            //ListaGen<string> listagenerica = new ListaGen<string>();
            int[] matrix= { 12, 13, 15, 17 };
            foreach( int x in matrix)
            {
                //listagenerica.insertToFront(x);
                listagenerica.insertToEnd(x);

            }
            listagenerica.delete(13);
            foreach (int element in listagenerica)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();



        }
    }
}
