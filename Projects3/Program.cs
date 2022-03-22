using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice= 1,i=0;
            String nameSearch;
            Student[] students = new Student[100];
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.Display students");
                Console.WriteLine("3.Change student");
                Console.WriteLine("4.Change date_uni");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Enter your options:");
                choice = Int16.Parse(Console.ReadLine());
                Student student = new Student();
                switch (choice)
                {
                   case  1: 
                        
                        students[i]=student.Add_Student();
                        Console.WriteLine("You add a new student");
                        i++;
                        break;
                       
                    case 2:
                        for (int j = 0; j < students.Length; j++)
                        {
                            students[j].Display_Students(students[j]);
                        }
                        break;
                    case 3:   Console.WriteLine("Enter the name of student:");
                        String name = Console.ReadLine();
                        for (i = 0; i < students.Length; i++)
                        {
                            nameSearch = students[i].Name;
                            if (String.Equals(name, nameSearch))
                            {
                                students[i] = students[i].Change_Student();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter the name of student:");
                        String nameData = Console.ReadLine();
                        for (i = 0; i < students.Length; i++)
                        {
                             String nameSearch2 = students[i].Name;
                            if (String.Equals(nameData,nameSearch2 ))
                            {
                                students[i].Data_uni = students[i].Change_Data();
                            }
                        }
                        
                        break;
                }
                Console.WriteLine();
            }while(i!=0);
            Console.WriteLine("You close the program.. See you later!");
        }
    }
}
