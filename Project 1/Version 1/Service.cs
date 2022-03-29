using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Service
    {
        private long id;
        private String name;
        private String codeInternal;

        public Service()
        {


        }
        public Service(long id, string name, string codeInternal)
        {
            this.id = id;
            this.name = name;
            this.codeInternal = codeInternal;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CodeInternal { get => codeInternal; set => codeInternal = value; }

        public Service AddService(int i)
        {
            Console.WriteLine("Enter the name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the internal code: ");
            String code = Console.ReadLine();

            Service service = new Service(i, name, code);
            return service;

        }
        public void WriteService(Service[] services)
        {
            for (int i = 0; i < services.Length; i++)
            {
                if (services[i] == null)
                {
                    continue;
                }
                Console.WriteLine("Service || id: " + services[i].Id + " | name: " + services[i].Name + " | internal code: " + services[i].CodeInternal);

            }
        }
    }
}
