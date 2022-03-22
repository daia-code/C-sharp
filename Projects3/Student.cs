using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    class Student
    {
        private String name;
        private String address;
        private int year_birth;
        private Data_uni data_uni;
        public Student()
        {

        }
        public Student(string name, string address, int year_birth, Data_uni data_uni)
        {
            this.name = name;
            this.address = address;
            this.year_birth = year_birth;
            this.data_uni = data_uni;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Year_birth { get => year_birth; set => year_birth = value; }
        internal Data_uni Data_uni { get => data_uni; set => data_uni = value; }
        
        public Student Add_Student()
        {
            Student student;
            Console.WriteLine("Enter the name of student:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the address:");
            String addres = Console.ReadLine();
            Console.WriteLine("Enter the year of birth:");
            int year = Int16.Parse(Console.ReadLine());
            Data_uni data = new Data_uni();
            data=data.Add_Data();
            student = new Student(name,addres,year,data);
            return student;

        }
        public void Display_Students(Student student)
        {
          
                Console.WriteLine(student.Name + "   " +student.Address+ "  " + student.Year_birth + " " + student.Data_uni.Year_study+"  "+student.Data_uni.Study_subject+"  "+student.Data_uni.University);
            
        }
        public Student Change_Student()
        {
           
                    Console.WriteLine("Enter the name of student:");
                    String nameNew = Console.ReadLine();
                    Console.WriteLine("Enter the address:");
                    String addresNew = Console.ReadLine();
                    Console.WriteLine("Enter the year of birth:");
                    int yearNew = Int16.Parse(Console.ReadLine());
                    Student student = new Student(nameNew, addresNew, yearNew, data_uni);


            return student;
        }
        public Data_uni Change_Data()
        {
          
                    Data_uni data_Uni = new Data_uni();
                    data_uni = data_uni.Add_Data();
            return Data_uni;

        }
           

        }
    }
