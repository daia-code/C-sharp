using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[100];
            Product product = new Product();
            Service[] services = new Service[100];
            Service service=new Service();
            Console.Write("Number of products:");
            int nrProduct =int.Parse(Console.ReadLine());
            for(int i = 0; i < nrProduct; i++)
            { 
                products[i] = product.AddProduct(i);
                Console.WriteLine();
            }
            Console.WriteLine();
            product.ViewProduct(products);
            Console.WriteLine();
            Console.Write("Number of services:");
            int nrService = int.Parse(Console.ReadLine());
            for (int i = 0; i < nrService; i++)
            {
                services[i] = service.AddService(i);
                Console.WriteLine();
            }
            Console.WriteLine();
            service.WriteService(services);


        }
    }
}
