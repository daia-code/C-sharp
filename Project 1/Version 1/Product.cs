using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {
        private long id;
        private String name;
        private String codeInternal;
        private String producer;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CodeInternal { get => codeInternal; set => codeInternal = value; }
        public string Producer { get => producer; set => producer = value; }

        public Product AddProduct(int i)
        {
            Product product = new Product();
            product.Id = i;
            Console.WriteLine("Enter the name: ");
            String name = Console.ReadLine();
            product.Name = name;
            Console.WriteLine("Enter the internal code: ");
            String code = Console.ReadLine();
            product.CodeInternal = code;
            Console.WriteLine("Enter the producer:");
            String producer = Console.ReadLine();
            product.Producer = producer;
            return product;

        }
       public void ViewProduct(Product[] products)
        {
            for(int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    continue;
                }
                    Console.WriteLine("Product || id: " + products[i].Id + " | name: " + products[i].Name + " | internal code: " + products[i].CodeInternal + " | producer: " + products[i].Producer);
                
            }
        }
    }
}
