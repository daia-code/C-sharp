using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int option, nr = 0,find=0;
            Menu menu = new Menu();
            Student[] students = new Student[100];
            do
            {
                menu.View();
                Console.Write("Enter your option:");
                option = Int32.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        {
                          
                            students[nr] = menu.AddStudent();
                            nr++;
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Enter name of student:");
                            String name = Console.ReadLine();
                            for (int j = 0; j < students.Length; j++)
                            {
                                String studName = students[j].Name;
                                if (String.Equals(name, studName))
                                {
                                    Console.WriteLine("We find the student!");
                                    students[j].DataStudy = students[j].NewDataStudy();
                                    find++;
                                    break;

                                }
                            }
                            if (find==0)
                            {
                                Console.WriteLine("We don't have a student with name " + name + " !");
                            }
                            break;
                        }
                    case 3:
                        { Student student = new Student();
                            student.StudView(students);
                            break;
                        }

                }
                Console.WriteLine();


                
            } while (option != 0);
        }
    }
}
