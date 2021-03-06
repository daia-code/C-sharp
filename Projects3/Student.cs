using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Student
    {

        private String _name;
        private String _address;
        private DataStudy _dataStudy;

        public Student()
        {

        }
        public Student(string name, string address, DataStudy dataStudy)
        {
            this._name = name;
            this._address = address;
            this._dataStudy = dataStudy;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }



        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public DataStudy DataStudy
        {
            get => _dataStudy;
            set => _dataStudy = value;
        }

        public void Describe()
        {
            Console.WriteLine("name:" + Name + " | Address:" + Address + "| Faculty:" + DataStudy.Faculty + " | Degree subject:" + DataStudy.Degree + " |Year:" + DataStudy.Year);


        }

        public DataStudy NewDataStudy()
        {
            Console.WriteLine("Enter the faculty:");
            String faculty = Console.ReadLine();
            Console.WriteLine("Enter the degree subject:");
            String degree = Console.ReadLine();
            Console.WriteLine("Enter the year of study:");
            int year = Int16.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            DataStudy dataStudy = new DataStudy(faculty, degree, year);
            return dataStudy;

        }
        public void StudView(Student[] students)
        {
            foreach (Student student in students)
            {
                if (student == null)
                {
                    continue;
                }
                student.Describe();

            }

        }
    }
}
