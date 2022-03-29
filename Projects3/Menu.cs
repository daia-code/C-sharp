using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        public void View()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Add a new student");
            Console.WriteLine("2.Change data about studing");
            Console.WriteLine("3.View students");
        }
        public  Student AddStudent()
        {
            Console.WriteLine("Enter name of student:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            String address = Console.ReadLine();
            Console.WriteLine("Enter the faculty:");
            String faculty = Console.ReadLine();
            Console.WriteLine("Enter the degree subject:");
            String degree = Console.ReadLine();
            Console.WriteLine("Enter the year of study:");
            int year = Int16.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            DataStudy dataStudy = new DataStudy(faculty, degree, year);
            Student student = new Student(name, address, dataStudy);
            return student;
        }

      
    }
   
        
    }
